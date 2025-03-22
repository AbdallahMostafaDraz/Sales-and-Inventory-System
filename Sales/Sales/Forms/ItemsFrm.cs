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
    public partial class ItemsFrm : Form
    {
        public ItemsFrm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            if (Login.ItemsSearchState  == true)
            {
                if (MessageBox.Show("هذا الصنف موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل صنف اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button6_Click_1(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }

            //====================================================================
            errorProvider1.SetError(CodeTXT, "");
            errorProvider1.SetError(NameTXT, "");
            errorProvider1.SetError(ColorTXT, "");
            errorProvider1.SetError(SizeTXT, "");
            errorProvider1.SetError(FrzTXT, "");
            errorProvider1.SetError(MetreTXT, "");
            errorProvider1.SetError(PricreTXT, "");
            errorProvider1.SetError(CompanyTXT, "");


            //=====================================================================

            if (comboBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(comboBox1, "اختر نوع الصنف من القائمة");
                comboBox1.Select();
                return;
            }

            if (comboBox1.Text.Trim() != "سيراميك" && comboBox1.Text.Trim() != "صحي" && comboBox1.Text.Trim() != "خلاطات" && comboBox1.Text.Trim() != "لوازم" && comboBox1.Text.Trim() != "بانيو")
            {
                errorProvider1.SetError(comboBox1, "اختر نوع صنف صحيح من القائمة");
                comboBox1.Select();
                return;
            }

            if (CodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CodeTXT, "يجب تسجيل كود الصنف !");
                CodeTXT.Select();
                return;
            }

            if (NameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(NameTXT, "يجب تسجيل اسم الصنف !");
                NameTXT.Select();
                return;
            }

            if (comboBox1.Text.Trim() != "خلاطات" && comboBox1.Text.Trim() != "لوازم")
            {
                if (ColorTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(ColorTXT, "يجب تسجيل اللون لهذا النوع من الأصناف !");
                    ColorTXT.Select();
                    return ;
                }
                
            }


            if (comboBox1.Text.Trim() == "سيراميك")
            {
                if (SizeTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(SizeTXT, "يجب تسجيل المقاس لهذا النوع من الأصناف !");
                    SizeTXT.Select();
                    return;
                }

                if (FrzTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(FrzTXT, "يجب تسجيل الفرز !");
                    FrzTXT.Select();
                    return;
                }

                if (MetreTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(MetreTXT, "يجب تسجيل عدد الأمتار في الكرتونة !");
                    MetreTXT.Select();
                    return;
                }
              
            }

            if (PriceInputTXT .Text .Trim () == "")
            {
                errorProvider1.SetError(PriceInputTXT , "يجب تسجيل سعر الشراء !");
                PriceInputTXT.Select();
                return;
            }

            if (PricreTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PricreTXT, "يجب تسجيل سعر البيع !");
                PricreTXT.Select();
                return;
            }

            if (StrartQuantityTXT.Text.Trim() == "")
            {
                if (MessageBox.Show("لم يتم ادخال رصيد بداية المدة . هل تريد بالتأكيد عدم اضافة رصيد لهذا الصنف ؟", "تـسـجـيـل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    StrartQuantityTXT.Select ();
                    return;
                }
                else
                {
                    StrartQuantityTXT.Text = "0";
                }
            }

            if (CompanyTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CompanyTXT, "يجب تسجيل اسم الشركة !");
                CompanyTXT.Select();
                return;
            }
            //============================================================
            if (comboBox1.Text.Trim() == "سيراميك")
            {
                RetriveData.ExecuteNonQuery("items_insert",
                    new RetriveData.prameter("@itemcategory", SqlDbType.NVarChar, comboBox1.Text.Trim()),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt   ,Int64 .Parse   ( CodeTXT.Text)),
                    new RetriveData.prameter("@itemname", SqlDbType.NVarChar, NameTXT.Text),
                    new RetriveData.prameter("@itemcolor", SqlDbType.NVarChar, ColorTXT.Text),
                    new RetriveData.prameter("@itemsize", SqlDbType.NVarChar, SizeTXT.Text),
                    new RetriveData.prameter("@itemfrz", SqlDbType.NVarChar, FrzTXT.Text),
                    new RetriveData.prameter("@itemmeter", SqlDbType.Decimal, decimal.Parse(MetreTXT.Text)),
                    new RetriveData.prameter("@itemcompany", SqlDbType.NVarChar, CompanyTXT.Text),
                    new RetriveData.prameter("@itemprice", SqlDbType.Decimal, decimal.Parse(PricreTXT.Text)),
                    new RetriveData.prameter("@itemnotes", SqlDbType.NVarChar, NotesTXT.Text),
                    new RetriveData.prameter("@QuantityStart", SqlDbType.Decimal, decimal.Parse(StrartQuantityTXT.Text)),
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@itempriceinput", SqlDbType.Decimal, decimal.Parse(PriceInputTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            }
            else
            {
                RetriveData.ExecuteNonQuery("items_insert",
                       new RetriveData.prameter("@itemcategory", SqlDbType.NVarChar, comboBox1.Text.Trim()),
                       new RetriveData.prameter("@itemcode", SqlDbType.BigInt  , Int64 .Parse   ( CodeTXT.Text)),
                       new RetriveData.prameter("@itemname", SqlDbType.NVarChar, NameTXT.Text),
                       new RetriveData.prameter("@itemcolor", SqlDbType.NVarChar, ColorTXT.Text),
                       new RetriveData.prameter("@itemsize", SqlDbType.NVarChar, SizeTXT.Text),
                       new RetriveData.prameter("@itemfrz", SqlDbType.NVarChar, FrzTXT.Text),
                       new RetriveData.prameter("@itemmeter", SqlDbType.Decimal, 1),
                       new RetriveData.prameter("@itemcompany", SqlDbType.NVarChar, CompanyTXT.Text),
                       new RetriveData.prameter("@itemprice", SqlDbType.Decimal, decimal.Parse(PricreTXT.Text)),
                       new RetriveData.prameter("@itemnotes", SqlDbType.NVarChar, NotesTXT.Text),
                       new RetriveData .prameter ("@QuantityStart",SqlDbType .Decimal , decimal .Parse (StrartQuantityTXT .Text )),
                       new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                       new RetriveData.prameter("@itempriceinput", SqlDbType.Decimal, decimal.Parse(PriceInputTXT.Text)),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            }

            if (RetriveData .saved == true )
            {
              
                button6_Click_1(null , null);
            }
            else 
            {
            MessageBox.Show ("تم تسجيل صنف اخر مسبقا بنفس الكود . برجاء التأكد من الكود واعادة المحاولة","",MessageBoxButtons .OK , MessageBoxIcon .Warning );
            CodeTXT.Focus ();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
           
        }

        private void MetreTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (MetreTXT,"");
            if (comboBox1.Text.Trim() != "سيراميك")
            {
                MetreTXT.Text = "";
            }
        }

        private void MetreTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(MetreTXT , e);
        }

        private void FrzTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (FrzTXT,"");

            if (comboBox1.Text.Trim() != "سيراميك")
            {
                FrzTXT.Text = "";
            }
        }

        private void ItemsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Login.Items_Visable = true;



                Login.ItemsSearchState = false;
                comboBox1.SelectedIndex = 0;
            }
            catch { }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(CodeTXT, "");
            errorProvider1.SetError(NameTXT, "");
            errorProvider1.SetError(ColorTXT, "");
            errorProvider1.SetError(SizeTXT, "");
            errorProvider1.SetError(FrzTXT, "");
            errorProvider1.SetError(MetreTXT, "");
            errorProvider1.SetError(PricreTXT, "");
            errorProvider1.SetError(CompanyTXT, "");

            Validation.TextClearOnly(this, Panel1);
        
         
            CodeTXT.Focus();
            Login.ItemsSearchState = false;
        }

        private void CodeTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (CodeTXT ,"");

       
        }

        private void NameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (NameTXT ,"");
        }

        private void ColorTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (ColorTXT,"");
        }

        private void SizeTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (SizeTXT,"");
        }

        private void CompanyTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (CompanyTXT,"");
        }

        private void PricreTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 .SetError (PricreTXT,"");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
           
            Login.MainItemsSearch = false;
            SearchItemsFrm frm = new SearchItemsFrm();
            frm.ShowDialog();
        }

        //=========================================================
        // لعرض البيانات من شاشة البحث في شاشة الأصناف
        public int ItemID;
        public void Find_Item( Int64    ItemCodeSearch)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("items_selectbycode",
                new RetriveData.prameter("@ItemCode", SqlDbType.BigInt  , ItemCodeSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["ItemsFrm"] as ItemsFrm;
            y.comboBox1.Text = dt.Rows[0]["ItemCategory"].ToString();
            y.CodeTXT.Text = dt.Rows[0]["ItemCode"].ToString();
            y.NameTXT.Text = dt.Rows[0]["ItemName"].ToString();
            y.ColorTXT.Text = dt.Rows[0]["ItemColor"].ToString();
            y.SizeTXT.Text = dt.Rows[0]["ItemSize"].ToString();
            y.FrzTXT.Text = dt.Rows[0]["ItemFrz"].ToString();
            y.MetreTXT.Text = dt.Rows[0]["ItemMeter"].ToString();
            y.CompanyTXT.Text = dt.Rows[0]["ItemCompany"].ToString();
            y.PricreTXT.Text = dt.Rows[0]["ItemPrice"].ToString();
            y.NotesTXT.Text = dt.Rows[0]["ItemNotes"].ToString();
            y.StrartQuantityTXT.Text = dt.Rows[0]["QuantityStart"].ToString();
            y.PriceInputTXT.Text = dt.Rows[0]["itempriceinput"].ToString();
            y.ItemID = int.Parse (dt.Rows[0]["ItemID"].ToString());
            
            Login.ItemsSearchState = true;

        


        }

        private void EdietBTN_Click(object sender, EventArgs e)
        {

            //عشان اخلي الأدمن فقط اللي يقدر يعدل الفاتورة
            DataTable dtupdate = new DataTable();
            dtupdate = RetriveData.ExecuteQuery("users_selectbyusername",
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName));

            if (dtupdate.Rows[0]["PerUpdate"].ToString() == "False")
            {
                MessageBox.Show("صلاحية التعديل غير متاحة للمستخدم الحالي", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            // عشان لو دوست ع تعديل قبل ما ابحث عن صنف
            if (Login.ItemsSearchState  == false)
            {
                MessageBox.Show("اختر الصنف الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }



            //====================================================================
            errorProvider1.SetError(CodeTXT, "");
            errorProvider1.SetError(NameTXT, "");
            errorProvider1.SetError(ColorTXT, "");
            errorProvider1.SetError(SizeTXT, "");
            errorProvider1.SetError(FrzTXT, "");
            errorProvider1.SetError(MetreTXT, "");
            errorProvider1.SetError(PricreTXT, "");
            errorProvider1.SetError(CompanyTXT, "");


            //=====================================================================

            if (comboBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(comboBox1, "اختر نوع الصنف من القائمة");
                return;
            }

            if (comboBox1.Text.Trim() != "سيراميك" && comboBox1.Text.Trim() != "صحي" && comboBox1.Text.Trim() != "خلاطات" && comboBox1.Text.Trim() != "لوازم" && comboBox1.Text.Trim() != "بانيو")
            {
                errorProvider1.SetError(comboBox1, "اختر نوع صنف صحيح من القائمة");
                return;
            }

            if (CodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CodeTXT, "يجب تسجيل كود الصنف !");
                return;
            }

            if (NameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(NameTXT, "يجب تسجيل اسم الصنف !");
                return;
            }

            if (comboBox1.Text.Trim() != "خلاطات" && comboBox1.Text.Trim() != "لوازم")
            {
                if (ColorTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(ColorTXT, "يجب تسجيل اللون لهذا النوع من الأصناف !");
                    return;
                }
                if (SizeTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(SizeTXT, "يجب تسجيل المقاس لهذا النوع من الأصناف !");
                    return;
                }
            }


            if (comboBox1.Text.Trim() == "سيراميك")
            {
                if (FrzTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(FrzTXT, "يجب تسجيل الفرز !");
                    return;
                }

                if (MetreTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(MetreTXT, "يجب تسجيل عدد الأمتار في الكرتونة !");
                    return;
                }

            }

            if (PricreTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PricreTXT, "يجب تسجيل سعر البيع !");
                return;
            }

            if (StrartQuantityTXT.Text.Trim() == "")
            {
                if (MessageBox.Show("لم يتم ادخال رصيد بداية المدة . هل تريد بالتأكيد عدم اضافة رصيد لهذا الصنف ؟", "تـسـجـيـل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    StrartQuantityTXT.Focus();
                    return;
                }
                else
                {
                    StrartQuantityTXT.Text = "0";
                }
            }

            if (CompanyTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CompanyTXT, "يجب تسجيل اسم الشركة !");
                return;
            }

            //============================================================

            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا الصنف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            

                if (comboBox1.Text.Trim() == "سيراميك")
                {
                    RetriveData.ExecuteNonQuery("items_update",
                    new RetriveData.prameter("@itemid", SqlDbType.Int, ItemID),
                    new RetriveData.prameter("@itemcategory", SqlDbType.NVarChar, comboBox1.Text.Trim()),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse  (CodeTXT.Text)),
                    new RetriveData.prameter("@itemname", SqlDbType.NVarChar, NameTXT.Text),
                    new RetriveData.prameter("@itemcolor", SqlDbType.NVarChar, ColorTXT.Text),
                    new RetriveData.prameter("@itemsize", SqlDbType.NVarChar, SizeTXT.Text),
                    new RetriveData.prameter("@itemfrz", SqlDbType.NVarChar, FrzTXT.Text),
                    new RetriveData.prameter("@itemmeter", SqlDbType.Decimal, decimal.Parse(MetreTXT.Text)),
                    new RetriveData.prameter("@itemcompany", SqlDbType.NVarChar, CompanyTXT.Text),
                    new RetriveData.prameter("@itemprice", SqlDbType.Decimal, decimal.Parse(PricreTXT.Text)),
                    new RetriveData.prameter("@itemnotes", SqlDbType.NVarChar, NotesTXT.Text),
                    new RetriveData.prameter("@QuantityStart", SqlDbType.Decimal, decimal.Parse(StrartQuantityTXT.Text)),
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@itempriceinput", SqlDbType.Decimal, decimal.Parse(PriceInputTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                }
                else
                {
                    RetriveData.ExecuteNonQuery("items_update",
                      new RetriveData.prameter("@itemid", SqlDbType.Int, ItemID),
                      new RetriveData.prameter("@itemcategory", SqlDbType.NVarChar, comboBox1.Text.Trim()),
                      new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse (CodeTXT.Text)),
                      new RetriveData.prameter("@itemname", SqlDbType.NVarChar, NameTXT.Text),
                      new RetriveData.prameter("@itemcolor", SqlDbType.NVarChar, ColorTXT.Text),
                      new RetriveData.prameter("@itemsize", SqlDbType.NVarChar, SizeTXT.Text),
                      new RetriveData.prameter("@itemfrz", SqlDbType.NVarChar, FrzTXT.Text),
                      new RetriveData.prameter("@itemmeter", SqlDbType.Decimal, 1),
                      new RetriveData.prameter("@itemcompany", SqlDbType.NVarChar, CompanyTXT.Text),
                      new RetriveData.prameter("@itemprice", SqlDbType.Decimal, decimal.Parse(PricreTXT.Text)),
                      new RetriveData.prameter("@itemnotes", SqlDbType.NVarChar, NotesTXT.Text),
                      new RetriveData.prameter("@QuantityStart", SqlDbType.Decimal, decimal.Parse(StrartQuantityTXT.Text)),
                      new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                      new RetriveData.prameter("@itempriceinput", SqlDbType.Decimal, decimal.Parse(PriceInputTXT.Text)),
                      new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
               
                
                }

          
                if (RetriveData.saved == true)
                {

                   
                    
                    MessageBox.Show("تم تعديل بيانات " + " " +NameTXT . Text + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button6_Click_1(null, null);
                    Login.ItemsSearchState  = false;
                }
                else
                {
                    MessageBox.Show("لا يمكنك تعديل كود هذا الصنف للكود الذي أدخلته . حيث يوجد صنف اخر مسجل بنفس الكود ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodeTXT.Focus();
                    return; 
                }


            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع حذف قبل ما ابحث عن عميل
            if (Login.ItemsSearchState  == false)
            {
                MessageBox.Show("اختر الصنف الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات هذا الصنف ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("Items_delete",
                    new RetriveData.prameter("@itemid", SqlDbType.Int, ItemID ),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم حذف بيانات الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button6_Click_1(null, null);
                    Login.ItemsSearchState  = false;
                }
                else
                {
                    MessageBox.Show("فشل حذف الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
           
        }

        private void ItemsFrm_Leave(object sender, EventArgs e)
        {
         
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void CodeTXT_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void CodeTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.T || e.KeyChar == (char)Keys.ShiftKey  )
            //{
            //    MessageBox.Show("تم");
            //}
            
            Validation.NumbersOnly(e);
        }

        private void NameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void PriceInputTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(PriceInputTXT ,e);
        }

        private void PricreTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly( PricreTXT  , e);
        }

        private void StrartQuantityTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(StrartQuantityTXT  ,e);
        }

        private void PriceInputTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(PriceInputTXT, "");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void CodeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                NameTXT.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                comboBox1.Select();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CodeTXT.Select();
            }
        }

        private void NameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                ColorTXT . Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                CodeTXT.Select();
            }
        }

        private void ColorTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                SizeTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NameTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                FrzTXT.Select();
            }
        }

        private void SizeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                FrzTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NameTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                ColorTXT.Select();
            }
        }

        private void FrzTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                MetreTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                SizeTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                PriceInputTXT.Select();
            }
        }

        private void MetreTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left || e.KeyCode == Keys .Down  )
            {
                PriceInputTXT.Select();
            }
            
            else if (e.KeyCode == Keys.Up)
            {
                SizeTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                FrzTXT.Select();
            }

        }

        private void PriceInputTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                PricreTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                StrartQuantityTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                FrzTXT.Select();
            }
        }

        private void PricreTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down )
            {
                StrartQuantityTXT.Select();
            }
            else if (e.KeyCode == Keys.Right )
            {
                PriceInputTXT . Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                MetreTXT . Select();
            }
        }

        private void StrartQuantityTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left )
            {
               CompanyTXT . Select();
            }
            else if (e.KeyCode == Keys.Down )
            {
                NotesTXT . Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
               PriceInputTXT . Select();
            }
        }

        private void CompanyTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down )
            {
               NotesTXT.Select();
            }
            else if (e.KeyCode == Keys.Right )
            {
                StrartQuantityTXT . Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                PricreTXT.Select();
            }
        }

        private void NotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }
         
            else if (e.KeyCode == Keys.Up)
            {
                CompanyTXT.Select();
            }
        }

        private void NewBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                ExitBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                SaveBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

        private void SaveBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                NewBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                SearchBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

        private void SearchBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                SaveBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                EdietBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

        private void EdietBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                SaveBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                DeleteBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

        private void DeleteBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                EdietBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                ExitBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

        private void ExitBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                DeleteBTN.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                NewBTN.Select();
            }
             else if (e.KeyCode == Keys.Up)
            {
                NotesTXT.Select();
            }
        }

    }
}
