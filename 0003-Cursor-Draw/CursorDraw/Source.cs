using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CursorDraw
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
            PictureBox.Paint += new PaintEventHandler(PictureBox_Paint);
            PictureBox.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            PictureBox.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            PictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);

            //Build
            drawingBitmap = new Bitmap(PictureBox.Width, PictureBox.Height);

            //Color
            PensColorBox.Items.Add("⚫ Black");
            PensColorBox.Items.Add("⚪ White");
            PensColorBox.Items.Add("🔴 Red");
            PensColorBox.Items.Add("🔵 Blue");
            PensColorBox.Items.Add("🟡 Yellow");
            PensColorBox.Items.Add("🟢 Green");

            PensColorBox.SelectedIndex = 0;

            pen = new Pen(Color.Black, 2);
        }

        private bool isDrawing = false;
        private Point previousPoint;
        private Bitmap drawingBitmap;
        private Pen pen;

        private void pensSize_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)pensSize.Value;
            pen = new Pen(Color.Black, i);
        }

        private void PensColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PensColorBox.SelectedIndex == 0)
            {
                pen = new Pen(Color.Black, 2);
            }
            string pensColor = PensColorBox.SelectedItem.ToString();
            switch (pensColor)
            {
                case "⚪ White":
                    pen.Color = Color.White;
                    break;
                case "🔴 Red":
                    pen.Color = Color.Red;
                    break;
                case "🔵 Blue":
                    pen.Color = Color.Blue;
                    break;
                case "🟡 Yellow":
                    pen.Color = Color.Yellow;
                    break;
                case "🟢 Green":
                    pen.Color = Color.Green;
                    break;
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                try
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawImage(drawingBitmap, Point.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Drawing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(pen, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
                PictureBox.Invalidate();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = ((PictureBox)sender).PointToClient(Cursor.Position);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var nL = Environment.NewLine;
            DialogResult Message = MessageBox.Show("パレットをクリアします。" + nL + "" + nL + "May I clear the palette?", "Cursor Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (Message == DialogResult.Yes)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.Clear(Color.White);
                }
                PictureBox.Image = drawingBitmap;
            }
            else
            {
                //null
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                using (var sfd = new SaveFileDialog() { Filter = "BitMap形式(*.bmp) | *.bmp; | PNG形式(*.png) | *.png; | JPEG形式(*.jpg *.jpeg) | *.jpg; *.jpeg;" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string FileName = sfd.FileName;

                            switch (Path.GetExtension(FileName).ToLower())
                            {
                                case ".bmp":
                                    PictureBox.Image.Save(FileName, ImageFormat.Bmp);
                                    break;

                                case ".png":
                                    PictureBox.Image.Save(FileName, ImageFormat.Png);
                                    break;

                                case ".jpg":
                                case ".jpeg":
                                    PictureBox.Image.Save(FileName, ImageFormat.Jpeg);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
