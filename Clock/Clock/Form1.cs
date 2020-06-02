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
        private Point Center; //중심점
        private double radius;//반지름
        private int hourHand; //시침
        private int minHand;  //분침
        private int secHand;  //초침


        public Form1()
        {
            InitializeComponent();

            this.Text = "안녕";

            g = panel1.CreateGraphics();   //그래프 세팅

            TimerSetting();   //타이머 세팅

        }

        private void TimerSetting()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;   //현재시간 받아오기
            Font font = new Font("맑은고딕", 12, FontStyle.Bold);

            Brush brush = Brushes.SkyBlue;
            panel1.Refresh();

            if(aClock_Flag == false)
            {
                string date = DateTime.Now.ToString();
                g.DrawString(date, font, brush, new Point(2, 50));
            } else
            {
                DrawClockFace();
            }

        }

        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightBlue, 30);

            g.DrawEllipse(pen, Center.X - 85, Center.Y - 85, 170, 170);   //시계판 그리기



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = aClock_Flag == false;
        }
    }
}
