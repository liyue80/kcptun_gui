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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSwitcher = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textboxProgram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.checkBoxDebugWriteFile = new System.Windows.Forms.CheckBox();
            this.buttonRandomLocalPort = new System.Windows.Forms.Button();
            this.CheckLocalPortButton = new System.Windows.Forms.Button();
            this.checkboxDebug = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitorTimer = new System.Windows.Forms.Timer(this.components);
            this.textboxLocalPort = new util.PortTextBox();
            this.textboxRemotePort = new util.PortTextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel2.Text = "Kcptun Client";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(50, 16);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSwitcher);
            this.groupBox2.Controls.Add(this.buttonBrowse);
            this.groupBox2.Controls.Add(this.textboxProgram);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCommand);
            this.groupBox2.Controls.Add(this.checkBoxDebugWriteFile);
            this.groupBox2.Controls.Add(this.buttonRandomLocalPort);
            this.groupBox2.Controls.Add(this.CheckLocalPortButton);
            this.groupBox2.Controls.Add(this.textboxLocalPort);
            this.groupBox2.Controls.Add(this.textboxRemotePort);
            this.groupBox2.Controls.Add(this.checkboxDebug);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textboxKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textboxServer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kcptun Client";
            // 
            // buttonSwitcher
            // 
            this.buttonSwitcher.Location = new System.Drawing.Point(23, 201);
            this.buttonSwitcher.Name = "buttonSwitcher";
            this.buttonSwitcher.Size = new System.Drawing.Size(79, 23);
            this.buttonSwitcher.TabIndex = 22;
            this.buttonSwitcher.Text = "Start";
            this.buttonSwitcher.UseVisualStyleBackColor = true;
            this.buttonSwitcher.Click += new System.EventHandler(this.buttonSwitcher_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(354, 15);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowse.TabIndex = 21;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textboxProgram
            // 
            this.textboxProgram.Location = new System.Drawing.Point(93, 17);
            this.textboxProgram.Name = "textboxProgram";
            this.textboxProgram.ReadOnly = true;
            this.textboxProgram.Size = new System.Drawing.Size(255, 20);
            this.textboxProgram.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Program";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Command";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(93, 130);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ReadOnly = true;
            this.textBoxCommand.Size = new System.Drawing.Size(286, 57);
            this.textBoxCommand.TabIndex = 17;
            // 
            // checkBoxDebugWriteFile
            // 
            this.checkBoxDebugWriteFile.AutoSize = true;
            this.checkBoxDebugWriteFile.Enabled = false;
            this.checkBoxDebugWriteFile.Location = new System.Drawing.Point(176, 207);
            this.checkBoxDebugWriteFile.Name = "checkBoxDebugWriteFile";
            this.checkBoxDebugWriteFile.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDebugWriteFile.TabIndex = 16;
            this.checkBoxDebugWriteFile.Text = "Write log to file";
            this.checkBoxDebugWriteFile.UseVisualStyleBackColor = true;
            // 
            // buttonRandomLocalPort
            // 
            this.buttonRandomLocalPort.Location = new System.Drawing.Point(159, 98);
            this.buttonRandomLocalPort.Name = "buttonRandomLocalPort";
            this.buttonRandomLocalPort.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomLocalPort.TabIndex = 14;
            this.buttonRandomLocalPort.Text = "Random";
            this.buttonRandomLocalPort.UseVisualStyleBackColor = true;
            this.buttonRandomLocalPort.Click += new System.EventHandler(this.buttonRandomLocalPort_Click);
            // 
            // CheckLocalPortButton
            // 
            this.CheckLocalPortButton.Location = new System.Drawing.Point(240, 98);
            this.CheckLocalPortButton.Name = "CheckLocalPortButton";
            this.CheckLocalPortButton.Size = new System.Drawing.Size(75, 23);
            this.CheckLocalPortButton.TabIndex = 13;
            this.CheckLocalPortButton.Text = "Test Port";
            this.CheckLocalPortButton.UseVisualStyleBackColor = true;
            this.CheckLocalPortButton.Click += new System.EventHandler(this.CheckLocalPortButton_Click);
            // 
            // checkboxDebug
            // 
            this.checkboxDebug.AutoSize = true;
            this.checkboxDebug.Location = new System.Drawing.Point(112, 207);
            this.checkboxDebug.Name = "checkboxDebug";
            this.checkboxDebug.Size = new System.Drawing.Size(58, 17);
            this.checkboxDebug.TabIndex = 9;
            this.checkboxDebug.Text = "Debug";
            this.checkboxDebug.UseVisualStyleBackColor = true;
            this.checkboxDebug.CheckedChanged += new System.EventHandler(this.checkboxDebug_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key/Passwd";
            // 
            // textboxKey
            // 
            this.textboxKey.Location = new System.Drawing.Point(243, 72);
            this.textboxKey.Name = "textboxKey";
            this.textboxKey.Size = new System.Drawing.Size(136, 20);
            this.textboxKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Port";
            // 
            // textboxServer
            // 
            this.textboxServer.Location = new System.Drawing.Point(93, 44);
            this.textboxServer.Name = "textboxServer";
            this.textboxServer.Size = new System.Drawing.Size(286, 20);
            this.textboxServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Addr";
            // 
            // monitorTimer
            // 
            this.monitorTimer.Tick += new System.EventHandler(this.monitorTimer_Tick);
            // 
            // textboxLocalPort
            // 
            this.textboxLocalPort.Location = new System.Drawing.Point(93, 100);
            this.textboxLocalPort.MaxLength = 5;
            this.textboxLocalPort.Name = "textboxLocalPort";
            this.textboxLocalPort.Size = new System.Drawing.Size(60, 20);
            this.textboxLocalPort.TabIndex = 12;
            // 
            // textboxRemotePort
            // 
            this.textboxRemotePort.Location = new System.Drawing.Point(93, 72);
            this.textboxRemotePort.MaxLength = 5;
            this.textboxRemotePort.Name = "textboxRemotePort";
            this.textboxRemotePort.Size = new System.Drawing.Size(60, 20);
            this.textboxRemotePort.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer monitorTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxKey;
        private System.Windows.Forms.CheckBox checkboxDebug;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private PortTextBox textboxRemotePort;
        private PortTextBox textboxLocalPort;
        private System.Windows.Forms.Button CheckLocalPortButton;
        private System.Windows.Forms.Button buttonRandomLocalPort;
        private System.Windows.Forms.CheckBox checkBoxDebugWriteFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxProgram;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSwitcher;

    }
}

