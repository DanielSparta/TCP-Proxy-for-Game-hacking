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
        private System.Net.Sockets.Socket ProxySocketServer;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += CloseEvent;
            this.listView1.MouseUp += MouseUpEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            this.TopMost = true;
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
            this.ProxySocketServer = data.ProxyServer;
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.contextMenuStrip1.Show(Cursor.Position);
        }
        private void ShowPacket(byte[] buffer)
        {
            //You intercepting the packets.
            this.Invoke((MethodInvoker)delegate
            {
                this.textBox2.Text = Encoding.ASCII.GetString(buffer);
            });
            //@TODO: manipulating the packet data
            //@TODO: fixing unknown bug that stop sniffing the packets and printing it after disable CheckBox checking
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Send data to server (from the game)
            this.GameServer.Send(Encoding.UTF8.GetBytes(this.textBox2.Text + "\0"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Send data to client (from the server)
            this.ProxySocketServer.Send(Encoding.UTF8.GetBytes(this.textBox2.Text + "\0"));
        }

        private void copyPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string SelectedPacket = listView1.SelectedItems[0].Text;
                Clipboard.SetText(SelectedPacket);
            }
        }

        private void traffic_CheckedChanged(object sender, EventArgs e)
        {
            if (traffic.Checked)
                MessageBox.Show("right now the feature is not working, buggy. there is more work about this thing.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }
    }
}
