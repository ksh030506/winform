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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
