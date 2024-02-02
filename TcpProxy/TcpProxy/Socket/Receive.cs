using TcpProxy.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TcpProxy.Socket
{
    public class SocketReceive
    {
        public int targetPort;
        public string targetServer;
        public System.Net.Sockets.Socket ProxyServer;
        private TcpProxy instance;
        public SocketReceive(TcpProxy instance, int targetPort, string targetServer)
        {
            this.targetPort = targetPort;
            this.targetServer = targetServer;
            this.instance = instance;
        }
        public void Receive(System.Net.Sockets.Socket ProxyServer)
        {
            //Global thread for the while loop so the GUI will not get blocked
            new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    //Sending each client to I'ts own thread
                    System.Net.Sockets.Socket GameClient = ProxyServer.Accept();
                    new Thread(new ThreadStart(() =>
                    {
                        //After connection established, Proxy server Connect to Game server
                        Proxy.ProxyConnect proxy = new ProxyConnect(this.instance, GameClient, this.targetServer, this.targetPort);
                        proxy.ConnectToGameServer();
                    })).Start();
                }
            })).Start();
        }
    }
}