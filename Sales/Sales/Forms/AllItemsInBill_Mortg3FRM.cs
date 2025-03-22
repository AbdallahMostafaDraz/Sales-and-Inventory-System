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


namespace Sales.Forms
{
    public partial class AllItemsInBill_Mortg3FRM : Form
    {
        public AllItemsInBill_Mortg3FRM()
        {
            InitializeComponent();
        }

        private void AllItemsInBill_Mortg3FRM_Load(object sender, EventArgs e)
        {
            try
            {
                var y = Application.OpenForms["EznMortg3BillFrm"] as EznMortg3BillFrm;


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_le_EznMortg3",
                    new RetriveData.prameter("@billno", SqlDbType.Int, y.billNoSearch),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));



                //هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
                DataTable dtCheckSubEznSrf = new DataTable();


                //هبحث عن الفاتورة في جدول الفواتير الفرعي لايجاد بياناتها في هذه الشاشة         
                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_le_EznMortg3",
                    new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(y.BillNoTXT.Text)),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
                        decimal EznQuantityDone = 0;
                        dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_Quantity_from_eznsrf",
                        new RetriveData.prameter("@Billno", SqlDbType.Int, int.Parse(y.BillNoTXT.Text)),
                        new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dt.Rows[i]["itemcode"].ToString())),
                        new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                        if (dtCheckSubEznSrf.Rows.Count > 0)
                        {
                            for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                            {
                                EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityDone"].ToString());

                            }
                            dataGridView1.Rows[i].Cells["QuantityDone"].Value = EznQuantityDone;
                        }

                        else
                        {
                            DataTable dtChekItemSrfFlag = new DataTable();
                            dtChekItemSrfFlag = RetriveData.ExecuteQuery("ChekItemSrf_FromSubBills",
                            new RetriveData.prameter("@billno", SqlDbType.Int, int.Parse(y.BillNoTXT.Text)),
                            new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dt.Rows[i]["itemcode"].ToString())),
                            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                            if (dtChekItemSrfFlag.Rows.Count == 1)
                            {
                                dataGridView1.Rows[i].Cells["QuantityDone"].Value = dt.Rows[i]["itemquantity"].ToString();
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells["QuantityDone"].Value = 0;
                            }
                        }

                    }
                }

            }
            catch { }
                



        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "اضافة";
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                //عشان اضف صنف تاني على الأصناف الموجودة في الاذن وانا بعمل تعديل



                var y = Application.OpenForms["EznMortg3BillFrm"] as EznMortg3BillFrm ;

                for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
                {
                    if (Int64.Parse(y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("تمت اضافة هذا الصنف بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DataTable dtCheckSubEznSrf = new DataTable();

                DataGridViewRow drow = new DataGridViewRow();

                DataGridViewTextBoxCell dcell0 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell3 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell4 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell5 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dcell6 = new DataGridViewTextBoxCell();
               
                drow.Cells.Add(dcell0);
                drow.Cells.Add(dcell1);
                drow.Cells.Add(dcell2);
                drow.Cells.Add(dcell3);
                drow.Cells.Add(dcell4);
                drow.Cells.Add(dcell5);
                drow.Cells.Add(dcell6);

                drow.Cells[0].Value = dataGridView1.CurrentRow.Cells[1].Value;
                drow.Cells[1].Value = dataGridView1.CurrentRow.Cells[2].Value;
                drow.Cells[2].Value = dataGridView1.CurrentRow.Cells[3].Value;
                drow.Cells[3].Value = dataGridView1.CurrentRow.Cells[4].Value;

              
                 DataTable dt = new DataTable ();
                 dt = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_itemcode_le_EznMortg3",
                 new RetriveData.prameter("@billno", SqlDbType.Int, y.billNoSearch),
                 new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                 new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                 drow.Cells[5].Value = dt.Rows [0]["itemprice"].ToString () ;

               

                ////هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
                decimal EznQuantityDone = 0;

                dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_SubMortg3Bill_byBillNo_itemcode",
                new RetriveData.prameter("@Billno", SqlDbType.Int, y.billNoSearch),
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dtCheckSubEznSrf.Rows.Count > 0)
                {
                    for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                    {
                        EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityMortg3"].ToString());

                    }
                    drow.Cells[4].Value = EznQuantityDone;
                }

                else
                {
                    drow.Cells[4].Value = 0;
                }

                drow.Cells[6].Value = (decimal.Parse(drow.Cells[4].Value.ToString()) * decimal.Parse(drow.Cells[5].Value.ToString()));

                y.dataGridView1.Rows.Add(drow);
                Close();


            }

            
            
        }
    }
}
