using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {

        Graphics g;
        private bool aClock_Flag = false;
        private Point Center;//중심점
        private double radius;//반지름
        private int hourHand;//시침
        private int minHand;//분침
        private int secHand;//초짐


        public Form1()
        {
            InitializeComponent();
            this.Text = "안녕";

            g = panel1.CreateGraphics();

            TimerSetting();

        }

        private void TimerSetting()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            Font font = new Font("맑은고딕", 12, FontStyle.Bold);

            Brush brush = Brushes.SkyBlue;

            panel1.Refresh();

            if (aClock_Flag == false)
            {
                string date = DateTime.Now.ToString();
                g.DrawString(date, font, brush, new Point(2, 50));
            }
            else
            {
                DrawClockFace();
                aClockSetting();

                double radHr = (c.Hour % 12 + c.Minute / 60.0)
                    * 30 * Math.PI / 180;
                double radMin = (c.Minute + c.Second / 60.0)
                    * 6 * Math.PI / 180;
                double radSec = (c.Second)
                    * 6 * Math.PI / 180;
                DrawHands(radHr, radMin, radSec);

            }

        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine((int)(hourHand * Math.Sin(radHr)), (int)(-hourHand * Math.Cos(radHr)),
    0, 0, Brushes.RoyalBlue, 8, Center.X, Center.Y);
            // 분침
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(-minHand * Math.Cos(radMin)),
                0, 0, Brushes.SkyBlue, 6, Center.X, Center.Y);
            // 초침
            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(-secHand * Math.Cos(radSec)),
                0, 0, Brushes.OrangeRed, 3, Center.X, Center.Y);


            int coreSize = 16;
            Rectangle r = new Rectangle(Center.X - coreSize / 2,
               Center.Y - coreSize / 2, coreSize, coreSize);
            g.FillRectangle(Brushes.Gold, r);
            Pen P = new Pen(Brushes.DarkBlue, 3);
            g.DrawEllipse(P, r);




        }

        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int Cx, int Cy)
        {
            Pen pen = new Pen(color, thick);//색, 길이
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; //선그리기 둥근모양
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(pen, x1 + Cx, y1 + Cy, x2 + Cx, y2 + Cy);
        }

        private void aClockSetting()
        {
            Center = new Point(panel1.Width / 2, panel1.Height / 2);
            radius = panel1.Height / 2;

            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);
        }

        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightBlue, 30);

            g.DrawEllipse(pen, Center.X - 85, Center.Y - 85, 170, 170);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClock_Flag = true;
        }

        private void 디지털ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aClock_Flag = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
