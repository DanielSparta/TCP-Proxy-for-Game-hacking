﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpProxy.Proxy
{
    public class ProxyConnect
    {
        private System.Net.Sockets.Socket ProxyServer;
        private int targetPort;
        private string targetServer;
        private TcpProxy GUIClassInstance;
        public ProxyConnect(TcpProxy instance, System.Net.Sockets.Socket ProxyServer, string targetServer, int targetPort)
        {
            this.targetPort = targetPort;
            this.ProxyServer = ProxyServer;
            this.targetServer = targetServer;
            this.GUIClassInstance = instance;
        }
        public void ConnectToGameServer()
        {
            //@TODO: too many garbage code, all this place looks like my shit. UNREADABLE.
            
            System.Net.Sockets.Socket targetServer = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            targetServer.Connect(this.targetServer, targetPort);

            // Create separate threads to handle data transfer in both directions
            Thread proxyToGameServer = new Thread(() =>
            {
                Proxy.ProxyReceive Data = new Proxy.ProxyReceive(this.GUIClassInstance, this.ProxyServer, targetServer);
                Data.StartReceive(true, true);
            });

            Thread GameToClient = new Thread(() =>
            {
                Proxy.ProxyReceive Data = new Proxy.ProxyReceive(this.GUIClassInstance, targetServer, this.ProxyServer);
                Data.StartReceive(false, false);
            });

            proxyToGameServer.Start();
            GameToClient.Start();

            // Wait for both threads to finish before closing the connection
            proxyToGameServer.Join();
            GameToClient.Join();

            MessageBox.Show($"Connection closed: {((IPEndPoint)targetServer.RemoteEndPoint).ToString()}");

        }
    }
}