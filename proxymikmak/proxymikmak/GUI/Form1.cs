using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using proxymikmak.Proxy;

namespace proxymikmak
{
    public partial class Form1 : Form
    {
        public ProxyReceive data;
        private System.Net.Sockets.Socket GameServer;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += CloseEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dynamic values, will changed from gui
            string TargetServerIP = "213.8.147.206";
            int ProxyPort = 443;
            int TargetServerPort = 443;

            //Proxy server creating
            Socket.SocketCreate Socket = new Socket.SocketCreate();
            Socket.Create(ProxyPort);
            System.Net.Sockets.Socket ProxyServer = Socket.ProxyServer;

            //Proxy server receiving connection
            Socket.SocketReceive Data = new Socket.SocketReceive(this, TargetServerPort, TargetServerIP);
            Data.Receive(ProxyServer);
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void LoadDelegate()
        {
            this.data.OnEditEvent += ShowPacket;
            this.GameServer = data.GameServer;
        }
        private void ShowPacket(string packet)
        {
            //You intercepting the packets.
            this.Invoke((MethodInvoker)delegate
            {
                this.textBox2.Text = packet;
            });
            //@TODO: manipulating the packet data
            //@TODO: fixing unknown bug that stop sniffing the packets and printing it after disable CheckBox checking
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.GameServer.Send(Encoding.UTF8.GetBytes(this.textBox2.Text + "\0"));
        }

        //private string datasent = @"{""t"":""xt"",""b"":{""x"":""ExtManager"",""p"":{},""c"":""us_away"",""r"":3}}";
        private void button2_Click(object sender, EventArgs e)
        {
            //this.GameServer.Send(Encoding.ASCII.GetBytes(datasent));
        }
    }
}
