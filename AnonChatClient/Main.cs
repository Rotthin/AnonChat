using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace AnonChatClient {
    public partial class Main : Form {
        private TcpClient client;
        private byte[] buffer = new byte[4096];

        public Main() {
            InitializeComponent();

            client = new TcpClient();
            client.Connect("127.0.0.1", 26950);
            client.GetStream().BeginRead(buffer, 0, buffer.Length, ServerMessageReceived, null);
        }

        private void ServerMessageReceived(IAsyncResult ar) {
            if (ar.IsCompleted) {
                // todo: receive message
            }
        }

        private void BtnSendClick(object sender, EventArgs e) {
            txtbox_message.Focus();
            txtbox_message.Clear();

            byte[] msg = Encoding.UTF8.GetBytes(txtbox_message.Text);
            client.GetStream().Write(msg, 0, msg.Length);
        }
    }
}
