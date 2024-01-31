using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxymikmak.Socket
{
    public class SocketCreate
    {
        public System.Net.Sockets.Socket ProxyServer;
        public void Create(int proxyPort)
        {
            // Create a TCP socket to listen for incoming connections
            System.Net.Sockets.Socket ProxyServer = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ProxyServer.Bind(new IPEndPoint(IPAddress.Any, proxyPort));
            ProxyServer.Listen(10);
            this.ProxyServer = ProxyServer;

            MessageBox.Show($"Proxy listening on port {proxyPort}, forwarding to {ProxyServer}:{proxyPort}");
        }
    }
}
