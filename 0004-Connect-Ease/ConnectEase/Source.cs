using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectEase
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent(); 
            this.KEYbox.PasswordChar = '⚫';
        }

        private string SSID;
        private string KEY;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SSID = SSIDbox.Text;
            KEY = KEYbox.Text;

            ProcessStartInfo psi = new ProcessStartInfo("netsh", $"wlan connect ssid={SSID} keyMaterial={KEY}");

            #region Settings
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            #endregion

            try
            {

                Process prs = new Process();
                prs.StartInfo = psi;
                prs.OutputDataReceived += (s, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data) && args.Data.Contains("Success"))
                    {
                        try
                        {
                            progressbar.Value = 100;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Connect Ease", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                };
                prs.Start();
                prs.BeginOutputReadLine();
                prs.WaitForExit();

                if (prs.ExitCode == 0)
                {
                    MessageBox.Show("Connected Successfully ...", "Connect Ease", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new Exception("Conncted Failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Ease", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            SSID = SSIDbox.Text;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("netsh", $"wlan disconnect interface=\"{SSID}\"");

                #region Settings
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                #endregion

                Process prs = new Process();
                prs.StartInfo = psi;
                prs.Start();

                prs.WaitForExit();

                if (prs.ExitCode == 0)
                {
                    MessageBox.Show("Disconnected Successfully ...", "Connect Ease", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new Exception("Disconncted Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Ease", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CharCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CharCheckBox.Checked)
            {
                this.KEYbox.PasswordChar = (char)0;
            }
            else
            {
                this.KEYbox.PasswordChar = '⚫';
            }
        }
    }
}
