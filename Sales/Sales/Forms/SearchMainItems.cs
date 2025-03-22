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
    public partial class SearchMainItems : Form
    {
        public SearchMainItems()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchMainItems_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("mainitems_selectall", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
                comboBox2.SelectedIndex = 0;
                textBox5.Select();
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MainItems frm = new MainItems();
                frm.Find_Tmk(Int64.Parse(dataGridView1.CurrentRow.Cells["ItemCode"].Value .ToString()));
                Close();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عـرض";
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
                sql = "select * from MainItems1 where DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by TkmCode";
            }

            if (comboBox2.SelectedIndex == 0)
            {
                sql = "select * from MainItems1 where TkmCode like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname  = '" + Login .CompanySelected + "' order by TkmCode ";
            }

            if (comboBox2.SelectedIndex == 1)
            {
                sql = "select * from MainItems1 where TkmName like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0  and companyname = '" + Login .CompanySelected + "' order by TkmName ";
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Validation.NumbersOnly(e);
            }
        }
    }
}
