using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Sales.Classes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
namespace Sales01.Forms
{
    public partial class RP_MrkzMaliFrm : Form
    {
        public RP_MrkzMaliFrm()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            foreach (Control M in this.Controls)
            {
                if (M is Panel)
                {
                    foreach (Control S in M.Controls )
                    {
                        if (S is GroupBox)
                        {
                            foreach (Control Si in S.Controls)
                            {
                                if (Si is TextBox)
                                {
                                    if (Si.Text.Trim() == "")
                                    {
                                        MessageBox.Show("برجاء ادخال جميع البيانات . لامكانية عرض التقرير","",MessageBoxButtons .OK , MessageBoxIcon .Warning );
                                        return;
                                    }
                                }
                            }
                        
                        }
                    }
                }
            }

            RetriveData.ExecuteNonQuery("MrkzMali_Insert",
                new RetriveData.prameter("@m1", SqlDbType.Decimal, decimal.Parse(M1_TXT.Text)),
                new RetriveData.prameter("@m2", SqlDbType.Decimal, decimal.Parse(M2_TXT.Text)),
                new RetriveData.prameter("@m3", SqlDbType.Decimal, decimal.Parse(M3_TXT.Text)),
                new RetriveData.prameter("@m4", SqlDbType.Decimal, decimal.Parse(M4_TXT.Text)),
                new RetriveData.prameter("@m5", SqlDbType.Decimal, decimal.Parse(M5_TXT.Text)),
                new RetriveData.prameter("@m6", SqlDbType.Decimal, decimal.Parse(M6_TXT.Text)),
                new RetriveData.prameter("@m7", SqlDbType.Decimal, decimal.Parse(M7_TXT.Text)),
                new RetriveData.prameter("@m8", SqlDbType.Decimal, decimal.Parse(M8_TXT.Text)),
                new RetriveData.prameter("@m9", SqlDbType.Decimal, decimal.Parse(M9_TXT.Text)),
                new RetriveData.prameter("@m10", SqlDbType.Decimal, decimal.Parse(M10_TXT.Text)),
                new RetriveData.prameter("@m11", SqlDbType.Decimal, decimal.Parse(M11_TXT.Text)),
                new RetriveData.prameter("@m12", SqlDbType.Decimal, decimal.Parse(M12_TXT.Text)),
                new RetriveData.prameter("@m13", SqlDbType.Decimal, decimal.Parse(M13_TXT.Text)),
                new RetriveData.prameter("@m14", SqlDbType.Decimal, decimal.Parse(M14_TXT.Text)),
                new RetriveData.prameter("@m15", SqlDbType.Decimal, decimal.Parse(M15_TXT.Text)));

                Sales.Forms.ShowReportFrm2 frm = new Sales.Forms.ShowReportFrm2();
                Sales.Reports.RP_OtherReports.RP_MRKZMALI rp = new Sales.Reports.RP_OtherReports.RP_MRKZMALI();
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pCompanyname = new ParameterField();
                pCompanyname.Name = "@companyname";
                ParameterDiscreteValue Valcompanyname = new ParameterDiscreteValue();
                Valcompanyname.Value = Login.CompanySelected;
                pCompanyname.CurrentValues.Clear();
                pCompanyname.CurrentValues.Add(Valcompanyname);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCompanyname);

                rp.Refresh();
                frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void M1_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M1_TXT, e);
        }

        private void M2_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M2_TXT, e);
        }

        private void M3_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M3_TXT, e);
        }

        private void M4_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M4_TXT, e);
        }

        private void M5_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M5_TXT, e);
        }

        private void M6_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M6_TXT, e);
        }

        private void M7_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M7_TXT, e);
        }

        private void M8_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M8_TXT, e);
        }

        private void M9_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M9_TXT, e);
        }

        private void M10_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M10_TXT, e);
        }

        private void M11_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M11_TXT, e);
        }

        private void M12_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M12_TXT, e);
        }

        private void M13_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M13_TXT, e);
        }

        private void M14_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M14_TXT, e);
        }

        private void M15_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(M15_TXT, e);
        }

        private void M15_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M1_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M8_TXT.Select();
            }

        }

        private void M1_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M2_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M15_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M9_TXT.Select();
            }
        }

        private void M2_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M3_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M1_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M10_TXT.Select();
            }

        }

        private void M3_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M4_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M2_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M11_TXT.Select();
            }
        }

        private void M4_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M5_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M3_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M12_TXT.Select();
            }
        }

        private void M5_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M6_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M4_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M13_TXT.Select();
            }
        }

        private void M6_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M7_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M5_TXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                M14_TXT.Select();
            }
        }

        private void M7_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M8_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M6_TXT.Select();
            }
        }

        private void M8_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left )
            {
                M9_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up  )
            {
                M7_TXT.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                M15_TXT.Select();
            }
        }

        private void M9_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M10_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M14_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M8_TXT.Select();
            }
        }

        private void M10_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M11_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M9_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M2_TXT.Select();
            }
        }

        private void M11_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M12_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M10_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M3_TXT.Select();
            }
        }

        private void M12_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M13_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M11_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M4_TXT.Select();
            }
        }

        private void M13_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                M14_TXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M12_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M5_TXT.Select();
            }

        }

        private void M14_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                M13_TXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                M6_TXT.Select();
            }
        }

        private void RP_MrkzMaliFrm_Load(object sender, EventArgs e)
        {
            try
            {
                M15_TXT.Select();
            }
            catch { }

        }
                
    }
}
