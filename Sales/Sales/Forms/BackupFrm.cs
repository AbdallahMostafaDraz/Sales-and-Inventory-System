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
using Sales.Classes ;
namespace Sales01.Forms
{
    public partial class BackupFrm : Form
    {
        public BackupFrm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
          
            panel4.Visible = false ;
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            if (BackupBATH.Text.Trim() == "")
            {
                MessageBox.Show("برجاء تحديد مسار حفظ النسخة الاحتياطية للبيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Select();
                return;
            }

            try
            {
                DBConnected db = new DBConnected();

                SqlCommand cmd = new SqlCommand("BACKUP DATABASE [Sales01] TO  DISK = N'" + BackupBATH.Text + "' WITH NOFORMAT, NOINIT,  NAME = N'Sales01-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", DBConnected.sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية النسخ الاحتياطي للبيانات بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackupBATH.Text = "";


            }
            catch (Exception )
            {
                MessageBox.Show("فشلت عملية النسخ الاحتياطي للبيانات . برجاء ادخال مسار حفظ صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "Sales01.bak";
            saveFileDialog1.Filter = "SQl Backup File|*.bak";
            saveFileDialog1.Title = "نسخ قاعدة البيانات";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BackupBATH.Text = saveFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Sales01.bak";
            openFileDialog1.Filter = "SQl Backup File|*.bak";
            openFileDialog1.Title = "استرجاع قاعدة البيانات";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveData.Text = openFileDialog1.FileName;
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
              if (SaveData.Text.Trim() == "")
              {
                  MessageBox.Show("برجاء تحديد نسخة البيانات التي تريد استرجاعها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  button2.Select();
                  return ;
              }

        try 
            {

                if (MessageBox.Show("سيتم استرجاع هذه النسخة من البيانات . سيؤدي ذلك لالغاء أي تعديلات تمت مؤخرا وتطبيق بيانات هذه النسخة . هل تريد بالتأكيد متابعة عملية الاسترجاع ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBConnected db = new DBConnected();

                    SqlCommand cmd = new SqlCommand("ALTER DATABASE Sales01 SET SINGLE_USER WITH ROLLBACK IMMEDIATE", DBConnected.sqlcon);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("use master", DBConnected.sqlcon);
                    cmd.ExecuteNonQuery();

                    //cmd = new SqlCommand("RESTORE DATABASE [Sales01] FROM DISK = '" + SaveData.Text + "' WITH Move 'Sales01' To 'E:\\Sales01\\DataBase\\Sales01.mdf' , Move 'Sales01_log' To 'E:\\Sales01\\DataBase\\Sales01.ldf' , REPLACE ,RECOVERY", DBConnected.sqlcon);
                    cmd = new SqlCommand("RESTORE DATABASE [Sales01] FROM DISK = '" + SaveData.Text + "' WITH RECOVERY ,REPLACE ,STATS = 10", DBConnected.sqlcon);
                    cmd.ExecuteNonQuery();


                    cmd = new SqlCommand("ALTER DATABASE Sales01 SET MULTI_USER WITH ROLLBACK IMMEDIATE", DBConnected.sqlcon);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("use sales01", DBConnected.sqlcon);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("تمت عملية الاسترجاع بنجاح . سيتم اعادة تشغيل البرنامج", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.Restart();
                    SaveData.Text = "";
                }
            }
            catch (Exception  )
        {
           
             MessageBox .Show ( "فشلت عملية الاسترجاع . برجاء ادخال المسار الصحيح لنسخة البيانات التي تريد استرجاعها","",MessageBoxButtons .OK , MessageBoxIcon.Error);
        }
        
    }

        private void BackupFrm_Load(object sender, EventArgs e)
        {
            try
            {
                button1.Select();
            }
            catch { }
        }

        
       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void تقاريرالمستخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
         
        }

        private void عـرضToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void عـرضToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void حركةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = false ;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Enabled = true;
                label4.Enabled = true;
                UserNameTXT.ReadOnly = false ;
                PasswordTXT.ReadOnly  = false ;
            }
            else
            {
                label3.Enabled = false ;
                label4.Enabled = false ;
               
                UserNameTXT.ReadOnly = true ;
                PasswordTXT.ReadOnly  = true  ;

            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Sales.Properties.Settings.Default.ServerName = SereveNameTXT.Text;
                Sales.Properties.Settings.Default.DatabaseName = DataBaseNameTXT.Text;
                Sales.Properties.Settings.Default.Mode = radioButton2.Checked == true ? "SQL" : "Windows";
                Sales.Properties.Settings.Default.UserName = UserNameTXT.Text;
                Sales.Properties.Settings.Default.Password = PasswordTXT.Text;
                Sales.Properties.Settings.Default.Save();
          try
          {
                DBConnected db = new DBConnected();
                db.OpenConn();
                MessageBox.Show("تم الاتصال بقاعدة البيانات بنجاح","",MessageBoxButtons .OK  , MessageBoxIcon.Information );
                MessageBox.Show("سيتم اعادة تشغيل البرنامج","",MessageBoxButtons .OK ,MessageBoxIcon.Information );
                Application.Exit();
                Application.Restart();
          
            }
            catch (Exception )
            {


                //Sales.Properties.Settings.Default.Reset();
                MessageBox.Show("فشل الاتصال بقاعدة البيانات . برجاء التأكد من ادخال المعلومات بشكل صحيح","",MessageBoxButtons .OK , MessageBoxIcon.Error );
                MessageBox.Show(Sales.Properties.Settings.Default.ServerName.ToString());
            }
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }

        private void تقاريرالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = true;
            SereveNameTXT.Text = Sales.Properties.Settings.Default.ServerName;
            DataBaseNameTXT.Text = Sales.Properties.Settings.Default.DatabaseName;
            if (Sales.Properties.Settings.Default.Mode == "SQL")
            {
                radioButton2.Checked = true;
                UserNameTXT.Text = Sales.Properties.Settings.Default.UserName;
                PasswordTXT.Text = Sales.Properties.Settings.Default.Password;
            }
            else
            {
                radioButton1.Checked = true;

            }

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = true;
            SereveNameTXT.Text = Sales.Properties.Settings.Default.ServerName;
            DataBaseNameTXT.Text = Sales.Properties.Settings.Default.DatabaseName;
            if (Sales.Properties.Settings.Default.Mode == "SQL")
            {
                radioButton2.Checked = true;
                UserNameTXT.Text = Sales.Properties.Settings.Default.UserName;
                PasswordTXT.Text = Sales.Properties.Settings.Default.Password;
            }
            else
            {
                radioButton1.Checked = true;

            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (Login.SettingFromMain == true)
            {
                panel1.Visible = false;
                panel4.Visible = true;
            }
            else
            {
                MessageBox.Show("برجاء تسجيل الدخول أولا حتى تستطيع الدخول لهذه الشاشة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (Login.SettingFromMain == true)
            {
                panel1.Visible = false;
                panel4.Visible = true;
            }
            else
            {
                MessageBox.Show("برجاء تسجيل الدخول أولا حتى تستطيع الدخول لهذه الشاشة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataBaseNameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("لا يمكنك التعديل في اسم قاعدة البيانات","",MessageBoxButtons .OK , MessageBoxIcon.Warning );
        }
    }
}

