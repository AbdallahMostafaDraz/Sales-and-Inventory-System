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

namespace Sales01.Forms
{
    public partial class VendorsFrm : Form
    {
        public VendorsFrm()
        {
            InitializeComponent();
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Validation.TextClear(this, panel1);
            Validation.TextClear(this, panel4);
            Login.VendorsSearchState = false;

        }

        private void VenCodeTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(VenCodeTXT, "");
        }

        private void VenNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(VenNameTXT, "");
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            
            if (Login.VendorsSearchState  == true)
            {
                if (MessageBox.Show("هذا المورد موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل مورد اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewBTN_Click(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }
            //===========================================

            if (VenCodeTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(VenCodeTXT, "يجب تسجيل كود المورد ");
                VenCodeTXT.Select();
                return;
            }

            if (VenNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(VenNameTXT, "يجب تسجيل اسم المورد ");
                VenNameTXT.Select(); 
                return;
            }

            //============================================

            RetriveData.ExecuteNonQuery("Vendors_insert",
                new RetriveData.prameter("@vencode", SqlDbType.Int, int.Parse(VenCodeTXT.Text)),
                new RetriveData.prameter("@venname", SqlDbType.NVarChar, VenNameTXT.Text),
                new RetriveData.prameter("@venmob", SqlDbType.NVarChar, VenMobTXT.Text),
                new RetriveData.prameter("@vennotes", SqlDbType.NVarChar, VenNotesTXT.Text),
                new RetriveData.prameter("@vendebit", SqlDbType.Decimal, 0),
                new RetriveData.prameter("@vencredit", SqlDbType.Decimal, 0),
                new RetriveData.prameter("@venbalance", SqlDbType.Decimal, 0),
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (RetriveData.saved == true)
            {
                NewBTN_Click(null, null);
            }
            else
            {
                MessageBox.Show("تم تسجيل مورد اخر بنفس الكود مسبقا . برجاء التأكد من الكود واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VenCodeTXT.Focus();
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            SearchVendors frm = new SearchVendors();
            frm.ShowDialog();
        }

        private void VendorsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Login.VendorsSearchState = false;
            }
            catch { }
        }

        // لعرض بيانات المورد من شاشة البحث في شاشة الموردين
        public int VenID;
        public void Find_Vendor(int VenCode)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("vendors_selectbycode",
                new RetriveData.prameter("@vencode", SqlDbType.Int, VenCode),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["VendorsFrm"] as VendorsFrm;
          
            y.VenCodeTXT.Text = dt.Rows[0]["VenCode"].ToString();
            y.VenNameTXT.Text = dt.Rows[0]["VenName"].ToString();
            y.VenMobTXT.Text = dt.Rows[0]["VenMob"].ToString();
            y.VenNotesTXT.Text = dt.Rows[0]["VenNotes"].ToString();
            y.VenDebitTXT.Text = dt.Rows[0]["VenDebit"].ToString();
            y.VenCreditTXT.Text = dt.Rows[0]["VenCredit"].ToString();
            y.VenBalanceTXT.Text = dt.Rows[0]["VenBalance"].ToString();
            y.VenID = int.Parse(dt.Rows[0]["VenID"].ToString());
            y.VenBalanceTXT.Text = (decimal.Parse(y.VenCreditTXT.Text) - decimal.Parse(y.VenDebitTXT.Text)).ToString(); 
            Login.VendorsSearchState = true;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void EdietBTN_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع تعديل قبل ما ابحث عن مورد
            if (Login.VendorsSearchState  == false)
            {
                MessageBox.Show("اختر المورد الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (VenCodeTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(VenCodeTXT , "يجب تسجيل كود المورد ");
                VenCodeTXT.Select();
                return;
            }

            if (VenNameTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(VenNameTXT , "يجب تسجيل اسم المورد ");
                VenNameTXT.Select();
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا المورد ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("vendors_update",
                    new RetriveData.prameter("@venid", SqlDbType.Int, VenID ),
                    new RetriveData.prameter("@VenCode", SqlDbType.Int, int.Parse(VenCodeTXT . Text)),
                    new RetriveData.prameter("@VenName", SqlDbType.NVarChar,VenNameTXT . Text),
                    new RetriveData.prameter("@VenMob", SqlDbType.NVarChar,VenMobTXT . Text),
                    new RetriveData.prameter("@VenNotes", SqlDbType.NVarChar,VenNotesTXT . Text),
                    new RetriveData.prameter("@VenDebit", SqlDbType.Decimal, decimal.Parse(VenDebitTXT . Text)),
                    new RetriveData.prameter("@VenCredit", SqlDbType.Decimal, decimal.Parse(VenCreditTXT . Text)),
                    new RetriveData.prameter("@VenBalance", SqlDbType.Decimal, decimal.Parse(VenBalanceTXT . Text)),
                    new RetriveData.prameter("@UserName", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم تعديل بيانات " + " " +VenNameTXT . Text + " " + "بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                    Login.VendorsSearchState  = false;
                }
                else
                {
                    MessageBox.Show("لا يمكنك تعديل كود هذا المورد للكود الذي أدخلته . حيث يوجد مورد اخر مسجل بنفس الكود ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            // عشان لو دوست ع حذف قبل ما ابحث عن عميل
            if (Login.VendorsSearchState  == false)
            {
                MessageBox.Show("اختر المورد الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }

            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات هذا المورد ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExecuteNonQuery("vendors_delete",
                    new RetriveData.prameter("@venid", SqlDbType.Int, VenID),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (RetriveData.saved == true)
                {
                    MessageBox.Show("تم حذف بيانات المورد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewBTN_Click(null, null);
                    Login.VendorsSearchState = false;
                }
                else
                {
                    MessageBox.Show("فشل حذف المورد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void VenCreditTXT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void VenDebitTXT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void VenCodeTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void VenMobTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void VenCodeTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                VenNameTXT.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                VenNotesTXT.Select();
            }
        }

        private void VenNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                VenMobTXT.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                VenCodeTXT.Select();
            }
        }

        private void VenMobTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                VenNotesTXT.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                VenNameTXT.Select();
            }
        }

        private void VenNotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                VenMobTXT.Select();
            }
        }
    }
}
