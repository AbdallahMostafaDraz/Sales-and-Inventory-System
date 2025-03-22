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
using Sales.Forms;

namespace Sales01.Forms
{
    public partial class Mortg3EznEstlamFrm : Form
    {
        public Mortg3EznEstlamFrm()
        {
            InitializeComponent();
        }




        //=========================================================================
        //لعرض بيانات الاذن في شاشة الاذن بعد البحث عن الاذن في شاشةة البحث
        public int EznID;
        public void Ezn_Find(int EznNoSearch)
        {
            DataTable dtCheckSubEznSrf = new DataTable();
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("MainEznMortg3Estlam_Select_ByEznNo",
                new RetriveData.prameter("@eznno", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["Mortg3EznEstlamFrm"] as Mortg3EznEstlamFrm;
            y.EznID = int.Parse(dt.Rows[0]["EznID"].ToString());
            y.EznNoTXT.Text = dt.Rows[0]["EznNo"].ToString();
            y.EznDateTXT.Text = dt.Rows[0]["EznDate"].ToString();
            y.EznEstlamNoTXT .Text = dt.Rows[0]["EznEstlamNo"].ToString();
            y.TotalEznTXT.Text = dt.Rows[0]["TotalEzn"].ToString();
            y.TotalDoneTXT.Text = dt.Rows[0]["TotalDone"].ToString();
            y.TotalDontTXT.Text = dt.Rows[0]["TotalDont"].ToString();
            y.EznEstalmNoSearch  = int.Parse(dt.Rows[0]["EznEstlamNo"].ToString());
            if (dt.Rows[0]["DeleteFlag"].ToString() == "True")
            {
                y.label11.Visible = true;
            }
            else
            {
                y.label11.Visible = false;
            }

            DataTable dt01 = new DataTable();
            dt01 = RetriveData.ExecuteQuery("MainEznEstlam_SelectbyNo",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, int.Parse(dt.Rows[0]["EznEstlamNo"].ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            y.VenNameTXT.Text  = dt01.Rows[0]["VenName"].ToString();
            y.VencodeSearch  = int.Parse(dt01.Rows[0]["VenCode"].ToString());
            y.EznEstlamDateSearch  = DateTime.Parse(dt01.Rows[0]["EznDate"].ToString());


            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور



            DataTable dt02 = new DataTable();
            dt02 = RetriveData.ExecuteQuery("submortg3estlam_selectbyeznno",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, EznNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));






            y.dataGridView1.Rows.Clear();
            y.dataGridView1.Rows.Add(dt02.Rows.Count); // هضيف عدد سجلات في الداتا جريد بعدد سجلات العناصر
            for (int i = 0; i < dt02.Rows.Count; i++)
            {

                y.dataGridView1.Rows[i].Cells["ItemCode"].Value = dt02.Rows[i]["ItemCode"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemName"].Value = dt02.Rows[i]["ItemName"].ToString();
                y.dataGridView1.Rows[i].Cells["MainQuantity"].Value = dt02.Rows[i]["MainQuantity"].ToString();
                y.dataGridView1.Rows[i].Cells["QuantityMortg3"].Value = dt02.Rows[i]["QuantityMortg3"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemPrice"].Value = dt02.Rows[i]["ItemPrice"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemValue"].Value = dt02.Rows[i]["ItemTotal"].ToString();

            }




            Login.EznMortg3EstlamSearch2  = true;
            y.linkLabel1.Visible = true;
        }


        //===================================================================
        //===================================================================
        //===================================================================





        // هعمل داتا تابل بالاسم الموجود في البروسدجر واملاها من الداتا جريد
        DataTable Mortg3EstalmDataTable()
        {

            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {

                dt.Columns.Add("ItemCode", typeof(Int64));
                dt.Columns.Add("ItemName", typeof(string));
                dt.Columns.Add("MainQuantity", typeof(decimal));
                dt.Columns.Add("QuantityMortg3", typeof(decimal));
                dt.Columns.Add("ItemPrice", typeof(decimal));
                dt.Columns.Add("ItemTotal", typeof(decimal));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        dr = dt.NewRow();

                        dr["ItemCode"] = Int64.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        dr["ItemName"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dr["MainQuantity"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        dr["QuantityMortg3"] = decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        dr["ItemPrice"] = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        dr["ItemTotal"] = (decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));

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


        //هعمل متغير احفظ فيه رقم وتاريخ اذن الاستلام  اللي تم البحث عنها
        public int EznEstalmNoSearch = 0;
        public DateTime EznEstlamDateSearch;
        public int VencodeSearch = 0;











        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mortg3EznEstlamFrm_Load(object sender, EventArgs e)
        {
            try
            {
                EznEstalmNoSearch = 0;
                Login.EznMortg3EstlamSearch = false;
                Login.EznMortg3EstlamSearch2 = false;
                //للحصول ع اخر رقم اخر اذن
                Validation.GetLasRecord("EznNo", "MainMortg3EznEstlam", EznNoTXT);
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void BillSearchBTN_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(BillSearchBTN, "");
            TotalEznTXT.Text = "0";
            TotalDoneTXT.Text = "0";
            TotalDontTXT.Text = "0";

            if (Login.EznMortg3EstlamSearch2  == true)
            {
                MessageBox.Show("أنت الان تقوم بتعديل بيانات اذن سابق . اذا كنت تريد استرجاع كميات من اذن استلام أخر قم بالضغط على مفتاح اذن جديد ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewBTN.Focus();
                return;
            }


            if (EznEstlamNoTXT .Text.Trim() == "")
            {
                MessageBox.Show("برجاء ادخال رقم اذن الاستلام الذي تريد استرجاع الأصناف منه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EznEstlamNoTXT . Focus();
                Login.EznMortg3EstlamSearch  = false;
                return;
            }

            //هتأكد ان اذن الاستلام موجود أو مش ملغي
            DataTable dtCheckBill = new DataTable();
            dtCheckBill = RetriveData.ExecuteQuery("MainEznEstlam_SelectbyNo",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, int.Parse(EznEstlamNoTXT .Text )),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dtCheckBill.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد اذون استلام بهذا الرقم . برجاء ادخال رقم الاذن الصحيح والمحاولة مجددا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login.EznMortg3EstlamSearch  = false;
                return;
            }
            else if (dtCheckBill.Rows[0]["DeleteFlag"].ToString() == "True")
            {
                MessageBox.Show("( " + dtCheckBill.Rows[0]["UserName"].ToString() + " )" + " " + "تم الغاء هذا الاذن بواسطة المستخدم ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login.EznMortg3EstlamSearch  = false;
                return;
            }
            //===================================================================================



            //هبحث عن الفاتورة في جدول اذون الاستلام الفرعي لايجاد بياناتها في هذه الشاشة         
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("SubEznestlam_SelectByEznNo_le_EznMortg3",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, int.Parse(EznEstlamNoTXT . Text)),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dt.Rows.Count > 0)
            {
                EznEstalmNoSearch  = int.Parse(dtCheckBill.Rows[0]["EznNo"].ToString());
                EznEstlamDateSearch  = DateTime.Parse(dtCheckBill.Rows[0]["EznDate"].ToString());
                VencodeSearch  = int.Parse(dtCheckBill.Rows[0]["VenCode"].ToString());
                VenNameTXT .Text = dtCheckBill.Rows[0]["VenName"].ToString();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Itemcode"].Value = dt.Rows[i]["itemcode"].ToString();
                    dataGridView1.Rows[i].Cells["itemname"].Value = dt.Rows[i]["itemname"].ToString();
                    dataGridView1.Rows[i].Cells["MainQuantity"].Value = dt.Rows[i]["itemquantity"].ToString();
                    // حساب السعر بعد الواحد بعد الخصومات وعدد الامتار
                    decimal PriceOfOnce = (decimal.Parse(dt.Rows[i]["ItemTotal"].ToString())) / (decimal.Parse(dt.Rows[i]["ItemQuantity"].ToString()));
                    dataGridView1.Rows[i].Cells["ItemPrice"].Value = PriceOfOnce;
                    
        
                    dataGridView1.Rows[i].Cells["QuantityMortg3"].Value = 0;
                    dataGridView1.Rows[i].Cells["ItemValue"].Value = 0;
                }
            }


            else
            {

          
                Login.EznMortg3EstlamSearch  = false;
                return;
            }

            Login.EznMortg3EstlamSearch  = true;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                dataGridView1.CurrentCell.Value = 0;
            }




            //هشوف لو الصنف دا اتعمله مرتجع من نفس الفاتورة قبل كده ولا لا
            decimal quan = 0;
            bool found_in_mortg3Estlam_table = false;


            // في حالة وانا ببحث عن فاتورة هنقص الاول الكمية المرتجعه السابقة 
            if (Login.EznMortg3EstlamSearch2 == true)
            {
                DataTable dte = new DataTable();
                dte = RetriveData.ExecuteQuery("submortg3Estlam_selct_eznno_billno_itemcode",
                    new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@eznestlamno", SqlDbType.Int, int.Parse (EznEstlamNoTXT.Text )),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dte.Rows.Count > 0)
                {
                    quan = quan - decimal.Parse(dte.Rows[0]["QuantityMortg3"].ToString());
                }
            }



            DataTable dtChekQuantity = new DataTable();
            dtChekQuantity = RetriveData.ExecuteQuery("dtChekQuantity_Mortg3Estlam",
                new RetriveData.prameter("@eznestlamno", SqlDbType.Int, EznEstalmNoSearch),
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dtChekQuantity.Rows.Count > 0)
            {
                found_in_mortg3Estlam_table = true;
                for (int i = 0; i < dtChekQuantity.Rows.Count; i++)
                {
                    quan = quan + decimal.Parse(dtChekQuantity.Rows[i][0].ToString());
                }
            }
            else
            {
                quan = 0;
            }


            if (decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) + quan > decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
            {
                if (found_in_mortg3Estlam_table == false)
                {
                    MessageBox.Show("برجاء ادخال كمية مرتجعة أقل من أو مساوية للكمية المباعة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("برجاء ادخال كمية مرتجعة أقل من أو مساوية للكمية المباعة . مع العلم انه تمت عمليات استرجاع سابقة لهذا الصنف من نفس الفاتورة بعدد " + quan.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dataGridView1.CurrentCell.Value = 0;
            }




            //=============================================================================
            //حساب الكمية الموجود في المخزن

                DataTable dt = new DataTable();
                DataTable dtEzn = new DataTable();


                dt = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                   new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())),
                   new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    if (decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) > (decimal.Parse(dt.Rows[0]["quantityinput"].ToString()) - (decimal.Parse(dt.Rows[0]["quantityoutput"].ToString()))))
                    {
                        
                                MessageBox.Show("لا يمكن استرجاع هذه الكمية من هذا الصنف ؛ حيث تم بيع هذه الكمية بالفعل . اذا كنت تريد استرجاعها عليك تعديل او الغاء الكمية التي تم بيعها من فواتير البيع ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[4].Value =0;
                         
                    }
                }
                else
                {

                    DataTable dtMI = new DataTable();
                    dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                        new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                    for (int x = 0; x < dtMI.Rows.Count; x++)
                    {



                        DataTable dtSI = new DataTable();
                        dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMI.Rows[x]["Itemcode"].ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                        if (decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) > (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString()) - (decimal.Parse(dtSI.Rows[0]["quantityoutput"].ToString()))))
                        {
                            MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم . تم بيع هذه الكمية منه بالفعل . اذا كنت تريد استرجاعها عليك تعديل او الغاء الكمية المباعة منه فواتير البيع أولا ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }
                }
                




            //=====================================================






            decimal itemtotal;
            itemtotal = decimal.Parse(dataGridView1.CurrentCell.Value.ToString()) * decimal.Parse(dataGridView1.CurrentRow.Cells["itemprice"].Value.ToString());
            dataGridView1.CurrentRow.Cells["itemvalue"].Value = itemtotal;

            decimal ezntotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ezntotal = ezntotal + decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            TotalEznTXT.Text = ezntotal.ToString();
            TotalDoneTXT.Text = ezntotal.ToString();
        
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Login.EznMortg3EstlamSearch2  = false;
            Validation.TextClear(this, panel1);
            TotalEznTXT.Text = "0";
            TotalDoneTXT.Text = "0";
            TotalDontTXT.Text = "0";


            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            label11.Visible = false;
            EznEstalmNoSearch  = 0;
            Login.EznSrfSearch = false;

            //للحصول ع اخر رقم اخر اذن
            Validation.GetLasRecord("EznNo", "MainMortg3EznEstlam", EznNoTXT);
            linkLabel1.Visible = false;
          
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Login.EznMortg3EstlamSearch2  == true)
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

            if (EznDateTXT.Value < EznEstlamDateSearch )
            {
                errorProvider1.SetError(EznDateTXT, "تاريخ اذن المرتجع الذي تم تحديده أقدم من تاريخ اذن الاستلام . برجاء ادخال تاريخ مرتجع صحيح");
                return;
            }


            if (EznEstlamNoTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(EznEstlamNoTXT , "برجاء ادخال رقم اذن الاستلام");
                return;
            }

            if (Login.EznMortg3EstlamSearch  == false)
            {
                errorProvider1.SetError(BillSearchBTN, "برجاء البحث عن اذن الاستلام المراد استرجاع أصناف منه");
                BillSearchBTN.Focus();
                return;
            }



            //هتأكد ان رقم اذن الاستلام ماتمش تغيره بعد عملية البحث عنها
            if (int.Parse(EznEstlamNoTXT . Text.Trim()) != EznEstalmNoSearch )
            {
                MessageBox.Show("لقد قمت بتغيير رقم اذن الاستلام بعد البحث عنه . برجاء ادخال رقم اذن الاستلام بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EznEstlamNoTXT . Focus();
                return;
            }



            int rowsEmpty = 0;
            for (int d = 0; d < dataGridView1.Rows.Count; d++)
            {
                if (dataGridView1.Rows[d].Cells[3].Value.ToString() == "0")
                {
                    rowsEmpty = rowsEmpty + 1;
                }
            }
            if (rowsEmpty == dataGridView1.Rows.Count)
            {
                MessageBox.Show("لم يتم ادخال أي كميات مرتجعة . برجاء ادخال الكميات المراد استرجاعها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }








            //===================================================================================
            //التسجيل في قاعدة البيانات
            DataTable dt = Mortg3EstalmDataTable ();


            DBConnected db = new DBConnected();
            db.cmd.Connection = DBConnected.sqlcon;
            db.cmd.CommandType = CommandType.StoredProcedure;
            db.cmd.CommandText = "Mortg3Estlam_Insert";

            db.cmd.Parameters.AddWithValue("@eznno", int.Parse(EznNoTXT.Text));
            db.cmd.Parameters.AddWithValue("@ezndate", EznDateTXT.Value.Date);
            db.cmd.Parameters.AddWithValue("@eznestlamno", int.Parse(EznEstlamNoTXT . Text));
            db.cmd.Parameters.AddWithValue("@totalezn", decimal.Parse(TotalEznTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(TotalDoneTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(TotalDontTXT.Text));
            db.cmd.Parameters.AddWithValue("@username", Login.UserName);
            db.cmd.Parameters.AddWithValue("@Mortg3EznEstlamDataTable", dt);
            db.cmd.Parameters.AddWithValue("@movedescription", "اذن مرتجع مشتريات من اذن الاستلام رقم " + EznEstalmNoSearch . ToString());
            db.cmd.Parameters.AddWithValue("@countdate", EznDateTXT.Value);
            db.cmd.Parameters.AddWithValue("@Vencode", VencodeSearch );
            db.cmd.Parameters.AddWithValue("@venname", VenNameTXT . Text);
            db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

            int r = db.cmd.ExecuteNonQuery();
            if (r < 1)
            {
                MessageBox.Show(" تم تسجيل اذن مرتجع اخر مسبقا بنفس الرقم . برجاء التأكد من رقم الاذن واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //======================================================================
           


            //اضافة في جدول حركة الأصناف

            DataTable dtT = new DataTable();
            DataTable dtMT = new DataTable();
            
            for (int t = 0; t < dataGridView1.Rows.Count; t++)
            {
                
                dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dtT.Rows.Count > 0)
                {
                    RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                        new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                        new RetriveData.prameter("@billdate", SqlDbType.Date, EznDateTXT.Value.Date),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                        new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[1].Value.ToString()),
                        new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن مرتجع مشتريات"),
                        new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse (dataGridView1 .Rows [t].Cells [3].Value .ToString ())),
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
                            new RetriveData.prameter("@billdate", SqlDbType.Date, EznDateTXT.Value.Date),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                            new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                            new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن مرتجع مشتريات"),
                            new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[3].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    }

                }
            }




            NewBTN_Click(null, null);
        
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchMortg3EznEstlam frm = new SearchMortg3EznEstlam();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي لا يمكنك اضافة أصناف أخرى فيه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AllItemsInBill_Mortg3EstlamFRM frm = new AllItemsInBill_Mortg3EstlamFRM();
            frm.ShowDialog();
        
        }

        private void EdietBtn_Click(object sender, EventArgs e)
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

            if (Login.EznMortg3EstlamSearch2  == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchBtn.Focus();
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

            if (EznDateTXT.Value < EznEstlamDateSearch )
            {
                errorProvider1.SetError(EznDateTXT, "تاريخ اذن المرتجع الذي تم تحديده أقدم من تاريخ اذن الاستلام . برجاء ادخال تاريخ مرتجع صحيح");
                return;
            }


            if (EznNoTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(EznNoTXT , "برجاء ادخال رقم الاذن");
                return;
            }


            //هتأكد ان رقم اذن الاستلام ماتمش تغيره بعد عملية البحث عنها
            if (int.Parse(EznEstlamNoTXT . Text.Trim()) != EznEstalmNoSearch )
            {
                MessageBox.Show("لقد قمت بتغيير رقم اذن الاستلام بعد البحث عنه . برجاء ادخال رقم اذن الاستلام بشكل صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EznNoTXT . Focus();
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
                MessageBox.Show("لم يتم ادخال أي كميات مرتجعة . برجاء ادخال الكميات المراد استرجاعها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            //===================================================================================
            //التسجيل في قاعدة البيانات
            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا الاذن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = Mortg3EstalmDataTable ();


                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;
                db.cmd.CommandType = CommandType.StoredProcedure;
                db.cmd.CommandText = "Mortg3Estlam_Update";

                db.cmd.Parameters.AddWithValue("@eznid", EznID);
                db.cmd.Parameters.AddWithValue("@eznno", int.Parse(EznNoTXT.Text));
                db.cmd.Parameters.AddWithValue("@ezndate", EznDateTXT.Value.Date);
                db.cmd.Parameters.AddWithValue("@eznestlamno", int.Parse(EznEstlamNoTXT . Text));
                db.cmd.Parameters.AddWithValue("@totalezn", decimal.Parse(TotalEznTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(TotalDoneTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(TotalDontTXT.Text));
                db.cmd.Parameters.AddWithValue("@username", Login.UserName);
                db.cmd.Parameters.AddWithValue("@Mortg3EznEstlamDataTable", dt);
                db.cmd.Parameters.AddWithValue("@movedescription", "اذن مرتجع مشتريات من اذن الاستلام رقم " +EznEstalmNoSearch . ToString());
                db.cmd.Parameters.AddWithValue("@countdate", EznDateTXT.Value);
                db.cmd.Parameters.AddWithValue("@vencode", VencodeSearch );
                db.cmd.Parameters.AddWithValue("@venname",VenNameTXT . Text);
                db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                int r = db.cmd.ExecuteNonQuery();
                if (r < 1)
                {
                    MessageBox.Show(" تم تسجيل اذن مرتجع اخر مسبقا بنفس الرقم . برجاء التأكد من رقم الاذن واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //======================================================================
                




                //الحذف من جدول حركة الأصناف أولا قبل التعديل
                RetriveData.ExecuteNonQuery("itemtrans_delete_le_mortg3Estlam",
                    new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


                //اضافة في جدول حركة الأصناف

                DataTable dtT = new DataTable();
                DataTable dtMT = new DataTable();

                for (int t = 0; t < dataGridView1.Rows.Count; t++)
                {

                    dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                    if (dtT.Rows.Count > 0)
                    {
                        RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                            new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                            new RetriveData.prameter("@billdate", SqlDbType.Date, EznDateTXT.Value.Date),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[0].Value.ToString())),
                            new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[1].Value.ToString()),
                            new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن مرتجع مشتريات"),
                            new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[3].Value.ToString())),
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
                                new RetriveData.prameter("@billdate", SqlDbType.Date, EznDateTXT.Value.Date),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                                new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                                new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن مرتجع مشتريات"),
                                new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[3].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        }

                    }
                }



                MessageBox.Show("تم تعديل بيانات الاذن  بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (Login.EznMortg3EstlamSearch2 == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد حذف بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchBtn.Focus();
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

                EznMortg3Estalm_Delete (EznID, int.Parse(EznNoTXT.Text));


                MessageBox.Show("تم الغاء الاذن بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);


            }
        }


        //فويد لحذف اذن مرتجع المبيعات
     
        public void EznMortg3Estalm_Delete(int InputEznID, int InputEznNo)
        {

            var z = Application.OpenForms["Mortg3EznEstlamFrm"] as Mortg3EznEstlamFrm ;
            //الحذف من جدول حركة الأصناف
            RetriveData.ExecuteNonQuery("itemtrans_delete_le_mortg3Estlam",
                new RetriveData.prameter("@billcode", SqlDbType.Int, InputEznNo),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


            RetriveData.ExecuteNonQuery("Mortg3Estlam_Delete",
                new RetriveData.prameter("@eznid", SqlDbType.Int, InputEznID),
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (RetriveData.saved == false)
            {
                MessageBox.Show("فشل حذف الاذن", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }

        private void EznNoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void EznNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                EznDateTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Down )
            {
                EznEstlamNoTXT.Select();
            }
            Validation.NumbersOnly(e);

        }

        private void EznDateTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                EznEstlamNoTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                VenNameTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Right )
            {
                EznNoTXT.Select();
            }
            
        }

        private void EznEstlamNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                SaveBtn.Select();
            }
            else if (e.KeyChar == (char)Keys.Up )
            {
                EznNoTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Right )
            {
                EznDateTXT.Select();
            }

            Validation.NumbersOnly(e);

        }

        private void BillSearchBTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                VenNameTXT.Select();
            }
          
            else if (e.KeyChar == (char)Keys.Right)
            {
                EznEstlamNoTXT.Select();
            }

     
        }

        private void VenNameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                dataGridView1.Select();
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                EznDateTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Right)
            {
                BillSearchBTN.Select();
            }

            
        }

        private void TotalEznTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                TotalDoneTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys .Right )
            {
                dataGridView1.Select();
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                SaveBtn.Select();
            }

           
        }

        private void TotalDoneTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left)
            {
                TotalDontTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                dataGridView1.Select();
            }
            else if (e.KeyChar == (char)Keys.Right)
            {
                TotalEznTXT.Select();
            }
            else if (e.KeyChar == (char)Keys.Down )
            {
                SaveBtn.Select();
            }
            Validation.NumbersOnly(e);
        }

        private void TotalDontTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Down)
            {
                SaveBtn.Select();
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                dataGridView1.Select();
            }
            else if (e.KeyChar == (char)Keys.Right)
            {
                TotalDontTXT.Select();
            }
            
            
        }
    }

}


