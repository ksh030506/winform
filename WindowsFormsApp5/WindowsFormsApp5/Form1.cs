using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn column1 = new DataColumn();
            column1.ColumnName = "숫자타입";
            column1.DataType = typeof(int);

            DataColumn column2 = new DataColumn();
            column2.ColumnName = "이름";
            column2.DataType = typeof(string);

            DataTable dt = new DataTable();
            dt.Columns.Add(column1);
            dt.Columns.Add(column2);
            dt.Rows.Add(1, "이름1");
            dt.Rows.Add(2, "이름2");
            dt.Rows.Add(3, "이름3");

            dataGridView1.DataSource = dt;
        }
    }
}
