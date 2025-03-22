using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using Sales.Classes;
using Sales.Forms;

using Microsoft.VisualBasic;
 
namespace Sales01.Forms
{
    public partial class MainFrm : Form
    {
        private const int TIMER_INTERVAL = 2000;
        private const int PROGRESS_BAR_MAX = 1000000;
        private int prayerTextIndex = 0;
        private readonly string[] prayerTexts = new string[]
        {
                "ســــــــــــبــــــــحـــــــــان الــــــــــــــلـــــــــــــه",
                "الـــــــــــحــــــــــمـــــــــــد لـــــــــــــلـــــــــــــه",
                "الـــــــــــــــــــلــــــــــــــــــه أكــــــــــــبــــــــــــر",
                "لا الــــــــــــــــــه الا الـــــــــــــــــــلـــــــــــــــــه",
                "لا حــــــــــول ولا قـــــــــوة الا بــــــالـــــــلـــــــه",
                "ســـبــــحــــان الـــــــــلـــــــــه وبـــــحـــــمــــده",
                "ســــــبـــــحــــان الــــــــلـــــــه الـــعـــظـــيــــم",
                "لا الــــه الا الــــــلــــــه وحـــده لا شــريــك لـــه",
                "لـه الـمـلك ولـه الـحمـد وهـو على كـل شئ قـديـر"
        };

        public MainFrm()
        {
            InitializeComponent();
        }

        #region Form Event Handlers

        private void MainFrm_Load(object sender, EventArgs e)
        {
            InitializeLoginSettings();
            UpdateUserNameLabel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabels();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdatePrayerText();
        }

        #endregion

        #region Menu Item Click Handlers

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFormWithPermissionCheck<NewUserFrm>("check_users_permission");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ValidateCompanySelection())
            {
                OpenFormWithPermissionCheck<VendorsFrm>("check_vendors_permission");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ValidateCompanySelection())
            {
                OpenFormWithPermissionCheck<CustomersFrm>("check_customers_permission");
            }
        }

        // Similar pattern for other menu items...

        #endregion

        #region Company Management

        private void button1_Click(object sender, EventArgs e)
        {
            HandleCompanySelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleAddNewCompany();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleUpdateCompanyName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleDeleteCompany();
        }

        #endregion

        #region Private Helper Methods

        private void InitializeLoginSettings()
        {
            Login.SettingFromMain = true;
            Login.SettingFromLogin = false;
        }

        private void UpdateUserNameLabel()
        {
            label13.Text = Login.UserName;
        }

        private void UpdateDateTimeLabels()
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToShortDateString();
        }

        private void UpdatePrayerText()
        {
            timer2.Interval = TIMER_INTERVAL;
            prayerTextIndex = (prayerTextIndex + 1) % prayerTexts.Length;
            label3.Text = prayerTexts[prayerTextIndex];
        }

        private bool ValidateCompanySelection()
        {
            if (string.IsNullOrEmpty(Login.CompanySelected))
            {
                MessageBox.Show("برجاء اختيار شركة من قائمة الشركات الحالية", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void OpenFormWithPermissionCheck<T>(string permissionProcedure) where T : Form, new()
        {
            var form = new T();
            CheckFormPermissionAndOpen(permissionProcedure, form);
        }

        private void CheckFormPermissionAndOpen(string procedureName, Form form)
        {
            var dt = RetriveData.ExecuteQuery(procedureName,
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName));

            if (dt.Rows.Count > 0)
            {
                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("عفوا ليس لديك صلاحية الدخول لهذه الشاشة", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandleCompanySelection()
        {
            if (!ValidateCompanyComboBox())
                return;

            if (!ValidateCompanyExists())
                return;

            if (!ValidateUserCompanyAccess())
                return;

            ShowProgressAndUpdateCompany();
        }

        private bool ValidateCompanyComboBox()
        {
            if (string.IsNullOrEmpty(AllCompanyCombo.Text))
            {
                errorProvider1.SetError(AllCompanyCombo, "برجاء اختيار شركة من القائمة");
                panel7.Visible = false;
                return false;
            }
            return true;
        }

        private bool ValidateCompanyExists()
        {
            var dt = RetriveData.ExecuteQuery("SelectCompany_ByCompanyName",
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, AllCompanyCombo.Text));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("برجاء ادخال اسم الشركة بشكل صحيح", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AllCompanyCombo.Select();
                panel7.Visible = false;
                return false;
            }
            return true;
        }

        private bool ValidateUserCompanyAccess()
        {
            var dt = RetriveData.ExecuteQuery("Check_User_Company",
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, AllCompanyCombo.Text));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("عفوا ليس لديك صلاحية الدخول لهذه الشركة", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel7.Visible = false;
                return false;
            }
            return true;
        }

        private void ShowProgressAndUpdateCompany()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = PROGRESS_BAR_MAX;
            progressBar1.Step = 1;

            for (int j = 0; j < PROGRESS_BAR_MAX; j++)
            {
                progressBar1.Value = 1 + j;
            }

            progressBar1.Visible = false;
            label7.Visible = true;
            panel7.Visible = true;

            Login.CompanySelected = AllCompanyCombo.Text;
            label8.Text = AllCompanyCombo.Text;
        }

        #endregion
    }
}
