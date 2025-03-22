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
    public partial class CustomersFrm : Form
    {
        public CustomersFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.CustomersSearchState  = false;
            Validation.TextClear(this, panel1);
            Validation.TextClear(this, panel4);
            CustCodeTXT.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Login.CustomersSearchState == true)
            {
                if (MessageBox.Show("هذا العميل موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل عميل اخر ؟", "حــفــظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button1_Click(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }

            if (CustCodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CustCodeTXT, "يجب تسجيل كود العميل !");
                return;
            }

            if (CustNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CustNameTXT, "يجب تسجيل اسم العميل !");
                return;
            }

            RetriveData.ExecuteNonQuery("customers_insert",
                new RetriveData.prameter("@custcode", SqlDbType.Int,int.Parse (CustCodeTXT.Text)),
                new RetriveData.prameter("@custname", SqlDbType.NVarChar, CustNameTXT.Text),
                new RetriveData.prameter("@custmob", SqlDbType.NVarChar , CustMobTXT.Text),
                new RetriveData.prameter("@custnotes", SqlDbType.NVarChar, CustNotesTXT.Text),
                new RetriveData.prameter("@custdebit", SqlDbType.Decimal,0),
                new RetriveData.prameter("@custcredit", SqlDbType.Decimal, 0),
                new RetriveData.prameter("@custbalance", SqlDbType.Decimal, 0),
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (RetriveData.saved == true)
            {
                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("تم تسجيل عميل اخر بنفس الكود مسبقا . برجاء التأكد من الكود واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCustomersFrm frm = new SearchCustomersFrm();
            frm.ShowDialog();
        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Login.SearchState = false;
            }
            catch { }
        }
        //==========================================================
        //لعرض البيانات من شاشة البحث في شاشة المستخدمين
        public int CustID;
        public void Find_Customer(int CustCodeSearch)
        {

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("customers_selectbycode",
                new RetriveData.prameter("@custcode", SqlDbType.Int, CustCodeSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["CustomersFrm"] as CustomersFrm;
            y.CustCodeTXT.Text = dt.Rows[0]["CustCode"].ToString();
            y.CustNameTXT.Text = dt.Rows[0]["CustName"].ToString();
            y.CustMobTXT.Text = dt.Rows[0]["CustMob"].ToString();
            y.CustNotesTXT.Text = dt.Rows[0]["CustNotes"].ToString();
            y.CustDebitTXT.Text = dt.Rows[0]["CustDebit"].ToString();
            y.CustCreditTXT.Text = dt.Rows[0]["CustCredit"].ToString();
            y.CustBalanceTXT.Text = (decimal.Parse(y.CustCreditTXT.Text) - decimal.Parse(y.CustDebitTXT.Text)).ToString ();
            y.CustID = int.Parse (dt.Rows[0]["CustID"].ToString());
            Login.CustomersSearchState = true;

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع تعديل قبل ما ابحث عن عميل
            if (Login.CustomersSearchState == false)
            {
                MessageBox.Show("اختر العميل الذي تريد تعديل بياناته من شاشة البحث أولا", "تــعــديــل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (CustCodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CustCodeTXT, "يجب تسجيل كود العميل !");
                return;
            }

            if (CustNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(CustNameTXT, "يجب تسجيل اسم العميل !");
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا العميل ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("customers_update",
                    new RetriveData.prameter("@CustID", SqlDbType.Int, CustID),
                    new RetriveData.prameter("@CustCode", SqlDbType.Int, int.Parse(CustCodeTXT.Text)),
                    new RetriveData.prameter("@CustName", SqlDbType.NVarChar, CustNameTXT.Text),
                    new RetriveData.prameter("@CustMob", SqlDbType.NVarChar, CustMobTXT.Text),
                    new RetriveData.prameter("@CustNotes", SqlDbType.NVarChar, CustNotesTXT.Text),
                    new RetriveData.prameter("@CustDebit", SqlDbType.Decimal, decimal.Parse(CustDebitTXT.Text)),
                    new RetriveData.prameter("@CustCredit", SqlDbType.Decimal, decimal.Parse(CustCreditTXT.Text)),
                    new RetriveData.prameter("@CustBalance", SqlDbType.Decimal, decimal.Parse(CustBalanceTXT.Text)),
                    new RetriveData.prameter("@UserName", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم تعديل بيانات " + " " + CustNameTXT.Text + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1_Click(null, null);
                    Login.CustomersSearchState = false;
                }
                else
                {
                    MessageBox.Show("لا يمكنك تعديل كود هذا العميل للكود الذي أدخلته . حيث يوجد عميل اخر مسجل بنفس الكود ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع حذف قبل ما ابحث عن عميل
            if (Login.CustomersSearchState == false)
            {
                MessageBox.Show("اختر العميل الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات هذا العميل ؟", "", MessageBoxButtons.YesNo , MessageBoxIcon .Question ) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("customers_delete",
                    new RetriveData.prameter("@custid", SqlDbType.Int, CustID),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم حذف بيانات العميل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1_Click(null, null);
                    Login.CustomersSearchState = false;
                }
                else
                {
                    MessageBox.Show("فشل حذف العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void CustCodeTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CustCodeTXT, "");
        }

        private void CustNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CustNameTXT, "");
        }

        private void CustCodeTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CustNameTXT . Select();
            }

            Validation.NumbersOnly(e);
        }

        private void CustMobTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void CustCodeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                CustNameTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CustNotesTXT.Select();
            }
        }

        private void CustNameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CustNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                CustMobTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CustCodeTXT.Select();
            }
        }

        private void CustMobTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                CustNotesTXT .  Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CustNameTXT . Select();
            }
        }

        private void CustNotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveBTN.Select();
            }
            else  if (e.KeyCode == Keys.Up)
            {
                CustMobTXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                CustCodeTXT.Select();
            }
        }

        private void CustCreditTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustDebitTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustBalanceTXT_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
