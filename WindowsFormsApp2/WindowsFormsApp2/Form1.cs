﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                textBox3.Text = "숫자를 입력해주세요";
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);


                double result = a + b;

                label4.Text = "+";
                textBox3.Text = a.ToString() + " + " + b.ToString() + "의 값은 " + result.ToString() + " 입니다.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                textBox3.Text = "숫자를 입력해주세요";
            }

            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                double result = a - b;

                label4.Text = "-";
                textBox3.Text = a.ToString() + " - " + b.ToString() + "의 값은 " + result.ToString() + " 입니다.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                textBox3.Text = "숫자를 입력해주세요";
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);


                double result = a / b;


                label4.Text = "/";
                textBox3.Text = a.ToString() + " / " + b.ToString() + "의 값은 " + result.ToString() + " 입니다.";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                textBox3.Text = "숫자를 입력해주세요";
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                double result = a * b;

                label4.Text = "*";
                textBox3.Text = a.ToString() + " * " + b.ToString() + "의 값은 " + result.ToString() + " 입니다.";
            }
        }
    }
}
