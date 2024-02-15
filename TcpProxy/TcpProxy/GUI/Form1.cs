using System;
using System.Drawing;
using System.Text;
using System.Threading;
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
            this.data.OnEditEvent += ShowPacket;
            this.GameServer = data.GameServer;
            this.ProxySocketServer = data.ProxyServer;
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
            new Thread(() => StringAddress.Change("213.8.147.201")).Start();
            new Thread(() =>
            {
                try
                {
                    //dynamic values
                    string TargetServerIP = "213.8.147.201";
                    int ProxyPort = int.Parse("443");
                    int TargetServerPort = int.Parse("443");

                    //Proxy server creating
                    System.Net.Sockets.Socket ProxyServer = SocketServer.Create(ProxyPort);

                    //Proxy server receiving connection
                    Socket.SocketReceive Data = new Socket.SocketReceive(this, TargetServerPort, TargetServerIP);
                    Data.Receive(ProxyServer);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }).Start();

            new Thread(() => StringAddress.Change("213.8.147.198")).Start();
            new Thread(() =>
            {
                try
                {
                    //dynamic values
                    string TargetServerIP = "213.8.147.198";
                    int ProxyPort = int.Parse("443");
                    int TargetServerPort = int.Parse("443");

                    //Proxy server creating
                    System.Net.Sockets.Socket ProxyServer = SocketServer.Create(ProxyPort);

                    //Proxy server receiving connection
                    Socket.SocketReceive Data = new Socket.SocketReceive(this, TargetServerPort, TargetServerIP);
                    Data.Receive(ProxyServer);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }).Start();
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

        private void TcpProxy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Send data to client (from the server)
                Send.Data(this.ProxySocketServer, Encoding.UTF8.GetBytes(@"{""b"":{""r"":-1,""o"":{""add"":""[{'id':" + textBox1.Text + @"}]"",""_cmd"":""inv_list""}},""t"":""xt""}" + "\0"));
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send.Data(this.ProxySocketServer, Encoding.UTF8.GetBytes(@"{""b"":{ ""r"":-1,""o"":{""prizeDesc"":""[{'a':'" + textBox2.Text + @"','c':'1'}]"",""res"":""ok"",""_cmd"":""codes_auth_res"",""prizeType"":8} },""t"":""xt""}" + "\0"));
        }
    }
}