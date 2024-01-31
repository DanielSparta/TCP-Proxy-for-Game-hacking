using System.Net.Sockets;
using System.Text;
using System;

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

        public void StartReceive()
        {
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = this.ProxyServer.Receive(buffer)) > 0)
                {
                    string[] packets = Encoding.UTF8.GetString(buffer).Split(new char[] { '\0', });
                    foreach (string packet in packets)
                    {
                        this.Instance.packetsRTB.Text += $"{packet}\n\n";
                    }
                    this.GameServer.Send(buffer, 0, bytesRead, SocketFlags.None);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"aAn error occurred: {ex.Message}");
            }
        }
    }
}