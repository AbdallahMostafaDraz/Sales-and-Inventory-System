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
using Sales.Forms;

namespace Sales01.Forms
{
    public partial class BillFrm : Form
    {
        public BillFrm()
        {
            InitializeComponent();
        }
     

        //=================================================================
        // لوضع الصنف المختار من شاشة البحث في داتا جريد الأصناف

        // لوضع بيانات الصنف الفرعي في الداتا جريد بعد اختيارها من شاشة البحث عن الأصناف
       
        public bool _err; // عشان لو الصنف اضاف بالفعل شاشة الاصناف ماتقفلش بعد الرسالة 

        public void Find_Item_Bill(Int64 itemcodesearch)
        {
            var y = Application.OpenForms["BillFrm"] as BillFrm;

            for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
            {
                if (Int64 .Parse (y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == itemcodesearch)
                {
                    MessageBox.Show("تمت اضافة هذا الصنف بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _err = true;

                    return;
                }
            }

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("items_selectbycode",
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt , itemcodesearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));



            DataGridViewRow drow = new DataGridViewRow();

            DataGridViewButtonCell dcell0 = new DataGridViewButtonCell();
            DataGridViewCheckBoxCell dcell1 = new DataGridViewCheckBoxCell();
            DataGridViewTextBoxCell dcell2 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell3 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell4 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell5 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell6 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell7 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell8 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell9 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell10 = new DataGridViewTextBoxCell();

            drow.Cells.Add(dcell0);
            drow.Cells.Add(dcell1);
            drow.Cells.Add(dcell2);
            drow.Cells.Add(dcell3);
            drow.Cells.Add(dcell4);
            drow.Cells.Add(dcell5);
            drow.Cells.Add(dcell6);
            drow.Cells.Add(dcell7);
            drow.Cells.Add(dcell8);
            drow.Cells.Add(dcell9);
            drow.Cells.Add(dcell10);

            drow.Cells[0].Value = "حـذف";
            drow.Cells[1].Value = true;
            drow.Cells[2].Value = dt.Rows[0]["ItemCode"].ToString();
            drow.Cells[3].Value = dt.Rows[0]["ItemName"].ToString();
            if (dt.Rows[0]["ItemCategory"].ToString() == "سيراميك".Trim())
            { drow.Cells[4].Value = dt.Rows[0]["ItemMeter"].ToString(); }
            else { drow.Cells[4].Value = "-"; }

            drow.Cells[5].Value = 0;
            drow.Cells[6].Value = dt.Rows[0]["ItemPrice"].ToString();
            drow.Cells[7].Value = 0;
            drow.Cells[8].Value = 0;
            drow.Cells[9].Value = 0;
            drow.Cells[10].Value = 0;

            y.dataGridView1.Rows.Add(drow);


        }


        //=============================================================
        //=============================================================
        //=============================================================
        //========================================================================
        // هعمل داتا تابل بالاسم الموجود في البروسدجر واملاها من الداتا جريد
        DataTable FillBillDataTable()
        {

            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {
              
                dt.Columns.Add("ItemCode", typeof(Int64 ));
                dt.Columns.Add("ItemName", typeof(string));
                dt.Columns.Add("ItemMeter", typeof(decimal));
                dt.Columns.Add("ItemQuantity", typeof(decimal));
                dt.Columns.Add("ItemPrice", typeof(decimal));
                dt.Columns.Add("DiscountPrecent", typeof(decimal));
                dt.Columns.Add("DiscountValue", typeof(decimal));
                dt.Columns.Add("ItemTotal", typeof(decimal));
                dt.Columns.Add("SrfFlag", typeof(int));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    
                    dr["ItemCode"] = Int64 .Parse  (dataGridView1.Rows[i].Cells[2].Value.ToString());
                    dr["ItemName"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "-")
                    { dr["ItemMeter"] = decimal.Parse("1"); }
                    else { dr["ItemMeter"] = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()); }
                    
                    dr["ItemQuantity"] = (Math.Round (decimal .Parse (dataGridView1.Rows[i].Cells[5].Value.ToString()),2));
                    dr["ItemPrice"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()),2));
                    dr["DiscountPrecent"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()),2));
                    dr["DiscountValue"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()),2));
                    dr["ItemTotal"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()),2));
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "True")
                    {
                        dr["SrfFlag"] = 1;
                    }
                    else
                    {
                        dr["SrfFlag"] = 0;
                    }
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

        // هعمل متغيرين لحفظ كود واسم العميل 
        //عشان لو الفاتورة مش لعميل مسجل هخلي قيمتهم null
        public int  CustCodeNull;
        public string CustNameNull;

        //==================================================================
        //=============================================================================
        //=============================================================================

        // لعرض بيانات الفاتورة عند البحث في الفواتير
        public int BillID;
        public DataSet ds5 = new DataSet();
        public int[] olditemcode;
        public decimal[] oldquantity;
   

        public void Find_Bill(int BillNoSearch)
        {


            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("MainBills_SelectByNo",
                new RetriveData.prameter("@BillNo", SqlDbType.Int, BillNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["BillFrm"] as BillFrm;

            y.BillID = int.Parse(dt.Rows[0]["BillID"].ToString());
            y.BillNoTXT.Text = dt.Rows[0]["BillNo"].ToString();
            y.BillDate.Text  = dt.Rows[0]["BillDate"].ToString();
            if (dt.Rows[0]["CustCode"].ToString() == "0")
            {
                y.CustCodeCMBO.Text = "";
                y.CustCodeNull = 0;
            }
            else 
            {
              y.CustCodeCMBO.Text = dt.Rows[0]["CustCode"].ToString();
            }
            y.CustNameCMBO .Text = dt.Rows[0]["CustName"].ToString();
            y.Df3TypeCMBO.Text = dt.Rows[0]["BillType"].ToString();
            y.CountDATE.Text = dt.Rows[0]["CountDate"].ToString();
            y.DribaTXT.Text = dt.Rows[0]["BillDriba"].ToString();
      
            y.NotesTXT.Text = dt.Rows[0]["BillNotes"].ToString();
            y.TotalBeforeDiscountTXT.Text = dt.Rows[0]["TotalBill"].ToString();
            y.TotalDiscountTXT.Text = dt.Rows[0]["TotalDiscount"].ToString();
            y.TotalAfterDiscountTXT.Text = dt.Rows[0]["TotalAfterDiscount"].ToString();
            y.DribaValueTXT .Text = dt.Rows[0]["TotalDriba"].ToString();
            y.TotalAfterDribaTXT .Text = dt.Rows[0]["TotalAfterDriba"].ToString();
            y.PayTXT.Text = dt.Rows[0]["TotalAfterDriba"].ToString();
            y.DoneTXT.Text = dt.Rows[0]["TotalDone"].ToString();
            y.DontTXT.Text = dt.Rows[0]["TotalDont"].ToString();
            if (dt.Rows[0]["DeleteFlag"].ToString() == "True")
            {
                y.label11.Visible = true;
            }
            else
            {
                y.label11.Visible = false;
            }


            //لوضع اذا كانت مدفوعة نقدي ولا شيك في الكومبو 
            DataTable dtshekmode = new DataTable();
            dtshekmode = RetriveData.ExecuteQuery("shekmodeinbill",
                new RetriveData.prameter("@billno", SqlDbType.Int, BillNoSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtshekmode.Rows.Count > 0)
            {
                if (dtshekmode.Rows[0]["EznType"].ToString() == "نقدي")
                {
                    y.ShekMode.SelectedIndex = 0;
                }
                else
                {
                    y.ShekMode.SelectedIndex = 1;
                }
            }
            
            //
            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور
            DataTable dt2 = new DataTable();
            dt2 = RetriveData.ExecuteQuery("SubBills_SelectByBillNo",
                new RetriveData.prameter("@BillNo", SqlDbType.Int, BillNoSearch ),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            y.dataGridView1.Rows.Clear();
            y.dataGridView1.Rows.Add(dt2.Rows.Count); // هضيف عدد سجلات في الداتا جريد بعدد سجلات العناصر
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                y.dataGridView1.Rows[i].Cells[0].Value = "حـذف";
                if (dt2.Rows[i]["SrfFlag"].ToString() == "1")
                { y.dataGridView1.Rows[i].Cells["SrfFlag"].Value = true; }
                else { y.dataGridView1.Rows[i].Cells["SrfFlag"].Value = false; }
                y.dataGridView1.Rows[i].Cells["ItemCode"].Value = dt2.Rows[i]["ItemCode"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemName"].Value = dt2.Rows[i]["ItemName"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemMeter"].Value = dt2.Rows[i]["ItemMeter"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemQuantity"].Value = Math.Round (decimal.Parse (dt2.Rows[i]["ItemQuantity"].ToString()),2);
                y.dataGridView1.Rows[i].Cells["ItemPrice"].Value = Math.Round (decimal.Parse (dt2.Rows[i]["ItemPrice"].ToString()),2);
                y.dataGridView1.Rows[i].Cells["DiscountPrecent"].Value =Math.Round (decimal.Parse ( dt2.Rows[i]["DiscountPrecent"].ToString()),2);
                y.dataGridView1.Rows[i].Cells["DiscountValue"].Value = Math.Round (decimal.Parse (dt2.Rows[i]["DiscountValue"].ToString()),2);
                y.dataGridView1.Rows[i].Cells["ItemValue"].Value = Math.Round (decimal.Parse(dt2.Rows[i]["ItemQuantity"].ToString()) * decimal.Parse(dt2.Rows[i]["ItemPrice"].ToString()),2);
                y.dataGridView1.Rows[i].Cells["SafyKima"].Value = Math.Round (decimal.Parse (dt2.Rows[i]["ItemTotal"].ToString()),2);
            }


            
            Login.BillSearch2  = true;
        }





        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BillFrm_Load(object sender, EventArgs e)
        {
            try
            {
                ShekMode.SelectedIndex = 0;



                Login.BillSearch = true;
                Login.EznEstlamSearch = false;
                Login.Items_Visable = false;
                Login.BillSearch2 = false;


                // ملي كومبو بوكس كود العميل
                Validation.FillComboBox(CustCodeCMBO, "customers_selectall", "CustCode");

                //ملئ كومبو بوكس اسم العميل
                Validation.FillComboBox(CustNameCMBO, "customers_selectall", "CustName");

                CustCodeCMBO.Text = "";
                CustNameCMBO.Text = "";
                Df3TypeCMBO.SelectedIndex = 0;

                //للحصول ع اخر رقم اخر اذن
                Validation.GetLasRecord("Billno", "MainBills", BillNoTXT);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("users_selectbyusername",
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dt.Rows[0]["PerCustomers"].ToString() == "False")
            {
                MessageBox.Show("عفوا ليس لديك صلاحية الدخول لشاشة العملاء", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }
            CustomersFrm frm = new CustomersFrm();
            frm.ShowDialog();
        }

        private void CustCodeCMBO_DropDown(object sender, EventArgs e)
        {
            // ملي كومبو بوكس كود العميل
            Validation.FillComboBox(CustCodeCMBO, "customers_selectall", "CustCode");
        }

        private void CustNameCMBO_DropDown(object sender, EventArgs e)
        {
            //ملئ كومبو بوكس اسم العميل
            Validation.FillComboBox(CustNameCMBO, "customers_selectall", "CustName");

        }

        private void CustCodeCMBO_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CustCodeCMBO , "");
            //كتابة اسم العميل في كومبو الاسم عند اختيار الكود
            if (CustCodeCMBO.Text.Trim() != "" &&CustCodeCMBO . Text != "System.Data.DataRowView")
            {


                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("customers_selectbycode",
                    new RetriveData.prameter("@custcode", SqlDbType.Int, int.Parse(CustCodeCMBO.Text.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                   CustNameCMBO.Text = dt.Rows[0]["CustName"].ToString();
                }
                else
                {
                    CustNameCMBO.Text = "";
                }

            }
        }

        private void CustNameCMBO_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CustNameCMBO , "");
            //كتابة اسم العميل في كومبو الاسم عند اختيار الكود
            if (CustNameCMBO.Text.Trim() != "" && CustNameCMBO.Text != "System.Data.DataRowView")
            {


                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("customers_selectbyname",
                    new RetriveData.prameter("@Custname", SqlDbType.NVarChar, CustNameCMBO.Text),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    CustCodeCMBO.Text = dt.Rows[0]["CustCode"].ToString();
                }
                else
                {
                    CustCodeCMBO.Text = "";
                }

            }
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Login.BillSearch2  = false;
            Validation.TextClear(this, panel1);
            Validation.TextClear(this, panel4);
            Df3TypeCMBO.SelectedIndex = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DribaTXT.Text = "0";
            label11.Visible = false;
            ShekMode.SelectedIndex = 0;

            //للحصول ع اخر رقم اخر اذن
            Validation.GetLasRecord("billno", "MainBills", BillNoTXT );
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            SearchItemsFrm frm = new SearchItemsFrm();
            frm.ShowDialog();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


            //لتغيير قيمة حقل تم الصرف بين الترو والفولس
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                {
                    dataGridView1.CurrentRow.Cells[1].Value = false;
                }
                else
                {



                    dataGridView1.CurrentRow.Cells[1].Value = true;



                    //التأكد من ان القيمة المراد بيعها موجودة في المخزن
                    //اذا كان بيع اول مرة مش تعديل
                    if (Login.BillSearch2 == false)
                    {
                        //اذا كان الصنف عادي مش طقم
                        DataTable dt0 = new DataTable();
                        dt0 = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse (dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dt0.Rows.Count > 0)
                        {
                            //طرح الكمية المستلمة من الكمية المصروفة لمعرفة الكمية الموجودة في المخزن
                            decimal Store_quantity = (decimal.Parse(dt0.Rows[0]["quantityinput"].ToString()) +  - decimal.Parse(dt0.Rows[0]["StoreQuantityOutPut"].ToString()));
                            if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                            {
                                if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                                {
                                    MessageBox.Show("الكمية الموجودة حاليا في المخزن من" + " " + "( " + dt0.Rows[0]["ItemName"].ToString() + " )" + " " + "هي" + " " + "( " + Store_quantity.ToString() + " )" + " " + "." + " " + "برجاء تعديل الكمية المباعة من هذا الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    dataGridView1.CurrentRow.Cells[5].Value = 0;
                                }
                            }
                        }
                        else //اذا كان طقم
                        {
                            DataTable dtMI = new DataTable();
                            dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                                new RetriveData.prameter("@tkmcode", SqlDbType.BigInt , Int64 .Parse (dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                            for (int x = 0; x < dtMI.Rows.Count; x++)
                            {
                                DataTable dtSI = new DataTable();
                                dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse (dtMI.Rows[x]["ItemCode"].ToString())),
                                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                                decimal Store_quantity = (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString()) - decimal.Parse(dtSI.Rows[0]["StoreQuantityOutPut"].ToString()));
                                if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                                {
                                    if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                                    {
                                        MessageBox.Show("الصنف " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم ، الكمية الموجودة منه حاليا في المخزن" + " " + "( " + Store_quantity.ToString() + " )" + " " + "فقط . برجاء تعديل الكمية المباعة من هذا الطقم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        dataGridView1.CurrentRow.Cells[5].Value = 0;

                                    }
                                }


                            }

                        }


                    }
                    else
                    //لو كان تعديل في بيانات الفاتورة
                    {


                        DataTable dtSI = new DataTable();
                        DataTable dtBill = new DataTable();
                        dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse (dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dtSI.Rows.Count > 0)
                        {
                            dtBill = RetriveData.ExecuteQuery("Select_Old_Quan_Of_Bill",
                                new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            if (dtBill.Rows.Count > 0)
                            {
                                //الكمية القديمة اللي في الفاتورة
                                decimal OldQuanOfBill = (decimal.Parse(dtBill.Rows[0][0].ToString()));
                                // الكمية القديمة ناقص كل اللي موجود ف الداتا جريد
                                decimal x = (OldQuanOfBill - (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString())));

                                decimal z = (decimal.Parse(dtSI.Rows[0]["StoreQuantityOutPut"].ToString()) - x);

                                decimal StoreInPut = (decimal.Parse(dtSI.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dtSI.Rows[0]["QuantityStart"].ToString()));

                                if (z > StoreInPut)
                                {
                                    MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + "الكمية الموجودة منه في المخزن أقل من هذه الكمية . لذلك لايمكن صرف هذه الكمية منه ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    dataGridView1.CurrentRow.Cells[5].Value = OldQuanOfBill;
                                }
                            }
                            else
                            {
                                DataTable dt01 = new DataTable();
                                dt01 = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                                if (dt01.Rows.Count > 0)
                                {
                                    //طرح الكمية المستلمة من الكمية المصروفة لمعرفة الكمية الموجودة في المخزن
                                    decimal Store_quantity = (decimal.Parse(dt01.Rows[0]["quantityinput"].ToString()) + -decimal.Parse(dt01.Rows[0]["StoreQuantityOutPut"].ToString()));
                                    if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                                    {
                                        if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                                        {
                                            MessageBox.Show("الكمية الموجودة حاليا في المخزن من" + " " + "( " + dt01.Rows[0]["ItemName"].ToString() + " )" + " " + "هي" + " " + "( " + Store_quantity.ToString() + " )" + " " + "." + " " + "برجاء تعديل الكمية المباعة من هذا الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            dataGridView1.CurrentRow.Cells[5].Value = 0;
                                        }
                                    }
                                }
            
                            }
                        }
                        else
                        {
                            dtBill = RetriveData.ExecuteQuery("Select_Old_Quan_Of_Bill",
                                new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            if (dtBill.Rows.Count > 0)
                            {
                                decimal OldQuanOfBill = (decimal.Parse(dtBill.Rows[0][0].ToString()));

                                DataTable dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                                    new RetriveData.prameter("@tkmcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                                for (int x = 0; x < dtMI.Rows.Count; x++)
                                {
                                    dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dtMI.Rows[x]["itemcode"].ToString())),
                                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                                    decimal x0 = (OldQuanOfBill - decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()));
                                    decimal z0 = (decimal.Parse(dtSI.Rows[0]["StoreQuantityOutPut"].ToString()) - x0);

                                    decimal StoreInPut0 = (decimal.Parse(dtSI.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dtSI.Rows[0]["QuantityStart"].ToString()));
                                    if (z0 > StoreInPut0)
                                    {
                                        MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + "وهو احد مكونات هذا الطقم ، الكمية الموجودة منه في المخزن أقل من هذه الكمية . لذلك لايمكن صرف هذه الكمية منه  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        dataGridView1.CurrentRow.Cells[5].Value = OldQuanOfBill;
                                    }


                                }

                            }
                        }


                    }

                    //=========================================================





                    //=====================================================
                }
            }


                // لحذف صنف من الداتا جريد
                if (e.ColumnIndex == 0)
                {


                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                    if (dataGridView1.Rows.Count == 0)
                    {
                        TotalBeforeDiscountTXT.Text = "0";
                        TotalDiscountTXT.Text = "0";
                        TotalAfterDiscountTXT.Text = "0";
                        DribaValueTXT.Text = "0";
                        TotalAfterDribaTXT.Text = "0";
                    }

                    //2 == حسابات القيم النهائية

                    decimal TotBeforeDis = 0;
                    decimal TotDisc = 0;
                    decimal TotAfterDisc = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        //الاجمالي قبل الخصم
                        TotBeforeDis = (TotBeforeDis + decimal.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()));
                        TotalBeforeDiscountTXT.Text = TotBeforeDis.ToString();

                        //اجمالي الخصم
                        TotDisc = (TotDisc + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                        TotalDiscountTXT.Text = TotDisc.ToString();

                        //صافي القيمة
                        TotAfterDisc = (TotAfterDisc + decimal.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()));
                        TotalAfterDiscountTXT.Text = TotAfterDisc.ToString();
                    }
                }
        
            }
        

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (BillNoTXT.Text == "")
            {
                MessageBox.Show("برجاء ادخال رقم الفاتورة أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.CurrentCell.Value = 0;
                return;
            }

            //==لو المستخدم عدل في حقل السعر والخصم والكمية وتركه فاضي البرنامج يجعل قيمته0 لتفادي حدوث اخطاء============
            if (dataGridView1.CurrentRow.Cells[5].Value == null)
            {
                dataGridView1.CurrentRow.Cells[5].Value = 0;
            }

            if (dataGridView1.CurrentRow.Cells[6].Value == null)
            {
                dataGridView1.CurrentRow.Cells[6].Value = 0;
            }

            if (dataGridView1.CurrentRow.Cells[7].Value == null)
            {
                dataGridView1.CurrentRow.Cells[7].Value = 0;
            }
            //===


            //همنع المستخدم انه يخلي قيمة الصرف صح اذا كان تم ادخال هذا الصنف من هذه الفاتورة في جدول اذون الصرف
            // عشان امنع المستخدم من صرف الكمية مرتين
            DataTable dtCheckInEznSrf = new DataTable();

            dtCheckInEznSrf = RetriveData.ExecuteQuery("Select_SubEznSrf_byBillNo",
                  new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                  new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                  new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtCheckInEznSrf.Rows.Count > 0)
            {

                if (e.ColumnIndex == 1)
                {


                    MessageBox.Show("تم الصرف من هذا الصنف عن طريق اذن صرف سابق . لذلك لا يمكن صرف الكمية مرة أخرى", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[1].Value = false;
                    return;


                }
                if (e.ColumnIndex == 5)
                {


                    MessageBox.Show("تم الصرف من هذا الصنف عن طريق اذن صرف سابق . لذلك لا يمكنك تعديل هذه الكمية ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[5].Value = oldquanofcell;
        
                    return;

                }
                

            }


            //=====================================================
            //التأكد من ان القيمة المراد بيعها موجودة في المخزن
            //اذا كان بيع اول مرة مش تعديل
            if (Login.BillSearch2 == false)
            {
                //اذا كان الصنف عادي مش طقم
                DataTable dt0 = new DataTable();
                dt0 = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt0.Rows.Count > 0)
                {
                    //طرح الكمية المستلمة من الكمية المصروفة لمعرفة الكمية الموجودة في المخزن
                    decimal Store_quantity = (decimal.Parse(dt0.Rows[0]["quantityinput"].ToString())  - decimal.Parse(dt0.Rows[0]["quantityoutput"].ToString()));
                    
                    if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                    {
                        if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                        {
                            MessageBox.Show("الكمية الموجودة حاليا في المخزن " + " "  + " " + "هي" + " " + "( " + Store_quantity.ToString() + " )" + " " + "." + " " + "برجاء تعديل الكمية المباعة من هذا الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView1.CurrentRow.Cells[5].Value = 0;
                        }
                    }
                }
                else //اذا كان طقم
                {
                    DataTable dtMI = new DataTable();
                    dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                        new RetriveData.prameter("@tkmcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                    for (int x = 0; x < dtMI.Rows.Count; x++)
                    {
                        DataTable dtSI = new DataTable();
                        dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dtMI.Rows[x]["ItemCode"].ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        decimal Store_quantity = (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString()) - decimal.Parse(dtSI.Rows[0]["quantityoutput"].ToString()));
                        if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                        {
                            if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                            {
                                MessageBox.Show("الصنف " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم ، الكمية الموجودة منه حاليا في المخزن" + " " + "( " + Store_quantity.ToString() + " )" + " " + "فقط . برجاء تعديل الكمية المباعة من هذا الطقم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[5].Value = 0;
                            }
                        }


                    }

                }

            }
            else
            //لو كان تعديل في بيانات الفاتورة
            {

                DataTable dtSI = new DataTable();
                DataTable dtBill = new DataTable();
                dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtSI.Rows.Count > 0)
                {
                    dtBill = RetriveData.ExecuteQuery("Select_Old_Quan_Of_Bill",
                        new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dtBill.Rows.Count > 0)
                    {
                        //الكمية القديمة اللي في الفاتورة
                        decimal OldQuanOfBill = (Math .Round (decimal.Parse(dtBill.Rows[0][0].ToString()),2));
                        // الكمية القديمة ناقص كل اللي موجود ف الداتا جريد
                        decimal x = (Math.Round (OldQuanOfBill - (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString())),2));

                        decimal z =(Math .Round ( (decimal.Parse(dtSI.Rows[0]["quantityoutput"].ToString())) - x,2));

                        decimal StoreInPut = (Math .Round (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString()),2));

                        if (z > StoreInPut && dataGridView1 .CurrentRow .Cells [1].Value .ToString () == "True")
                        {
                            MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + "الكمية الموجودة منه في المخزن أقل من هذه الكمية . لذلك لايمكن تعديل كمية هذا الطقم لهذه الكمية ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView1.CurrentRow.Cells[5].Value = OldQuanOfBill;
                        }
                    }

                    else
                    {
                        DataTable dt01 = new DataTable();
                        dt01 = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dt01.Rows.Count > 0)
                        {
                            //طرح الكمية المستلمة من الكمية المصروفة لمعرفة الكمية الموجودة في المخزن
                            decimal Store_quantity = (decimal.Parse(dt01.Rows[0]["quantityinput"].ToString()) + -decimal.Parse(dt01.Rows[0]["StoreQuantityOutPut"].ToString()));
                            if (dataGridView1.CurrentRow.Cells[1].Value.Equals(true))
                            {
                                if (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) > Store_quantity)
                                {
                                    MessageBox.Show("الكمية الموجودة حاليا في المخزن من" + " " + "( " + dt01.Rows[0]["ItemName"].ToString() + " )" + " " + "هي" + " " + "( " + Store_quantity.ToString() + " )" + " " + "." + " " + "برجاء تعديل الكمية المباعة من هذا الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    dataGridView1.CurrentRow.Cells[5].Value = 0;
                                }
                            }
                        }

                    }
                }
                else
                {
                    dtBill = RetriveData.ExecuteQuery("Select_Old_Quan_Of_Bill",
                        new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dtBill.Rows.Count > 0)
                    {
                        decimal OldQuanOfBill = Math .Round (decimal.Parse(dtBill.Rows[0][0].ToString()),2);
                        
                        DataTable dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                            new RetriveData.prameter("@tkmcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        for (int x = 0; x < dtMI.Rows.Count; x++)
                        {
                            dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dtMI.Rows[x]["itemcode"].ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                            decimal x0 = (Math.Round (OldQuanOfBill - (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()))));
                            decimal z0 = (Math .Round (decimal.Parse(dtSI.Rows[0]["quantityoutput"].ToString()) - x0));

                            decimal StoreInPut0 = (Math .Round (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString())));
                            if (z0 > StoreInPut0 && dataGridView1 .CurrentRow .Cells [1].Value .ToString () == "True")
                            {
                                MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + "وهو احد مكونات هذا الطقم ، الكمية الموجودة منه في المخزن أقل من هذه الكمية . لذلك لايمكن تعديل كمية هذا الطقم لهذه الكمية ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[5].Value = OldQuanOfBill;
                            }
                        
                        
                        }

                    }
                }
               

            }
                
            //=========================================================
            //======================الحسابات==========================

            // 1== الحسابات داخل الداتا جريد
      
            //جعل الخصم نسبة مئوية
            decimal discprecent = (Math .Round (decimal.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()) / 100,2));


            //حساب قيمة الصنف من غير خصم 
            decimal ItemBeforeDisc;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "-")
            {
                ItemBeforeDisc = (Math .Round (decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) * decimal.Parse (dataGridView1.CurrentRow.Cells[6].Value.ToString()),2));
                dataGridView1.CurrentRow.Cells[9].Value = (Math.Round (ItemBeforeDisc,2));
            }
            else
            {
                ItemBeforeDisc = (Math .Round (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) * decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) * decimal.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()),2));
                dataGridView1.CurrentRow.Cells[9].Value = ItemBeforeDisc.ToString();
            }

            //حساب قيمة الخصم
            decimal DiscValue = discprecent * ItemBeforeDisc;
            dataGridView1.CurrentRow.Cells[8].Value = (Math.Round (DiscValue,2));

            //حساب القيمة النهائية بعد الخصم
            dataGridView1.CurrentRow.Cells[10].Value = Math .Round ((ItemBeforeDisc - DiscValue),2);




            //2 == حسابات القيم النهائية

            decimal TotBeforeDis = 0;
            decimal TotDisc = 0;
            decimal TotAfterDisc = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
        
                //الاجمالي قبل الخصم
                TotBeforeDis = (Math.Round (TotBeforeDis + decimal.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()),2));
                TotalBeforeDiscountTXT.Text = TotBeforeDis.ToString();

                //اجمالي الخصم
                TotDisc = (Math.Round (TotDisc + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()),2));
                TotalDiscountTXT.Text = TotDisc.ToString();

                //صافي القيمة
                TotAfterDisc = (Math.Round (TotAfterDisc + decimal.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()),2));
                TotalAfterDiscountTXT.Text = TotAfterDisc.ToString();
            }
        }

        private void Df3TypeCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Df3TypeCMBO.SelectedIndex == 0)
            {
                DoneTXT.ReadOnly = true;
                DoneTXT.Text = PayTXT.Text;
                DontTXT.Text = (decimal.Parse("0,000")).ToString();
            }
            else
            {
                DoneTXT.ReadOnly = false;
                DoneTXT.Text = (decimal.Parse("0,000")).ToString();
                DontTXT.Text = PayTXT.Text;
            }
        }

        private void DribaTXT_TextChanged(object sender, EventArgs e)
        {
            // حساب قيمة الضريبة
            if (TotalAfterDiscountTXT.Text.Trim() != "")
            {
                if (DribaTXT.Text.Trim() == "")
                { DribaTXT.Text = "0"; }
                decimal x = (decimal.Parse(DribaTXT.Text) / 100) * decimal.Parse(TotalAfterDiscountTXT.Text);

                DribaValueTXT . Text = x.ToString();
                TotalAfterDribaTXT . Text = (decimal.Parse(TotalAfterDiscountTXT.Text) + decimal.Parse(DribaValueTXT . Text)).ToString();
                PayTXT.Text = TotalAfterDribaTXT.Text;
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    DoneTXT.Text = PayTXT.Text;
                    DontTXT.Text = (decimal.Parse("0,000")).ToString();
                }
                else
                {
                    DoneTXT.Text = (decimal.Parse("0,000")).ToString();
                    DontTXT.Text = PayTXT.Text;
                }
            }
        }

        private void TotalAfterDiscountTXT_TextChanged(object sender, EventArgs e)
        {
            // حساب قيمة الضريبة
            if (TotalAfterDiscountTXT.Text.Trim() != "")
            {
                if (DribaTXT.Text.Trim() == "")
                { DribaTXT.Text = "0"; }
                decimal x = (decimal.Parse(DribaTXT.Text) / 100) * decimal.Parse(TotalAfterDiscountTXT.Text);

                DribaValueTXT . Text = x.ToString();
                TotalAfterDribaTXT . Text = (decimal.Parse(TotalAfterDiscountTXT.Text) + decimal.Parse(DribaValueTXT . Text)).ToString();
                PayTXT.Text =TotalAfterDribaTXT . Text;
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    DoneTXT.Text = PayTXT.Text;
                    DontTXT.Text = (decimal.Parse("0,000")).ToString();
                }
                else
                {
                    DoneTXT.Text = (decimal.Parse("0,000")).ToString();
                    DontTXT.Text = PayTXT.Text;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {

            if (Login.BillSearch2 == true)
            {
                if (MessageBox.Show("هذه الفاتورة موجودة بالفعل يمكنك تعديل بياناتها أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل فاتورة اخرى ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewBTN_Click(null, null);
                    return;
                }
                else
                {
                    return;
                }
            }



            //التأكد من ادخال جميع البيانات وبشكل صحيح
            if (BillNoTXT . Text.Trim() == "")
            {
                errorProvider1.SetError(BillNoTXT, "يجب ادخال رقم الفاتورة");
                return;
            }

            if (BillDate . Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(BillDate, "التاريخ الذي تم ادخاله لم يأت بعد . برجاء ادخال تاريخ الفاتورة بشكل صحيح");
                return;
            }
            /*
            if (CustCodeCMBO.Text.Trim() == "" && CustNameCMBO .Text .Trim() == "")
            {
                if (MessageBox.Show("لم يتم ادخال بيانات العميل . هل تريد بالتأكيد عدم تسجيل هذه الفاتورة لأي من العملاء المسجلين ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    CustCodeCMBO.Text = "";
                    CustNameCMBO.Text = "";
                    CustCodeCMBO.Focus();
                    return;
                }
                else
                {
                    goto _out;
                }
                
            }
            */
            if (CustCodeCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(CustCodeCMBO ,"يجب ادخال كود العميل");
                return;
            }

            if (CustNameCMBO.Text.Trim() == "")
            { 
            errorProvider1 .SetError (CustNameCMBO ,"يجب ادخال اسم العميل");
            }

            _out: ;

            if (CustCodeCMBO.Text.Trim() != "" && CustNameCMBO.Text.Trim() != "")
            {
                CustCodeNull = int.Parse(CustCodeCMBO.Text);
                CustNameNull = CustNameCMBO.Text;
            }
            else
            {
                CustCodeNull = 0;
                CustNameNull = "";
            }

            
            if (DribaTXT.Text.Trim() == "")
            {
                DribaTXT.Text = "0";
            }

            if (CountDATE.Value.Date <BillDate . Value.Date)
            {
                errorProvider1.SetError(CountDATE, "تاريخ الاستحقاق الذي تم ادخاله قبل تاريخ الفاتورة . برجاء ادخال تاريخ الاستحقاق بشكل صحيح");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف المباعة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التأكد من بيانات الأصناف
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    MessageBox.Show("برجاء التأكد من ادخال كميات جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Focus();
                    return;
                }

                if (dataGridView1.Rows[i].Cells["ItemPrice"].Value.ToString() == "0")
                {
                    MessageBox.Show("برجاء التأكد من ادخال أسعار جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Focus();
                    return;
                }

            }
            if (TotalAfterDiscountTXT.Text.Trim() == "")
            {
                MessageBox.Show("برجاء التأكد من ادخال أسعار جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Focus();
                return;
            }

            if (DoneTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(DoneTXT, "يجب ادخال القيمة المدفوعة");
                return;
            }

            //===================================================================================
            //===================================================================================
            //التسجيل في قاعدة البيانات


            DataTable dt = FillBillDataTable();

            DBConnected db = new DBConnected();
         
            db.cmd.Connection = DBConnected.sqlcon;
            db.cmd.CommandType = CommandType.StoredProcedure;
            db.cmd.CommandText = "Bills_Insert";

            db.cmd.Parameters.AddWithValue("@billno", int.Parse(BillNoTXT . Text));
            db.cmd.Parameters.AddWithValue("@billdate",BillDate . Value.Date);
           
            db.cmd.Parameters.AddWithValue("@Custcode", CustCodeNull );
            db.cmd.Parameters.AddWithValue("@Custname", CustNameNull );
            db.cmd.Parameters.AddWithValue("@billtype", Df3TypeCMBO.Text);
            db.cmd.Parameters.AddWithValue("@countdate", CountDATE.Value.Date);

            db.cmd.Parameters.AddWithValue("@billdriba", decimal.Parse(DribaTXT.Text));
            db.cmd.Parameters.AddWithValue("@billnotes", NotesTXT.Text);
            db.cmd.Parameters.AddWithValue("@totalbill", decimal.Parse(TotalBeforeDiscountTXT . Text));
            db.cmd.Parameters.AddWithValue("@totaldiscount", decimal.Parse(TotalDiscountTXT.Text));
            db.cmd.Parameters.AddWithValue("@totalafterdiscount", decimal.Parse(TotalAfterDiscountTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldriba", decimal.Parse(DribaValueTXT . Text));
            db.cmd.Parameters.AddWithValue("@totalafterdriba", decimal.Parse(TotalAfterDribaTXT . Text));
            db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(DoneTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(DontTXT.Text));
            db.cmd.Parameters.AddWithValue("@username", Login.UserName);
            db.cmd.Parameters.AddWithValue("@BillsDataTable", dt);
            db.cmd .Parameters .AddWithValue ("@ShekMode",ShekMode.Text);
            db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);
       
            string desc;
            if (Df3TypeCMBO.SelectedIndex == 0)
            {
                desc = "فاتورة مبيعات "  + " " + "-" + "نـقـدية";
            }
            else
            {
                desc = "فاتورة مبيعات  " + " " + "-" + "اجــلة";
            }
            db.cmd.Parameters.AddWithValue("@movedescription", desc);


            int r = db.cmd.ExecuteNonQuery();
            if (r < 1)
            {
                MessageBox.Show(" تم تسجيل فاتورة اخرى مسبقا بنفس الرقم . برجاء التأكد من رقم الفاتورة واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //=================================================================================
            //=================================================================================


            //اضافة في جدول حركة الأصناف

            DataTable dtT = new DataTable();
            DataTable dtMT = new DataTable();

            for (int t = 0; t < dataGridView1.Rows.Count; t++)
            {
                if (dataGridView1 .Rows [t].Cells[1].Value.ToString() == "True")
                {
                    dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
             
                if (dtT.Rows.Count > 0)
                {
                    RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                        new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                        new RetriveData.prameter("@billdate", SqlDbType.Date, BillDate . Value.Date),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                        new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[3].Value.ToString()),
                        new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "فاتورة مبيعات"),
                        new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[5].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                }
                else
                {
                    dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                        new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    for (int m = 0; m < dtMT.Rows.Count; m++)
                    {
                        RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                            new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                            new RetriveData.prameter("@billdate", SqlDbType.Date, BillDate . Value.Date),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                            new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                            new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "فاتورة مبيعات"),
                            new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[5].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    }
                }
                }
            }
            


            NewBTN_Click(null, null);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void DoneTXT_TextChanged(object sender, EventArgs e)
        {
            if (PayTXT.Text.Trim() != "")
            {
                if (DoneTXT.Text.Trim() == "")
                { DoneTXT.Text = "0"; }
                DontTXT.Text = (decimal.Parse(PayTXT.Text) - decimal.Parse(DoneTXT.Text)).ToString();
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Login.billfrm = true;
            Login.fastbillfrm = false;
            SearchBill frm = new SearchBill();
            frm.ShowDialog();
        }

        private void EdietBTN_Click(object sender, EventArgs e)
        {
            //عشان اخلي الأدمن فقط اللي يقدر يعدل الفاتورة
            DataTable dtupdate = new DataTable();
            dtupdate = RetriveData.ExecuteQuery("users_selectbyusername",
                new RetriveData .prameter ("@username" ,SqlDbType.NVarChar , Login .UserName));

            if (dtupdate.Rows[0]["PerUpdate"].ToString() == "False")
            {
                MessageBox.Show("صلاحية التعديل غير متاحة للمستخدم الحالي", "", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }


            if (Login.BillSearch2  == false)
            {
                MessageBox.Show("اختر الفاتورة التي تريد تعديل بياناتها من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }


            //التأكد من ان الفاتورة غير ملغية
            if (label11.Visible == true)
            {
                MessageBox.Show("هذه الفاتورة ملغية لايمكن تعديل بياناتها", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            //التأكد من ادخال جميع البيانات وبشكل صحيح
            if (BillNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(BillNoTXT, "يجب ادخال رقم الفاتورة");
                return;
            }

            if (BillDate.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(BillDate, "التاريخ الذي تم ادخاله لم يأت بعد . برجاء ادخال تاريخ الفاتورة بشكل صحيح");
                return;
            }

            if (CustCodeCMBO.Text.Trim() == "" && CustNameCMBO.Text.Trim() == "")
            {
                if (MessageBox.Show("لم يتم ادخال بيانات العميل . هل تريد بالتأكيد عدم تسجيل هذه الفاتورة لأي من العملاء المسجلين ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    CustCodeCMBO.Text = "";
                    CustNameCMBO.Text = "";
                    CustCodeCMBO.Focus();
                    return;
                }
                else
                {
                    goto _out;
                }

            }

            if (CustCodeCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(CustCodeCMBO, "يجب ادخال كود المورد");
                return;
            }

            if (CustNameCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(CustNameCMBO, "يجب ادخال اسم المورد");
            }

             _out: ;

            if (CustCodeCMBO.Text.Trim() != "" && CustNameCMBO.Text.Trim() != "")
            {
                CustCodeNull = int.Parse(CustCodeCMBO.Text);
                CustNameNull = CustNameCMBO.Text;
            }
            else
            {
                CustCodeNull = 0;
                CustNameNull = "";
            }


            if (DribaTXT.Text.Trim() == "")
            {
                DribaTXT.Text = "0";
            }

            if (CountDATE.Value.Date < BillDate.Value.Date)
            {
                errorProvider1.SetError(CountDATE, "تاريخ الاستحقاق الذي تم ادخاله قبل تاريخ الفاتورة . برجاء ادخال تاريخ الاستحقاق بشكل صحيح");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف المباعة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التأكد من بيانات الأصناف
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    MessageBox.Show("برجاء التأكد من ادخال كميات جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Focus();
                    return;
                }

                if (dataGridView1.Rows[i].Cells["ItemPrice"].Value.ToString() == "0")
                {
                    MessageBox.Show("برجاء التأكد من ادخال أسعار جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Focus();
                    return;
                }

            }
            if (TotalAfterDiscountTXT.Text.Trim() == "")
            {
                MessageBox.Show("برجاء التأكد من ادخال أسعار جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Focus();
                return;
            }

            if (DoneTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(DoneTXT, "يجب ادخال القيمة المدفوعة");
                return;
            }


              //===================================================================================
            //===================================================================================
            //التسجيل في قاعدة البيانات

                 

                
            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذه الفاتورة ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {






                DataTable dt = FillBillDataTable ();

                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;
                db.cmd.CommandType = CommandType.StoredProcedure;
                db.cmd.CommandText = "Bills_Update";

                db.cmd.Parameters.AddWithValue("@billid", BillID );
                db.cmd.Parameters.AddWithValue("@billno", int.Parse(BillNoTXT . Text));
                db.cmd.Parameters.AddWithValue("@Billdate",BillDate . Value.Date);
                db.cmd.Parameters.AddWithValue("@custcode", CustCodeNull );
                db.cmd.Parameters.AddWithValue("@Custname", CustNameNull );
                db.cmd.Parameters.AddWithValue("@billtype", Df3TypeCMBO.Text);
                db.cmd.Parameters.AddWithValue("@countdate", CountDATE.Value.Date);
                db.cmd.Parameters.AddWithValue("@billdriba", decimal.Parse(DribaTXT.Text));
                db.cmd.Parameters.AddWithValue("@billnotes", NotesTXT.Text);
                db.cmd.Parameters.AddWithValue("@totalbill", decimal.Parse(TotalBeforeDiscountTXT . Text));
                db.cmd.Parameters.AddWithValue("@totaldiscount", decimal.Parse(TotalDiscountTXT.Text));
                db.cmd.Parameters.AddWithValue("@totalafterdiscount", decimal.Parse(TotalAfterDiscountTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldriba", decimal.Parse(DribaValueTXT . Text));
                db.cmd.Parameters.AddWithValue("@totalafterdriba", decimal.Parse(TotalAfterDribaTXT . Text));
                db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(DoneTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(DontTXT.Text));
                db.cmd.Parameters.AddWithValue("@username", Login.UserName);
                db.cmd.Parameters.AddWithValue("@BillsDataTable", dt);
                db.cmd.Parameters.AddWithValue("@ShekMode", ShekMode.Text);
                db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                string desc;
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    desc = "فاتورة مبيعات "  + " " + "-" + "نـقـدية";
                }
                else
                {
                    desc = "فاتورة مبيعات " +  " " + "-" + "اجــلة";
                }
                db.cmd.Parameters.AddWithValue("@movedescription", desc);


                int r = db.cmd.ExecuteNonQuery();
                if (r < 1)
                {
                    MessageBox.Show(" تم تسجيل فاتورة اخرى مسبقا بنفس الرقم . برجاء التأكد من رقم الفاتورة واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //=================================================================================
                //=================================================================================



                //الحذف اولا من جدول حركة الأصناف
                RetriveData.ExecuteNonQuery("itemstrans_delete_le_bills",
                    new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                //اضافة في جدول حركة الأصناف

                DataTable dtT = new DataTable();
                DataTable dtMT = new DataTable();

                for (int t = 0; t < dataGridView1.Rows.Count; t++)
                {
                    if (dataGridView1.Rows[t].Cells[1].Value.ToString() == "True")
                    {
                        dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dtT.Rows.Count > 0)
                        {
                            RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                                new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                                new RetriveData.prameter("@billdate", SqlDbType.Date, BillDate.Value.Date),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                                new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[3].Value.ToString()),
                                new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "فاتورة مبيعات"),
                                new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[5].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        }
                        else
                        {
                            dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                                new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[2].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            for (int m = 0; m < dtMT.Rows.Count; m++)
                            {
                                RetriveData.ExecuteNonQuery("ItemsTrans_Output_Insert",
                                    new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                                    new RetriveData.prameter("@billdate", SqlDbType.Date, BillDate.Value.Date),
                                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                                    new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                                    new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "فاتورة مبيعات"),
                                    new RetriveData.prameter("@quantityoutput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[5].Value.ToString())),
                                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            }
                        }
                    }
                }
            









                //==================================================
                MessageBox.Show("تم تعديل بيانات الفاتورة  بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);
       
            
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

      
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            
            if (Login.BillSearch2  == false)
            {
                MessageBox.Show("اختر الفاتورة التي تريد الغائها من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }



            //التأكد من ان الاذن غير ملغي
            if (label11.Visible == true)
            {
                MessageBox.Show("هذه الفاتورة ملغية بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            if (MessageBox.Show(" هل تريد بالتأكيد الغاء  هذه الفاتورة ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {






                DataTable dtCheckInEznSrf = new DataTable();
                dtCheckInEznSrf = RetriveData.ExecuteQuery("MainEznSrf_Select_by_billNo",
                    new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtCheckInEznSrf.Rows.Count > 0)
                {
                    if (MessageBox.Show("تم تسجييل عدد" + " " + dtCheckInEznSrf.Rows.Count.ToString() + " " + " اذن صرف خاصة بهذه الفاتورة . اذا قمت بالاستمرار في عملية الالغاء سيؤدي ذلك لالغاء هذه الاذون أيضا . هل تريد بالتأكيد الغاء الفاتورة واذون الصرف الخاصة بها ؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {

                        return;

                    }
                }     
                //لو الفاتورة اللي عايز يلغيها تم الصرف منها عن طريق اذون صرف هلغي معاها اذون الصرف بتاعتها كمان

        

                DataTable dtChekEznMortg3 = new DataTable();
                dtChekEznMortg3 = RetriveData.ExecuteQuery("MainEznMortg3Bill_Select_by_billNo",
                    new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(BillNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtChekEznMortg3.Rows.Count > 0)
                {
                    if (MessageBox.Show("تم تسجييل عدد" + " " +dtChekEznMortg3 . Rows.Count.ToString() + " " + " اذن مرتجع خاصة بهذه الفاتورة . اذا قمت بالاستمرار في عملية الالغاء سيؤدي ذلك لالغاء هذه الاذون أيضا . هل تريد بالتأكيد الغاء الفاتورة واذون المرتجع الخاصة بها ؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {

                        return;

                    }
             
                }

                EznSrfFrm frm = new EznSrfFrm();
                int eznidV;
                int eznnoV;
                for (int i = 0; i < dtCheckInEznSrf.Rows.Count; i++)
                {
                    eznidV = int.Parse(dtCheckInEznSrf.Rows[i]["eznid"].ToString());
                    eznnoV = int.Parse(dtCheckInEznSrf.Rows[i]["eznno"].ToString());
                    frm.EznSrf_Delete(eznidV, eznnoV);
                }

                EznMortg3BillFrm frm2 = new EznMortg3BillFrm();
                int EznidM;
                int EznnoM;
                for (int x = 0; x < dtChekEznMortg3.Rows.Count; x++)
                {
                    EznidM = int.Parse(dtChekEznMortg3.Rows[x]["Eznid"].ToString());
                    EznnoM = int.Parse(dtChekEznMortg3.Rows[x]["eznno"].ToString());
                    frm2.EznMortg3_Delete(EznidM, EznnoM);
                }



                Bill_Delete();








            }

        
        }

        //هعمل فويد لالغاء الفاتورة
        public void Bill_Delete()
        {
            RetriveData.ExecuteNonQuery("Bills_Delete",
                       new RetriveData.prameter("@billid", SqlDbType.Int, BillID),
                       new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (RetriveData.saved == false)
            {
                MessageBox.Show("فشل حذف الفاتورة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            else
            {

                MessageBox.Show("تم الغاء الفاتورة بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);

            }
        }
        private void button3_Click_3(object sender, EventArgs e)
        {
         
        }

        private void button3_Click_4(object sender, EventArgs e)
        {
           
        }
        // old quan
        public decimal oldquanofcell;
        public bool oldSrfFlagCell;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                oldquanofcell =(Math.Round (decimal .Parse ( dataGridView1.CurrentRow.Cells[5].Value.ToString()),2));
            }
       
            
              
             
           
          

        }

        private void CustNameCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BillNoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BillDate.Select();
            }
           

            Validation.NumbersOnly(e);
        }

        private void CustCodeCMBO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               CustNameCMBO . Select();
            }

            Validation.NumbersOnly(e);
        }

        private void DribaTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(DribaTXT, e);
        }

        private void DoneTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Decimalonly(DoneTXT, e);
        }
        
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void BillDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CustCodeCMBO.Select();
            }
        }

        private void Df3TypeCMBO_KeyPress(object sender, KeyPressEventArgs e)
        {
            }

        private void CountDATE_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BillNoTXT_ImeModeChanged(object sender, EventArgs e)
        {
          
        }

        private void BillNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                BillDate.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                CustCodeCMBO.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                DribaTXT.Select(); 
            }
        }

        private void BillDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustCodeCMBO.Select();
            }
        }

        private void CustCodeCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustNameCMBO.Select();
            }
        }

        private void CustNameCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Df3TypeCMBO.Select();
            }
        }

        private void Df3TypeCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShekMode.Select();
            }
        }

        private void CountDATE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DribaTXT.Select();
            }
        }

        private void DribaTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                NotesTXT.Select();
            }
            else if (e.KeyCode == Keys.Down )
            {
                BillNoTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Df3TypeCMBO.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                CountDATE.Select();
            }

        }

        private void DoneTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e .KeyCode == Keys.Down )
            {
                SaveBTN.Select(); 
            }
        }

        private void NotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                button2.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                DribaTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CountDATE.Select();
            }

        }

        private void Df3TypeCMBO_KeyUp(object sender, KeyEventArgs e)
        {
            Df3TypeCMBO.FlatStyle = FlatStyle.Popup;
        }

        private void Df3TypeCMBO_Leave(object sender, EventArgs e)
        {
            Df3TypeCMBO.FlatStyle = FlatStyle.Standard;
        }

        private void ShekMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CountDATE.Select();
            }
        }

        private void ShekMode_KeyUp(object sender, KeyEventArgs e)
        {
            ShekMode.FlatStyle = FlatStyle.Popup;
        }

        private void ShekMode_Leave(object sender, EventArgs e)
        {
            ShekMode.FlatStyle = FlatStyle.Standard;
        }

        private void TotalBeforeDiscountTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotalDiscountTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DribaValueTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalAfterDribaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustCodeCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
