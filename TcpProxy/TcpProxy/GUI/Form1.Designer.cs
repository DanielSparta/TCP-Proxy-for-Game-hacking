﻿namespace TcpProxy
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(6, 287);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(78, 19);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.ClientSendBtn);
            this.tabPage1.Controls.Add(this.ServerSendBtn);
            this.tabPage1.Controls.Add(this.SendPacketText);
            this.tabPage1.Controls.Add(this.StartBtn);
            this.tabPage1.Controls.Add(this.ClearBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Network Traffic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.message);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.username);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item getting";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(283, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 38);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Code Get";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.Location = new System.Drawing.Point(273, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 38);
            this.textBox2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Send Message";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.username.Location = new System.Drawing.Point(283, 166);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(192, 38);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.message.Location = new System.Drawing.Point(283, 210);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(192, 38);
            this.message.TabIndex = 4;
            this.message.Text = "Message";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox username;
    }
}

