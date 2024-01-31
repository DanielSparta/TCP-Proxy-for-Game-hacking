using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;

namespace proxymikmak.Proxy
{
    public class ProxyReceive
    {
        private Form1 Instance;
        private System.Net.Sockets.Socket ProxyServer;
        private System.Net.Sockets.Socket GameServer;
        public ProxyReceive(Form1 instance, System.Net.Sockets.Socket ProxyServer, System.Net.Sockets.Socket GameServer)
        {
            this.Instance = instance;
            this.ProxyServer = ProxyServer;
            this.GameServer = GameServer;
        }

        public void StartReceive(bool ShouldDisplay)
        {
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = this.ProxyServer.Receive(buffer)) > 0)
                {
                    string packets = "";
                    if (ShouldDisplay)
                    {
                        packets = Encoding.UTF8.GetString(buffer);
                        this.Instance.Invoke((MethodInvoker)delegate
                        {
                            this.Instance.textBox1.Text += $"{packets}" + "\n\n";
                        });
                        string editedtext = Encoding.UTF8.GetString(buffer);
                        byte[] editedtext_buffer = Encoding.UTF8.GetBytes(editedtext);
                        //If you want to debug the sending packet to server
                        this.GameServer.Send(editedtext_buffer, 0, editedtext_buffer.Length, SocketFlags.None);
                    }
                    else
                    {
                        //If you want to debug the server respone
                        this.GameServer.Send(buffer, 0, bytesRead, SocketFlags.None);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}   