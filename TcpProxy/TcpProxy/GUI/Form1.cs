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
using TcpProxy.Proxy;
using TcpProxy.Socket;

namespace TcpProxy
{
    public partial class TcpProxy : Form
    {
        public ProxyReceive data;
        private System.Net.Sockets.Socket GameServer;
        private System.Net.Sockets.Socket ProxySocketServer;
        public TcpProxy()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormClosing += CloseEvent;
            this.PacketList.MouseUp += MouseUpEvent;
        }
        private void TrafficIntercept_click(object sender, EventArgs e)
        {
            if (TrafficIntercept.Checked)
                MessageBox.Show("right now the feature is not working, buggy. there is more work about this thing.");
        }
        public void LoadDelegate()
        {
            //this.data.OnEditEvent += ShowPacket;
            //this.GameServer = data.GameServer;
            //this.ProxySocketServer = data.ProxyServer;
        }
        private void ShowPacket(byte[] buffer)
        {
            //You intercepting the packets.
            this.Invoke((MethodInvoker)delegate
            {
                this.SendPacketText.Text = Encoding.ASCII.GetString(buffer);
            });
            //@TODO: manipulating the packet data
            //@TODO: fixing unknown bug that stop sniffing the packets and printing it after disable CheckBox checking
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //dynamic values
                string TargetServerIP = GameServerIp.Text;
                int ProxyPort = int.Parse(GameServerPort.Text);
                int TargetServerPort = int.Parse(ProxyServerPort.Text);

                //Proxy server creating
                System.Net.Sockets.Socket ProxyServer = SocketServer.Create(ProxyPort);

                //Proxy server receiving connection
                Socket.SocketReceive Data = new Socket.SocketReceive(this, TargetServerPort, TargetServerIP);
                Data.Receive(ProxyServer);
            }catch(Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
        }
        private void SendToServer_btn(object sender, EventArgs e)
        {
            try
            {
                //Send data to server (from the game)
                Send.Data(this.GameServer, Encoding.UTF8.GetBytes(this.SendPacketText.Text + "\0"));
            }
            catch { }
        }
        private void SendToClient_btn(object sender, EventArgs e)
        {
            try
            {
                //Send data to client (from the server)
                Send.Data(this.ProxySocketServer, Encoding.UTF8.GetBytes(this.SendPacketText.Text + "\0"));
            }
            catch { }
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.contextMenuStrip1.Show(Cursor.Position);
        }
        private void PacketListview_CopyPacket(object sender, EventArgs e)
        {
            if (PacketList.SelectedItems.Count == 1)
            {
                string SelectedPacket = PacketList.SelectedItems[0].Text;
                Clipboard.SetText(SelectedPacket);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.PacketList.Items.Clear();
        }
        private void CloseEvent(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}