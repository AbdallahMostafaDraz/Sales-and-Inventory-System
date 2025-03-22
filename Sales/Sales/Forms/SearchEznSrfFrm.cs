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
    public partial class SearchEznSrfFrm : Form
    {
        public SearchEznSrfFrm()
        {
            InitializeComponent();
        }

        private void SearchEznSrfFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("EznSrf_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
                comboBox2.SelectedIndex = 0;
                textBox5.Select();
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            errorProvider1.SetError(comboBox2, "");
            textBox5.Text = "";
            textBox5.Focus();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = RetriveData.ExecuteQuery("EznSrf_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
            if (comboBox2.SelectedIndex == 1)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "برجاء تحديد اختيار للبحث من القائمة");

                return;
            }



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
                sql = "select * from MainEznSrf where companyname = '" + Login.CompanySelected + "' order by EznNo ";
            }

            if (comboBox2.SelectedIndex == 0)
            {
                sql = "select * from MainEznSrf where EznNo like  N'" + textBox5.Text + "%" + "'" + " and companyname = '" + Login .CompanySelected + "' order by EznNo ";
            }


            if (comboBox2.SelectedIndex == 2)
            {
                sql = "select * from MainEznSrf where BillNo like  N'" + textBox5.Text + "%" + "'" + " and companyname  = '" + Login .CompanySelected + "'  order by BillNo ";
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
                MessageBox.Show("برجاء تحديد تاريخ بداية البحث أكبر من تاريخ نهاية البحث", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sql = "select * from MainEznSrf  order by ezndate";

            }
            else if (D1.Value.Date == D2.Value.Date)
            {
                sql = "select * from MainEznSrf where EznDate = '" + D1.Value.ToString("yyyy-MM-dd") + "' and companyname = '" + Login .CompanySelected + "'";
            }
            else
            {
                sql = "select * from MainEznSrf where EznDate >= '" + D1.Value.ToString("yyyy-MM-dd") + "' and EznDate <= '" + D2.Value.ToString("yyyy-MM-dd") + "' and companyname = '" + Login .CompanySelected + "'";
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عرض";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                EznSrfFrm  frm = new EznSrfFrm ();
                frm.Ezn_Find  (int.Parse(dataGridView1.CurrentRow.Cells["EznNo"].Value.ToString()));
                Close();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                return;
            }
            else
            {
                Validation.NumbersOnly(e);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
