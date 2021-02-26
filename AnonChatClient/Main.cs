using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace AnonChatClient {
    public partial class Main : Form {
        private TcpClient client;
        private byte[] buffer = new byte[4096];
        private string ip;

        public Main() {
            InitializeComponent();
        }

        private void ServerMessageReceived(IAsyncResult ar) {
            if (ar.IsCompleted) {
                try {
                    int bytesLen = client.GetStream().EndRead(ar);
                    if(bytesLen > 0) {
                        byte[] tmp = new byte[bytesLen];
                        Array.Copy(buffer, tmp, bytesLen);

                        string msg = Encoding.UTF8.GetString(tmp);

                        Console.WriteLine(msg);

                        BeginInvoke((Action)(()=>{
                            list_messages.Items.Add(msg);
                            list_messages.TopIndex = list_messages.Items.Count - 1;
                        }));

                        Array.Clear(buffer, 0, buffer.Length);
                        client.GetStream().BeginRead(buffer, 0, buffer.Length, ServerMessageReceived, null);
                    }

                } catch {
                    BeginInvoke((Action)(()=> { 
                        list_messages.Items.Add("Couldn't read server message. Disconnecting...");
                    }));
                    Disconnect();
                }
            }
        }

        private void BtnSendClick(object sender, EventArgs e) {
            if(txtbox_message.TextLength < 1 || client == null || !client.Connected)
                return;

            try {
                byte[] msg = Encoding.UTF8.GetBytes(txtbox_message.Text);
                client.GetStream().Write(msg, 0, msg.Length);
            } catch {
                list_messages.Items.Clear();
                list_messages.Items.Add("Couldn't send message. Disconnecting...");
                Disconnect();
            } finally {
                txtbox_message.Focus();
                txtbox_message.Clear();
            }
        }

        private void Disconnect() {
            if(client != null && client.Connected) {
                client.GetStream().Write(null, 0, 0);
            }
        }

        private void TryConnect() {
            try {
                if (ip == txtBox_ip.Text || !ValidateIPv4(txtBox_ip.Text))
                    return;

                if (client != null) client.Dispose();
                client = new TcpClient();
                client.Connect(txtBox_ip.Text, 26950);
                client.GetStream().BeginRead(buffer, 0, buffer.Length, ServerMessageReceived, null);

                ip = txtBox_ip.Text;
                list_messages.Items.Clear();
            } catch {
                list_messages.Items.Add("Couldn't connect. Trying again.");
            }
        }

        private void BtnConnectClick(object sender, EventArgs e) {
            TryConnect();
        }

        public bool ValidateIPv4(string ipString) {
            if (String.IsNullOrWhiteSpace(ipString))
                return false;

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
                return false;

            return splitValues.All(r => byte.TryParse(r, out var tmp));
        }

        private void ListMessagesDrawItem(object sender, DrawItemEventArgs e) {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(list_messages.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void ListMessagesMeasureItem(object sender, MeasureItemEventArgs e) {
            if(list_messages.Items.Count <= 0) 
                return; 

            e.ItemHeight = (int)e.Graphics.MeasureString(list_messages.Items[e.Index].ToString(), list_messages.Font, list_messages.Width).Height;
        }

        private void MainResize(object sender, EventArgs e) {
            list_messages.Refresh();
        }

        private void TxtMessageTextChanged(object sender, EventArgs e) {
            lbl_symbols.Text = $"{txtbox_message.TextLength} / {txtbox_message.MaxLength}";
        }
    }
}
