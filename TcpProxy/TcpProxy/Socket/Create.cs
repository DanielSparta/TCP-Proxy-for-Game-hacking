using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpProxy.Socket
{
    public class SocketServer
    {
        public static System.Net.Sockets.Socket Create(int proxyPort)
        {
            // Create a TCP socket to listen for incoming connections
            System.Net.Sockets.Socket ProxyServer = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPEndPoint = new IPEndPoint(IPAddress.Any, proxyPort);
            ProxyServer.Bind(IPEndPoint);
            ProxyServer.Listen(10);

            MessageBox.Show($"Proxy listening on port {proxyPort}, forwarding to {IPEndPoint.ToString()}:{proxyPort}");
            return ProxyServer;
        }
    }
}
