using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();    //반의 정보를 가지고 있을 DataSet

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bCheckIsTable = false;

            //DataSet안에 해당하는 DataTable이 있는지 확인 한다
            if(ds.Tables.Contains(comboBox1.Text))
            {
                bCheckIsTable = true;
            }

            DataTable dt = null;

            if(!bCheckIsTable)    //기존 table이 없을 경우 신규로 생성
            {
                dt = new DataTable(comboBox1.Text);

                //DataColumn생성
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));


                //생성된 Column을 DataTable에 Add
                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else    //기존 Table이 있을 경우 기존 Table을 가져온다
            {
                dt = ds.Tables[comboBox1.Text];
            }

            //Rou생성
            DataRow row = dt.NewRow();
            row["NAME"] = textBox1.Text;

            if (radioButton2.Checked)
            {
                row["SEX"] = "여자";
            }
            else if (radioButton1.Checked)
            {
                row["SEX"] = "남자";
            }

            row["REF"] = textBox2.Text;


            //생성된 Row를 DataTable에 Add
            if(bCheckIsTable)
            {
                ds.Tables[comboBox1.Text].Rows.Add(row);    //DataSet에 해당 Datatable넣기
            }
            else
            {
                dt.Rows.Add(row);    //신규로 작성한 DataTable에 Row를 등록함
                ds.Tables.Add(dt);   
            }

            comboBox2_SelectedIndexChanged(this, null);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox2.Text];

            //DatagridView Cell정렬 및 number를 적용
            foreach(DataGridViewRow oRow in dataGridView1.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dataGridView1.AutoResizeRowHeadersWidth
                (DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int iSelectRow = dataGridView1.SelectedRows[0].Index;
            ds.Tables[comboBox2.Text].Rows.RemoveAt(iSelectRow);

            comboBox2_SelectedIndexChanged(this, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
