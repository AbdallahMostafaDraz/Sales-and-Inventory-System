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
    public partial class MainItems : Form
    {
        public MainItems()
        {
            InitializeComponent();
        }

        //==============================================================================
        //==============================================================================
        //==============================================================================
        //لعرض البيانات في شاشة الأصناف المركبة بعد البحث عن الطقم في شاشة البحث
        public int ItemID;
        public void Find_Tmk(Int64 tkmcodesearch)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("mainitems1_selectbycode",
                new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, tkmcodesearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["MainItems"] as MainItems;
            y.ItemID =int.Parse(dt.Rows[0]["itemID"].ToString());
            y.comboBox1.Text = dt.Rows[0]["ItemCategory"].ToString();
            y.MainCodeTXT.Text = dt.Rows[0]["Itemcode"].ToString();
            y.MainNameTXT.Text = dt.Rows[0]["itemname"].ToString();
            y.CompanyTXT.Text = dt.Rows[0]["itemcompany"].ToString();
            y.PriceTXT.Text = dt.Rows[0]["itemprice"].ToString();
            y.PriceInputTXT.Text = dt.Rows[0]["itempriceinput"].ToString();



            //
            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور
            DataTable dt2 = new DataTable();
            dt2 = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, tkmcodesearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
       
            y.dataGridView1.Rows.Clear();
            y.dataGridView1.Rows.Add(dt2.Rows.Count);
            for (int i = 0; i < dt2 .Rows .Count ; i++)
            {
                y.dataGridView1.Rows[i].Cells[0].Value = dt2.Rows[i]["ItemCode"].ToString();
                y.dataGridView1.Rows[i].Cells[1].Value = dt2.Rows[i]["ItemName"].ToString();
                
            }      

            Login.MainItemsSearch2 = true ;
        }
        //======================================================================
        //======================================================================
        //======================================================================




        //=========================================================================================
        // لوضع بيانات الصنف الفرعي في الداتا جريد بعد اختيارها من شاشة البحث عن الأصناف
        public bool _err; // عشان لو الصنف اضاف بالفعل شاشة الاصناف ماتقفلش بعد الرسالة 
 
        public void find_item_mainitem(Int64 itemcodesearch)
        {
            var y = Application.OpenForms["MainItems"] as MainItems;

            for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
            {
                if (Int64.Parse(y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == itemcodesearch)
                {
                    MessageBox.Show("تم اختيار هذا الصنف بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _err = true;

                    return;
                }
            }

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("items_selectbycode",
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, itemcodesearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


            DataGridViewRow drow = new DataGridViewRow();

            DataGridViewTextBoxCell dcell0 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell1 = new DataGridViewTextBoxCell();
    
            drow.Cells.Add(dcell0);
            drow.Cells.Add(dcell1);
       

            drow.Cells[0].Value = dt.Rows[0]["ItemCode"].ToString();
            drow.Cells[1].Value = dt.Rows[0]["ItemName"].ToString();
          

            y.dataGridView1.Rows.Add(drow);

            Login.MainItemsSearch = false;
           
        }


        private void MainItems_Load(object sender, EventArgs e)
        {
            try
            {
                Login.MainItemsSearch2 = false;
                comboBox1.SelectedIndex = 0;
                comboBox1.Select();
            }
            catch { }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = "حــذف";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.MainItemsSearch = true;
            SearchItemsFrm frm = new SearchItemsFrm();
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // لحذف السجل المحدد من الدات جريد بعد الضغط على حذف اللي الاندكس بتاعه 2
            if (e.ColumnIndex == 2)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
         
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Validation.TextClearOnly(this, panel1);
  
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            MainCodeTXT.Focus();
            Login.MainItemsSearch2 = false;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
          
            if (Login.MainItemsSearch2 == true)
            {
                if (MessageBox.Show("هذا الطقم موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل طقم اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewBTN_Click(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }
            //==========================================================

            errorProvider1.SetError(MainCodeTXT, "");
            errorProvider1.SetError(MainNameTXT, "");
            errorProvider1.SetError(CompanyTXT, "");
            errorProvider1.SetError(PriceTXT, "");
            //===========================================================

         
            if (comboBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(comboBox1, "برجاء اختيار نوع الطقم من القائمة");
                return;
            }

            if (MainCodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(MainCodeTXT, "يجب تسجيل كود الصنف");
                return;
            }

            if (MainNameTXT .Text .Trim ()== "")
            {
                errorProvider1.SetError(MainNameTXT , "يجب تسجيل اسم الصنف");
                return;
            }

            if (CompanyTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CompanyTXT, "يجب تسجيل اسم الشركة");
                return;
            }

            if (PriceTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PriceTXT, "يجب تسجيل سعر البيع");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف التي يتكون منها الطقم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddBTN.Focus();
                return;
            }
            //==============================================================================


          

            DataTable dt = Fillmainitemsdatatable();
            DBConnected db = new DBConnected();
            db.cmd.Connection = DBConnected.sqlcon;
            db.cmd.CommandType = CommandType.StoredProcedure;
            db.cmd.CommandText = "mainitems_insert";

            db.cmd.Parameters.AddWithValue("@itemcategory", comboBox1.Text.Trim());
            db.cmd.Parameters.AddWithValue("@tkmcode", Int64.Parse(MainCodeTXT.Text));
            db.cmd.Parameters.AddWithValue("@tkmname", MainNameTXT.Text);
            db.cmd.Parameters.AddWithValue("@itemcompany", CompanyTXT.Text);
            db.cmd.Parameters.AddWithValue("@itemprice", decimal.Parse(PriceTXT.Text));
            db.cmd.Parameters.AddWithValue("@username", Login.UserName);
            db.cmd.Parameters.AddWithValue("@itempriceinput", decimal.Parse(PriceInputTXT.Text));
            db.cmd.Parameters.AddWithValue("@mainitemsdatatable", dt);
            db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

            int r = db.cmd.ExecuteNonQuery();
            if (r > 0)
            {
                
                NewBTN_Click(null, null);
            }
            else
            {
                MessageBox.Show(" تم تسجيل صنف اخر مسبقا بنفس الكود . برجاء التأكد من الكود واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }

        }


        //========================================================================
        // هعمل داتا تابل بالاسم الموجود في البروسدجر واملاها من الداتا جريد
        DataTable Fillmainitemsdatatable()
        {

            DataTable dt = new DataTable();
            DataRow dr;
           
            if (dataGridView1.Rows.Count != 0)
            {
                dt.Columns.Add("ItemCode", typeof(Int64));
                dt.Columns.Add("ItemName", typeof(string));


                for (int i = 0; i < dataGridView1.Rows.Count  ; i++)
                {
                    dr = dt.NewRow();
                    dr["ItemCode"] = Int64.Parse(dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString());
                    dr["ItemName"] = dataGridView1.Rows[i].Cells["ItemName"].Value.ToString();
                    dt.Rows.Add(dr);

                }
                return dt;
            }

            else
            {
                return null;
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            SearchMainItems frm = new SearchMainItems();
            frm.ShowDialog();
        }

        private void MainCodeTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(MainCodeTXT, "");
        }

        private void EdietBTN_Click(object sender, EventArgs e)
        {
            if (Login.MainItemsSearch2 == false)
            {
                MessageBox.Show("اختر الصنف الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            //==========================================================

            errorProvider1.SetError(MainCodeTXT, "");
            errorProvider1.SetError(MainNameTXT, "");
            errorProvider1.SetError(CompanyTXT, "");
            errorProvider1.SetError(PriceTXT, "");
            //===========================================================


            if (comboBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(comboBox1, "برجاء اختيار نوع الطقم من القائمة");
                return;
            }

            if (MainCodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(MainCodeTXT, "يجب تسجيل كود الصنف");
                return;
            }

            if (MainNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(MainNameTXT, "يجب تسجيل اسم الصنف");
                return;
            }

            if (CompanyTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CompanyTXT, "يجب تسجيل اسم الشركة");
                return;
            }

            if (PriceInputTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(PriceInputTXT, "يجب تسجيل سعر الشراء");
                return;
            }

            if (PriceTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PriceTXT, "يجب تسجيل سعر البيع");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف التي يتكون منها الطقم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddBTN.Focus();
                return;
            }
            //==============================================================================


            //==============================================================================
            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا الصنف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = Fillmainitemsdatatable();
                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;
                db.cmd.CommandType = CommandType.StoredProcedure;
                db.cmd.CommandText = "mainitems_update";

                db.cmd.Parameters.AddWithValue("@tkmid", ItemID);
                db.cmd.Parameters.AddWithValue("@itemcategory", comboBox1.Text.Trim());
                db.cmd.Parameters.AddWithValue("@tkmcode", Int64.Parse(MainCodeTXT.Text));
                db.cmd.Parameters.AddWithValue("@tkmname", MainNameTXT.Text);
                db.cmd.Parameters.AddWithValue("@itemcompany", CompanyTXT.Text);
                db.cmd.Parameters.AddWithValue("@itemprice", decimal.Parse(PriceTXT.Text));
                db.cmd.Parameters.AddWithValue("@username", Login.UserName);
                db.cmd.Parameters.AddWithValue("@itempriceinput", decimal.Parse(PriceInputTXT.Text));
                db.cmd.Parameters.AddWithValue("@mainitemsdatatable", dt);
                db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                int r = db.cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("تم تعديل" + " " + MainNameTXT.Text + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                    MainCodeTXT.Focus();
                    Login.MainItemsSearch2 = false;
                }
                else
                {
                    MessageBox.Show("لا يمكنك تعديل كود هذا الصنف للكود الذي أدخلته . حيث يوجد صنف اخر مسجل بنفس الكود", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (Login.MainItemsSearch2 == false)
            {
                MessageBox.Show("اختر الصنف الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد حذف بيانات هذا الصنف ؟","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery ("mainitems_delete",
                    new RetriveData.prameter("@tkmid", SqlDbType.Int, ItemID),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم حذف بيانات الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                    MainCodeTXT.Focus();
                    Login.MainItemsSearch2 = false;
                }
                else
                {
                    MessageBox.Show("فشل حذف الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void MainItems_Leave(object sender, EventArgs e)
        {
  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
        }

        private void MainNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(MainNameTXT, "");
        }

        private void CompanyTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CompanyTXT, "");
        }

        private void PriceTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(PriceTXT, "");
        }

        private void MainCodeTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void PriceInputTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(PriceInputTXT, e);
        }

        private void PriceTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(PriceTXT, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainCodeTXT.Select();
            }
        }

        private void MainCodeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                MainNameTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                PriceInputTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                comboBox1.Select();
            }
        }

        private void MainNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                PriceInputTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                MainCodeTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                PriceTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                comboBox1.Select();
            }
            
        }

        private void PriceInputTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left )
            {
                PriceTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                MainNameTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                CompanyTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                MainCodeTXT.Select();
            }
        }

        private void PriceTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                CompanyTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                PriceInputTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                MainNameTXT.Select();
            }
        }

        private void CompanyTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                AddBTN.Select();
            }
            
            else if (e.KeyCode == Keys.Up)
            {
                PriceTXT.Select();
            }
        }
        //==========================================================================
    }
}
