using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = "김상현";

            MessageBox.Show(a);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("안녕");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();


            form2.Show();
            form2.MdiParent = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
