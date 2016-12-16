using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace util
{
    public partial class Form1 : Form
    {
        private bool IsShadowsocksRunning
        {
            get { return (Process.GetProcessesByName("Shadowsocks").Length > 0); }
        }

        private bool IsKcptunClientRunning
        {
            get { return (Process.GetProcessesByName("client_windows_amd64").Length > 0); }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KcptunClientConfig config;
            config = KcptunClientConfig.LoadFromFile(KcptunClientConfig.DefaultFileName);
            if (config != null)
            {
                this.textboxServer.Text = config.ServerAddress;
                this.textboxRemotePort.Text = config.ServerPort;
                this.textboxLocalPort.Text = config.LocalPort;
                this.textboxKey.Text = config.Key;
            }
            this.toolStripProgressBar1.Visible = false;
            UpdateStatusBar();
            this.monitorTimer.Interval = 3 * 1000;
            this.monitorTimer.Start();
        }

        private void UpdateStatusBar()
        {
            lock (this)
            {
                toolStripStatusLabel1.Text = this.IsShadowsocksRunning ? "Shadowsocks: RUNNING" : "Shadowsocks: STOPPED";
                toolStripStatusLabel2.Text = this.IsKcptunClientRunning ? "Kcptun: RUNNING" : "Kcptun: STOPPED";
            }
        }

        private void startShadowsocks_Click(object sender, EventArgs e)
        {
            if (!this.IsShadowsocksRunning)
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = Path.Combine(Directory.GetCurrentDirectory(), "Shadowsocks.exe");
                start.WindowStyle = ProcessWindowStyle.Minimized;
                try
                {
                    using (Process proc = Process.Start(start)) { };
                    this.UpdateStatusBar();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stopShadowsocks_Click(object sender, EventArgs e)
        {
            if (this.IsShadowsocksRunning)
            {
                using (Form1.Progress progress = new Form1.Progress(this))
                {
                    int loops = 20;
                    progress.Value = progress.Minimum;
                    int step = (progress.Maximum - progress.Minimum) / loops;

                    this.KillProcessByName("Shadowsocks");

                    for (int i = 0; i < loops; i++)
                    {
                        progress.Value += step;
                        Thread.Sleep(3000 / loops);
                    }
                    SystemTray.RefreshTrayArea();
                    this.UpdateStatusBar();
                }
            }
        }

        private void monitorTimer_Tick(object sender, EventArgs e)
        {
            this.UpdateStatusBar();
        }

        private void startKcptunClient_Click(object sender, EventArgs e)
        {
            KcptunClientConfig config = this.SaveConfiguration();

            if (!this.IsKcptunClientRunning)
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = Path.Combine(Directory.GetCurrentDirectory(), "client_windows_amd64.exe");
                start.WindowStyle = checkboxDebug.Checked ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
                start.Arguments = string.Format("-l :{0} -r {1}:{2} --key {3}",
                    config.LocalPort, config.ServerAddress, config.ServerPort, config.Key);

                try
                {
                    using (Process proc = Process.Start(start)) { };
                    this.UpdateStatusBar();
                    checkboxDebug.Enabled = false;
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private KcptunClientConfig SaveConfiguration()
        {
            KcptunClientConfig config = new KcptunClientConfig();
            config.ServerAddress = textboxServer.Text;
            config.ServerPort = textboxRemotePort.Text;
            config.LocalPort = textboxLocalPort.Text;
            config.Key = textboxKey.Text;

            try
            {
                config.Save(KcptunClientConfig.DefaultFileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return config;
        }

        private KcptunClientConfig LoadConfiguration()
        {
            try
            {
                return KcptunClientConfig.LoadFromFile(KcptunClientConfig.DefaultFileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void checkboxDebug_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KillProcessByName(string name)
        {
            foreach (var proc in Process.GetProcessesByName(name))
            {
                proc.Kill();
            }
        }

        private void stopKcptunClient_Click(object sender, EventArgs e)
        {
            if (this.IsKcptunClientRunning)
            {
                using (Form1.Progress progress = new Form1.Progress(this))
                {
                    int loops = 20;
                    progress.Value = progress.Minimum;
                    int step = (progress.Maximum - progress.Minimum) / loops;

                    this.KillProcessByName("client_windows_amd64");

                    for (int i = 0; i < loops; i++)
                    {
                        progress.Value += step;
                        Thread.Sleep(3000 / loops);
                    }
                    this.UpdateStatusBar();
                }
            }
        }

        private class Progress : IDisposable
        {
            private Form1 form;

            internal int Value
            {
                get { return this.form.toolStripProgressBar1.Value; }
                set { this.form.toolStripProgressBar1.Value = value; }
            }

            internal int Minimum
            {
                get { return this.form.toolStripProgressBar1.Minimum; }
                set { this.form.toolStripProgressBar1.Minimum = value; }
            }

            internal int Maximum
            {
                get { return this.form.toolStripProgressBar1.Maximum; }
                set { this.form.toolStripProgressBar1.Maximum = value; }
            }

            internal Progress(Form1 form)
            {
                form.Enabled = false;

                this.form = form;
                form.toolStripProgressBar1.Minimum = 0;
                form.toolStripProgressBar1.Maximum = 100;
                form.toolStripProgressBar1.Value = 0;
                form.toolStripProgressBar1.Visible = true;
            }

            public void Dispose()
            {
                form.toolStripProgressBar1.Visible = false;
                form.Enabled = true;
            }
        }
    }
}
