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
    public partial class Df3Mali : Form
    {
        public Df3Mali()
        {
            InitializeComponent();
        }





        //لعرض بيانات الاذن في شاشة الاذن بعد البحث عن الاذن في شاشةة البحث
        public int EznID;
        public void Ezn_Find(int EznNoSearch)
        {
            var y = Application.OpenForms["Df3Mali"] as Df3Mali;

            //هشوف الاذن دا لمورد ولا عميل ولا اخر
            DataTable dtcheck = new DataTable();

            y.OtherCheck.Checked = true;

            dtcheck = RetriveData.ExecuteQuery("VendorsTrans_SelectAll_ByBillCode",
                new RetriveData.prameter("@eznno", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@movetype", SqlDbType.NVarChar, "اذن دفع مالي"),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtcheck.Rows.Count > 0)
            {
                y.VendorCheck.Checked = true;
            }
            else
            {
                dtcheck = RetriveData.ExecuteQuery("CustomersTrans_SelectAll_ByBillCode",
                    new RetriveData.prameter("@eznno", SqlDbType.Int, EznNoSearch),
                    new RetriveData.prameter("@movetype", SqlDbType.NVarChar, "اذن دفع مالي"),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtcheck.Rows.Count > 0)
                {
                    y.CustCheck.Checked = true;
                }
            }
            
            DataTable dtCheckSubEznSrf = new DataTable();
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("Df3Mali_SelectAll_ByEznNo",
                new RetriveData.prameter("@eznno", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

         
            y.EznID = int.Parse(dt.Rows[0]["EznID"].ToString());
            y.EznNoTXT.Text = dt.Rows[0]["EznNo"].ToString();
            y.EznDateTXT .Text = dt.Rows[0]["EznDate"].ToString();
            y.EznPriceTXT.Text = dt.Rows[0]["Eznvalue"].ToString();
            y.EznTypeTXT.Text = dt.Rows[0]["EznType"].ToString();
            if (dt.Rows[0]["VenCode"].ToString() == "0")
            {
                y.CodeCOMBO.Text = "";
                y.NameCOMBO.Text = "";
            }
            else
            {
                y.CodeCOMBO.Text = dt.Rows[0]["VenCode"].ToString();
                y.NameCOMBO.Text = dt.Rows[0]["VenName"].ToString();
            }

            if (dt.Rows[0]["ShekNo"].ToString() == "0")
            {
                y.ShekNoTXT.Text = "";
                y.BankNameTXT.Text = "";
            }
            else
            {
                y.ShekNoTXT.Text = dt.Rows[0]["ShekNo"].ToString();
                y.BankNameTXT.Text = dt.Rows[0]["BankName"].ToString();
            }
            y.ShekDate.Text = dt.Rows[0]["ShekDate"].ToString();
            y.EznNotesTXT.Text = dt.Rows[0]["txtnotes"].ToString();
            y.comboNotes.Text = dt.Rows[0]["ComboNotes"].ToString();
           
            
            if (dt.Rows[0]["DeleteFalg"].ToString() == "True")
            {
                y.label11.Visible = true;
            }
            else
            {
                y.label11.Visible = false;
            }



            

            Login.Df3MaliSearch2  = true;
           
        }







        private void Df3Mali_Load(object sender, EventArgs e)
        {
            try
            {
                Login.Df3MaliSearch2 = false;
                VendorCheck.Checked = true;
                EznTypeTXT.SelectedIndex = 0;
                //ملي الكومبو بأكواد واسماء الموردين
                Validation.FillComboBox(CodeCOMBO, "Vendors_selectall", "VenCode");
                Validation.FillComboBox(NameCOMBO, "Vendors_selectall", "VenName");

                CodeCOMBO.Text = "";
                NameCOMBO.Text = "";

                //للحصول على اخر سجل
                Validation.GetLasRecord("Eznno", "EznDf3Mali", EznNoTXT);
            }
            catch { }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Login.Df3MaliSearch2 = false;
            Validation.TextClear(this, panel1);
            Validation.GetLasRecord("eznno", "ezndf3mali", EznNoTXT );
            EznTypeTXT.SelectedIndex = 0;
            label11.Visible = false;

            
        }

        private void VendorCheck_CheckedChanged(object sender, EventArgs e)
        {
            //ملي الكومبو بأكواد واسماء الموردين
            CodeCOMBO.Enabled = true;
            NameCOMBO.Enabled = true;
            label8.Enabled = true;
            Validation.FillComboBox(CodeCOMBO , "Vendors_selectall","VenCode");
            Validation.FillComboBox(NameCOMBO, "Vendors_selectall", "VenName");
            comboNotes.Enabled = false;
            comboNotes.Text = "";
            CodeCOMBO.Text = "";
            NameCOMBO.Text = "";
        }

        private void CustCheck_CheckedChanged(object sender, EventArgs e)
        {
            //ملي الكومبو بأكواد واسماء العملاء
            CodeCOMBO.Enabled = true;
            NameCOMBO.Enabled = true;
            label8.Enabled = true;

            Validation.FillComboBox(CodeCOMBO, "Customers_selectall", "CustCode");
            Validation.FillComboBox(NameCOMBO, "Customers_selectall", "CustName");
            comboNotes.Enabled = false;
            comboNotes.Text = "";
            CodeCOMBO.Text = "";
            NameCOMBO.Text = "";
        }

        private void OtherCheck_CheckedChanged(object sender, EventArgs e)
        {
            // تفريغ الكومبو من اكواد واسماء الموردين او العملاء 
            CodeCOMBO.DataSource = null;
            NameCOMBO.DataSource = null;
            comboNotes.Enabled = true ;
            comboNotes.Text = "";
            CodeCOMBO.Text = "";
            NameCOMBO.Text = "";
       
        }

        private void EznTypeTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EznTypeTXT.SelectedIndex == 0)
            {
                ShekNoTXT.Text = "";
                ShekDate.Value = EznDateTXT.Value;
                BankNameTXT.Text = "";
            }
            else 
            {
                ShekDate.Value = DateTime.Now;
            }
        }

        private void VenCodeCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VenCodeCOMBO_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CodeCOMBO , "");
            //كتابة اسم المورد في كومبو الاسم عند اختيار الكود


            if (VendorCheck.Checked == true)
            {
                if (CodeCOMBO.Text.Trim() != "" && CodeCOMBO.Text != "System.Data.DataRowView")
                {


                    DataTable dt = new DataTable();
                    dt = RetriveData.ExecuteQuery("Vendors_selectbycode",
                        new RetriveData.prameter("@vencode", SqlDbType.Int, int.Parse(CodeCOMBO.Text.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
                       NameCOMBO.Text = dt.Rows[0]["VenName"].ToString();
                    }
                    else
                    {
                        NameCOMBO.Text = "";
                    }

                }
            }
            else if (CustCheck.Checked == true)
            {
                if (CodeCOMBO.Text.Trim() != "" && CodeCOMBO.Text != "System.Data.DataRowView")
                {


                    DataTable dt = new DataTable();
                    dt = RetriveData.ExecuteQuery("Customers_selectbycode",
                        new RetriveData.prameter("@Custcode", SqlDbType.Int, int.Parse(CodeCOMBO.Text.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
                        NameCOMBO.Text = dt.Rows[0]["CustName"].ToString();
                    }
                    else
                    {
                        NameCOMBO.Text = "";
                    }

                }

            }
           
        }

        private void NameCOMBO_TextChanged(object sender, EventArgs e)
        {
             errorProvider1.SetError(NameCOMBO  , "");
            //كتابة اسم المورد أو العميل في كومبو الاسم عند اختيار الكود

            if (VendorCheck.Checked == true)
            {
                if (NameCOMBO.Text.Trim() != "" && NameCOMBO.Text != "System.Data.DataRowView")
                {
                    DataTable dt = new DataTable();
                    dt = RetriveData.ExecuteQuery("Vendors_selectbyname",
                        new RetriveData.prameter("@venname", SqlDbType.NVarChar  , NameCOMBO.Text),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
                       CodeCOMBO.Text = dt.Rows[0]["VenCode"].ToString();
                    }
                    else
                    {
                        CodeCOMBO.Text = "";
                    }
                }
            }
            else if (CustCheck.Checked  == true)
            {
                if (NameCOMBO.Text.Trim() != "" && NameCOMBO.Text != "System.Data.DataRowView")
                {
                    DataTable dt = new DataTable();
                    dt = RetriveData.ExecuteQuery("Customers_selectbyName",
                        new RetriveData.prameter("@Custname", SqlDbType.NVarChar , NameCOMBO.Text),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
                        CodeCOMBO.Text = dt.Rows[0]["CustCode"].ToString();
                    }
                    else
                    {
                        CodeCOMBO.Text = "";
                    }
                }
            
            }
        }

        private void NameCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            
            if (Login.Df3MaliSearch2  == true)
            {
                if (MessageBox.Show("هذا الاذن موجود بالفعل يمكنك تعديل بياناته أو حذفه . هل تريد ادخال بيانات جديدة لتسجيل اذن اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewBTN_Click(null, null);
                    return;
                }
                else
                {
                    return;
                }
             }




            if (EznNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznNoTXT, "برجاء ادخال رقم الاذن");
                return;
            }

            if (EznPriceTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznPriceTXT, "برجاء ادخال قيمة الاذن");
                return;
            }



            int CodeVairable = 0;



            if (OtherCheck .Checked  == false )
            {
                if (CodeCOMBO.Text.Trim() == "")
                {
                    errorProvider1.SetError(CodeCOMBO, "برجاء ادخال الكود");
                    return;
                }

                if (NameCOMBO.Text.Trim() == "")
                {
                    errorProvider1.SetError(NameCOMBO, "برجاء ادخال الاسم");
                    return;
                }
                CodeVairable = int.Parse(CodeCOMBO.Text);
            }




            //هعمل متغيرات لاضافة القيم اللي ممكن تبقى مش موجودة زي رقم الشيك واسم البنك
            int sheknoVairable = 0;
            string banknameVairable = "";
            DateTime ShekDateVairable = EznDateTXT.Value.Date;


            if (EznTypeTXT .SelectedIndex  == 1)
            {

                if (ShekNoTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(ShekNoTXT, "برجاء ادخال رقم الشيك");
                    return;
                }

                if (ShekDate.Value.Date  < EznDateTXT.Value.Date )
                {
                    errorProvider1.SetError(ShekDate, "تاريخ الاستحقاق أقدم من تاريخ الاذن . برجاء ادخال تاريخ الاستحقاق الصحيح");
                    return;
                }

                if (BankNameTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(BankNameTXT, "برجاء ادخال اسم البنك");
                    return;
                }
                sheknoVairable = int.Parse(ShekNoTXT.Text);
                banknameVairable = BankNameTXT.Text;
                ShekDateVairable = ShekDate.Value.Date;
            }

            string comboNotesVariable;
            if (OtherCheck.Checked == true)
            {
                if (comboNotes.Text == "")
                {
                    errorProvider1.SetError(comboNotes, "برجاء تحديد اختيار من القائمة");
                    return;
                }
                comboNotesVariable = comboNotes.Text;
            }
            else
            {
                comboNotesVariable = "";
            }
           //===================================================================================
        

            string MoveDescriptionVairable;
            string EznTypeVairable = "";
            if (EznTypeTXT.SelectedIndex == 0)
            {
                EznTypeVairable = "نقديا";
            }
            else
            {
                EznTypeVairable = "الشيك رقم " + " " + sheknoVairable.ToString() + " " + "بتاريخ : " + ShekDateVairable.Date.ToShortDateString();
            }



            MoveDescriptionVairable = " اذن دفع مالي" + " - " + EznTypeVairable ;



         

            //في حالة اذا كان الدفع لمورد هخلي قيمته 1 ولو لعميل 2 ولو اخر 3
            // عشان من خلاله هحدد التسجيل هيبقى في انهي جدول
            int WhichPerson = 0;
            if (VendorCheck.Checked  == true)
            {
                WhichPerson = 1;
            }
            else if (CustCheck.Checked  == true)
            {
                WhichPerson = 2;
            }
            else if (OtherCheck.Checked == true)
            {
                WhichPerson = 3;
            }

           //التسجيل في قاعدة البيانات
            RetriveData.ExecuteNonQuery("Df3Mali_Insert",
                new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                new RetriveData.prameter("@ezndate", SqlDbType.Date, EznDateTXT.Value.Date),
                new RetriveData.prameter("@eznprice", SqlDbType.Decimal, decimal.Parse(EznPriceTXT.Text)),
                new RetriveData.prameter("@ezntype", SqlDbType.NVarChar, EznTypeTXT.Text),
                new RetriveData.prameter("@shekno", SqlDbType.Int, sheknoVairable),
                new RetriveData.prameter("@shekdate", SqlDbType.Date, ShekDateVairable),
                new RetriveData.prameter("@bankname", SqlDbType.NVarChar, banknameVairable),
                new RetriveData.prameter("@vencode", SqlDbType.Int, CodeVairable),
                new RetriveData.prameter("@venname", SqlDbType.NVarChar, NameCOMBO.Text),
                new RetriveData.prameter("@eznnotes", SqlDbType.NVarChar, EznNotesTXT.Text),
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@movedescrption", SqlDbType.NVarChar, MoveDescriptionVairable),
                new RetriveData.prameter("@whichPerson", SqlDbType.Int, WhichPerson),
                new RetriveData.prameter("@combonotes", SqlDbType.NVarChar, comboNotesVariable ),
                new RetriveData.prameter("@txtnotes", SqlDbType.NVarChar, EznNotesTXT.Text),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected)); 
            if (RetriveData.saved == true)
            {
                NewBTN_Click(null, null);
            }
            else
            {
                MessageBox.Show("تم تسجيل اذن دفع مسبقا بنفس رقم الاذن . برجاء التأكد من رقم الاذن الصحيح والمحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //عشان اخلي الأدمن فقط اللي يقدر يعدل الفاتورة
            DataTable dtupdate = new DataTable();
            dtupdate = RetriveData.ExecuteQuery("users_selectbyusername",
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtupdate.Rows[0]["PerUpdate"].ToString() == "False")
            {
                MessageBox.Show("صلاحية التعديل غير متاحة للمستخدم الحالي", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

            if (Login.Df3MaliSearch2 == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //التأكد من ان الاذن غير ملغي
            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي لايمكن تعديل بياناته", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (EznNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznNoTXT, "برجاء ادخال رقم الاذن");
                return;
            }

            if (EznPriceTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznPriceTXT, "برجاء ادخال قيمة الاذن");
                return;
            }



            int CodeVairable = 0;



            if (OtherCheck .Checked  ==false )
            {
                if (CodeCOMBO.Text.Trim() == "")
                {
                    errorProvider1.SetError(CodeCOMBO, "برجاء ادخال الكود");
                    return;
                }

                if (NameCOMBO.Text.Trim() == "")
                {
                    errorProvider1.SetError(NameCOMBO, "برجاء ادخال الاسم");
                    return;
                }
                CodeVairable = int.Parse(CodeCOMBO.Text);
            }




            //هعمل متغيرات لاضافة القيم اللي ممكن تبقى مش موجودة زي رقم الشيك واسم البنك
            int sheknoVairable = 0;
            string banknameVairable = "";
            DateTime ShekDateVairable = EznDateTXT.Value.Date;


            if (EznTypeTXT .SelectedIndex  == 1)
            {

                if (ShekNoTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(ShekNoTXT, "برجاء ادخال رقم الشيك");
                    return;
                }

                if (ShekDate.Value.Date < EznDateTXT.Value.Date)
                {
                    errorProvider1.SetError(ShekDate, "تاريخ الاستحقاق أقدم من تاريخ الاذن . برجاء ادخال تاريخ الاستحقاق الصحيح");
                    return;
                }

                if (BankNameTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(BankNameTXT, "برجاء ادخال اسم البنك");
                    return;
                }
                sheknoVairable = int.Parse(ShekNoTXT.Text);
                banknameVairable = BankNameTXT.Text;
                ShekDateVairable = ShekDate.Value.Date;
            }


            string comboNotesVariable;
            if (OtherCheck.Checked == true)
            {
                if (comboNotes.Text == "")
                {
                    errorProvider1.SetError(comboNotes, "برجاء تحديد اختيار من القائمة");
                    return;
                }
                comboNotesVariable = comboNotes.Text;
            }
            else
            {
                comboNotesVariable = "";
            }

            //===================================================================================

           



            string MoveDescriptionVairable;
            string EznTypeVairable = "";
            if (EznTypeTXT.SelectedIndex == 0)
            {
                EznTypeVairable = "نقديا";
            }
            else
            {
                EznTypeVairable = "الشيك رقم " + " " + sheknoVairable.ToString() + " " + "بتاريخ : " + ShekDateVairable.Date.ToShortDateString();
            }



            MoveDescriptionVairable = " اذن استلام مالي" + " - " + EznTypeVairable + EznNotesTXT.Text;



            //في حالة اذا كان الدفع لمورد هخلي قيمته 1 ولو لعميل 2 ولو اخر 3
            // عشان من خلاله هحدد التسجيل هيبقى في انهي جدول
            int WhichPerson = 0;
            if (VendorCheck.Checked == true)
            {
                WhichPerson = 1;
            }
            else if (CustCheck.Checked == true)
            {
                WhichPerson = 2;
            }
            else if (OtherCheck.Checked == true)
            {
                WhichPerson = 3;
            }



            //التسجيل في قاعدة البيانات
            if (MessageBox.Show("هل تريد بالتأكيد تعديل بيانات الاذن رقم " + " " + "( " + EznNoTXT.Text + " )" + " " + "؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("Df3Mali_Update",
                    new RetriveData.prameter("@eznid", SqlDbType.Int, EznID),
                    new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@ezndate", SqlDbType.Date, EznDateTXT.Value.Date),
                    new RetriveData.prameter("@eznprice", SqlDbType.Decimal, decimal.Parse(EznPriceTXT.Text)),
                    new RetriveData.prameter("@ezntype", SqlDbType.NVarChar, EznTypeTXT.Text),
                    new RetriveData.prameter("@shekno", SqlDbType.Int, sheknoVairable),
                    new RetriveData.prameter("@shekdate", SqlDbType.Date, ShekDateVairable),
                    new RetriveData.prameter("@bankname", SqlDbType.NVarChar, banknameVairable),
                    new RetriveData.prameter("@vencode", SqlDbType.Int, CodeVairable),
                    new RetriveData.prameter("@venname", SqlDbType.NVarChar, NameCOMBO.Text),
                    new RetriveData.prameter("@eznnotes", SqlDbType.NVarChar, EznNotesTXT.Text),
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@movedescrption", SqlDbType.NVarChar, MoveDescriptionVairable),
                    new RetriveData.prameter("@whichPerson", SqlDbType.Int, WhichPerson),
                    new RetriveData.prameter("@combonotes", SqlDbType.NVarChar, comboNotesVariable ),
                    new RetriveData.prameter("@txtnotes", SqlDbType.NVarChar, EznNotesTXT.Text),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم تعديل بيانات الاذن رقم " + " " + "( " + EznNoTXT.Text + " )" + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                }
                else
                {
                    MessageBox.Show("تم تسجيل اذن دفع مسبقا بنفس رقم الاذن . برجاء التأكد من رقم الاذن الصحيح والمحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDf3Mali frm = new SearchDf3Mali();
            frm.ShowDialog();
        }

        private void EznNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznNoTXT, "");
        }

        private void ShekNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(ShekNoTXT, "");
            if (EznTypeTXT.SelectedIndex == 0)
            {
                ShekNoTXT.Text = "";
            }
        }

        private void BankNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(BankNameTXT, "");
            if (EznTypeTXT.SelectedIndex == 0)
            {
                BankNameTXT.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void CodeCOMBO_TextUpdate(object sender, EventArgs e)
        {
            if (OtherCheck.Checked == true)
            {
                CodeCOMBO.Text = "";

            }

        }

        private void NameCOMBO_TextUpdate(object sender, EventArgs e)
        {
            if (OtherCheck.Checked == true)
            {
                NameCOMBO.Text = "";
            }
        }

        private void EznDateTXT_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ShekDate_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(ShekDate, "");
        }

        private void EznPriceTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznPriceTXT, "");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EznNotesTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznNotesTXT, "");
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            if (Login.Df3MaliSearch2  == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد الغائه من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Select();
                return;
            }



            //التأكد من ان الاذن غير ملغي
            if (label11.Visible == true)
            {
                MessageBox.Show("هذ الاذن ملغي بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
             //التسجيل في قاعدة البيانات
            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات الاذن رقم " + " " + "( " + EznNoTXT.Text + " )" + " " + "؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("Df3Mali_Delete",
                    new RetriveData.prameter("eznid", SqlDbType.Int, EznID),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (RetriveData.saved == true)
                {

                    MessageBox.Show("تم الغاء الاذن رقم " + " " + "( " + EznNoTXT.Text + " )" + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                }
                else
                {
                    MessageBox.Show("فشل الغاء الاذن", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void comboNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboNotes, "");
        }

        private void EznNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void EznPriceTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(EznPriceTXT, e);
        }

        private void CodeCOMBO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void ShekNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void EznNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                EznDateTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                EznPriceTXT.Select();
            }
        }

        private void EznDateTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EznPriceTXT.Select();
            }
       
        }

        private void EznPriceTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                EznTypeTXT.Select();
            }
            else if (e.KeyCode == Keys .Up )
            {
                EznNoTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                CodeCOMBO.Select();
            }
        }

        private void EznTypeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CodeCOMBO.Select();
            }
          
        }

        private void CodeCOMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NameCOMBO.Select();
            }
        }

        private void NameCOMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShekNoTXT.Select();
            }
        }

        private void ShekNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Left)
            {
                ShekDate.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CodeCOMBO.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                BankNameTXT.Select();
            }


        }

        private void ShekDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BankNameTXT.Select();
            }
        }

        private void BankNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (comboNotes.Enabled == true)
                {
                    comboNotes.Select();
                }
                else
                {
                    EznNotesTXT.Select();
                }
            }
            else if (e.KeyCode == Keys.Up )
            {
                ShekDate.Select();
            }
        }

        private void comboNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EznNotesTXT.Select();
            }
        }

        private void EznNotesTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void EznNotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }

            if (e.KeyCode == Keys.Right)
            {
                if (comboNotes.Enabled == true)
                {
                    comboNotes.Select();
                }
            }
        }

        private void EznTypeTXT_KeyUp(object sender, KeyEventArgs e)
        {
            EznTypeTXT.FlatStyle = FlatStyle.Flat;
        }

        private void EznTypeTXT_Leave(object sender, EventArgs e)
        {
            EznTypeTXT.FlatStyle = FlatStyle.Standard;
        }
        }
    }

