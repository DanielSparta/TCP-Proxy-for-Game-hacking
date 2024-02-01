using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;
using static proxymikmak.Proxy.ProxyReceive;

namespace proxymikmak.Proxy
{
    public class ProxyReceive
    {
        public delegate void Packet(string packet);
        public event Packet OnEditEvent;
        private Form1 Instance;
        private System.Net.Sockets.Socket ProxyServer;
        public System.Net.Sockets.Socket GameServer;
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

                while (true)
                {
                    int received = this.ProxyServer.Receive(buffer);
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
                        if (this.Instance.traffic.Checked)
                        {
                            MessageBox.Show("block");
                            buffer = Encoding.UTF8.GetBytes(this.Instance.textBox2.Text);
                        }
                        this.GameServer.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    }
                    else
                    {
                        //If you want to debug the server respone
                        this.GameServer.Send(buffer, 0, received, SocketFlags.None);
                    }
                }
            }
            catch (Exception ex)
            {
                this.Instance.Invoke((MethodInvoker)delegate
                {
                    this.Instance.textBox1.Text += $"An error occurred: {ex.Message}" + "\n\n";
                });
            }
        }
    }
}   
