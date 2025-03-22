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
    public partial class SearchItemsFrm : Form
    {
        public SearchItemsFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //عشان لو فاتح الشاشة دي من شاشة الأصناف المركبة ينفذ اول اف ولو فاتحها من شاشة الاصناف العادية ينفذ التانية
            if (Login.MainItemsSearch == true)
            {
           
                MainItems frm = new MainItems();
                frm.find_item_mainitem(Int64.Parse(dataGridView1.CurrentRow.Cells["ItemCode"].Value.ToString()));
                if (frm._err != true)
                {
                    Close();

                }
                else
                {
                    Login.MainItemsSearch = true;
                }
                return;
             }

            else if (Login.Items_Visable  == true)
            {
                ItemsFrm frm = new ItemsFrm();
                frm.Find_Item(Int64 .Parse  (dataGridView1.CurrentRow.Cells["ItemCode"].Value.ToString()));
                Close();

               
            }

            else if (Login.EznEstlamSearch == true)
            {
                EznEstlamFrm frm = new EznEstlamFrm();
                frm.Find_Item_EznEstlam(Int64.Parse(dataGridView1.CurrentRow.Cells["ItemCode"].Value.ToString()));
                if (frm._err != true)
                {
                    Close();
                }
                else
                {
                    Login.EznEstlamSearch = true;
                }
                return;
            }
            else if (Login .BillSearch == true )
            {
                BillFrm frm = new BillFrm();
                frm.Find_Item_Bill(Int64.Parse(dataGridView1.CurrentRow.Cells["ItemCode"].Value.ToString()));
                if (frm._err != true)
                {
                    Close();
                }
                else
                {
                    Login.BillSearch = true;
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "عـرض";
            }
        }
        

        private void SearchItemsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.SelectedIndex = 0;
                textBox5.Select();

                if (Login.Items_Visable == true)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = RetriveData.ExecuteQuery("items_selectall", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;

                }
                else
                {

                    //===================================================
                    //لملئ الداتا جريد من جدولين الأصناف والأطقم
                    DBConnected db = new DBConnected();
                    db.cmd.Connection = DBConnected.sqlcon;
                    db.cmd.CommandType = CommandType.StoredProcedure;
                    db.cmd.CommandText = "Items_SelectAll";
                    db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                    DBConnected db2 = new DBConnected();
                    db2.cmd.Connection = DBConnected.sqlcon;
                    db2.cmd.CommandType = CommandType.StoredProcedure;
                    db2.cmd.CommandText = "MainItems_SelectAll";
                    db2.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);


                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(db.cmd);
                    SqlDataAdapter adp2 = new SqlDataAdapter(db2.cmd);


                    adp.Fill(ds);
                    adp2.Fill(ds);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    //================================================= 

                }
            }
            catch { }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox2, "");
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "برجاء تحديد اختيار للبحث من القائمة");
                return;
            }

            if (Login.Items_Visable  == true)
            {
                string sql = "";
                if (textBox5.TextLength == 0)
                {
                    sql = "select * from items where DeleteFlag = 0 and companyname  = '" + Login .CompanySelected + "' order by itemcode";
                }

                if (comboBox2.SelectedIndex == 0)
                {
                    sql = "select * from items where ItemCode like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemCode ";
                }

                if (comboBox2.SelectedIndex == 1)
                {
                    sql = "select * from Items where ItemName like  N'" + textBox5.Text + "%" + "'" + " and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemName ";
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
            else
            {
                //===================================================
                //لملئ الداتا جريد من جدولين الأصناف والأطقم
                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;



                DBConnected db2 = new DBConnected();
                db2.cmd.Connection = DBConnected.sqlcon;

                if (textBox5.TextLength == 0)
                {
                    db.cmd.CommandType = CommandType.StoredProcedure;
                    db.cmd.CommandText = "Items_SelectAll";
                    db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                    db2.cmd.CommandType = CommandType.StoredProcedure;
                    db2.cmd.CommandText = "MainItems_SelectAll";
                    db2.cmd.Parameters.AddWithValue("@Companyname", Login.CompanySelected);

                }

                if (comboBox2.SelectedIndex == 0)
                {
                    db.cmd.CommandType = CommandType.Text;
                    db.cmd.CommandText = "select * from items where ItemCode like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemCode";

                    db2.cmd.CommandType = CommandType.Text;
                    db2.cmd.CommandText = "select * from MainItems1 where ItemCode like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemCode";
                }

                if (comboBox2.SelectedIndex == 1)
                {
                    db.cmd.CommandType = CommandType.Text;
                    db.cmd.CommandText = "select * from items where ItemName like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemName";

                    db2.cmd.CommandType = CommandType.Text;
                    db2.cmd.CommandText = "select * from MainItems1 where ItemName like  N'" + textBox5.Text + "%" + "'" + "  and DeleteFlag = 0 and companyname = '" + Login .CompanySelected + "' order by ItemName";
                }

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(db.cmd);
                SqlDataAdapter adp2 = new SqlDataAdapter(db2.cmd);


                adp.Fill(ds);
                adp2.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //================================================= 
            }
       }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Validation.NumbersOnly(e);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
