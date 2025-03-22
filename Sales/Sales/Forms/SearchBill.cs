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
using Sales.Forms;
namespace Sales01.Forms
{
    public partial class SearchBill : Form
    {
        public SearchBill()
        {
            InitializeComponent();
        }

        private void SearchBill_Load(object sender, EventArgs e)
        {

            //لو فاتح شاشة البحث من شاشة الفواتير الكبيرة هيجيب كل الفواتير ماعدا بتاعت زبون عام والعكس صحيح
            if (Login.billfrm == true)
            {
                try
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = RetriveData.ExecuteQuery("Bills_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
                    comboBox2.SelectedIndex = 0;
                    textBox5.Select();
                }
                catch { }
            }
            else if (Login.fastbillfrm2 == true)
            {
                try
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = RetriveData.ExecuteQuery("FastBills_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
                    comboBox2.SelectedIndex = 0;
                    textBox5.Select();
                }
                catch { }

            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox2, "");
            textBox5.Text = "";
            textBox5.Select ();
            dataGridView1.AutoGenerateColumns = false;
            if (Login.billfrm == true)
            {
                dataGridView1.DataSource = RetriveData.ExecuteQuery("Bills_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
            }
            else if (Login.fastbillfrm2 == true)
            {
                dataGridView1.DataSource = RetriveData.ExecuteQuery("FastBills_SelectAll", new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)).DefaultView;
            }
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

            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "برجاء تحديد اختيار للبحث من القائمة");

                return;
            }



            if (panel3.Visible == true && textBox5 .Text != "")
            {
                textBox5.Text = "";
                MessageBox.Show(" قم بتحديد تاريخ الفاتورة الذي تريد البحث عنها من الخانة المخصصة للتاريخ ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                D1.Focus();
                return;
            }



            string sql = "";
            if (textBox5.TextLength == 0)
            {
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills order by BillNo where CustName != 'زبون عام' and companyname = " + Login.CompanySelected + "";
                }
                else if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills order by BillNo where CustName = 'زبون عام' and companyname = " + Login.CompanySelected + "";
                }
           }

            if (comboBox2.SelectedIndex == 0)
            {
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills where BillNo like  N'" + textBox5.Text + "%" + "'" + " and CustName != 'زبون عام' and companyname = '" + Login.CompanySelected + "'  order by BillNo ";
                }
                else if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills where BillNo like  N'" + textBox5.Text + "%" + "'" + " and CustName = 'زبون عام' and companyname = '" + Login.CompanySelected + "'  order by BillNo ";
                }
          
           }


            if (comboBox2.SelectedIndex == 2)
            {
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills where CustName like  N'" + textBox5.Text + "%" + "'" + " and CustName != 'زبون عام' and companyname = '" + Login.CompanySelected + "' order by CustName ";
                }
                if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills where CustName like  N'" + textBox5.Text + "%" + "'" + " and CustName = 'زبون عام' and companyname = '" + Login.CompanySelected + "' order by CustName ";
                }

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
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills  order by Billdate where CustName != 'زبون عام' and companyname = " + Login.CompanySelected + "";
                }
                else if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills  order by Billdate where CustName = 'زبون عام' and companyname = " + Login.CompanySelected + "";
                }
            }
            else if (D1.Value.Date == D2.Value.Date)
            {
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills where BillDate = '" + D1.Value.ToString("yyyy-MM-dd") + "' and CustName != 'زبون عام' and companyname = '" + Login.CompanySelected + "'";
                }
                else if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills where BillDate = '" + D1.Value.ToString("yyyy-MM-dd") + "' and CustName = 'زبون عام' and companyname = '" + Login.CompanySelected + "'";
                }
            }
            else
            {
                if (Login.billfrm == true)
                {
                    sql = "select * from MainBills where BillDate >= '" + D1.Value.ToString("yyyy-MM-dd") + "' and BillDate <= '" + D2.Value.ToString("yyyy-MM-dd") + "' and CustName != 'زبون عام' and companyname = '" + Login.CompanySelected + "'";
                }
                else if (Login.fastbillfrm2 == true)
                {
                    sql = "select * from MainBills where BillDate >= '" + D1.Value.ToString("yyyy-MM-dd") + "' and BillDate <= '" + D2.Value.ToString("yyyy-MM-dd") + "' and CustName = 'زبون عام' and companyname = '" + Login.CompanySelected + "'";
                }
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
            if (e.ColumnIndex == 0 && Login.billfrm == true)
            {
                BillFrm frm = new BillFrm();
                frm.Find_Bill (int.Parse(dataGridView1.CurrentRow.Cells["BillNo"].Value.ToString()));
                Close();
            }
            else if (e.ColumnIndex == 0 && Login.fastbillfrm2 == true)
            {
                FastBill frm = new FastBill();
                frm.Find_Bill(int.Parse(dataGridView1.CurrentRow.Cells["BillNo"].Value.ToString()));
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
