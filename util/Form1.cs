using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace util
{
    public partial class Form1 : Form
    {
        private bool IsKcptunClientRunning
        {
            get
            {
                return (Process.GetProcessesByName("client_windows_amd64").Length > 0)
                    || (Process.GetProcessesByName("client_windows_386").Length > 0);
            }
        }

        private string KcptunProgramName32_64
        {
            get
            {
                return System.Environment.Is64BitOperatingSystem ? "client_windows_amd64.exe"
                    : "client_windows_386.exe";
            }
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
                this.textboxProgram.Text = config.ExecutableFile;
                this.textboxServer.Text = config.ServerAddress;
                this.textboxRemotePort.Text = config.ServerPort;
                this.textboxLocalPort.Text = config.LocalPort;
                this.textboxKey.Text = config.Key;
            }
            this.toolStripProgressBar1.Visible = false;
            this.RefreshGuiTextStatus();
            this.monitorTimer.Interval = 3 * 1000;
            this.monitorTimer.Start();

            if (!File.Exists(this.textboxProgram.Text))
            {
                this.PopupDownloadKcptunDialog();
            }

            UpdateTextBoxCommandArguments(null, null);
            this.textboxServer.TextChanged += UpdateTextBoxCommandArguments;
            this.textboxRemotePort.TextChanged += UpdateTextBoxCommandArguments;
            this.textboxLocalPort.TextChanged += UpdateTextBoxCommandArguments;
            this.textboxKey.TextChanged += UpdateTextBoxCommandArguments;
        }

        private void PopupDownloadKcptunDialog()
        {
            DialogResult dialogResult = MessageBox.Show(
                        "Cannot found Kcptun client in current directory.\n\n"
                        + "[Yes] Open web page to download a new kcptun client.\n"
                        + "[No] Choose the kcptun client on local disk.\n"
                        + "[Cancel] Do nothing.",
                        "Choice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (System.Windows.Forms.DialogResult.Yes == dialogResult)
            {
                System.Diagnostics.Process.Start("https://github.com/xtaci/kcptun/releases/latest");
            }
            else if (System.Windows.Forms.DialogResult.No == dialogResult)
            {
                this.ShowFileDialog();
            }
            else
            {
            }
        }

        private void RefreshGuiTextStatus()
        {
            lock (this)
            {
                if (this.IsKcptunClientRunning)
                {
                    this.toolStripStatusLabel2.Text = "Running";
                    this.buttonSwitcher.Text = "Stop";
                    this.textboxServer.Enabled = false;
                    this.textboxLocalPort.Enabled = false;
                    this.textboxRemotePort.Enabled = false;
                    this.textboxKey.Enabled = false;
                    this.buttonRandomLocalPort.Enabled = false;
                    this.checkboxDebug.Enabled = false;
                    this.checkBoxDebugWriteFile.Enabled = false;
                }
                else
                {
                    this.toolStripStatusLabel2.Text = "Stopped";
                    this.buttonSwitcher.Text = "Save && Start";
                    this.textboxServer.Enabled = true;
                    this.textboxLocalPort.Enabled = true;
                    this.textboxRemotePort.Enabled = true;
                    this.textboxKey.Enabled = true;
                    this.buttonRandomLocalPort.Enabled = true;
                    this.checkboxDebug.Enabled = true;
                    this.checkBoxDebugWriteFile.Enabled = true;
                }
            }
        }

        private void monitorTimer_Tick(object sender, EventArgs e)
        {
            this.RefreshGuiTextStatus();
        }

        private void StartKcptunClient()
        {
            if (!this.CheckLocalPort(false))
            {
                return;
            }

            if (!File.Exists(this.textboxProgram.Text))
            {
                MessageBox.Show("Invalid KCPTUN client file.");
                return;
            }

            KcptunClientConfig config = this.SaveConfiguration();

            if (!this.IsKcptunClientRunning)
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = this.textboxProgram.Text;
                start.UseShellExecute = true;
                start.CreateNoWindow = true;
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.WorkingDirectory = Path.GetDirectoryName(start.FileName);
                if (this.checkboxDebug.Checked && !this.checkBoxDebugWriteFile.Checked)
                {
                    start.WindowStyle = ProcessWindowStyle.Normal;
                }
                start.Arguments = this.GenerateKcptunCommandArguments(config);

                try
                {
                    using (Process proc = Process.Start(start)) { };
                    this.UpdateTextBoxCommandArguments(null, null);
                    this.RefreshGuiTextStatus();
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
            config.ExecutableFile = textboxProgram.Text;
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
            this.checkBoxDebugWriteFile.Enabled = this.checkboxDebug.Checked;
        }

        private void KillProcessByName(string name)
        {
            foreach (var proc in Process.GetProcessesByName(name))
            {
                proc.Kill();
            }
        }

        private void StopKcptunClient()
        {
            if (this.IsKcptunClientRunning)
            {
                using (Form1.Progress progress = new Form1.Progress(this))
                {
                    int loops = 20;
                    progress.Value = progress.Minimum;
                    int step = (progress.Maximum - progress.Minimum) / loops;

                    this.KillProcessByName("client_windows_amd64");
                    this.KillProcessByName("client_windows_386");

                    for (int i = 0; i < loops; i++)
                    {
                        progress.Value += step;
                        Thread.Sleep(3000 / loops);
                    }
                    this.RefreshGuiTextStatus();
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

        private void CheckLocalPortButton_Click(object sender, EventArgs e)
        {
            this.CheckLocalPort(true);
        }

        private bool CheckLocalPort(bool showMessageOnSuccess)
        {
            bool valid = true;
            int port = int.Parse(textboxLocalPort.Text);

            if (port <= 1024 || port > 655535)
            {
                valid = (MessageBox.Show("Port number is out of range. (1025~65535)\n\nDo you want to use it?",
                    null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes);
            }

            if (valid)
            {
                valid = this.TestPortInUse(port);
                if (valid)
                {
                    if (showMessageOnSuccess)
                    {
                        MessageBox.Show(
                            string.Format("Port {0} is valid.", textboxLocalPort.Text),
                            null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        string.Format("Port {0} is in use.", textboxLocalPort.Text),
                        null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return valid;
        }

        private bool TestPortInUse(int port)
        {
            // Evaluate current system tcp connections. This is the same information provided
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    return false;
                }
            }

            return true;
        }

        private void buttonRandomLocalPort_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.ToBinary());
            int port;

            do
            {
                port = rand.Next(30000 - 2000) + 2000;
            } while (!this.TestPortInUse(port));

            this.textboxLocalPort.Text = port.ToString();
        }

        private void UpdateTextBoxCommandArguments(object sender, EventArgs e)
        {
            string command = this.textboxProgram.Text;
            string arguments = this.GenerateKcptunCommandArguments(null);
            this.textBoxCommand.Text = string.Format("{0} {1}", command, arguments);
        }

        private string GenerateKcptunCommandArguments(KcptunClientConfig config)
        {
            string arguments = "";

            if (config == null)
            {
                if (this.textboxLocalPort.Text.Length > 0)
                {
                    arguments += string.Format(" -l :{0}", this.textboxLocalPort.Text);
                }

                if (this.textboxServer.Text.Length > 0)
                {
                    if (this.textboxRemotePort.Text.Length > 0)
                    {
                        arguments += string.Format(" -r {0}:{1}",
                            this.textboxServer.Text, this.textboxRemotePort.Text);
                    }
                    else
                    {
                        arguments += string.Format(" -r {0}:0", this.textboxServer.Text);
                    }
                }

                if (this.textboxKey.Text.Length > 0)
                {
                    arguments += string.Format(" --key {0}", this.textboxKey.Text);
                }
            }
            else
            {
                arguments = string.Format("-l :{0} -r {1}:{2} --key {3}",
                        config.LocalPort, config.ServerAddress, config.ServerPort, config.Key);
            }

            if (this.checkboxDebug.Checked && this.checkBoxDebugWriteFile.Checked)
                arguments += string.Format(" --log kcptun.log");

            return arguments.TrimStart();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.ShowFileDialog();
        }

        private void ShowFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Kcptun|client_windows_386.exe|Kcptun|client_windows_amd64.exe";
            dialog.FilterIndex = System.Environment.Is64BitOperatingSystem ? 2 : 1;
            dialog.CheckFileExists = true;
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult dialogResult = dialog.ShowDialog();

            if (System.Windows.Forms.DialogResult.OK == dialogResult)
            {
                this.textboxProgram.Text = dialog.FileName;
            }
        }

        private void buttonSwitcher_Click(object sender, EventArgs e)
        {
            if (this.IsKcptunClientRunning)
            {
                this.StopKcptunClient();
            }
            else
            {
                this.StartKcptunClient();
            }
        }
    }
}
