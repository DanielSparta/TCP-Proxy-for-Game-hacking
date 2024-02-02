﻿using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;
using static TcpProxy.Proxy.ProxyReceive;
using System.Threading;

namespace TcpProxy.Proxy
{
    public class ProxyReceive
    {
        public delegate void Packet(byte[] buffer);
        public event Packet OnEditEvent;
        private TcpProxy Instance;
        public System.Net.Sockets.Socket ProxyServer;
        public System.Net.Sockets.Socket GameServer;
        public ProxyReceive(TcpProxy instance, System.Net.Sockets.Socket ProxyServer, System.Net.Sockets.Socket GameServer)
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

                            GUI.Listview.Add(packets, "From client", this.Instance);
                            Send.Data(GameServer, buffer);

                        }
                        else
                        {
                            GUI.Listview.Add(packets, "From server", this.Instance);
                            Send.Data(GameServer, buffer, received);
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.Instance.Invoke((MethodInvoker)delegate
                    {
                        this.Instance.PacketList.Items.Add($"An error occurred: {ex.Message}");
                    });
                }
            }
        }
    }
}   
