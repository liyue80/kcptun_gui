namespace util
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopShadowsocks = new System.Windows.Forms.Button();
            this.startShadowsocks = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startKcptunClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitorTimer = new System.Windows.Forms.Timer(this.components);
            this.checkboxDebug = new System.Windows.Forms.CheckBox();
            this.stopKcptunClient = new System.Windows.Forms.Button();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.textboxLocalPort = new util.Int32TextBox();
            this.textboxRemotePort = new util.Int32TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopShadowsocks);
            this.groupBox1.Controls.Add(this.startShadowsocks);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shadowsocks";
            // 
            // stopShadowsocks
            // 
            this.stopShadowsocks.Location = new System.Drawing.Point(122, 18);
            this.stopShadowsocks.Name = "stopShadowsocks";
            this.stopShadowsocks.Size = new System.Drawing.Size(75, 23);
            this.stopShadowsocks.TabIndex = 1;
            this.stopShadowsocks.Text = "Stop";
            this.stopShadowsocks.UseVisualStyleBackColor = true;
            this.stopShadowsocks.Click += new System.EventHandler(this.stopShadowsocks_Click);
            // 
            // startShadowsocks
            // 
            this.startShadowsocks.Location = new System.Drawing.Point(20, 19);
            this.startShadowsocks.Name = "startShadowsocks";
            this.startShadowsocks.Size = new System.Drawing.Size(75, 23);
            this.startShadowsocks.TabIndex = 0;
            this.startShadowsocks.Text = "Start";
            this.startShadowsocks.UseVisualStyleBackColor = true;
            this.startShadowsocks.Click += new System.EventHandler(this.startShadowsocks_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Shadowsocks";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel2.Text = "Kcptun Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stopKcptunClient);
            this.groupBox2.Controls.Add(this.checkboxDebug);
            this.groupBox2.Controls.Add(this.startKcptunClient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textboxKey);
            this.groupBox2.Controls.Add(this.textboxLocalPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textboxRemotePort);
            this.groupBox2.Controls.Add(this.textboxServer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kcptun Client";
            // 
            // startKcptunClient
            // 
            this.startKcptunClient.Location = new System.Drawing.Point(20, 136);
            this.startKcptunClient.Name = "startKcptunClient";
            this.startKcptunClient.Size = new System.Drawing.Size(75, 23);
            this.startKcptunClient.TabIndex = 8;
            this.startKcptunClient.Text = "Start";
            this.startKcptunClient.UseVisualStyleBackColor = true;
            this.startKcptunClient.Click += new System.EventHandler(this.startKcptunClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key/Passwd";
            // 
            // textboxKey
            // 
            this.textboxKey.Location = new System.Drawing.Point(93, 101);
            this.textboxKey.Name = "textboxKey";
            this.textboxKey.Size = new System.Drawing.Size(100, 20);
            this.textboxKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Port";
            // 
            // textboxServer
            // 
            this.textboxServer.Location = new System.Drawing.Point(93, 17);
            this.textboxServer.Name = "textboxServer";
            this.textboxServer.Size = new System.Drawing.Size(166, 20);
            this.textboxServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Addr";
            // 
            // monitorTimer
            // 
            this.monitorTimer.Tick += new System.EventHandler(this.monitorTimer_Tick);
            // 
            // checkboxDebug
            // 
            this.checkboxDebug.AutoSize = true;
            this.checkboxDebug.Location = new System.Drawing.Point(245, 140);
            this.checkboxDebug.Name = "checkboxDebug";
            this.checkboxDebug.Size = new System.Drawing.Size(58, 17);
            this.checkboxDebug.TabIndex = 9;
            this.checkboxDebug.Text = "Debug";
            this.checkboxDebug.UseVisualStyleBackColor = true;
            this.checkboxDebug.CheckedChanged += new System.EventHandler(this.checkboxDebug_CheckedChanged);
            // 
            // stopKcptunClient
            // 
            this.stopKcptunClient.Location = new System.Drawing.Point(122, 136);
            this.stopKcptunClient.Name = "stopKcptunClient";
            this.stopKcptunClient.Size = new System.Drawing.Size(75, 23);
            this.stopKcptunClient.TabIndex = 10;
            this.stopKcptunClient.Text = "Stop";
            this.stopKcptunClient.UseVisualStyleBackColor = true;
            this.stopKcptunClient.Click += new System.EventHandler(this.stopKcptunClient_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(50, 16);
            // 
            // textboxLocalPort
            // 
            this.textboxLocalPort.Location = new System.Drawing.Point(93, 74);
            this.textboxLocalPort.MaxLength = 5;
            this.textboxLocalPort.Name = "textboxLocalPort";
            this.textboxLocalPort.Size = new System.Drawing.Size(60, 20);
            this.textboxLocalPort.TabIndex = 5;
            this.textboxLocalPort.Tag = "";
            // 
            // textboxRemotePort
            // 
            this.textboxRemotePort.Location = new System.Drawing.Point(93, 45);
            this.textboxRemotePort.MaxLength = 5;
            this.textboxRemotePort.Name = "textboxRemotePort";
            this.textboxRemotePort.Size = new System.Drawing.Size(60, 20);
            this.textboxRemotePort.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button stopShadowsocks;
        private System.Windows.Forms.Button startShadowsocks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer monitorTimer;
        private Int32TextBox textboxRemotePort;
        private Int32TextBox textboxLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxKey;
        private System.Windows.Forms.Button startKcptunClient;
        private System.Windows.Forms.CheckBox checkboxDebug;
        private System.Windows.Forms.Button stopKcptunClient;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

    }
}

