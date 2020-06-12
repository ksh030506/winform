using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl1.myClic += new EventHandler(myFunc12);
        }

        private void myFunc12(object sender, EventArgs e)
        {
            MessageBox.Show("함수");
            
        }
    }
}
