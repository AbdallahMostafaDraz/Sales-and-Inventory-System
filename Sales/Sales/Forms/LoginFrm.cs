using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Classes;

namespace Sales01.Forms
{

    public partial class LoginFrm : Form, ISound
    {


        private SoundPlayer soundPlayer = new SoundPlayer();
        public void StopSound()
        {
            soundPlayer.Stop();
        }
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DBConnected db = new DBConnected();
                }
                catch (Exception)
                {
                    MessageBox.Show("خطأ في الاتصال بقاعدة البيانات . برجاء التأكد من ادخال معلومات قاعدة البيانات بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Login.SettingFromLogin = true;
                Login.SettingFromMain = false;
            }
            catch { }
          
       }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (UserNameTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(UserNameTXT, "برجاء ادخال اسم المستخدم");
                UserNameTXT.Focus();
                return;
            }

            if (PasswordTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(PasswordTXT, "برجاء ادخال كلمة المرور");
                PasswordTXT.Focus();
                return;
            }

            try
            {
                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("users_checklogin",
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, UserNameTXT.Text),
                    new RetriveData.prameter("@password", SqlDbType.NVarChar, PasswordTXT.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة . برجاء التأكد من صحة البيانات واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTXT.Select();
                }
                else
                {
                    Login.UserName = UserNameTXT.Text;
                    Login.AdminUserName = UserNameTXT.Text;
                    MainFrm frm = new MainFrm();

                    frm.Show();
                    this.Hide();
                    Login.CompanySelected = "";
                }
            }
            catch (Exception)
            { MessageBox.Show("خطأ في الاتصال بقاعدة البيانات . برجاء التأكد من ادخال معلومات قاعدة البيانات بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void UserNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(UserNameTXT, "");
        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(PasswordTXT , "");
         }

        private void UserNameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down | e.KeyCode == Keys.Up)
            {
                PasswordTXT.Select();
             
            }
        }

        private void PasswordTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                button1.Select();    
            }
            else if (e.KeyCode == Keys.Up)
            {
                UserNameTXT.Select();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackupFrm frm = new BackupFrm();
            frm.ShowDialog();

            Login.SettingFromLogin = true;
            Login.SettingFromMain = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NewUserFrm frm = new NewUserFrm();
            frm.ShowDialog();
            frm.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد الخروج من البرنامج ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
                
            }
        }

        private void UserNameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            StopSound();
        }
    }
}
