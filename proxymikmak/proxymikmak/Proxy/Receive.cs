using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;
using static proxymikmak.Proxy.ProxyReceive;
using System.Threading;

namespace proxymikmak.Proxy
{
    public class ProxyReceive
    {
        public delegate void Packet(byte[] buffer);
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
        }

        public void StartReceive(bool ShouldDisplay, bool LoadDelegate)
        {
            //@TODO: All this place can be better.
            //This is the place where all the main bugs are, this is the place that decide if everything will work or not
            byte[] buffer = new byte[1000];

            while (true)
            {
                try
                {
                    Array.Clear(buffer, 0, buffer.Length);
                    int received = this.ProxyServer.Receive(buffer);
                    if (received > 0)
                    {
                        string packets = Encoding.UTF8.GetString(buffer);
                        buffer = Encoding.UTF8.GetBytes(packets);

                        if (ShouldDisplay)
                        {
                            if (LoadDelegate)
                            {
                                this.Instance.data = this;
                                this.Instance.LoadDelegate();
                                LoadDelegate = false;
                            }

                            /* VERY BUGGY RIGHT NOW.
                             * @TODO: FIX THE INTERCEPT TRAFFIC IN REAL TIME FEATURE
                            if (this.Instance.traffic.Checked)
                            {
                                Thread InterceptPacket = new Thread((() =>
                                {
                                    OnEditEvent.Invoke(buffer);
                                    buffer = Encoding.UTF8.GetBytes(this.Instance.textBox2.Text);
                                }));
                                InterceptPacket.Start();
                            }
                            */

                            this.Instance.Invoke((MethodInvoker)delegate
                            {
                                this.Instance.listView1.Items.Add($"{packets}");
                            });
                            //If you want to debug the sending packet to server
                            this.GameServer.Send(buffer, 0, packets.Length, SocketFlags.None);
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
                        this.Instance.listView1.Items.Add($"An error occurred: {ex.Message}");
                    });
                }
            }
        }
    }
}   
