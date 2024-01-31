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

namespace proxymikmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Socket.SocketReceive Data = new Socket.SocketReceive(TargetServerPort, TargetServerIP);
            Data.Receive(ProxyServer);

        }


    }
}
