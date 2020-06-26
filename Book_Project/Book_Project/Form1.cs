using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Project
{
    public partial class Form1 : Form
    {

        private SqlConnection sqlconn = null;
        private string constr = "SERVER=127.0.0.1,1433; DATABASE=mydb1;" +
            "UID = kim; PASSWORD=1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn = new SqlConnection(constr);
                sqlconn.Open();

                MessageBox.Show("연결 성공");
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlconn != null)
                {
                    sqlconn.Close();

                    MessageBox.Show("연결해제 성공");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            //using기능을 사용하여 알아서 닫는 기능을 해준다
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                //연결이 안되어 있어도 자동적으로 연결
                string sql = "SELECT * FROM BOOKS";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                adapter.Fill(ds, "BOOKS");
            }   //conn.Close를 자동으로 해준다.

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BOOKNO"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["BOOKNO"].Value.ToString();
        }
    }
}
