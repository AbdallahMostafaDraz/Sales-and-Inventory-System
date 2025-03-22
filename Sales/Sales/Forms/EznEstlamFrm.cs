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
    public partial class EznEstlamFrm : Form
    {
        public EznEstlamFrm()
        {
            InitializeComponent();
        }



        //=================================================================
        // لوضع الصنف المختار من شاشة البحث في داتا جريد الأصناف

        // لوضع بيانات الصنف الفرعي في الداتا جريد بعد اختيارها من شاشة البحث عن الأصناف
        public bool _err; // عشان لو الصنف اضاف بالفعل شاشة الاصناف ماتقفلش بعد الرسالة 

        public void Find_Item_EznEstlam(Int64  itemcodesearch)
        {
            var y = Application.OpenForms["EznEstlamFrm"] as EznEstlamFrm ;

            for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
            {
                if (Int64.Parse(y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == itemcodesearch)
                {
                    MessageBox.Show("تمت اضافة هذا الصنف بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _err = true;

                    return;
                }
            }

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("items_selectbycode",
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, itemcodesearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));



            DataGridViewRow drow = new DataGridViewRow();

            DataGridViewButtonCell dcell0 = new DataGridViewButtonCell();
            DataGridViewTextBoxCell dcell1 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell2 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell3 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell4 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell5 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell6 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell7 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell8 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dcell9 = new DataGridViewTextBoxCell();
         
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
           

            drow.Cells[0].Value = "حـذف";
            drow.Cells[1].Value = dt.Rows[0]["ItemCode"].ToString();
            drow.Cells[2].Value = dt.Rows[0]["ItemName"].ToString();
            if (dt.Rows[0]["ItemCategory"].ToString() == "سيراميك".Trim())
            { drow.Cells[3].Value = dt.Rows[0]["ItemMeter"].ToString();  }
            else { drow.Cells[3].Value = "-"; }

            drow.Cells[4].Value = 0;
            drow.Cells[5].Value = dt.Rows[0]["itempriceinput"].ToString();
            drow.Cells[6].Value = 0;
            drow.Cells[7].Value = 0;
            drow.Cells[8].Value = 0;
            drow.Cells[9].Value = 0;
        
            y.dataGridView1.Rows.Add(drow);

           
        }

        //=================================================================

        //=================================================================

        //========================================================================
        // هعمل داتا تابل بالاسم الموجود في البروسدجر واملاها من الداتا جريد
        DataTable FillEznEstlamDataTable()
        {

            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {
                dt.Columns.Add("ItemCode", typeof(Int64));
                dt.Columns.Add("ItemName", typeof(string));
                dt.Columns.Add("ItemMeter", typeof(decimal));
                dt.Columns.Add("ItemQuantity", typeof(decimal));
                dt.Columns.Add("ItemPrice", typeof(decimal));
                dt.Columns.Add("DiscountPrecent", typeof(decimal));
                dt.Columns.Add("DiscountValue", typeof(decimal));
                dt.Columns.Add("ItemTotal", typeof(decimal));

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["ItemCode"] = Int64.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    dr["ItemName"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "-")
                    { dr["ItemMeter"] = decimal.Parse("1"); }
                    else { dr["ItemMeter"] = decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()); }
                    dr["ItemQuantity"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()),2));
                    dr["ItemPrice"] =(Math.Round (decimal.Parse ( dataGridView1.Rows[i].Cells[5].Value.ToString()),2));
                    dr["DiscountPrecent"] = (Math.Round(decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()), 2));
                    dr["DiscountValue"] =(Math.Round (decimal.Parse ( dataGridView1.Rows[i].Cells[7].Value.ToString()),2));
                    dr["ItemTotal"] = (Math.Round (decimal.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()),2));
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

     
        //هعمل داتا تابل عشان استخدمها في بروسيدجر طرح كمية الأصناف قبل تعديل الاذن
         DataTable FillTr7QuantityDataTable()
        {

       
            DataTable dt = new DataTable();
            DataRow dr;

            if (dataGridView1.Rows.Count != 0)
            {
                dt.Columns.Add("ItemCode", typeof(Int64));
                dt.Columns.Add("ItemQuantity", typeof(decimal));
         
        

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["ItemCode"] = Int64.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    dr["ItemQuantity"] = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dt.Rows.Add(dr);
                 
                }
                return dt;
            }

            else
            {
                return null;
            }
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
          
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            Login.EznEstlamSearch2 = false;
            Validation.TextClear(this, panel1);
            Validation.TextClear(this, panel4);
            Df3TypeCMBO.SelectedIndex = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DribaTXT.Text = "0";
            label11.Visible = false;
         

            //للحصول ع اخر رقم اخر اذن
            Validation.GetLasRecord("eznno", "MainEznEstlam", EznNoTXT);
        }

        private void EznEstlamFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Login.EznEstlamSearch = true;
                Login.BillSearch = false;
                Login.EznEstlamSearch2 = false;
                Login.Items_Visable = false;
                // ملي كومبو بوكس كود المورد
                Validation.FillComboBox(VenCodeCMBO, "vendors_selectall", "VenCode");

                //ملئ كومبو بوكس اسم المورد
                Validation.FillComboBox(VenNameCMBO, "vendors_selectall", "VenName");
                VenNameCMBO.Text = "";
                VenCodeCMBO.Text = "";
                Df3TypeCMBO.SelectedIndex = 0;

                //للحصول ع اخر رقم اخر اذن
                Validation.GetLasRecord("eznno", "MainEznEstlam", EznNoTXT);
            }
            catch { }
        }

        private void VenCodeCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void VenCodeCMBO_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(VenCodeCMBO, "");
            //كتابة اسم العميل في كومبو الاسم عند اختيار الكود
            if (VenCodeCMBO.Text.Trim () != "" && VenCodeCMBO .Text != "System.Data.DataRowView")
            {
               
             
                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("vendors_selectbycode",
                    new RetriveData.prameter("@vencode", SqlDbType.Int, int.Parse(VenCodeCMBO.Text.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    VenNameCMBO.Text = dt.Rows[0]["VenName"].ToString();
                }
                else
                {
                   VenNameCMBO. Text = "";
                }
             
            }
        }

        private void VenNameCMBO_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(VenNameCMBO, "");
            //كتابة اسم المورد في كومبو الاسم عند اختيار الكود
            if (VenNameCMBO.Text.Trim() != "" && VenNameCMBO.Text != "System.Data.DataRowView")
            {

             
                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("vendors_selectbyname",
                    new RetriveData.prameter("@venname", SqlDbType.NVarChar, VenNameCMBO.Text),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    VenCodeCMBO.Text = dt.Rows[0]["VenCode"].ToString();
                }
                else
                {
                    VenCodeCMBO.Text = "";
                }

            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            
            if (Login.EznEstlamSearch2  == true)
            {
                if (MessageBox.Show("هذا الاذن موجود بالفعل يمكنك تعديل بياناته أو حذفها . هل تريد ادخال بيانات جديدة لتسجيل اذن اخر ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (EznNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznNoTXT, "يجب ادخال رقم اذن الاستلام");
                return;
            }

            if (EznDATE.Value.Date  > DateTime.Now.Date)
            {
                errorProvider1.SetError(EznDATE, "التاريخ الذي تم ادخاله لم يأت بعد . برجاء ادخال تاريخ الاذن بشكل صحيح");
                return;
            }

            if (VenCodeCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(VenCodeCMBO, "يجب ادخال كود المورد");
                return;
            }

            if (VenNameCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(VenNameCMBO, "يجب ادخال اسم المورد");
                return;
            }


            if (VenBillNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(VenBillNoTXT, "يجب ادخال رقم فاتورة المورد");
               return;
            }
            
            
            DataTable dtBillVenNo = new DataTable();
            dtBillVenNo = RetriveData.ExecuteQuery("EznEstlam_Select_VenBillNo",
            new RetriveData.prameter("@VenBillNo", SqlDbType.Int, int.Parse(VenBillNoTXT.Text)),
            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtBillVenNo.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل اذن استلام مسبقا لنفس فاتورة المورد . برجاء التأكد من رقم فاتورة المورد واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VenBillNoTXT.Focus();
                return;
            }

            if (DribaTXT.Text.Trim() == "")
            {
                DribaTXT.Text = "0";
            }

            if (CountDATE.Value.Date < EznDATE.Value.Date)
            {
                errorProvider1.SetError(CountDATE, "تاريخ الاستحقاق الذي تم ادخاله قبل تاريخ الاذن . برجاء ادخال تاريخ الاستحقاق بشكل صحيح");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف المستلمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التأكد من بيانات الأصناف
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString () == "0")
                {
                    MessageBox.Show("برجاء التأكد من ادخال كميات جميع الأصناف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Focus();
                    return;
                }

                if (dataGridView1.Rows[i].Cells["ItemPrice"].Value.ToString () == "0")
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


            DataTable dt = FillEznEstlamDataTable();
           
            DBConnected db = new DBConnected();
            db.cmd.Connection = DBConnected.sqlcon;
            db.cmd.CommandType = CommandType.StoredProcedure;
            db.cmd.CommandText = "EznEstlam_Insert";

            db.cmd.Parameters.AddWithValue("@eznno",int.Parse ( EznNoTXT.Text));
            db.cmd.Parameters.AddWithValue("@ezndate", EznDATE.Value.Date);
            db.cmd.Parameters.AddWithValue("@vencode", int.Parse(VenCodeCMBO.Text));
            db.cmd.Parameters.AddWithValue("@venname", VenNameCMBO.Text);
            db.cmd.Parameters.AddWithValue("@venbillno", int.Parse(VenBillNoTXT.Text));
            db.cmd.Parameters.AddWithValue("@driba", decimal.Parse(DribaTXT.Text));
            db.cmd.Parameters.AddWithValue("@ezntype", Df3TypeCMBO.Text);
            db.cmd.Parameters.AddWithValue("@countdate", CountDATE.Value.Date);
            db.cmd.Parameters.AddWithValue("@eznnotes", NotesTXT.Text);
            db.cmd.Parameters.AddWithValue("@totalezn", decimal.Parse(TotalEznTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldiscount", decimal.Parse(TotalDiscountTXT.Text));
            db.cmd.Parameters.AddWithValue("@totalafterdiscount", decimal.Parse(TotalAfterDiscountTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldriba", decimal.Parse(DribaPrecentTXT.Text));
            db.cmd.Parameters.AddWithValue("@totalafterdriba", decimal.Parse(ValueAfterDriba.Text));
            db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(DoneTXT.Text));
            db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(DontTXT.Text));
            db.cmd.Parameters.AddWithValue("@username", Login.UserName);
            db.cmd.Parameters.AddWithValue("@EznEstlamDataTable", dt);
            db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);
 
            string desc;
            if (Df3TypeCMBO.SelectedIndex == 0)
            {
                desc = "اذن استلام أصناف رقم " + " " + EznNoTXT.Text + " " + "-" + "نـقـدي";
            }
            else
            {
                desc = "اذن استلام أصناف رقم " + " " + EznNoTXT.Text + " " + "-" + "اجــل";
            }
            db.cmd.Parameters.AddWithValue("@movedescription", desc);


            int r = db.cmd.ExecuteNonQuery();
            if (r < 1)
            {
                MessageBox.Show(" تم تسجيل اذن استلام اخر مسبقا بنفس الكود . برجاء التأكد من الكود واعادة المحاولة", "تـسـجـيـل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


           //=================================================================================
           //=================================================================================

        

            //اضافة في جدول حركة الأصناف

            DataTable dtT = new DataTable();
            DataTable dtMT = new DataTable();

            for (int t = 0; t < dataGridView1.Rows.Count; t++)
            {
                dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtT.Rows.Count > 0)
                {
                    RetriveData.ExecuteNonQuery("ItemsTrans_Input_Insert",
                        new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                        new RetriveData.prameter("@billdate", SqlDbType.Date, EznDATE.Value.Date),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                        new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[2].Value.ToString()),
                        new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن استلام أصناف"),
                        new RetriveData.prameter("@quantityinput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                }
                else
                {
                    dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                        new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    for (int m = 0; m < dtMT.Rows.Count; m++)
                    {
                        RetriveData.ExecuteNonQuery("ItemsTrans_Input_Insert",
                            new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                            new RetriveData.prameter("@billdate", SqlDbType.Date, EznDATE.Value.Date),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT .Rows [m]["itemcode"].ToString ())),
                            new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT .Rows [m]["itemname"].ToString ()),
                            new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن استلام أصناف"),
                            new RetriveData.prameter("@quantityinput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    }

                }
            }
               
         

            NewBTN_Click(null, null);
            
         
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            Login.EznEstlamSearch = true;
            SearchItemsFrm frm = new SearchItemsFrm();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // لحذف صنف من الداتا جريد
            if (e.ColumnIndex == 0)
            {




                //حساب الكمية الموجود في المخزن
                if (Login.EznEstlamSearch2 == true)
                {

                    DataTable dt = new DataTable();
                    DataTable dtEzn = new DataTable();


                    dt = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                       new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
                        if (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) < (decimal.Parse(dt.Rows[0]["StoreQuantity"].ToString())) + decimal.Parse(dt.Rows[0]["QuantityStart"].ToString()))
                        {
                            dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                       new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                       new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


                            decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());
                            decimal x = OldQaunOfEzn - decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                            decimal z = (decimal.Parse(dt.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dt.Rows[0]["QuantityStart"].ToString())) - x;
                            if (z < decimal.Parse(dt.Rows[0]["StoreQuantityOutPut"].ToString()))
                            {
                                MessageBox.Show("لا يمكن تعديل كمية هذا الصنف بهذه الكمية ؛ حيث تم بيع هذه الكمية بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية التي تم بيعها من فواتير البيع ", "تـعـديـل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                            }
                        }
                    }
                    else
                    {
                        dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                        new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());

                        DataTable dtMI = new DataTable();
                        dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                            new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        for (int x = 0; x < dtMI.Rows.Count; x++)
                        {

                            DataTable dtSI = new DataTable();
                            dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMI.Rows[x]["Itemcode"].ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            if (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) < (decimal.Parse(dtSI.Rows[0]["StoreQuantity"].ToString())) + decimal.Parse(dtSI.Rows[0]["QuantityStart"].ToString()))
                            {
                                decimal x2 = OldQaunOfEzn - decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                decimal z2 = (decimal.Parse(dtSI.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dtSI.Rows[0]["QuantityStart"].ToString())) - x2;
                                if (z2 < decimal.Parse(dtSI.Rows[0]["StoreQuantityOutPut"].ToString()))
                                {
                                    MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم . تم بيع هذه الكمية منه بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية المباعة منه فواتير البيع أولا ", "تـعـديـل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                                }
                            }

                        }

                    }

                }




                //=====================================================
                //حساب الكمية الموجود في المخزن
                if (Login.EznEstlamSearch2 == true)
                {

                    DataTable dt = new DataTable();
                    DataTable dtEzn = new DataTable();
                    dt = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                       new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                       new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dt.Rows.Count > 0)
                    {
         

                        decimal x = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                        decimal z = (decimal.Parse(dt.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dt.Rows[0]["QuantityStart"].ToString())) - x;
                        if (z < decimal.Parse(dt.Rows[0]["StoreQuantityOutPut"].ToString()))
                        {
                            dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                             new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                             new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                             new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


                            decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());




                            MessageBox.Show("لا يمكن تعديل كمية هذا الصنف بهذه الكمية ؛ حيث تم بيع هذه الكمية بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية التي تم بيعها من فواتير البيع ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                            return;
                        }
                    }
                    else
                    {
                        DataTable dtMI = new DataTable();
                        dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                            new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        for (int x = 0; x < dtMI.Rows.Count; x++)
                        {
                            DataTable dtSI = new DataTable();
                            dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMI.Rows[x]["Itemcode"].ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                            decimal x2 = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                            decimal z2 = (decimal.Parse(dtSI.Rows[0]["StoreQuantity"].ToString()) + decimal.Parse(dtSI.Rows[0]["QuantityStart"].ToString())) - x2;
                            if (z2 < decimal.Parse(dtSI.Rows[0]["StoreQuantityOutPut"].ToString()))
                            {
                                dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                                 new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                                 new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                                 new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));


                                decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());

                                
                                MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم . تم بيع هذه الكمية منه بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية المباعة منه فواتير البيع أولا ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                                return;
                            }


                        }

                    }

                }






                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                if (dataGridView1.Rows.Count == 0)
                {
                   TotalEznTXT . Text = "0";
                    TotalDiscountTXT.Text = "0";
                    TotalAfterDiscountTXT.Text = "0";
                    DribaPrecentTXT . Text = "0";
                    ValueAfterDriba . Text = "0";
                }



                //2 == حسابات القيم النهائية

                decimal TotBeforeDis = 0;
                decimal TotDisc = 0;
                decimal TotAfterDisc = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    //الاجمالي قبل الخصم
                    TotBeforeDis = TotBeforeDis + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                    TotalEznTXT.Text = TotBeforeDis.ToString();

                    //اجمالي الخصم
                    TotDisc = TotDisc + decimal.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    TotalDiscountTXT.Text = TotDisc.ToString();

                    //صافي القيمة
                    TotAfterDisc = TotAfterDisc + decimal.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                    TotalAfterDiscountTXT.Text = TotAfterDisc.ToString();
                }
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (EznNoTXT.Text == "")
            {
                MessageBox.Show("برجاء ادخال رقم الاذن أولا","",MessageBoxButtons .OK , MessageBoxIcon.Warning );
                dataGridView1.CurrentCell.Value = 0;
                return;
            }

            //==لو المستخدم عدل في حقل السعر والخصم والكمية وتركه فاضي البرنامج يجعل قيمته0 لتفادي حدوث اخطاء============
            if (dataGridView1.CurrentRow.Cells[4].Value == null)
            {
                dataGridView1.CurrentRow.Cells[4].Value =0;
            }

            if (dataGridView1.CurrentRow.Cells[5].Value == null)
            {
                dataGridView1.CurrentRow.Cells[5].Value = 0;
            }

            if (dataGridView1.CurrentRow.Cells[6].Value == null)
            {
                dataGridView1.CurrentRow.Cells[6].Value = 0;
            }
            //===


            //=====================================================
            //حساب الكمية الموجود في المخزن
            if (Login .EznEstlamSearch2 == true )
            {
             
                DataTable dt = new DataTable();
                DataTable dtEzn = new DataTable();
               

                dt = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                   new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                   new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    if (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) < (decimal.Parse(dt.Rows[0]["quantityinput"].ToString()))) 
                    {
                        dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                        new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        if (dtEzn.Rows.Count > 0)
                        {
                            decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());
                            decimal x = OldQaunOfEzn - decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                            decimal z = (decimal.Parse(dt.Rows[0]["quantityinput"].ToString())) - x;
                            if (z < decimal.Parse(dt.Rows[0]["quantityoutput"].ToString()))
                            {
                                MessageBox.Show("لا يمكن تعديل كمية هذا الصنف بهذه الكمية ؛ حيث تم بيع هذه الكمية بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية التي تم بيعها من فواتير البيع ", "تـعـديـل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                            }
                        }
                    }
                }
                else
                {
                    dtEzn = RetriveData.ExecuteQuery("Select_OldQuanOfEzn",
                    new RetriveData.prameter("@eznno", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                    new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1 .CurrentRow .Cells [1].Value .ToString ())),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dtEzn.Rows.Count > 0)
                    {
                        decimal OldQaunOfEzn = decimal.Parse(dtEzn.Rows[0][0].ToString());

                        DataTable dtMI = new DataTable();
                        dtMI = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                            new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        for (int x = 0; x < dtMI.Rows.Count; x++)
                        {

                            DataTable dtSI = new DataTable();
                            dtSI = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMI.Rows[x]["Itemcode"].ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            if (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) < (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString())))
                            {
                                decimal x2 = OldQaunOfEzn - decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                decimal z2 = (decimal.Parse(dtSI.Rows[0]["quantityinput"].ToString())) - x2;
                                if (z2 < decimal.Parse(dtSI.Rows[0]["quantityoutput"].ToString()))
                                {
                                    MessageBox.Show("الصنف" + " " + "( " + dtSI.Rows[0]["ItemName"].ToString() + " )" + " " + " وهو احدى مكونات هذا الطقم . تم بيع هذه الكمية منه بالفعل . اذا كنت تريد تعديلها عليك تعديل او الغاء الكمية المباعة منه فواتير البيع أولا ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    dataGridView1.CurrentRow.Cells[4].Value = OldQaunOfEzn;
                                }
                            }

                        }
                    }
                }

            }
                
       
          
            //=====================================================




            //=========================================================
            //======================الحسابات==========================

            // 1== الحسابات داخل الداتا جريد

           
            //جعل الخصم نسبة مئوية
            decimal discprecent =(Math.Round (decimal .Parse ( dataGridView1.CurrentRow.Cells[6].Value.ToString ()) / 100,2));
            

            //حساب قيمة الصنف من غير خصم 
            decimal ItemBeforeDisc;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "-")
            {
                ItemBeforeDisc = (Math.Round (decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) * decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()),2));
                dataGridView1.CurrentRow.Cells[8].Value = (Math.Round (decimal.Parse (ItemBeforeDisc.ToString()),2));
            }
            else
            {
                ItemBeforeDisc =(Math.Round (decimal .Parse (dataGridView1 .CurrentRow .Cells [3].Value .ToString ()) * decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) * decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()),2));
                dataGridView1.CurrentRow.Cells[8].Value = (Math.Round (decimal.Parse (ItemBeforeDisc.ToString()),2));
            }

            //حساب قيمة الخصم
            decimal DiscValue = (Math.Round (discprecent * ItemBeforeDisc,2));
            dataGridView1.CurrentRow.Cells[7].Value = (Math.Round (decimal.Parse (DiscValue.ToString()),2));

            //حساب القيمة النهائية بعد الخصم
            dataGridView1.CurrentRow.Cells[9].Value = (Math.Round((ItemBeforeDisc - DiscValue), 2)); 
        



            //2 == حسابات القيم النهائية

            decimal TotBeforeDis = 0;
            decimal TotDisc = 0;
            decimal TotAfterDisc = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            { 
            
                //الاجمالي قبل الخصم
                TotBeforeDis = (Math.Round (TotBeforeDis + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()),2));
                TotalEznTXT.Text = TotBeforeDis.ToString();

                //اجمالي الخصم
                TotDisc = (Math.Round (TotDisc + decimal.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()),2));
                TotalDiscountTXT.Text = TotDisc.ToString();

                //صافي القيمة
                TotAfterDisc = (Math.Round (TotAfterDisc + decimal.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()),2));
                TotalAfterDiscountTXT.Text = TotAfterDisc.ToString();
            }

        }

        private void TotalAfterDiscountTXT_TextChanged(object sender, EventArgs e)
        {
            // حساب قيمة الضريبة
            if (TotalAfterDiscountTXT.Text.Trim() != "")
            {
                if (DribaTXT.Text.Trim() == "")
                { DribaTXT.Text = "0"; }
                decimal x = (Math .Round ((decimal.Parse(DribaTXT.Text) / 100) * decimal.Parse(TotalAfterDiscountTXT.Text),2));
               
                DribaPrecentTXT.Text = x.ToString();
                ValueAfterDriba.Text = (Math.Round(decimal.Parse(TotalAfterDiscountTXT.Text) + decimal.Parse(DribaPrecentTXT.Text), 2)).ToString();
                PayTXT.Text = ValueAfterDriba.Text;
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    DoneTXT.Text = PayTXT.Text;
                    DontTXT.Text = (Math.Round ((decimal.Parse("0,000")),2).ToString());
                }
                else
                {
                    DoneTXT.Text = (Math .Round ((decimal.Parse("0,000")),2).ToString());
                    DontTXT.Text = PayTXT.Text;
                }

            }
        }

        private void DribaTXT_TextChanged(object sender, EventArgs e)
        {
            // حساب قيمة الضريبة
            if (TotalAfterDiscountTXT.Text.Trim() != "" )
            {
                if (DribaTXT.Text.Trim() == "")
                { DribaTXT.Text = "0"; }
                decimal x = (Math .Round ((decimal.Parse(DribaTXT.Text) / 100) * decimal.Parse(TotalAfterDiscountTXT.Text),2));
            
                DribaPrecentTXT.Text = x.ToString();
                ValueAfterDriba.Text = (Math .Round (decimal.Parse(TotalAfterDiscountTXT.Text) + decimal.Parse(DribaPrecentTXT.Text),2)).ToString();
                PayTXT.Text = (Math.Round (decimal.Parse (ValueAfterDriba.Text),2)).ToString ();
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    DoneTXT.Text = PayTXT.Text;
                    DontTXT.Text = (decimal.Parse("0,00")).ToString();
                }
                else
                {
                    DoneTXT.Text =(decimal.Parse("0,00")).ToString();
                    DontTXT.Text = PayTXT.Text;
                }
            }
        }

        private void ValueAfterDriba_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Df3TypeCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Df3TypeCMBO.SelectedIndex == 0)
            {
                DoneTXT.ReadOnly = true;
                DoneTXT.Text = PayTXT.Text;
                DontTXT.Text = (decimal.Parse("0,00")).ToString();
            }
            else
            {
                DoneTXT.ReadOnly = false ;
                DoneTXT.Text = (decimal.Parse("0,00")).ToString();
                DontTXT.Text = PayTXT.Text;
            }
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

        private void PayTXT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void EznNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznNoTXT, "");
        }

        private void EznDATE_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(EznDATE, "");
        }

        private void VenBillNoTXT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(VenBillNoTXT, "");
        }

        private void CountDATE_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CountDATE, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {

         
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
         
        
            SearchEznEstlamFrm frm = new SearchEznEstlamFrm();
            frm.ShowDialog();
        }




        //=============================================================================
        //=============================================================================
       
        // لعرض بيانات اذن الاستلام عند البحث في اذون الاستلام
        public int EznID;
        public DataSet ds5 = new DataSet();

        public void Find_EznEstalm(int EznEstalmSearch)
        {

            DataTable dt = new DataTable();
            dt = RetriveData.ExecuteQuery("MainEznEstlam_SelectbyNo",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, EznEstalmSearch),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            var y = Application.OpenForms["EznEstlamFrm"] as EznEstlamFrm ;
            
            y.EznID = int.Parse(dt.Rows[0]["EznID"].ToString());
            y.EznNoTXT.Text = dt.Rows[0]["EznNo"].ToString();
            y.EznDATE.Text  = dt.Rows[0]["EznDate"].ToString ();
            y.VenCodeCMBO.Text = dt.Rows[0]["VenCode"].ToString();
            y.VenNameCMBO.Text = dt.Rows[0]["VenName"].ToString();
            y.VenBillNoTXT.Text = dt.Rows[0]["VenBillNo"].ToString();
            y.DribaTXT.Text = dt.Rows[0]["Driba"].ToString();
            y.Df3TypeCMBO.Text = dt.Rows[0]["EznType"].ToString();
            y.CountDATE.Text = dt.Rows[0]["CountDate"].ToString();
            y.NotesTXT.Text = dt.Rows[0]["EznNotes"].ToString();
            y.TotalEznTXT.Text = dt.Rows[0]["TotalEzn"].ToString();
            y.TotalDiscountTXT.Text = dt.Rows[0]["TotalDiscount"].ToString();
            y.TotalAfterDiscountTXT.Text = dt.Rows[0]["TotalAfterDiscount"].ToString();
            y.DribaPrecentTXT.Text = dt.Rows[0]["TotalDriba"].ToString();
            y.ValueAfterDriba.Text = dt.Rows[0]["TotalAfterDriba"].ToString();
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


            //
            //لملئ الداتا جريد بس بطريقة اضافة الصفوف بدل الداتا سورس عشان الايروور
            DataTable dt2 = new DataTable();
            dt2 = RetriveData.ExecuteQuery("SubEznEstlam_SelectbyNo",
                new RetriveData.prameter("@EznNo", SqlDbType.Int, EznEstalmSearch ),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            y.dataGridView1.Rows.Clear();
            y.dataGridView1.Rows.Add(dt2.Rows.Count); // هضيف عدد سجلات في الداتا جريد بعدد سجلات العناصر
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                y.dataGridView1.Rows[i].Cells[0].Value = "حـذف";
                y.dataGridView1.Rows[i].Cells["ItemCode"].Value = dt2.Rows[i]["ItemCode"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemName"].Value = dt2.Rows[i]["ItemName"].ToString();
                y.dataGridView1.Rows[i].Cells["ItemMeter"].Value = decimal.Parse (dt2.Rows[i]["ItemMeter"].ToString());
                y.dataGridView1.Rows[i].Cells["ItemQuantity"].Value = (Math.Round (decimal.Parse (dt2.Rows[i]["ItemQuantity"].ToString()),2));
                y.dataGridView1.Rows[i].Cells["ItemPrice"].Value = (Math.Round (decimal.Parse (dt2.Rows[i]["ItemPrice"].ToString()),2));
                y.dataGridView1.Rows[i].Cells["DiscountPrecent"].Value = (Math.Round(decimal.Parse(dt2.Rows[i]["DiscountPrecent"].ToString()), 2)); 
                y.dataGridView1.Rows[i].Cells["DiscountValue"].Value =(Math.Round (decimal .Parse ( dt2.Rows[i]["DiscountValue"].ToString()),2));
                y.dataGridView1.Rows[i].Cells["ItemValue"].Value = (Math.Round (decimal.Parse(dt2.Rows[i]["ItemQuantity"].ToString()) * decimal.Parse(dt2.Rows[i]["ItemPrice"].ToString()),2));
                y.dataGridView1.Rows[i].Cells["SafyKima"].Value = (Math.Round (decimal.Parse (dt2.Rows[i]["ItemTotal"].ToString()),2));
           
            }


            Login.EznEstlamSearch2 = true;


          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_2(object sender, EventArgs e)
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

            if (Login.EznEstlamSearch2 == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد تعديل بياناته من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchBTN.Focus();
                return;
            }


            //التأكد من ان الاذن غير ملغي
            if (label11.Visible == true)
            {
                MessageBox.Show("هذا الاذن ملغي لايمكن تعديل بياناته", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //التأكد من ادخال جميع البيانات وبشكل صحيح
            if (EznNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(EznNoTXT, "يجب ادخال رقم اذن الاستلام");
                return;
            }

            if (EznDATE.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(EznDATE, "التاريخ الذي تم ادخاله لم يأت بعد . برجاء ادخال تاريخ الاذن بشكل صحيح");
                return;
            }

            if (VenCodeCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(VenCodeCMBO, "يجب ادخال كود المورد");
                return;
            }

            if (VenNameCMBO.Text.Trim() == "")
            {
                errorProvider1.SetError(VenNameCMBO, "يجب ادخال اسم المورد");
                return;
            }



            if (VenBillNoTXT.Text.Trim() == "")
            {
                errorProvider1.SetError(VenBillNoTXT, "يجب ادخال رقم فاتورة المورد");
                return;
            }

            DataTable dtBillVenNo = new DataTable();
            dtBillVenNo = RetriveData.ExecuteQuery("EznEstlam_Select_VenBillNo_update",
            new RetriveData.prameter("@VenBillNo", SqlDbType.Int, int.Parse(VenBillNoTXT.Text)),
            new RetriveData.prameter("@EznID", SqlDbType.Int, EznID),
            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (dtBillVenNo.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل اذن استلام مسبقا لنفس فاتورة المورد . برجاء التأكد من رقم فاتورة المورد واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VenBillNoTXT.Focus();
                return;
            }

            if (DribaTXT.Text.Trim() == "")
            {
                DribaTXT.Text = "0";
            }

            if (CountDATE.Value.Date < EznDATE.Value.Date)
            {
                errorProvider1.SetError(CountDATE, "تاريخ الاستحقاق الذي تم ادخاله قبل تاريخ الاذن . برجاء ادخال تاريخ الاستحقاق بشكل صحيح");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب ادخال الأصناف المستلمة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التأكد من بيانات الأصناف
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
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

            // تعديل كميات جدول الأصناف
         
            //==================================================
            if (MessageBox.Show(" هل تريد بالتأكيد تعديل بيانات هذا الاذن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           






            //تعديل بيانات اذن الاستلام
       
                DataTable dt = FillEznEstlamDataTable();

                DBConnected db = new DBConnected();
                db.cmd.Connection = DBConnected.sqlcon;
                db.cmd.CommandType = CommandType.StoredProcedure;
                db.cmd.CommandText = "EznEstlam_Update";

                db.cmd.Parameters.AddWithValue("@eznid", EznID);
                db.cmd.Parameters.AddWithValue("@eznno", int.Parse(EznNoTXT.Text));
                db.cmd.Parameters.AddWithValue("@ezndate", EznDATE.Value.Date);
                db.cmd.Parameters.AddWithValue("@vencode", int.Parse(VenCodeCMBO.Text));
                db.cmd.Parameters.AddWithValue("@venname", VenNameCMBO.Text);
                db.cmd.Parameters.AddWithValue("@venbillno", int.Parse(VenBillNoTXT.Text));
                db.cmd.Parameters.AddWithValue("@driba", decimal.Parse(DribaTXT.Text));
                db.cmd.Parameters.AddWithValue("@ezntype", Df3TypeCMBO.Text);
                db.cmd.Parameters.AddWithValue("@countdate", CountDATE.Value.Date);
                db.cmd.Parameters.AddWithValue("@eznnotes", NotesTXT.Text);
                db.cmd.Parameters.AddWithValue("@totalezn", decimal.Parse(TotalEznTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldiscount", decimal.Parse(TotalDiscountTXT.Text));
                db.cmd.Parameters.AddWithValue("@totalafterdiscount", decimal.Parse(TotalAfterDiscountTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldriba", decimal.Parse(DribaPrecentTXT.Text));
                db.cmd.Parameters.AddWithValue("@totalafterdriba", decimal.Parse(ValueAfterDriba.Text));
                db.cmd.Parameters.AddWithValue("@totaldone", decimal.Parse(DoneTXT.Text));
                db.cmd.Parameters.AddWithValue("@totaldont", decimal.Parse(DontTXT.Text));
                db.cmd.Parameters.AddWithValue("@username", Login.UserName);
                db.cmd.Parameters.AddWithValue("@EznEstlamDataTable", dt);
                db.cmd.Parameters.AddWithValue("@companyname", Login.CompanySelected);

                string desc;
                if (Df3TypeCMBO.SelectedIndex == 0)
                {
                    desc = "اذن استلام أصناف رقم " + " " + EznNoTXT.Text + " " + "-" + "نـقـدي";
                }
                else
                {
                    desc = "اذن استلام أصناف رقم " + " " + EznNoTXT.Text + " " + "-" + "اجــل";
                }
                db.cmd.Parameters.AddWithValue("@movedescription", desc);


                int r = db.cmd.ExecuteNonQuery();
                if (r < 1)
                {
                    MessageBox.Show(" تم تسجيل اذن استلام اخر مسبقا بنفس الكود . برجاء التأكد من الكود واعادة المحاولة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }







                //اضافة في جدول حركة الأصناف

                DataTable dtT = new DataTable();
                DataTable dtMT = new DataTable();

                for (int t = 0; t < dataGridView1.Rows.Count; t++)
                {
                    dtT = RetriveData.ExecuteQuery("Items_SelectByCode_q",
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    if (dtT.Rows.Count > 0)
                    {
                        RetriveData.ExecuteNonQuery("itemstrans_input_update",
                            new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                            new RetriveData.prameter("@billdate", SqlDbType.Date, EznDATE.Value.Date),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                            new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dataGridView1.Rows[t].Cells[2].Value.ToString()),
                            new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن استلام أصناف"),
                            new RetriveData.prameter("@quantityinput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                    }
                    else
                    {
                        dtMT = RetriveData.ExecuteQuery("mainitems2_selectbycode",
                            new RetriveData.prameter("@tkmcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        for (int m = 0; m < dtMT.Rows.Count; m++)
                        {
                            RetriveData.ExecuteNonQuery("itemstrans_input_update",
                                new RetriveData.prameter("@billcode", SqlDbType.Int, int.Parse(EznNoTXT.Text)),
                                new RetriveData.prameter("@billdate", SqlDbType.Date, EznDATE.Value.Date),
                                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dtMT.Rows[m]["itemcode"].ToString())),
                                new RetriveData.prameter("@itemname", SqlDbType.NVarChar, dtMT.Rows[m]["itemname"].ToString()),
                                new RetriveData.prameter("@movedescription", SqlDbType.NVarChar, "اذن استلام أصناف"),
                                new RetriveData.prameter("@quantityinput", SqlDbType.Decimal, decimal.Parse(dataGridView1.Rows[t].Cells[4].Value.ToString())),
                                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                        }

                    }
                }
            



                MessageBox.Show("تم تعديل بيانات الاذن  بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_5(object sender, EventArgs e)
        {

          
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            if (Login.EznEstlamSearch2 == false)
            {
                MessageBox.Show("اختر الاذن الذي تريد الغائه من شاشة البحث أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                //لو الفاتورة اللي عايز يلغيها تم الصرف منها عن طريق اذون صرف هلغي معاها اذون الصرف بتاعتها كمان



                DataTable dtChekEznMortg3 = new DataTable();
                dtChekEznMortg3 = RetriveData.ExecuteQuery("MainEznMortg3Bill_Select_by_EznEstlamNo",
                    new RetriveData.prameter("@eznestlamno", SqlDbType.Int, int.Parse(EznNoTXT . Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dtChekEznMortg3.Rows.Count > 0)
                {
                    if (MessageBox.Show("تم تسجييل عدد" + " " + dtChekEznMortg3.Rows.Count.ToString() + " " + " اذن مرتجع خاصة بهذا الاذن . اذا قمت بالاستمرار في عملية الالغاء سيؤدي ذلك لالغاء هذه الاذون أيضا . هل تريد بالتأكيد الغاء اذن الاستلام واذون المرتجع الخاصة به ؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }

                }



                Mortg3EznEstlamFrm frm2 = new Mortg3EznEstlamFrm();
                int EznidM;
                int EznnoM;
                for (int x = 0; x < dtChekEznMortg3.Rows.Count; x++)
                {
                    EznidM = int.Parse(dtChekEznMortg3.Rows[x]["Eznid"].ToString());
                    EznnoM = int.Parse(dtChekEznMortg3.Rows[x]["eznno"].ToString());
                    frm2.EznMortg3Estalm_Delete (EznidM, EznnoM);
                }


                EznEstlam_Delete();

               
                
                
                
            }
        }



                //هعمل فويد لالغاء اذن الاستلام
        public void EznEstlam_Delete()
        {

            RetriveData.ExecuteNonQuery("EznEstlam_Delete",
                new RetriveData.prameter("@eznid", SqlDbType.Int, EznID),
                new RetriveData.prameter("@username", SqlDbType.NVarChar, Login.UserName),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            if (RetriveData.saved == false)
            {
                MessageBox.Show("فشل حذف الاذن", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            else
            {
                MessageBox.Show("تم الغاء الاذن بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewBTN_Click(null, null);

            }
            
        }




        private void button2_Click_6(object sender, EventArgs e)
        {
  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        //للحصول على الكية القديمة الموجودة في الاذن قبل التعدييل 
        // للتأكد من القيمة الجديدة اذا كانت ينفع تتعدل او تتحذف
        public decimal Check_quantity;

        private void button2_Click_7(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendorsFrm frm = new VendorsFrm();
            frm.ShowDialog();
        }

        private void VenNameCMBO_DropDown(object sender, EventArgs e)
        {
            //ملئ كومبو بوكس اسم المورد
            Validation.FillComboBox(VenNameCMBO, "vendors_selectall", "VenName");
        }

        private void VenCodeCMBO_DropDown(object sender, EventArgs e)
        {
            // ملي كومبو بوكس كود المورد
            Validation.FillComboBox(VenCodeCMBO, "vendors_selectall", "VenCode");
        }

        private void VenNameCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DribaPrecentTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_8(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_9(object sender, EventArgs e)
        {
           
             

       

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void EznNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void VenCodeCMBO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersOnly(e);
        }

        private void VenBillNoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void EznNoTXT_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void EznNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter |e.KeyCode == Keys.Left)
            {
                EznDATE.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                VenCodeCMBO.Select();
            }
        }

        private void EznDATE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VenCodeCMBO.Select();
            }
        }

        private void VenCodeCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VenNameCMBO.Select();
            }
        }

        private void VenNameCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VenBillNoTXT.Select();
            }
        }

        private void VenBillNoTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Left)
            {
                DribaTXT.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                VenNameCMBO.Select();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Df3TypeCMBO.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                VenCodeCMBO.Select();
            }
        }

        private void DribaTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                Df3TypeCMBO.Select();
            }
            else if (e.KeyCode == Keys.Right)
            {
                VenBillNoTXT.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                VenNameCMBO.Select();
            }
        }

        private void Df3TypeCMBO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CountDATE.Select();
            }
        }

        private void CountDATE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NotesTXT.Select();
            }
        }

        private void NotesTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                AddBTN.Select();
            }
            else if (e.KeyCode == Keys.Up )
            {
                EznNoTXT.Select();
            }
        }

        private void DoneTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Down)
            {
                SaveBTN.Select();
            }
        }

        private void Df3TypeCMBO_KeyUp(object sender, KeyEventArgs e)
        {
            Df3TypeCMBO.FlatStyle = FlatStyle.Flat;
        }

        private void Df3TypeCMBO_Layout(object sender, LayoutEventArgs e)
        {
           Df3TypeCMBO.FlatStyle = FlatStyle.Standard;
        }
        
    }
}
