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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendPacketText
            // 
            this.SendPacketText.Location = new System.Drawing.Point(3, 237);
            this.SendPacketText.Multiline = true;
            this.SendPacketText.Name = "SendPacketText";
            this.SendPacketText.Size = new System.Drawing.Size(661, 45);
            this.SendPacketText.TabIndex = 2;
            this.SendPacketText.Text = " ";
            // 
            // ServerSendBtn
            // 
            this.ServerSendBtn.Location = new System.Drawing.Point(670, 237);
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
            this.PacketList.Location = new System.Drawing.Point(3, 0);
            this.PacketList.Name = "PacketList";
            this.PacketList.Size = new System.Drawing.Size(776, 229);
            this.PacketList.TabIndex = 4;
            this.PacketList.UseCompatibleStateImageBehavior = false;
            this.PacketList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Packet";
            this.columnHeader1.Width = 653;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 116;
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
            this.TrafficIntercept.Location = new System.Drawing.Point(682, 290);
            this.TrafficIntercept.Name = "TrafficIntercept";
            this.TrafficIntercept.Size = new System.Drawing.Size(97, 17);
            this.TrafficIntercept.TabIndex = 1;
            this.TrafficIntercept.Text = "Intercept traffic";
            this.TrafficIntercept.UseVisualStyleBackColor = true;
            this.TrafficIntercept.CheckedChanged += new System.EventHandler(this.TrafficIntercept_click);
            // 
            // ClientSendBtn
            // 
            this.ClientSendBtn.Location = new System.Drawing.Point(670, 263);
            this.ClientSendBtn.Name = "ClientSendBtn";
            this.ClientSendBtn.Size = new System.Drawing.Size(109, 20);
            this.ClientSendBtn.TabIndex = 5;
            this.ClientSendBtn.Text = "Send (To Client)";
            this.ClientSendBtn.UseVisualStyleBackColor = true;
            this.ClientSendBtn.Click += new System.EventHandler(this.SendToClient_btn);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(583, 287);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(93, 20);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear listview";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GameServerIp
            // 
            this.GameServerIp.Location = new System.Drawing.Point(3, 288);
            this.GameServerIp.Name = "GameServerIp";
            this.GameServerIp.Size = new System.Drawing.Size(231, 20);
            this.GameServerIp.TabIndex = 7;
            this.GameServerIp.Text = "213.8.147.198";
            // 
            // GameServerPort
            // 
            this.GameServerPort.Location = new System.Drawing.Point(240, 288);
            this.GameServerPort.Name = "GameServerPort";
            this.GameServerPort.Size = new System.Drawing.Size(95, 20);
            this.GameServerPort.TabIndex = 8;
            this.GameServerPort.Text = "443";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(442, 288);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(78, 19);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ProxyServerPort
            // 
            this.ProxyServerPort.Location = new System.Drawing.Point(341, 288);
            this.ProxyServerPort.Name = "ProxyServerPort";
            this.ProxyServerPort.Size = new System.Drawing.Size(95, 20);
            this.ProxyServerPort.TabIndex = 9;
            this.ProxyServerPort.Text = "443";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 353);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PacketList);
            this.tabPage1.Controls.Add(this.TrafficIntercept);
            this.tabPage1.Controls.Add(this.GameServerPort);
            this.tabPage1.Controls.Add(this.ClientSendBtn);
            this.tabPage1.Controls.Add(this.ProxyServerPort);
            this.tabPage1.Controls.Add(this.ServerSendBtn);
            this.tabPage1.Controls.Add(this.GameServerIp);
            this.tabPage1.Controls.Add(this.SendPacketText);
            this.tabPage1.Controls.Add(this.StartBtn);
            this.tabPage1.Controls.Add(this.ClearBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "הרחקת משתמשים";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "השגת פריטים";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(283, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 38);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Get all Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(51, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "רשום קוד פריט וקבל אותו";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "השגת פרטי משתמשים";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 327);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "השגת מנוי";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(243, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "נשמר לאחר התנתקות, ניתן להחליף";
            // 
            // TcpProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 359);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TcpProxy";
            this.Text = " TCP Proxy";
            this.Load += new System.EventHandler(this.TcpProxy_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
    }
}

