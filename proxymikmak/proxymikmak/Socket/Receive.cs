using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proxymikmak.Socket
{
    public class SocketReceive
    {
        public int targetPort; //443
        public string targetServer; //"213.8.147.206"
        public System.Net.Sockets.Socket ProxyServer;
        private Form1 instance;
        public SocketReceive(Form1 instance, int targetPort, string targetServer)
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
                        Proxy.ProxyReceive ProxyReceive = new Proxy.ProxyReceive(instance, ProxyServer);
                        ProxyReceive.StartReceive();
                    })).Start();
                }
            })).Start();
        }
    }
}