using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImagePicker
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();

            ScreenBuffer = CaptureScreen();
            ResultScreenBox.Image = ScreenBuffer;
            RGBLabel.Visible = false;
            ColorPickButton.Enabled = false;
            Console.WriteLine("ScreenShot Successfully ...");
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

        private int Red;
        private int Green;
        private int Blue;

        private void ColorPickButton_Click(object sender, System.EventArgs e)
        {
            using(var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorDialog.FullOpen = false;
                    Color SelectedColor = colorDialog.Color;
                }
            }
        }

        private string ColorToHtml(Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
        }

        private void Multi()
        {
            HTMLColorBox.SelectAll();
            HTMLColorBox.Copy();
        }


        private void ResultScreenBox_Click(object sender, EventArgs e)
        {
            Point ClickPoint = Cursor.Position;
            Bitmap Image = (Bitmap)ResultScreenBox.Image;
            Color PickedColor = Image.GetPixel(ClickPoint.X, ClickPoint.Y);

            Red = PickedColor.R;
            Green = PickedColor.G;
            Blue = PickedColor.B;

            Color GetColor = Color.FromArgb(Red, Green, Blue);

            PickColorPanel.BackColor = GetColor;

            string HtmlCode = ColorToHtml(GetColor);

            HTMLColorBox.Text = HtmlCode;
            Multi();

            RGBLabel.Text = $"{Red}, {Green}, {Blue}";

            if (ShowRGBCheckBox.Checked)
            {
                var nL = Environment.NewLine;
                MessageBox.Show("RGB : " + $"{Red}, {Green}, {Blue}", "Show RGB", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CaptureButton_Click(object sender, System.EventArgs e)
        {
            ScreenBuffer = CaptureScreen();
            ResultScreenBox.Image = ScreenBuffer;
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
        private void ShowRGBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowRGBCheckBox.Checked)
            {
                RGBLabel.Visible = true;
            }
            else
            {
                RGBLabel.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if(ResultScreenBox.Image != null)
            {
                using (var sfd = new SaveFileDialog() { Filter = "BitMap形式(*.bmp) | *.bmp; | PNG形式(*.png) | *.png; | JPEG形式(*.jpg *.jpeg) | *.jpg; *.jpeg;"})
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string FileName = sfd.FileName;

                            switch (Path.GetExtension(FileName).ToLower())
                            {
                                case ".bmp":
                                    ResultScreenBox.Image.Save(FileName, ImageFormat.Bmp);
                                    break;

                                case ".png":
                                    ResultScreenBox.Image.Save(FileName, ImageFormat.Png);
                                    break;

                                case ".jpg":
                                case ".jpeg":
                                    ResultScreenBox.Image.Save(FileName, ImageFormat.Jpeg);
                                    break;
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
    }
}