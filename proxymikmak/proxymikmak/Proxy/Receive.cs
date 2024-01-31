using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;

namespace proxymikmak.Proxy
{
    public class ProxyReceive
    {
        public delegate void Packet(string packet);
        public event Packet OnEditEvent;
        private Form1 Instance;
        private System.Net.Sockets.Socket ProxyServer;
        private System.Net.Sockets.Socket GameServer;
        public ProxyReceive(Form1 instance, System.Net.Sockets.Socket ProxyServer, System.Net.Sockets.Socket GameServer)
        {
            this.Instance = instance;
            this.ProxyServer = ProxyServer;
            this.GameServer = GameServer;
            this.OnEditEvent = delegate { };
            instance.data = this;
            instance.LoadDelegate();
        }

        public void StartReceive(bool ShouldDisplay)
        {
            //@TODO: All this place can be better.
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = this.ProxyServer.Receive(buffer)) > 0)
                {
                    string packets = default(string); //default null
                    if (ShouldDisplay)
                    {
                        packets = Encoding.UTF8.GetString(buffer);
                        if (this.Instance.traffic.Checked)
                            OnEditEvent.Invoke(packets);
                        this.Instance.Invoke((MethodInvoker)delegate
                        {
                            this.Instance.textBox1.Text += $"{packets}" + "\n\n";
                        });
                        //If you want to debug the sending packet to server
                        this.GameServer.Send(buffer, 0, bytesRead, SocketFlags.None);
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
