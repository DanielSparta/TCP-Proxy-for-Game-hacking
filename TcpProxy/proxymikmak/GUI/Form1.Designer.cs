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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traffic = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SocketPort = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(661, 45);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send (To Server)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 229);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Packet";
            this.columnHeader1.Width = 642;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 126;
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
            this.copyPacketToolStripMenuItem.Click += new System.EventHandler(this.copyPacketToolStripMenuItem_Click);
            // 
            // traffic
            // 
            this.traffic.AutoSize = true;
            this.traffic.Location = new System.Drawing.Point(683, 294);
            this.traffic.Name = "traffic";
            this.traffic.Size = new System.Drawing.Size(97, 17);
            this.traffic.TabIndex = 1;
            this.traffic.Text = "Intercept traffic";
            this.traffic.UseVisualStyleBackColor = true;
            this.traffic.CheckedChanged += new System.EventHandler(this.traffic_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send (To Client)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear listview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(4, 292);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(231, 20);
            this.ip.TabIndex = 7;
            this.ip.Text = "Your game server Ip Address";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(241, 292);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(95, 20);
            this.port.TabIndex = 8;
            this.port.Text = "Game server port";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 19);
            this.button4.TabIndex = 9;
            this.button4.Text = "start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SocketPort
            // 
            this.SocketPort.Location = new System.Drawing.Point(342, 292);
            this.SocketPort.Name = "SocketPort";
            this.SocketPort.Size = new System.Drawing.Size(95, 20);
            this.SocketPort.TabIndex = 11;
            this.SocketPort.Text = "Socket server port";
            // 
            // TcpProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 319);
            this.Controls.Add(this.SocketPort);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.traffic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TcpProxy";
            this.Text = " TCP Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyPacketToolStripMenuItem;
        public System.Windows.Forms.CheckBox traffic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SocketPort;
    }
}

