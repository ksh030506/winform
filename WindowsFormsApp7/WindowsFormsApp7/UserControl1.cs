using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class UserControl1 : UserControl
    {
        public static EventHandler myClic;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public string Lable1tex
        {
            get
            {
                return this.button2.Text;
            }
            set
            {
                this.button2.Text = value;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.제목_없음;

            EventHandler handler = myClic;
            if (handler != null)
            {
                handler(sender, e);            }
        }
    }
}
