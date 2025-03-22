using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Classes;
using System.Data.SqlClient;

namespace Sales01.Forms
{
    public partial class NewUserFrm : Form
    {
       



        public   NewUserFrm()
        {
            InitializeComponent();
        }
        //===========================================================
        // لعرض بيانات المستخدم الذي تم اختياره من شاشة البحث
       public  void find_user  (string usernamesearch)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("users_selectbyusername",
             new RetriveData.prameter("@username", SqlDbType.NVarChar, usernamesearch));

            var y = Application.OpenForms["NewUserFrm"] as NewUserFrm; // لامكانية التحكم في التكستات من فورم اخرى

            y.NameTXT.Text = dt.Rows[0]["Name"].ToString();
            y.UserNameTXT.Text = dt.Rows[0]["UserName"].ToString();
            y.PasswordTXT.Text = dt.Rows[0]["UserPassword"].ToString();
            y.Password2TXT.Text = dt.Rows[0]["UserPassword"].ToString();
            if (dt.Rows[0]["PerItems"].ToString() == "True")
            {
                y.ItemsCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerCustomers"].ToString() == "True")
            {
                y.CustCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerVendors"].ToString() == "True")
            {
                y.VendorsCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerUsers"].ToString() == "True")
            {
                y.UsersCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerBill"].ToString() == "True")
            {
                y.BillCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerEznSrf"].ToString() == "True")
            {
                y.EznsfrCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerEznEstlam"].ToString() == "True")
            {
                y.EznestlamCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerUpdate"].ToString() == "True")
            {
                y.UpdateCheckBox.Checked = true;
            }
            if (dt.Rows[0]["PerEznDf3Mali"].ToString() == "True")
            {
                y.Df3maliCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerEznEstlamMali"].ToString() == "True")
            {
                y.estlammaliCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerData"].ToString() == "True")
            {
                y.DataCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["PerReports"].ToString() == "True")
            {
                y.ReportsCHKBOX.Checked = true;
            }
            if (dt.Rows[0]["permortg3bill"].ToString() == "True")
            {
                y.Mortg3BillChek .Checked  = true;
            }
            if (dt.Rows[0]["permortg3estlam"].ToString() == "True")
            {
                y.Mortg3EstlamCheck .Checked  = true;
            }
            if (dt.Rows[0]["percompanysetting"].ToString() == "True")
            {
                y.CompanyCheck .Checked  = true;
            }
            y.AddBy_lbl.Visible = true;
            y.useradd_lbl.Visible = true;
            y.useradd_lbl.Text = dt.Rows[0]["UserNameAdd"].ToString();
            y.UserNameTXT.Enabled = false;

            
            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور
            DataTable dt2 = new DataTable();
            dt2 = RetriveData.ExecuteQuery("subusers_selectbyusername",
                new RetriveData.prameter("@username", SqlDbType.NVarChar , dt.Rows[0]["UserName"].ToString()));

            y.dataGridView1.Rows.Clear();
            if (dt2.Rows.Count > 0)
            {
                y.dataGridView1.Rows.Add(dt2.Rows.Count); // هضيف عدد سجلات في الداتا جريد بعدد سجلات العناصر
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    y.dataGridView1.Rows[i].Cells[0].Value = "حـذف";
                    y.dataGridView1.Rows[i].Cells[1].Value = dt2.Rows[i]["CompanyName"].ToString();
                }
            }


            Login.SearchState = true;
           }
        
        
        
        
        // ==========================================================







        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Login.SearchState == true)
            {
                if (MessageBox.Show("هذا المستخدم موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل مستخدم اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button6_Click_3(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }
            
            if (NameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(NameTXT, "يجب ادخال الاسم");
                NameTXT.Focus();
                return;
            }

            if (UserNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(UserNameTXT, "يجب ادخال اسم المستخدم");
                UserNameTXT.Focus();
                return;
            }

            if (PasswordTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PasswordTXT, "يجب ادخال كلمة المرور");
                PasswordTXT.Focus();
                return;
            }

            if (Password2TXT.Text.Trim() == "")
            {
                errorProvider1.SetError(Password2TXT, "يجب اعادة ادخال كلمة المرور");
                PasswordTXT.Focus();
                return;
            }

            if (PasswordTXT.Text != Password2TXT.Text)
            {
                errorProvider1.SetError(Password2TXT, "كلمة المرور غير متطابقة");
                Password2TXT.Focus();
                return;
            }

            try
            {
                //عشان لو أول مرة استخدم فيها البرنامج
                DataTable dtFrist = new DataTable();
                dtFrist = RetriveData.ExecuteQuery("users_selectall");
                if (dtFrist.Rows.Count == 0)
                {

                    if (AllPerCHKBOX.Checked == false && CustCHKBOX.Checked == false && UsersCHKBOX.Checked == false
                    && VendorsCHKBOX.Checked == false && ItemsCHKBOX.Checked == false &&
                    BillCHKBOX.Checked == false && EznsfrCHKBOX.Checked == false &&
                    EznestlamCHKBOX.Checked == false && UpdateCheckBox.Checked == false &&
                    Df3maliCHKBOX.Checked == false && estlammaliCHKBOX.Checked == false
                    && DataCHKBOX.Checked == false && ReportsCHKBOX.Checked == false && Mortg3BillChek.Checked == false
                    && Mortg3EstlamCheck.Checked == false && CompanyCheck.Checked == false)
                    {
                        if (MessageBox.Show(" لم يتم تحديد أي صلاحيات لهذا المستخدم . هل تريد الاستمرار ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    DataTable dt = FillUsersDataTable();

                    DBConnected db = new DBConnected();

                    db.cmd.Connection = DBConnected.sqlcon;
                    db.cmd.CommandType = CommandType.StoredProcedure;
                    db.cmd.CommandText = "Users_Insert";

                    db.cmd.Parameters.AddWithValue("@name", NameTXT.Text);
                    db.cmd.Parameters.AddWithValue("@username", UserNameTXT.Text);
                    db.cmd.Parameters.AddWithValue("@userpassword", PasswordTXT.Text);
                    db.cmd.Parameters.AddWithValue("@peritems", ItemsCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@percustomers", CustCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@pervendors", VendorsCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@perusers", UsersCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@perbill", BillCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@pereznsrf", EznsfrCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@pereznestlam", EznestlamCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@perupdate", UpdateCheckBox.Checked);
                    db.cmd.Parameters.AddWithValue("@perezndf3mali", Df3maliCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@pereznestlammali", estlammaliCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@perdata", DataCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@perreports", ReportsCHKBOX.Checked);
                    db.cmd.Parameters.AddWithValue("@permortg3bill", Mortg3BillChek.Checked);
                    db.cmd.Parameters.AddWithValue("@permortg3estlam", Mortg3EstlamCheck.Checked);
                    db.cmd.Parameters.AddWithValue("@percompanysetting", CompanyCheck.Checked);
                    db.cmd.Parameters.AddWithValue("@usernameadd", UserNameTXT.Text);
                    db.cmd.Parameters.AddWithValue("@UsersDataTable", dt);



                    int r = db.cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show(" تم تسجيل المستخدم بنجاح  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("سيتم اعادة تشغيل البرنامج لتسجيل دخولك بالمستخدم الجديد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validation.TextClear(this, panel5);
                        AllPerCHKBOX.Checked = false;
                        ItemsCHKBOX.Checked = false;
                        CustCHKBOX.Checked = false;
                        VendorsCHKBOX.Checked = false;
                        UsersCHKBOX.Checked = false;
                        BillCHKBOX.Checked = false;
                        EznsfrCHKBOX.Checked = false;
                        EznestlamCHKBOX.Checked = false;
                        UpdateCheckBox.Checked = false;
                        Df3maliCHKBOX.Checked = false;
                        estlammaliCHKBOX.Checked = false;
                        DataCHKBOX.Checked = false;
                        ReportsCHKBOX.Checked = false;
                        Mortg3BillChek.Checked = false;
                        Mortg3EstlamCheck.Checked = false;
                        CompanyCheck.Checked = false;
                        AdminpasswordTXT.Text = "";
                        AllCompanyName.Text = "";
                        dataGridView1.Rows.Clear();
                        Application.Restart();
                    }

                    else
                    {
                        MessageBox.Show("فشل تسجيل المستخدم برجاء المحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {


                    if (AdminpasswordTXT.Text.Trim() == "")
                    {
                        errorProvider1.SetError(AdminpasswordTXT, "يجب ادخال كلمة مرور المستخدم الحالي");
                        AdminpasswordTXT.Focus();
                        return;
                    }


                    DataTable dt0 = new DataTable();
                    dt0 = RetriveData.ExecuteQuery("users_checklogin",
                        new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName.ToString()),
                        new RetriveData.prameter("@password", SqlDbType.NVarChar, AdminpasswordTXT.Text));
                    if (dt0.Rows.Count == 0)
                    {
                        errorProvider1.SetError(AdminpasswordTXT, "كلمة مرور المستخدم الحالي غير صحيحة");
                        return;
                    }


                    if (AllPerCHKBOX.Checked == false && CustCHKBOX.Checked == false && UsersCHKBOX.Checked == false
                    && VendorsCHKBOX.Checked == false && ItemsCHKBOX.Checked == false &&
                    BillCHKBOX.Checked == false && EznsfrCHKBOX.Checked == false &&
                    EznestlamCHKBOX.Checked == false && UpdateCheckBox.Checked == false &&
                    Df3maliCHKBOX.Checked == false && estlammaliCHKBOX.Checked == false
                    && DataCHKBOX.Checked == false && ReportsCHKBOX.Checked == false && Mortg3BillChek.Checked == false
                        && Mortg3EstlamCheck.Checked == false && CompanyCheck.Checked == false)
                    {
                        if (MessageBox.Show(" لم يتم تحديد أي صلاحيات لهذا المستخدم . هل تريد الاستمرار ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }


                    DataTable dt1 = FillUsersDataTable();

                    DBConnected db1 = new DBConnected();

                    db1.cmd.Connection = DBConnected.sqlcon;
                    db1.cmd.CommandType = CommandType.StoredProcedure;
                    db1.cmd.CommandText = "Users_Insert";

                    db1.cmd.Parameters.AddWithValue("@name", NameTXT.Text);
                    db1.cmd.Parameters.AddWithValue("@username", UserNameTXT.Text);
                    db1.cmd.Parameters.AddWithValue("@userpassword", PasswordTXT.Text);
                    db1.cmd.Parameters.AddWithValue("@peritems", ItemsCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@percustomers", CustCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@pervendors", VendorsCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@perusers", UsersCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@perbill", BillCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@pereznsrf", EznsfrCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@pereznestlam", EznestlamCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@perupdate", UpdateCheckBox.Checked);
                    db1.cmd.Parameters.AddWithValue("@perezndf3mali", Df3maliCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@pereznestlammali", estlammaliCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@perdata", DataCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@perreports", ReportsCHKBOX.Checked);
                    db1.cmd.Parameters.AddWithValue("@permortg3bill", Mortg3BillChek.Checked);
                    db1.cmd.Parameters.AddWithValue("@permortg3estlam", Mortg3EstlamCheck.Checked);
                    db1.cmd.Parameters.AddWithValue("@percompanysetting", CompanyCheck.Checked);
                    db1.cmd.Parameters.AddWithValue("@usernameadd", Login.UserName);
                    db1.cmd.Parameters.AddWithValue("@UsersDataTable", dt1);


                    int r1 = db1.cmd.ExecuteNonQuery();
                    if (r1 > 0)
                    {
                        MessageBox.Show("تم تسجيل المستخدم بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validation.TextClear(this, panel5);
                        AllPerCHKBOX.Checked = false;
                        ItemsCHKBOX.Checked = false;
                        CustCHKBOX.Checked = false;
                        VendorsCHKBOX.Checked = false;
                        UsersCHKBOX.Checked = false;
                        BillCHKBOX.Checked = false;
                        EznsfrCHKBOX.Checked = false;
                        EznestlamCHKBOX.Checked = false;
                        UpdateCheckBox.Checked = false;
                        Df3maliCHKBOX.Checked = false;
                        estlammaliCHKBOX.Checked = false;
                        DataCHKBOX.Checked = false;
                        ReportsCHKBOX.Checked = false;
                        Mortg3BillChek.Checked = false;
                        Mortg3EstlamCheck.Checked = false;
                        CompanyCheck.Checked = false;
                        AdminpasswordTXT.Text = "";
                        AllCompanyName.Text = "";
                        dataGridView1.Rows.Clear();
                    }

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات . برجاء التأكد من ادخال معلومات قاعدة البيانات بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable FillUsersDataTable()
        {

            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {

                
                dt.Columns.Add("companyname", typeof(string));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dr = dt.NewRow();

                   
                    dr["companyname"] = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    dt.Rows.Add(dr);

                }
                return dt;
            }

            else
            {
                return null;
            }
        }
        //===================================================================
        //===================================================================
        //===================================================================


        private void NewUserFrm_Load(object sender, EventArgs e)
        {
            try
            {
                NameTXT.Select();
                Login.SearchState = false;
            }
            catch { }
        }

        private void NameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(NameTXT, "");
        }

        private void UserNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(UserNameTXT , "");
        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(PasswordTXT , "");
        }

        private void Password2TXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(Password2TXT , "");
        }

        private void AdminNameTXT_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(AdminpasswordTXT  , "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Login.SettingFromMain != true)
            {
                MessageBox.Show("برجاء تسجيل الدخول لامكانية عرض بيانات المستخدمين","",MessageBoxButtons .OK , MessageBoxIcon .Information  );
                return;
            }
            
            SearchUsersFrm frm = new SearchUsersFrm();
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
         
        }

        private void AllPerCHKBOX_CheckedChanged(object sender, EventArgs e)
        {
            // اذا قمت بتحديد الكل جميع التشيك بوكس هيتعلم عليه ، والعكس
            if (AllPerCHKBOX.Checked == true)
            {
                ItemsCHKBOX.Checked = true;
                CustCHKBOX.Checked = true;
                VendorsCHKBOX.Checked = true;
                UsersCHKBOX.Checked = true;
                BillCHKBOX.Checked = true;
                EznsfrCHKBOX.Checked = true;
                EznestlamCHKBOX.Checked = true;
                UpdateCheckBox.Checked = true;
                Df3maliCHKBOX.Checked = true;
                estlammaliCHKBOX.Checked = true;
                DataCHKBOX.Checked = true;
                ReportsCHKBOX.Checked = true;
                Mortg3BillChek.Checked = true;
                Mortg3EstlamCheck.Checked = true;
                CompanyCheck.Checked = true;
            }
            else 
            {
                ItemsCHKBOX.Checked = false ;
                CustCHKBOX.Checked = false;
                VendorsCHKBOX.Checked = false;
                UsersCHKBOX.Checked = false;
                BillCHKBOX.Checked = false;
                EznsfrCHKBOX.Checked = false;
                EznestlamCHKBOX.Checked = false;
                UpdateCheckBox.Checked = false ;
                Df3maliCHKBOX.Checked = false;
                estlammaliCHKBOX.Checked = false;
                DataCHKBOX.Checked = false;
                ReportsCHKBOX.Checked = false;
                Mortg3BillChek.Checked =false ;
                Mortg3EstlamCheck.Checked = false ;
                CompanyCheck.Checked = false ;
            }
        }

        public  void button6_Click_3(object sender, EventArgs e)
        {
            Validation.TextClear(this, panel5);
           
            AllPerCHKBOX.Checked = false;
            ItemsCHKBOX.Checked = false;
            CustCHKBOX.Checked = false;
            VendorsCHKBOX.Checked = false;
            UsersCHKBOX.Checked = false;
            BillCHKBOX.Checked = false;
            EznsfrCHKBOX.Checked = false;
            EznestlamCHKBOX.Checked = false;
            UpdateCheckBox.Checked = false;
            Df3maliCHKBOX.Checked = false;
            estlammaliCHKBOX.Checked = false;
            DataCHKBOX.Checked = false;
            ReportsCHKBOX.Checked = false;
            Mortg3BillChek.Checked = false;
            Mortg3EstlamCheck.Checked = false;
            CompanyCheck.Checked = false;

            AddBy_lbl.Visible = false;
            useradd_lbl.Visible = false;
            UserNameTXT.Enabled = true;
            Login.SearchState = false;

            AllCompanyName.Text = "";
            dataGridView1.Rows.Clear();
            AdminpasswordTXT.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // عشان لو دوست ع تعديل قبل ما ابحث عن مستخدم
            if (Login.SearchState == false)
            {
                MessageBox.Show("اختر المستخدم الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }
            

            if (MessageBox.Show( UserNameTXT .Text + " " + "هل تريد بالتأكيد تعديل بيانات"  , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                // التأكد من وجود جميع البيانات 
                if (NameTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(NameTXT, "يجب ادخال الاسم");
                    NameTXT.Focus();
                    return;
                }

                if (UserNameTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(UserNameTXT, "يجب ادخال اسم المستخدم");
                    UserNameTXT.Focus();
                    return;
                }

                if (PasswordTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(PasswordTXT, "يجب ادخال كلمة المرور");
                    PasswordTXT.Focus();
                    return;
                }

                if (Password2TXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(Password2TXT, "يجب اعادة ادخال كلمة المرور");
                    PasswordTXT.Focus();
                    return;
                }

                if (PasswordTXT.Text != Password2TXT.Text)
                {
                    errorProvider1.SetError(Password2TXT, "كلمة المرور غير متطابقة");
                    Password2TXT.Focus();
                    return;
                }


                if (AdminpasswordTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(AdminpasswordTXT, "يجب ادخال كلمة مرور المستخدم الحالي");
                    AdminpasswordTXT.Focus();
                    return;
                }


                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("users_checklogin",
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName.ToString()),
                    new RetriveData.prameter("@password", SqlDbType.NVarChar, AdminpasswordTXT.Text));
                if (dt.Rows.Count == 0)
                {
                    errorProvider1.SetError(AdminpasswordTXT, "كلمة مرور المستخدم الحالي غير صحيحة");
                    return;
                }

                if (AllPerCHKBOX.Checked == false && CustCHKBOX.Checked == false && UsersCHKBOX.Checked == false
                    && VendorsCHKBOX.Checked == false && ItemsCHKBOX.Checked == false &&
                    BillCHKBOX.Checked == false && EznsfrCHKBOX.Checked == false &&
                    EznestlamCHKBOX.Checked == false && UpdateCheckBox.Checked == false &&
                     Df3maliCHKBOX.Checked == false && estlammaliCHKBOX.Checked == false
                     && DataCHKBOX.Checked == false && ReportsCHKBOX.Checked == false && 
                     Mortg3BillChek.Checked ==false  && Mortg3EstlamCheck.Checked ==false 
                     &&CompanyCheck.Checked == false )
                {
                    if (MessageBox.Show(" لم يتم تحديد أي صلاحيات لهذا المستخدم . هل تريد الاستمرار ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }


                DataTable dt1 = FillUsersDataTable();

                DBConnected db1 = new DBConnected();

                db1.cmd.Connection = DBConnected.sqlcon;
                db1.cmd.CommandType = CommandType.StoredProcedure;
                db1.cmd.CommandText = "users_update";

                db1.cmd.Parameters.AddWithValue("@name", NameTXT.Text);
                db1.cmd.Parameters.AddWithValue("@username", UserNameTXT.Text);
                db1.cmd.Parameters.AddWithValue("@password", PasswordTXT.Text);
                db1.cmd.Parameters.AddWithValue("@peritems", ItemsCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@percustomers", CustCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@pervendors", VendorsCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@perusers", UsersCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@perbill", BillCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@pereznsrf", EznsfrCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@pereznestlam", EznestlamCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@perupdate", UpdateCheckBox.Checked);
                db1.cmd.Parameters.AddWithValue("@df3mali", Df3maliCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@estlammail", estlammaliCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@perdata", DataCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@perreports", ReportsCHKBOX.Checked);
                db1.cmd.Parameters.AddWithValue("@permortg3bill", Mortg3BillChek.Checked);
                db1.cmd.Parameters.AddWithValue("@permortg3estlam", Mortg3EstlamCheck.Checked);
                db1.cmd.Parameters.AddWithValue("@percompanysetting", CompanyCheck.Checked);
                db1.cmd.Parameters.AddWithValue("@usernameadd", Login.UserName);
                db1.cmd.Parameters.AddWithValue("@UsersDataTable", dt1);
              
                
                string x = UserNameTXT.Text;


                int r1 = db1.cmd.ExecuteNonQuery();
                if (r1 > 0)
                {
                    MessageBox.Show("بنجاح" + " " + UserNameTXT.Text + " " + "تم تعديل بيانات  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validation.TextClear(this, panel5);
                    AllPerCHKBOX.Checked = false;
                    ItemsCHKBOX.Checked = false;
                    CustCHKBOX.Checked = false;
                    VendorsCHKBOX.Checked = false;
                    UsersCHKBOX.Checked = false;
                    BillCHKBOX.Checked = false;
                    EznsfrCHKBOX.Checked = false;
                    EznestlamCHKBOX.Checked = false;
                    UpdateCheckBox.Checked = false;
                    Df3maliCHKBOX.Checked = false;
                    estlammaliCHKBOX.Checked = false;
                    DataCHKBOX.Checked = false;
                    ReportsCHKBOX.Checked = false;
                    Mortg3BillChek.Checked = false;
                    Mortg3EstlamCheck.Checked = false;
                    CompanyCheck.Checked = false;
                    AdminpasswordTXT.Text = "";
                    AllCompanyName.Text = "";
                    dataGridView1.Rows.Clear();
                }


                
                else
                {
                      MessageBox.Show("فشل تعديل بيانات المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                  
                if (Login.UserName.ToLower () == x.ToLower())
                {
                    MessageBox.Show("سيتم تسجيل الخروج من البرنامج . لأنك عدلت بيانات المستخدم الحالي . اعد تسجيل الدخول مرة أخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginFrm frm = new LoginFrm();
                    frm.Show();
                    this.Close();
                }
            }

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع حذف قبل ما ابحث عن مستخدم
            if (Login.SearchState == false)
            {
                MessageBox.Show("اختر المستخدم الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (MessageBox.Show(UserNameTXT.Text + " " + "هل تريد بالتأكيد حذف بيانات", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                if (AdminpasswordTXT.Text.Trim() == "")
                {
                    errorProvider1.SetError(AdminpasswordTXT, "يجب ادخال كلمة مرور المستخدم الحالي");
                    AdminpasswordTXT.Focus();
                    return;
                }


                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("users_checklogin",
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName.ToString()),
                    new RetriveData.prameter("@password", SqlDbType.NVarChar, AdminpasswordTXT.Text));
                if (dt.Rows.Count == 0)
                {
                    errorProvider1.SetError(AdminpasswordTXT, "كلمة مرور المستخدم الحالي غير صحيحة");
                    return;
                }

                DataTable dt2 = new DataTable();
                dt2 = RetriveData.ExecuteQuery("users_selectall");
                if (dt2.Rows.Count == 1)
                {
                    MessageBox.Show("لا يمكنك حذف هذا المستخدم لأنه المستخدم الوحيد حاليا للبرنامج . يمكنك تسجيل مستخدم جديد واعادة محاولة حذف هذا المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                RetriveData.ExecuteNonQuery("users_delete",
                    new RetriveData.prameter("@username", SqlDbType.NVarChar , UserNameTXT.Text));

                string x = UserNameTXT.Text;


                MessageBox.Show("بنجاح" + " " + UserNameTXT.Text + " " + "تم حذف بيانات  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Validation.TextClear(this, panel5);
                AllPerCHKBOX.Checked = false;
                ItemsCHKBOX.Checked = false;
                CustCHKBOX.Checked = false;
                VendorsCHKBOX.Checked = false;
                UsersCHKBOX.Checked = false;
                BillCHKBOX.Checked = false;
                EznsfrCHKBOX.Checked = false;
                EznestlamCHKBOX.Checked = false;
                UpdateCheckBox.Checked = false;
                Df3maliCHKBOX.Checked = false;
                estlammaliCHKBOX.Checked = false;
                DataCHKBOX.Checked = false;
                ReportsCHKBOX.Checked = false;
                Mortg3BillChek.Checked = false;
                Mortg3EstlamCheck.Checked = false;
                CompanyCheck.Checked = false;
                Login.SearchState = false;

                AllCompanyName.Text = "";
                dataGridView1.Rows.Clear();
                AdminpasswordTXT.Text = "";

                if (Login.UserName == x)
                {
                    MessageBox.Show("سيتم تسجيل الخروج من البرنامج . لأنك حذفت بيانات المستخدم الحالي . اعد تسجيل الدخول مرة أخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginFrm frm = new LoginFrm();
                    frm.Show();
                    this.Close();
                }
            }
        }

        private void NameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                UserNameTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                PasswordTXT.Select();
            }

        }

        private void UserNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down )
            {
                PasswordTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Password2TXT.Select();
            }
            else if (e.KeyCode == Keys.Right )
            {
                NameTXT.Select();
            }

        }

        private void PasswordTXT_KeyUp(object sender, KeyEventArgs e)
        {
          
            
        }

        private void Password2TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                groupBox1.Select();
            }
            else if (e.KeyCode == Keys.Right )
            {
                PasswordTXT.Select();
            }
            else if (e.KeyCode == Keys.Up )
            {
                UserNameTXT.Select();
            }
        }

        private void AdminpasswordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void AdminpasswordTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Password2TXT.Select();
            }

        }

        private void PasswordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PasswordTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                Password2TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                NameTXT.Select();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (AllCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("برجاء اختيار تحديد الشركات من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AllCompanyName.Select();
                return;
            }

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("SelectCompany_ByCompanyName",
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, AllCompanyName.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("برجاء ادخال اسم الشركة بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AllCompanyName.Select();
                return;
            }


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (AllCompanyName.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("تمت اضافة هذه الشركة بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DataGridViewRow drow = new DataGridViewRow();

            DataGridViewButtonCell dcell0 = new DataGridViewButtonCell();
            DataGridViewTextBoxCell dcell1 = new DataGridViewTextBoxCell();
            drow.Cells.Add(dcell0);
            drow.Cells.Add(dcell1);

            drow.Cells[0].Value = "حـذف";
            drow.Cells[1].Value = AllCompanyName.Text;

            dataGridView1.Rows.Add(drow);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void AllCompanyName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("Company_SelectAll");
            AllCompanyName.DataSource = dt;
            AllCompanyName.DisplayMember = "CompanyName";
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
        }

        private void AllCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
