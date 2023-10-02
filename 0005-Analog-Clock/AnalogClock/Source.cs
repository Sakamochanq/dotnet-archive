using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();

            #region TimerSettings

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(DrawClock);
            timer.Start();

            #endregion
        }

        private void DrawClock(object sender, EventArgs e)
        {
            AnalogClockBox.Invalidate();
        }

        private void DrawTick(Graphics g, int centerX, int centerY, int length, double angle, Pen pen)
        {
            double radians = angle * Math.PI / 180;
            int x = centerX + (int)(length * Math.Sin(radians));
            int y = centerY - (int)(length * Math.Cos(radians));
            g.DrawLine(pen, centerX, centerY, x, y);
        }

        private void AnalogClockBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = AnalogClockBox.Width / 2;
            int centerY = AnalogClockBox.Height / 2;

            //円
            int CircleRadius = 200;
            g.DrawEllipse(Pens.Black, centerX - CircleRadius, centerY - CircleRadius, CircleRadius * 2, CircleRadius * 2);

            DateTime dt = DateTime.Now;

            //時針
            int hour = dt.Hour % 12;
            double hourAngle = (hour + dt.Minute / 60.0) * 360.0 / 12.0;
            DrawTick(g, centerX, centerY, 130, hourAngle, Pens.Blue);

            //分針
            double minuteAngle = dt.Minute * 360.0 / 60.0;
            DrawTick(g, centerX, centerY, 160, minuteAngle, Pens.Red);

            //秒針
            double secondAngle = dt.Second * 360.0 / 60.0;
            DrawTick(g, centerX, centerY, 180, secondAngle, Pens.Green);

            //チック
            int tickMarkLength = 10;
            for (int i = 0; i < 12; i++)
            {
                double angle = i * 30.0;
                double radians = angle * Math.PI / 180;
                int x1 = centerX + (int)((CircleRadius - tickMarkLength) * Math.Sin(radians));
                int y1 = centerY - (int)((CircleRadius - tickMarkLength) * Math.Cos(radians));
                int x2 = centerX + (int)(CircleRadius * Math.Sin(radians));
                int y2 = centerY - (int)(CircleRadius * Math.Cos(radians));
                g.DrawLine(Pens.Black, x1, y1, x2, y2);
            }
        }
    }
}
