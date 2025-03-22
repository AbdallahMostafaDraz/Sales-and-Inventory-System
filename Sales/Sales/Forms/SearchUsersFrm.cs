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
    public partial class SearchUsersFrm : Form
    {
        public SearchUsersFrm()
        {
            InitializeComponent();
        }

        private void SearchUsersFrm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("users_selectall");
                dataGridView1.DataSource = dt.DefaultView;
                comboBox2.SelectedIndex = 0;
                textBox5.Select();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox2, "");
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // للبحث والفرز بأول الكلام

            if (comboBox2 .Text == "")
            {
                errorProvider1.SetError(comboBox2, "برجاء تحديد اختيار للبحث من القائمة");
                return;
            }

            string sql = "";
            if (textBox5.TextLength == 0)
            {
                sql = "select name , username from users where DeleteFlag = 0  order by name";
            }

            if (comboBox2.SelectedIndex == 0)
            {
                sql = "select name , username from users where Name like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0  order by Name ";
            }

            if (comboBox2.SelectedIndex == 1)
            {
                sql = "select name , username from users where UserName like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0 order by UserName ";
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NewUserFrm frm = new NewUserFrm();
            frm.find_user(dataGridView1 .CurrentRow .Cells [2].Value .ToString ());
         
            Close();
         
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // لكتابة كلمة عرض تحت عمود التفاصيل
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عرض"; 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }
    }
}
