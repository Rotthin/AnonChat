#include <string>
#include <WinSock2.h>

std::string getSocketID(SOCKET sock);
void sendMessageTo(SOCKET sock, std::string msg);
void sendMessageToAll(std::string msg);
void kickPlayer(SOCKET sock);
void handleCommand(SOCKET sock, std::string cmd);
