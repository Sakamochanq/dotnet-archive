using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace StopMotionCapture
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
            PlayButton.Enabled = true;
            StopButton.Enabled = false;
            RetryButton.Enabled = true;
        }

        private Bitmap ScreenBuffer;
        private string screenshot;

        private Bitmap CaptureScreen()
        {
            Size screensize = Screen.PrimaryScreen.Bounds.Size;
            Bitmap screenshot = new Bitmap(screensize.Width, screensize.Height);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(0, 0, 0, 0, screensize);
            }
            return screenshot;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = false;
            StopButton.Enabled = true;
            RetryButton.Enabled = false;

            StopMotionTick.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopButton.Enabled = false;
            RetryButton.Enabled = true;
            StopMotionTick.Stop();
        }
        private void RetryButton_Click(object sender, EventArgs e)
        {
            CaptureBox.Image = null;
        }

        private void StopMotionTick_Tick(object sender, EventArgs e)
        {
            try
            {
                ScreenBuffer = CaptureScreen();
                CaptureBox.Image = ScreenBuffer;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMostCheckBox.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
