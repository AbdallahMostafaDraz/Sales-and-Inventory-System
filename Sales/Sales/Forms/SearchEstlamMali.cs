using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sales.Classes;

namespace Sales01.Forms
{
    public partial class SearchEstlamMali : Form
    {
        public SearchEstlamMali()
        {
            InitializeComponent();
        }

        private void SearchEstlamMali_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.SelectedIndex = 0;
                textBox5.Select();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("EstlamMali_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
            }
            catch { }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عـرض";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Select();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = RetriveData.ExecuteQuery("Df3Mali_selectall", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
            if (comboBox2.SelectedIndex == 1)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (panel3.Visible == true && textBox5.Text != "")
            {
                textBox5.Text = "";
                MessageBox.Show(" قم بتحديد تاريخ الفاتورة الذي تريد البحث عنها من الخانة المخصصة للتاريخ ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                D1.Focus();
                return;
            }



            string sql = "";
            if (textBox5.TextLength == 0)
            {
                sql = "select * from EznEstlamMali order by EznNo where companyname = "+ Login .CompanySelected + "";
            }

            if (comboBox2.SelectedIndex == 0)
            {
                sql = "select * from EznEstlamMali where EznNo like  N'" + textBox5.Text + "%" + "'" + " where companyname = '" + Login.CompanySelected + "' order by EznNo ";
            }


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = RetriveData.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (D1.Value.Date > D2.Value.Date)
            {
                MessageBox.Show("برجاء تحديد تاريخ بداية البحث أكبر من تاريخ نهاية البحث", "بــحــث", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sql = "select * from EznEstlamMali  order by EznDate where companyname = " + Login.CompanySelected + "";

            }
            else if (D1.Value.Date == D2.Value.Date)
            {
                sql = "select * from EznEstlamMali where EznDate = '" + D1.Value.ToString("yyyy-MM-dd") + "' where companyname = '" + Login .CompanySelected + "'";
            }
            else
            {
                sql = "select * from EznEstlamMali where EznDate >= '" + D1.Value.ToString("yyyy-MM-dd") + "' and EznDate <= '" + D2.Value.ToString("yyyy-MM-dd") + "' where companyname = '" + Login .CompanySelected + "'";
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = RetriveData.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                EstlamMaliFrm  frm = new EstlamMaliFrm ();
                frm.Ezn_Find(int.Parse(dataGridView1.CurrentRow.Cells["EznNo"].Value.ToString()));
                Close();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Validation.NumbersOnly(e);
            }
        }
    }
}
