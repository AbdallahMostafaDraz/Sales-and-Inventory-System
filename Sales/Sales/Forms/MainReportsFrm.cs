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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using Sales01.Forms;
namespace Sales.Forms
{
    public partial class MainReportsFrm : Form
    {
        public MainReportsFrm()
        {
            InitializeComponent();
        }

        private void تقاريرالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.ShowDialog();
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ShowReportFrm2  frm = new ShowReportFrm2 ();



            if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Select();
                return;
            }




            if (textBox5.Visible == true)
            {

                if (textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال كود العميل الذي تريد تقريره", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Select();
                    return;
                }


                dt = RetriveData.ExecuteQuery("customers_selectbycode",
                    new RetriveData.prameter("@custcode", SqlDbType.Int, int.Parse(textBox5.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد عملاء بهذا الكود . برجاء التأكد من كود العميل الذي تريد تقرير عنه والمحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Select();
                    return;
                }

                dt = RetriveData.ExecuteQuery("RP_CustTrans",
                    new RetriveData.prameter("@custcode", SqlDbType.Int, int.Parse(textBox5.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات لهذا العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }

           
      


            if (comboBox1.SelectedIndex == 0)
            {
               
                Sales.Reports.RP_AllCustTrans rp = new Reports.RP_AllCustTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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


            else if (comboBox1.SelectedIndex == 1)
            {

                if (D2.Value.Date < D1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dt = RetriveData.ExecuteQuery("RP_AllCustTransBetweenDate",
                    new RetriveData.prameter("@date1", SqlDbType.Date, D1.Value.Date.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, D2.Value.Date.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد حركات لأي عميل خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }




                Sales.Reports.RP_AllCustTransBetweenDate rp = new Reports.RP_AllCustTransBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource  = rp;
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
        
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                
                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                
                ValDate1.Value = D1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = D2.Value.ToString("yyyy-MM-dd");
              
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                
                
                ParameterField pCompanyname = new ParameterField();
                pCompanyname.Name = "@companyname";
                ParameterDiscreteValue Valcompanyname = new ParameterDiscreteValue();
                Valcompanyname.Value = Login.CompanySelected;
                pCompanyname.CurrentValues.Clear();
                pCompanyname.CurrentValues.Add(Valcompanyname);

                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCompanyname);

                
                rp.Refresh();
                frm.ShowDialog();
            }


            else  if (comboBox1.SelectedIndex == 2)
            {
                Reports.RP_CustTrans rp = new Reports.RP_CustTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pram = new ParameterField();
                pram.Name = "@custcode";
                ParameterDiscreteValue pValue = new ParameterDiscreteValue();
                pValue.Value = textBox5.Text;
                pram.CurrentValues.Clear();
                pram.CurrentValues.Add(pValue);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pram);


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

            else if (comboBox1.SelectedIndex == 3)
            {


                if (D2.Value.Date < D1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dt = RetriveData.ExecuteQuery("RP_CustTransBetweenDate",
                    new RetriveData.prameter("@custcode", SqlDbType.Int, int.Parse(textBox5.Text)),
                    new RetriveData.prameter("@date1", SqlDbType.Date, D1.Value.Date.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, D2.Value.Date.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد حركات لهذا العميل خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                
                
               
                
                
                Reports.RP_CustTransBetweenDate rpd = new Reports.RP_CustTransBetweenDate();
                rpd.DataSourceConnections[0].IntegratedSecurity = true;
                rpd.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rpd;

                ParameterField pramcode = new ParameterField();
                ParameterField pramd1 = new ParameterField();
                ParameterField pramd2 = new ParameterField();

                pramcode.Name = "@custcode";
                pramd1.Name = "@date1";
                pramd2.Name = "@date2";

                ParameterDiscreteValue pValueCode = new ParameterDiscreteValue();
                ParameterDiscreteValue pValueD1 = new ParameterDiscreteValue();
                ParameterDiscreteValue pValueD2 = new ParameterDiscreteValue();

                pValueCode.Value = textBox5.Text;
                pValueD1.Value = D1.Value.ToString("yyyy-MM-dd");
                pValueD2.Value = D2.Value.ToString("yyyy-MM-dd");

                pramcode.CurrentValues.Clear();
                pramcode.CurrentValues.Add(pValueCode);
                pramd1.CurrentValues.Clear();
                pramd1.CurrentValues.Add(pValueD1);
                pramd2.CurrentValues.Clear();
                pramd2.CurrentValues.Add(pValueD2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pramcode);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pramd1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pramd2);

                ParameterField pCompanyname = new ParameterField();
                pCompanyname.Name = "@companyname";
                ParameterDiscreteValue Valcompanyname = new ParameterDiscreteValue();
                Valcompanyname.Value = Login.CompanySelected;
                pCompanyname.CurrentValues.Clear();
                pCompanyname.CurrentValues.Add(Valcompanyname);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCompanyname);

                rpd.Refresh();
                frm.ShowDialog();


            }
            else
            {
                MessageBox.Show("برجاء ادخال اسم التقرير بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 1)
            {
                panel4.Visible = true;
                panel5.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                panel5.Visible = true;
                textBox5.Select();
                panel4.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                panel5.Visible = true;
                textBox5.Select();
                panel4.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                panel4.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                panel10.Visible = true;
                panel12.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                panel12.Visible = true;
                textBox1.Select();
                panel10.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                panel12.Visible = true;
                textBox1.Select();
                panel10.Visible = true;
            }
            else
            {
                panel12.Visible = false ;
                panel10.Visible = false ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            ShowReportFrm2 frm = new ShowReportFrm2();



            if (comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Select();
                return;
            }

            dt = RetriveData.ExecuteQuery("RP_AllVendorsTrans",
                new RetriveData .prameter ("@companyname", SqlDbType.NVarChar ,Login .CompanySelected  ));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد حركات لأي مورد لعرضها", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (comboBox2.SelectedIndex == 0)
            {
                Reports.RP_Vendors.RP_AllVendorsTrans rp = new Reports.RP_Vendors.RP_AllVendorsTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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


            else if (comboBox2.SelectedIndex == 1)
            {
                dt = RetriveData.ExecuteQuery("RP_AllVendorsTransBetweenDate",
                    new RetriveData.prameter("@date1", SqlDbType.Date, dateVen1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, dateVen2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات للموردين خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_Vendors.RP_AllVendorsBetweenDate rp = new Reports.RP_Vendors.RP_AllVendorsBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                ValDate1.Value = dateVen1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = dateVen2.Value.ToString("yyyy-MM-dd");
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);

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


            else if (comboBox2.SelectedIndex == 2)
            {

                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال كود المورد الذي تريد تقرير عنه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                dt = RetriveData.ExecuteQuery("RP_OneVendorTrans",
                    new RetriveData.prameter("@vencode", SqlDbType.Int, int.Parse(textBox1.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات لهذا المورد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_Vendors.RP_OneVendorTrans rp = new Reports.RP_Vendors.RP_OneVendorTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pram = new ParameterField();
                pram.Name = "@Vencode";
                ParameterDiscreteValue pValue = new ParameterDiscreteValue();
                pValue.Value = textBox1.Text;
                pram.CurrentValues.Clear();
                pram.CurrentValues.Add(pValue);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pram);

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



            else if (comboBox2.SelectedIndex == 3)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال كود المورد الذي تريد تقرير عنه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dateVen1.Value.Date > dateVen2.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt = RetriveData.ExecuteQuery("RP_OneVendorsBetweenDate",
                    new RetriveData.prameter("@vencode", SqlDbType.Int, int.Parse(textBox1.Text)),
                    new RetriveData.prameter("@date1", SqlDbType.Date, dateVen1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, dateVen2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات لهذا المورد خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Reports.RP_Vendors.RP_OneVendorsBetweenDate rp = new Reports.RP_Vendors.RP_OneVendorsBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pCode = new ParameterField();
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
                pCode.Name = "@VenCode";
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                ParameterDiscreteValue ValCode = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                ValCode.Value = textBox1.Text;
                ValDate1.Value = dateVen1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = dateVen2.Value.ToString("yyyy-MM-dd");
                pCode.CurrentValues.Clear();
                pCode.CurrentValues.Add(ValCode);
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCode);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);

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
            else
            {
                MessageBox.Show("برجاء ادخال اسم التقرير بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3 . SelectedIndex == 1)
            {
                panel16.Visible = true;
                panel18.Visible = false;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                panel18.Visible = true;
                TxtItems.Select();
                panel16.Visible = false;
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                panel18.Visible = true;
                TxtItems.Select();
                panel16 .Visible = true;
            }
            else
            {
                panel18.Visible = false;
                panel16 .Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            ShowReportFrm2 frm = new ShowReportFrm2();



            if (comboBox3 .Text.Trim() == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox3.Select();
                return;
            }

            dt = RetriveData.ExecuteQuery("RP_AllItemsTarns",
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد حركات لأي صنف لعرضها", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (comboBox3.SelectedIndex == 0)
            {
                Reports.RP_ITEMS.RP_AllItemsTrans rp = new Reports.RP_ITEMS.RP_AllItemsTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;

                ParameterField Companyname = new ParameterField();
                Companyname.Name = "@companyname";
                ParameterDiscreteValue Valcompanyname = new ParameterDiscreteValue();
                Valcompanyname.Value = Login.CompanySelected;
                Companyname.CurrentValues.Clear();
                Companyname.CurrentValues.Add(Valcompanyname);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(Companyname);
            
                rp.Refresh();
                frm.ShowDialog();
            }


            else if (comboBox3.SelectedIndex == 1)
            {
                if (DateItems2.Value.Date < DateItems1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                dt = RetriveData.ExecuteQuery("RP_AllItemsTrans_BetweenDate",
                    new RetriveData.prameter("@date1", SqlDbType.Date, DateItems1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, DateItems2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات للموردين خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_ITEMS.RP_AllItemsTrans_BetweenDate rp = new Reports.RP_ITEMS.RP_AllItemsTrans_BetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
                ParameterField pCompanyname = new ParameterField();
              
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                pCompanyname.Name = "@companyname";

                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                ParameterDiscreteValue Valcompanyname = new ParameterDiscreteValue();
                ValDate1.Value = DateItems1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = DateItems2.Value.ToString("yyyy-MM-dd");
                Valcompanyname.Value = Login.CompanySelected;
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                pCompanyname.CurrentValues.Clear();
                pCompanyname.CurrentValues.Add(Valcompanyname);
                
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCompanyname);
              
                rp.Refresh();
                frm.ShowDialog();
            }


            else if (comboBox3.SelectedIndex == 2)
            {

                if (TxtItems.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال كود الصنف الذي تريد تقرير عنه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                dt = RetriveData.ExecuteQuery("RP_OneItemTrans",
                    new RetriveData.prameter("@Itemcode", SqlDbType.BigInt, Int64.Parse(TxtItems.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات لهذا الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_ITEMS.RP_OneItemTrans rp = new Reports.RP_ITEMS.RP_OneItemTrans();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pram = new ParameterField();
                pram.Name = "@Itemcode";
                ParameterDiscreteValue pValue = new ParameterDiscreteValue();
                pValue.Value = TxtItems.Text;
                pram.CurrentValues.Clear();
                pram.CurrentValues.Add(pValue);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pram);

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



            else if (comboBox3.SelectedIndex == 3)
            {
                if (TxtItems.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال كود الصنف الذي تريد تقرير عنه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DateItems2.Value.Date < DateItems1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt = RetriveData.ExecuteQuery("RP_OneItemTarnsBetweensDate",
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(TxtItems.Text)),
                    new RetriveData.prameter("@date1", SqlDbType.Date, DateItems1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, DateItems2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات لهذا الصنف خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Reports.RP_ITEMS.RP_OneItemTransBetweenDate rp = new Reports.RP_ITEMS.RP_OneItemTransBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pCode = new ParameterField();
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
                pCode.Name = "@ItemCode";
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                ParameterDiscreteValue ValCode = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                ValCode.Value = TxtItems.Text;
                ValDate1.Value = DateItems1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = DateItems2.Value.ToString("yyyy-MM-dd");
                pCode.CurrentValues.Clear();
                pCode.CurrentValues.Add(ValCode);
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pCode);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);

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

            else if (comboBox3.SelectedIndex == 4)
            {
                
                dt = RetriveData.ExecuteQuery("items_selectall",
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم تسجيل أي أصناف بعد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Reports.Barcode rp = new Reports.Barcode();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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
            
            else
            {
                MessageBox.Show("برجاء ادخال اسم التقرير بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKzna.SelectedIndex == 1 | comboKzna.SelectedIndex == 3)
            {
                panel22.Visible = true;
            }
            else
            {
               panel22.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            ShowReportFrm2 frm = new ShowReportFrm2();



            if (comboKzna.Text.Trim() == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboKzna.Select();
                return;
            }




            if (comboKzna.SelectedIndex == 0)
            {

                dt = RetriveData.ExecuteQuery("RP_KznaNkdi",
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد حركات لعرضها", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_KZNA.RP_KznaNkdi rp = new Reports.RP_KZNA.RP_KznaNkdi();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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


            else if (comboKzna.SelectedIndex == 1)
            {
                if (DateKzn2.Value.Date < DateKzna1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                dt = RetriveData.ExecuteQuery("RP_KznaNkdiBetweenDate",
                    new RetriveData.prameter("@date1", SqlDbType.Date, DateKzna1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, DateKzn2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات للخزنة خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_KZNA.RP_KznaNkdiBetweenDate rp = new Reports.RP_KZNA.RP_KznaNkdiBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;
                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();
                pDate1.Name = "@date1";
                pDate2.Name = "@date2";
                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();
                ValDate1.Value = DateKzna1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = DateKzn2.Value.ToString("yyyy-MM-dd");
                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);

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


            else if (comboKzna.SelectedIndex == 2)
            {


                dt = RetriveData.ExecuteQuery("RP_KznaShek",
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات شيكات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reports.RP_KZNA.RP_KznaShek rp = new Reports.RP_KZNA.RP_KznaShek();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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



            else  if (comboKzna.SelectedIndex == 3)
            {


                if (DateKzn2.Value.Date < DateKzna1.Value.Date)
                {
                    MessageBox.Show("برجاء تحديد تاريخ نهاية الفترة أكبر من تاريخ بداية الفترة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt = RetriveData.ExecuteQuery("RP_KznaShekBetweenDate",

                    new RetriveData.prameter("@date1", SqlDbType.Date, DateKzna1.Value.ToShortDateString()),
                    new RetriveData.prameter("@date2", SqlDbType.Date, DateKzn2.Value.ToShortDateString()),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أي حركات شيكات في الخزنة خلال الفترة المحددة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Reports.RP_KZNA.RP_KznaShekBetweenDate rp = new Reports.RP_KZNA.RP_KznaShekBetweenDate();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
                frm.crystalReportViewer1.ReportSource = rp;

                ParameterField pDate1 = new ParameterField();
                ParameterField pDate2 = new ParameterField();

                pDate1.Name = "@date1";
                pDate2.Name = "@date2";

                ParameterDiscreteValue ValDate1 = new ParameterDiscreteValue();
                ParameterDiscreteValue ValDate2 = new ParameterDiscreteValue();

                ValDate1.Value = DateKzna1.Value.ToString("yyyy-MM-dd");
                ValDate2.Value = DateKzn2.Value.ToString("yyyy-MM-dd");

                pDate1.CurrentValues.Clear();
                pDate1.CurrentValues.Add(ValDate1);
                pDate2.CurrentValues.Clear();
                pDate2.CurrentValues.Add(ValDate2);

                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate1);
                frm.crystalReportViewer1.ParameterFieldInfo.Add(pDate2);
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

            else if (comboKzna.SelectedIndex == 4)
            {
                Reports.RP_OtherReports.RP_Arba7AND5sa2r rp = new Reports.RP_OtherReports.RP_Arba7AND5sa2r();
                rp.DataSourceConnections[0].IntegratedSecurity = true;
                rp.DataSourceConnections[0].SetConnection(Properties.Settings.Default.ServerName, Properties.Settings.Default.DatabaseName, true);
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

            else if (comboKzna.SelectedIndex == 5)
            {
                RP_MrkzMaliFrm frm0 = new RP_MrkzMaliFrm();
                
                frm0.ShowDialog();

            }
            else
            {
                MessageBox.Show("برجاء ادخال اسم التقرير بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void حركةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            panel14.Visible = false;
            panel8.Visible = false;
            panel1.Visible = true;
        }

        private void عـرضToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            panel14.Visible = false;
            panel1.Visible = false;
            panel8.Visible = true;
        }

        private void عـرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            panel8.Visible = false;
            panel1.Visible = false;
            panel14.Visible = true; 
        }

        private void عـرضToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel14.Visible = false;
            panel1.Visible = false;
            panel20.Visible = true;
        }

        private void MainReportsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                panel20.Visible = false;
                panel14.Visible = false;
                panel1.Visible = false;
                panel8.Visible = false;
            }
            catch { }
        }

        private void comboKzna_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (comboKzna .Text == "")
            {
            MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (comboBox2.Text == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (comboBox3.Text == "")
            {
                MessageBox.Show("برجاء اختيار تقرير من القائمة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
