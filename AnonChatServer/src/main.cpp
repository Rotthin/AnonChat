#include <iostream>
#include <WS2tcpip.h>
#include <string>
#include <sstream>

#include "main.hpp"

#pragma comment (lib, "ws2_32.lib")

fd_set master;
bool running = true;

int main() {
	SetConsoleTitle(L"AnonChat Server");

	// Initialze winsock
	WSADATA wsData;
	if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0){
		std::cerr << "Can't Initialize winsock. Quitting..." << std::endl;
		return -1;
	}

	// Create a socket 
	SOCKET listening = socket(AF_INET, SOCK_STREAM, 0);
	if (listening == INVALID_SOCKET) {
		std::cerr << "Can't create a socket. Quitting..." << std::endl;
		return -1;
	}

	// Bind the ip address and port to a socket
	sockaddr_in hint;
	hint.sin_family = AF_INET;
	hint.sin_port = htons(26950);
	hint.sin_addr.S_un.S_addr = INADDR_ANY; 

	bind(listening, (sockaddr*)&hint, sizeof(hint));

	// Tell Winsock the socket is for listening 
	listen(listening, SOMAXCONN);

	// Create the master file descriptor set and zero it
	FD_ZERO(&master);

	FD_SET(listening, &master);

	std::cout << "Server has started.\n";

	while (running) {
		fd_set copy = master;

		int socketCount = select(0, &copy, nullptr, nullptr, nullptr);

		for (int i = 0; i < socketCount; i++) {
			SOCKET sock = copy.fd_array[i];

			// New connection
			if (sock == listening) {
				std::cout << "#" << sock << " has connected to the server.\n";
				sendMessageToAll("#" + getSocketID(sock) + " has connected.");
				
				SOCKET client = accept(listening, nullptr, nullptr);

				FD_SET(client, &master);
				sendMessageTo(client, "SERVER: Welcome to the AnonChat Server!");
			} 
			// Message
			else { 
				char buf[4096];
				memset(buf, 0, 4096);

				int bytesIn = recv(sock, buf, 4096, 0);
				if (bytesIn <= 0) {
					kickPlayer(sock);
				}

				else {
					if (buf[0] == '\\'){
						handleCommand(sock, std::string(buf, bytesIn));
						continue;
					}

					std::ostringstream ss;
					ss << "#" << sock << ": " << buf << "\n";
					std::cout << ss.str();

					for (u_int i = 0; i < master.fd_count; i++){
						SOCKET outSock = master.fd_array[i];
						ss.str("");
						ss.clear();

						if (outSock == listening)
							continue;

						if (outSock != listening && outSock != sock)
							ss << "#" << sock << ": " << buf;
						else 
							ss << "Me: " << buf;
						
						std::string strOut = ss.str();
						send(outSock, strOut.c_str(), strOut.size() + 1, 0);
					}
				}
			}
		}
	}

	// Close the listening socket.
	FD_CLR(listening, &master);
	closesocket(listening);

	// Message to let users know what's happening.
	std::string msg = "SERVER: Server is shutting down. See ya.\n";
	while (master.fd_count > 0){
		SOCKET sock = master.fd_array[0];

		send(sock, msg.c_str(), msg.size() + 1, 0);

		FD_CLR(sock, &master);
		closesocket(sock);
	}

	WSACleanup();
	return 0;
}

void handleCommand(SOCKET sock, std::string cmd) {
	if (cmd == "\\help") {
		sendMessageTo(sock, "All commands:\r\n\\leave: kicks you out of the server");
		return;
	}

	if (cmd == "\\leave") {
		kickPlayer(sock);
		return;
	}
}

std::string getSocketID(SOCKET sock) {
	std::ostringstream ss;
	ss << sock;
	return ss.str();
}

void sendMessageTo(SOCKET sock, std::string msg) {
	send(sock, msg.c_str(), msg.size()+1, 0);
}

void sendMessageToAll(std::string msg) {
	for (u_int i = 0; i < master.fd_count; i++) {
		SOCKET sock = master.fd_array[i];
		send(sock, msg.c_str(), msg.size() + 1, 0);
	}
}

void kickPlayer(SOCKET sock) {
	sendMessageTo(sock, "You have been kicked from the server.");

	FD_CLR(sock, &master);
	closesocket(sock);

	sendMessageToAll("#" + getSocketID(sock) + " has disconnected.");
	std::cout << "#" + getSocketID(sock) + " has disconnected.";
}
