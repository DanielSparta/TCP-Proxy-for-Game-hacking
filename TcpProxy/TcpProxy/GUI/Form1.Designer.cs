namespace TcpProxy
{
    partial class TcpProxy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendPacketText = new System.Windows.Forms.TextBox();
            this.ServerSendBtn = new System.Windows.Forms.Button();
            this.PacketList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrafficIntercept = new System.Windows.Forms.CheckBox();
            this.ClientSendBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GameServerIp = new System.Windows.Forms.TextBox();
            this.GameServerPort = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ProxyServerPort = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendPacketText
            // 
            this.SendPacketText.Location = new System.Drawing.Point(4, 241);
            this.SendPacketText.Multiline = true;
            this.SendPacketText.Name = "SendPacketText";
            this.SendPacketText.Size = new System.Drawing.Size(661, 45);
            this.SendPacketText.TabIndex = 2;
            this.SendPacketText.Text = " ";
            // 
            // ServerSendBtn
            // 
            this.ServerSendBtn.Location = new System.Drawing.Point(671, 241);
            this.ServerSendBtn.Name = "ServerSendBtn";
            this.ServerSendBtn.Size = new System.Drawing.Size(109, 20);
            this.ServerSendBtn.TabIndex = 3;
            this.ServerSendBtn.Text = "Send (To Server)";
            this.ServerSendBtn.UseVisualStyleBackColor = true;
            this.ServerSendBtn.Click += new System.EventHandler(this.SendToServer_btn);
            // 
            // PacketList
            // 
            this.PacketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.PacketList.HideSelection = false;
            this.PacketList.Location = new System.Drawing.Point(4, 4);
            this.PacketList.Name = "PacketList";
            this.PacketList.Size = new System.Drawing.Size(776, 229);
            this.PacketList.TabIndex = 4;
            this.PacketList.UseCompatibleStateImageBehavior = false;
            this.PacketList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Packet";
            this.columnHeader2.Width = 666;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPacketToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // copyPacketToolStripMenuItem
            // 
            this.copyPacketToolStripMenuItem.Name = "copyPacketToolStripMenuItem";
            this.copyPacketToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.copyPacketToolStripMenuItem.Text = "Copy Packet";
            this.copyPacketToolStripMenuItem.Click += new System.EventHandler(this.PacketListview_CopyPacket);
            // 
            // TrafficIntercept
            // 
            this.TrafficIntercept.AutoSize = true;
            this.TrafficIntercept.Location = new System.Drawing.Point(683, 294);
            this.TrafficIntercept.Name = "TrafficIntercept";
            this.TrafficIntercept.Size = new System.Drawing.Size(97, 17);
            this.TrafficIntercept.TabIndex = 1;
            this.TrafficIntercept.Text = "Intercept traffic";
            this.TrafficIntercept.UseVisualStyleBackColor = true;
            this.TrafficIntercept.CheckedChanged += new System.EventHandler(this.TrafficIntercept_click);
            // 
            // ClientSendBtn
            // 
            this.ClientSendBtn.Location = new System.Drawing.Point(671, 267);
            this.ClientSendBtn.Name = "ClientSendBtn";
            this.ClientSendBtn.Size = new System.Drawing.Size(109, 20);
            this.ClientSendBtn.TabIndex = 5;
            this.ClientSendBtn.Text = "Send (To Client)";
            this.ClientSendBtn.UseVisualStyleBackColor = true;
            this.ClientSendBtn.Click += new System.EventHandler(this.SendToClient_btn);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(584, 291);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(93, 20);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear listview";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GameServerIp
            // 
            this.GameServerIp.Location = new System.Drawing.Point(4, 292);
            this.GameServerIp.Name = "GameServerIp";
            this.GameServerIp.Size = new System.Drawing.Size(231, 20);
            this.GameServerIp.TabIndex = 7;
            this.GameServerIp.Text = "Your game server Ip Address";
            // 
            // GameServerPort
            // 
            this.GameServerPort.Location = new System.Drawing.Point(241, 292);
            this.GameServerPort.Name = "GameServerPort";
            this.GameServerPort.Size = new System.Drawing.Size(95, 20);
            this.GameServerPort.TabIndex = 8;
            this.GameServerPort.Text = "Game server port";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(443, 292);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(78, 19);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ProxyServerPort
            // 
            this.ProxyServerPort.Location = new System.Drawing.Point(342, 292);
            this.ProxyServerPort.Name = "ProxyServerPort";
            this.ProxyServerPort.Size = new System.Drawing.Size(95, 20);
            this.ProxyServerPort.TabIndex = 9;
            this.ProxyServerPort.Text = "Socket server port";
            // 
            // TcpProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 319);
            this.Controls.Add(this.ProxyServerPort);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.GameServerPort);
            this.Controls.Add(this.GameServerIp);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ClientSendBtn);
            this.Controls.Add(this.PacketList);
            this.Controls.Add(this.ServerSendBtn);
            this.Controls.Add(this.SendPacketText);
            this.Controls.Add(this.TrafficIntercept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TcpProxy";
            this.Text = " TCP Proxy";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox SendPacketText;
        private System.Windows.Forms.Button ServerSendBtn;
        public System.Windows.Forms.ListView PacketList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyPacketToolStripMenuItem;
        public System.Windows.Forms.CheckBox TrafficIntercept;
        private System.Windows.Forms.Button ClientSendBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox GameServerIp;
        private System.Windows.Forms.TextBox GameServerPort;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox ProxyServerPort;
    }
}

