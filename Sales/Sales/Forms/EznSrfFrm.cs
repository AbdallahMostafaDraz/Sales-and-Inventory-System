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
    public partial class EznSrfFrm : Form
    {
        public EznSrfFrm()
        {
            InitializeComponent();
        }

        //عشان اضيف صنف تاني على الأصناف الموجودة في الاذن وانا بعمل تعديل

        public bool _err; // عشان لو الصنف اضاف بالفعل شاشة الاصناف ماتقفلش بعد الرسالة 

        public void Find_Item_Bill(Int64  itemcodesearch)
        {
            var y = Application.OpenForms["EznSrfFrm"] as EznSrfFrm ;

            for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
            {
                if (Int64.Parse(y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == itemcodesearch)
                {
                    MessageBox.Show("تمت اضافة هذا الصنف بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _err = true;

                    return;
                }
            }
            DataTable dtCheckSubEznSrf = new DataTable();
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_le_EznSrf",
               new RetriveData.prameter("@billno", SqlDbType.Int, y.billNoSearch),
               new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            DataGridViewRow drow = new DataGridViewRow();

            DataGridViewButtonCell dcell0 = new DataGridViewButtonCell();
            DataGridViewCheckBoxCell dcell1 = new DataGridViewCheckBoxCell();
            DataGridViewTextBoxCell dcell2 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell3 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell4 = new DataGridViewTextBoxCell();

            drow.Cells.Add(dcell0);
            drow.Cells.Add(dcell1);
            drow.Cells.Add(dcell2);
            drow.Cells.Add(dcell3);
            drow.Cells.Add(dcell4);



            drow.Cells[0].Value = dt.Rows[0]["ItemCode"].ToString();
            drow.Cells[1].Value = dt.Rows[0]["ItemName"].ToString();
            drow.Cells[2].Value = dt.Rows[0]["ItemQuantity"].ToString();
            drow.Cells[4].Value = 0;



            ////هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
            decimal EznQuantityDone = 0;

            dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_SubEznSrf_byBillNo",
            new RetriveData.prameter("@Billno", SqlDbType.Int, y.billNoSearch),
            new RetriveData.prameter("@itemcode", SqlDbType.BigInt , itemcodesearch),
            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dtCheckSubEznSrf.Rows.Count > 0)
            {
                for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                {
                    EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityDone"].ToString());

                }
                y.dataGridView1.Rows[0].Cells["QuantityDont"].Value = EznQuantityDone;
            }

            else
            {
                y.dataGridView1.Rows[0].Cells["QuantityDont"].Value = 0;
            }



            y.dataGridView1.Rows.Add(drow);



         }






        //=========================================================================
        //لعرض بيانات الاذن في شاشة الاذن بعد البحث عن الاذن في شاشةة البحث
        public int EznID;
        public void Ezn_Find(int EznNoSearch)
        {
            DataTable dtCheckSubEznSrf = new DataTable();
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("MainEznSrf_Select_ByEznNo",
                new RetriveData.prameter("@eznno", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["EznSrfFrm"] as EznSrfFrm;
            y.EznID =int.Parse ( dt.Rows[0]["EznID"].ToString());
            y.EznNoTXT.Text = dt.Rows[0]["EznNo"].ToString();
            y.EznDate.Text = dt.Rows[0]["EznDate"].ToString();
            y.BillNoTXT.Text = dt.Rows[0]["BillNo"].ToString();
            y.billNoSearch =int.Parse ( dt.Rows[0]["BillNo"].ToString());
            if (dt.Rows[0]["DeleteFalg"].ToString() == "True")
            {
               y. label11.Visible = true;
            }
            else
            {
                y.label11.Visible = false;
            }

            DataTable dt01 = new DataTable();
            dt01 = RetriveData.ExecuteQuery("MainBills_SelectByNo",
                new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(dt.Rows[0]["BillNo"].ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            y.CustNameTXT.Text = dt01.Rows[0]["CustName"].ToString();



            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور

          
            
            DataTable dt02 = new DataTable();
            dt02 = RetriveData.ExecuteQuery("SubEznSrf_SelectAll_ByEznNo",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            y.dataGridView1.Rows.Clear();
            y.dataGridView1.Rows.Add(dt02.Rows.Count); // هضيف عدد سجلات في الداتا جريد بعدد سجلات العناصر
            for (int i = 0; i < dt02.Rows.Count; i++)
            {
               
                y.dataGridView1.Rows[i].Cells["ItemCode"].Value = dt02.Rows[i]["ItemCode"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemName"].Value = dt02.Rows[i]["ItemName"].ToString();
                y.dataGridView1.Rows[i].Cells["MainQuantity"].Value = dt02.Rows[i]["MainQuantity"].ToString();
                y.dataGridView1.Rows[i].Cells["QuantityDone"].Value = dt02 .Rows [i]["QuantityDone"].ToString ();


                //هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
                decimal EznQuantityDone = 0;
               
                dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_SubEznSrf_byBillNo",
                new RetriveData.prameter("@Billno", SqlDbType.Int, int.Parse(dt.Rows[0]["BillNo"].ToString())),
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dt02.Rows[i]["itemcode"].ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dtCheckSubEznSrf.Rows.Count > 0)
                {
                    for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                    {
                        EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityDone"].ToString());

                    }
                    y.dataGridView1.Rows[i].Cells["QuantityDont"].Value = EznQuantityDone;
                }

                else
                {
                    y.dataGridView1.Rows[i].Cells["QuantityDont"].Value = 0;
                }

              
            }

         

            Login.EznSrfSearch2  = true;
           y. linkLabel1.Visible = true;
        }



        //===================================================================
        //===================================================================
        //===================================================================

        // هعمل داتا تابل بالاسم الموجود في البروسدجر واملاها من الداتا جريد
        DataTable FillEznSrfDataTable()
        {

            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {

                dt.Columns.Add("ItemCode", typeof(Int64));
                dt.Columns.Add("ItemName", typeof(string));
                dt.Columns.Add("MainQuantity", typeof(decimal));
                dt.Columns.Add("QuantityDone", typeof(decimal));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        dr = dt.NewRow();

                        dr["ItemCode"] = Int64.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        dr["ItemName"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dr["MainQuantity"] = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        dr["QuantityDone"] = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        dt.Rows.Add(dr);
                    }
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

        //هعمل متغير احفظ فيه رقم وتاريخ الفاتورة  اللي تم البحث عنها
        public int billNoSearch = 0;
        public DateTime billDateSearch ;



        private void Btn_new_Click(object sender, EventArgs e)
        {
            Login.EznSrfSearch2  = false;
            Validation.TextClear(this, panel1);

        
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
          
            label11.Visible = false;
            billNoSearch = 0;
            Login.EznSrfSearch = false;

            //للحصول ع اخر رقم اخر اذن
            Validation.GetLasRecord("EznNo", "MainEznSrf", EznNoTXT);

            linkLabel1.Visible = false;
        }

        private void BillSearchTXT_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(BillSearchBTN, "");

            if (Login.EznSrfSearch2 == true)
            {
                MessageBox.Show("أنت الان تقوم بتعديل بيانات اذن سابق . اذا كنت تريد صرف كميات من فاتورة أخرى قم بالضغط على مفتاح اذن جديد "  , "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewBTN.Focus();
                return;
            }


            if (BillNoTXT.Text.Trim() == "")
            {
                MessageBox.Show("برجاء ادخال رقم الفاتورة التي تريد صرف الأصناف منها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BillNoTXT.Focus();
                Login.EznSrfSearch = false;
                return;
            }

            //هتأكد ان الفاتورة موجودة أو مش ملغية
            DataTable dtCheckBill = new DataTable ();
            dtCheckBill = RetriveData .ExecuteQuery ("MainBills_SelectByNo",
                new RetriveData .prameter ("@billno" ,SqlDbType .Int , int.Parse (BillNoTXT.Text)),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtCheckBill.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد فواتير بهذا الرقم . برجاء ادخال رقم الفاتورة الصحيح والمحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login.EznSrfSearch = false;
                return;
            }
            else if (dtCheckBill.Rows[0]["DeleteFlag"].ToString () == "True")
            {
                MessageBox.Show( "( " + dtCheckBill.Rows[0]["UserName"].ToString() + " )" + " " + "تم الغاء هذه الفاتورة بواسطة المستخدم " ,"" , MessageBoxButtons .OK , MessageBoxIcon.Warning );
                Login.EznSrfSearch = false;
                return;
            }
            //===================================================================================



            //هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
            DataTable dtCheckSubEznSrf = new DataTable();

            //هبحث عن الفاتورة في جدول الفواتير الفرعي لايجاد بياناتها في هذه الشاشة         
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_le_EznSrf",
                new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dt.Rows.Count > 0)
            {
                billNoSearch = int.Parse (dtCheckBill.Rows[0]["BillNo"].ToString());
                billDateSearch = DateTime.Parse(dtCheckBill.Rows[0]["BillDate"].ToString());

                CustNameTXT.Text = dtCheckBill.Rows[0]["CustName"].ToString();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Itemcode"].Value = dt.Rows[i]["itemcode"].ToString();
                    dataGridView1.Rows[i].Cells["itemname"].Value = dt.Rows[i]["itemname"].ToString();
                    dataGridView1.Rows[i].Cells["MainQuantity"].Value = dt.Rows[i]["itemquantity"].ToString();

                    //هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
                    decimal EznQuantityDone = 0;
                    dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_SubEznSrf_byBillNo",
                    new RetriveData.prameter("@Billno", SqlDbType.Int, int.Parse(dtCheckBill .Rows [0]["BillNo"].ToString ())),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dt.Rows[i]["itemcode"].ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                    if (dtCheckSubEznSrf.Rows.Count > 0)
                    {
                        for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                        {
                            EznQuantityDone =EznQuantityDone +  decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityDone"].ToString());

                        }
                        dataGridView1.Rows[i].Cells["QuantityDont"].Value = EznQuantityDone;
                    }

                    else
                    {
                        dataGridView1.Rows[i].Cells["QuantityDont"].Value = 0;
                    }



                    dataGridView1.Rows[i].Cells["QuantityDone"].Value = 0;
                }       
                }

            
            else
            {
            
                MessageBox.Show("تم صرف جميع أصناف هذه الفاتورة بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login.EznSrfSearch = false;
                return;
            }

            Login.EznSrfSearch = true;

        }

        private void EznSrfFrm_Load(object sender, EventArgs e)
        {
            try
            {
                billNoSearch = 0;
                Login.EznSrfSearch = false;
                Login.EznSrfSearch2 = false;
                //للحصول ع اخر رقم اخر اذن
                Validation.GetLasRecord("EznNo", "MainEznSrf", EznNoTXT);
            }
            catch { }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {

            if (Login.EznSrfSearch2  == true)
            {
                if (MessageBox.Show("هذا الاذن موجود بالفعل يمكنك تعديل بياناته أو حذفه . هل تريد ادخال بيانات جديدة لتسجيل اذن اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Btn_new_Click(null, null);
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

            if (EznDate.Value < billDateSearch)
            {
                errorProvider1.SetError(EznDate, "تاريخ اذن الصرف الذي تم تحديده أقدم من تاريخ الفاتورة . برجاء ادخال تاريخ صرف صحيح");
                return;
            }


            if (BillNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(BillNoTXT, "برجاء ادخال رقم الفاتورة");
                return;
            }

            if (Login.EznSrfSearch == false)
            {
                errorProvider1.SetError(BillSearchBTN, "برجاء البحث عن الفاتورة المراد صرف أصناف منها");
                BillSearchBTN.Focus();
                return;
            }



           //هتأكد ان رقم الفاتورة ماتمش تغيره بعد عملية البحث عنها
            if (int.Parse(BillNoTXT.Text.Trim()) != billNoSearch)
            {
                MessageBox.Show("لقد قمت بتغيير رقم الفاتورة بعد البحث عنها . برجاء ادخال رقم الفاتورة بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BillNoTXT.Focus();
                return;
            }



            int rowsEmpty = 0;
            for (int d = 0; d < dataGridView1.Rows.Count; d++)
            {
                if (dataGridView1.Rows[d].Cells[4].Value.ToString () == "0")
                {
                    rowsEmpty = rowsEmpty + 1;
                }
            }
            if (rowsEmpty == dataGridView1.Rows.Count)
            {
                MessageBox.Show("لم يتم ادخال أي كميات مصروفة . برجاء ادخال الكميات المراد صرفها", "تـنـبـيـه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            
            //===================================================================================
            //التسجيل في قاعدة البيانات
            DataTable dt = FillEznSrfDataTable();


            DBConnected db = new DBConnected();
            db.cmd.Connection = DBConnected.sqlcon;
            db.cmd.CommandType = CommandType.StoredProcedure;
            db.cmd.CommandText = "EznSrf_Insert";

            db.cmd.Parameters.AddWithValue("@eznno", int.Parse(EznNoTXT.Text));
            db.cmd.Parameters.AddWithValue("@ezndate", EznDate.Value.Date);
            db.cmd.Parameters.AddWithValue("@billno", int.Parse(BillNoTXT.Text));
            db.cmd.Parameters.AddWithValue("@username", Login.UserName);
            db.cmd.Parameters.AddWithValue("@EznSrfDataTable", dt);
            db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

            int r = db.cmd.ExecuteNonQuery();
            if (r < 1)
            {
                MessageBox.Show(" تم تسجيل اذن صرف اخر مسبقا بنفس الرقم . برجاء التأكد من رقم الاذن واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //======================================================================
           
        

            //الاضافة في جدول حركة صنف
           DataTable dtT = new DataTable();
           DataTable dtMT = new DataTable();

           for (int t = 0; t < dataGridView1.Rows.Count; t++)
           {
               if (dataGridView1.Rows[t].Cells[4].Value.ToString () != "0")
               {
                   dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                       new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                   if (dtT.Rows.Count > 0)
                   {
                       RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                           new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                           new RetriveData.prameter("@billdate", SqlDbType.Date, EznDate.Value.Date),
                           new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                           new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[1].Value.ToString()),
                           new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن صرف"),
                           new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                           new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                   }
                   else
                   {
                       dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                           new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                           new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                       for (int m = 0; m < dtMT.Rows.Count; m++)
                       {
                           RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                               new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                               new RetriveData.prameter("@billdate", SqlDbType.Date, EznDate.Value.Date),
                               new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                               new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                               new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن صرف"),
                               new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                               new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                       }
                   }
               }
           }
           

           Btn_new_Click(null, null);
        
        }

        private void EznNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznNoTXT, "");
        }

        private void BillNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(BillNoTXT, "");
        }

        private void EznDate_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznDate, "");
        }

        private void CustNameTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CustNameTXT, "");
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            SearchEznSrfFrm  frm = new SearchEznSrfFrm ();
            frm.ShowDialog();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي لا يمكنك التعديل في بياناته", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.CurrentRow.Cells[4].Value = oldquanDone;
                return;
            
            }

            if (dataGridView1.CurrentRow.Cells[4].Value== null )
            {
                dataGridView1.CurrentRow.Cells[4].Value = 0;
            }
            if (Login.EznSrfSearch2 == false)
            {   
                if (decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) == decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
                {
                    MessageBox.Show("تم صرف الكمية كاملة بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[4].Value = 0;
                    dataGridView1.Focus();
                }

            
                if (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) > (decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) - decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())))
                {
                    MessageBox.Show("الكمية التي لم تصرف بعد هي " + " " + (decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) - decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())) + " " + "فقط . برجاء التأكد من الكمية المراد صرفها", "تـنـبـيـه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[4].Value = 0;
                    dataGridView1.Focus();
                }
            }
            else
            {

                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("Select_OldQuan_Of_EznSrf",
                    new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


                decimal x = decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) - decimal.Parse(dt.Rows[0][0].ToString()); ;



                if (decimal .Parse (dataGridView1 .CurrentRow .Cells [4].Value .ToString ()) > (decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) - x ))
                {
                    MessageBox.Show("الكمية التي لم تصرف بعد هي " + " " + (decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()) - decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())) + " " + "فقط . برجاء التأكد من الكمية المراد صرفها", "تـنـبـيـه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[4].Value = dt.Rows [0][0].ToString();
                    dataGridView1.Focus();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            if (Login.EznSrfSearch2  == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                SearchBTN.Focus();
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

            if (EznDate.Value < billDateSearch)
            {
                errorProvider1.SetError(EznDate, "تاريخ اذن الصرف الذي تم تحديده أقدم من تاريخ الفاتورة . برجاء ادخال تاريخ صرف صحيح");
                return;
            }


            if (BillNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(BillNoTXT, "برجاء ادخال رقم الفاتورة");
                return;
            }


            //هتأكد ان رقم الفاتورة ماتمش تغيره بعد عملية البحث عنها
            if (int.Parse(BillNoTXT.Text.Trim()) != billNoSearch)
            {
                MessageBox.Show("لقد قمت بتغيير رقم الفاتورة بعد البحث عنها . برجاء ادخال رقم الفاتورة بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BillNoTXT.Focus();
                return;
            }

            int rowsEmpty = 0;
            for (int d = 0; d < dataGridView1.Rows.Count; d++)
            {
                if (dataGridView1.Rows[d].Cells[4].Value.ToString() == "0")
                {
                    rowsEmpty = rowsEmpty + 1;
                }
            }
            if (rowsEmpty == dataGridView1.Rows.Count)
            {
                MessageBox.Show("لم يتم ادخال أي كميات مصروفة . برجاء ادخال الكميات المراد صرفها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // التسجيل في قاعدة البيانات
            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا الاذن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                DataTable dt = FillEznSrfDataTable();


                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;
                db.cmd.CommandType = CommandType.StoredProcedure;
                db.cmd.CommandText = "EznSrf_Update";

                db.cmd.Parameters.AddWithValue("@eznid", EznID);
                db.cmd.Parameters.AddWithValue("@eznno", int.Parse(EznNoTXT.Text));
                db.cmd.Parameters.AddWithValue("@ezndate", EznDate.Value.Date);
                db.cmd.Parameters.AddWithValue("@billno", int.Parse(BillNoTXT.Text));
                db.cmd.Parameters.AddWithValue("@username", Login.UserName);
                db.cmd.Parameters.AddWithValue("@EznSrfDataTable", dt);
                db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                int r = db.cmd.ExecuteNonQuery();
                if (r < 1)
                {
                    MessageBox.Show(" تم تسجيل اذن صرف اخر مسبقا بنفس الرقم . برجاء التأكد من رقم الاذن واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }





                //الحذف من جدول حركة الأصناف أولا قبل التعديل
                RetriveData.ExecuteNonQuery("ItemsTrans_delete",
                    new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                //الاضافة في جدول حركة صنف
                DataTable dtT = new DataTable();
                DataTable dtMT = new DataTable();

                for (int t = 0; t < dataGridView1.Rows.Count; t++)
                {
                    if (dataGridView1.Rows[t].Cells[4].Value.ToString() != "0")
                    {
                        dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dtT.Rows.Count > 0)
                        {
                            RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                                new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                                new RetriveData.prameter("@billdate", SqlDbType.Date, EznDate.Value.Date),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                                new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[1].Value.ToString()),
                                new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن صرف"),
                                new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        }
                        else
                        {
                            dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                                new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            for (int m = 0; m < dtMT.Rows.Count; m++)
                            {
                                RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                                    new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                                    new RetriveData.prameter("@billdate", SqlDbType.Date, EznDate.Value.Date),
                                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                                    new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                                    new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن صرف"),
                                    new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            }
                        }
                    }



                    MessageBox.Show("تم تعديل بيانات الاذن  بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_new_Click(null, null);
                }

            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            if (Login.EznSrfSearch2 == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchBTN.Focus();
                return;
            }


            //التأكد من ان الاذن غير ملغي
            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (MessageBox.Show(" هل تريد بالتأكيد الغاء  هذا الاذن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                

                EznSrf_Delete(EznID, int.Parse(EznNoTXT.Text)); 


                    MessageBox.Show("تم الغاء الاذن بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_new_Click(null, null);


            }
        }
       
        //هعمل فويد لالغاء اذن الصرف
        public void EznSrf_Delete(int InputEznID , int InputEznNo)
        {

        
            var z = Application.OpenForms["EznSrfFrm"] as EznSrfFrm;
            //الحذف من جدول حركة الأصناف
            RetriveData.ExecuteNonQuery("ItemsTrans_delete",
                new RetriveData.prameter("@billcode", SqlDbType.Int, InputEznNo ),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            //الحذف من جداول اذن الصرف
                RetriveData.ExecuteNonQuery("EznSrf_Delete",
                    new RetriveData.prameter("@eznid", SqlDbType.Int, InputEznID  ),
                    new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (RetriveData.saved == false)
                {
                    MessageBox.Show("فشل حذف الاذن", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
        }


        


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي لا يمكنك اضافة أصناف أخرى فيه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AllItemsINBillFrm frm = new AllItemsINBillFrm();
            frm.ShowDialog();
        }
        public decimal  oldquanDone;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                oldquanDone = decimal.Parse (dataGridView1.CurrentRow.Cells[4].Value.ToString ());
            }
        }

        private void EznNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void BillNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void EznNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                EznDate.Select();
            }
            else if (e.KeyCode == Keys.Down |e.KeyCode == Keys.Up)
            {
                BillNoTXT.Select();
            }

        }

        private void EznDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BillNoTXT.Select();
            }
        }

        private void BillNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                BillSearchBTN.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                EznDate.Select();
            }
            else if (e.KeyCode == Keys.Down  |e.KeyCode == Keys.Up )
            {
                EznNoTXT.Select();
            }
        }

        private void BillSearchBTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                BillNoTXT.Select();
            }
            else if (e.KeyCode == Keys.Left)
            {
                CustNameTXT.Select();
            }
        }
    }
}
