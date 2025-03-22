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
    public partial class SearchCustomersFrm : Form
    {
        public SearchCustomersFrm()
        {
            InitializeComponent();
        }

        private void SearchCustomersFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("customers_selectall", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
                comboBox2.SelectedIndex = 0;
                textBox5.Select();
            }
            catch { }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // لكتابة كلمة عرض تحت عمود التفاصيل
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عرض";

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "برجاء تحديد اختيار للبحث من القائمة");
                return;
            }

         
            string sql = "";
            if (textBox5.TextLength == 0)
            {
                sql = "select * from customers where DeleteFlag = 0  order by custcode and companyname = '" + Login .CompanySelected + "'";
            }

            if (comboBox2.SelectedIndex == 0)
            {
                sql = "select * from Customers where CustCode like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by CustCode ";
            }

            if (comboBox2.SelectedIndex == 1)
            {
                sql = "select * from Customers where CustName like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0  and companyname = '" + Login .CompanySelected + "' order by CustName ";
            }

            if (comboBox2.SelectedIndex == 2)
            {
                sql = "select * from Customers where CustMob like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by CustMob ";
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox2, "");
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomersFrm frm = new CustomersFrm();
            frm.Find_Customer(int.Parse ( dataGridView1.CurrentRow.Cells["CustCode"].Value.ToString()));
            Close();
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
    }
}
