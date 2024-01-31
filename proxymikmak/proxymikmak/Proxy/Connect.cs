﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxymikmak.Proxy
{
    public class ProxyConnect
    {
        private System.Net.Sockets.Socket ProxyServer;
        private int targetPort;
        private string targetServer;
        private Form1 GUIClassInstance;
        public ProxyConnect(Form1 instance, System.Net.Sockets.Socket ProxyServer, string targetServer, int targetPort)
        {
            this.targetPort = targetPort;
            this.ProxyServer = ProxyServer;
            this.targetServer = targetServer;
            this.GUIClassInstance = instance;
        }
        public void ConnectToGameServer()
        {
            using (System.Net.Sockets.Socket targetServer = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    targetServer.Connect(this.targetServer, targetPort);
                    MessageBox.Show($"Client connected: {((IPEndPoint)this.ProxyServer.RemoteEndPoint).Address}");

                    // Create separate threads to handle data transfer in both directions
                    Thread clientToTarget = new Thread(new ThreadStart(() => { Proxy.ProxyReceive Data = new Proxy.ProxyReceive(this.GUIClassInstance, this.ProxyServer, targetServer) })); ;

                    Thread targetToClient;
                    targetToClient = new Thread(new ThreadStart(() => {
                        RelayData(clientSocket, target);
                    })).Start();

                    // Wait for both threads to finish before closing the connection
                    clientToTarget.Join();
                    targetToClient.Join();

                    MessageBox.Show($"Connection closed: {((IPEndPoint)clientSocket.RemoteEndPoint).Address}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    this.ProxyServer.Close();
                }
            }
        }
    }
}
