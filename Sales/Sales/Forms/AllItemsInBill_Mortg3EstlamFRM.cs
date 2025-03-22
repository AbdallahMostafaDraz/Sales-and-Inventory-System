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
using Sales01.Forms;

namespace Sales.Forms
{
    public partial class AllItemsInBill_Mortg3EstlamFRM : Form
    {
        public AllItemsInBill_Mortg3EstlamFRM()
        {
            InitializeComponent();
        }

        private void AllItemsInBill_Mortg3EstlamFRM_Load(object sender, EventArgs e)
        {
            try
            {
                var y = Application.OpenForms["Mortg3EznEstlamFrm"] as Mortg3EznEstlamFrm;


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("SubEznestlam_SelectByEznNo_le_EznMortg3",
                    new RetriveData.prameter("@EznNo", SqlDbType.Int, y.EznEstalmNoSearch),
                    new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
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



                var y = Application.OpenForms["Mortg3EznEstlamFrm"] as Mortg3EznEstlamFrm;

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

                DataGridViewTextBoxCell dcell0 = new DataGridViewTextBoxCell(); //كود
                DataGridViewTextBoxCell dcell1 = new DataGridViewTextBoxCell(); //اسم
                DataGridViewTextBoxCell dcell2 = new DataGridViewTextBoxCell(); //مباع
                DataGridViewTextBoxCell dcell3 = new DataGridViewTextBoxCell(); // مرتجع
                DataGridViewTextBoxCell dcell4 = new DataGridViewTextBoxCell(); //سعر
                DataGridViewTextBoxCell dcell5 = new DataGridViewTextBoxCell(); //اجمالي
  

                drow.Cells.Add(dcell0);
                drow.Cells.Add(dcell1);
                drow.Cells.Add(dcell2);
                drow.Cells.Add(dcell3);
                drow.Cells.Add(dcell4);
                drow.Cells.Add(dcell5);
         
                drow.Cells[0].Value = dataGridView1.CurrentRow.Cells[1].Value;
                drow.Cells[1].Value = dataGridView1.CurrentRow.Cells[2].Value;
                drow.Cells[2].Value = dataGridView1.CurrentRow.Cells[3].Value;
                

                DataTable dt = new DataTable();
                dt = RetriveData.ExecuteQuery("SubEznEstlam_SelectByEznNo_itemcode_le_EznMortg3Estalm",
                new RetriveData.prameter("@eznno", SqlDbType.Int, y.EznEstalmNoSearch ),
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
                drow.Cells[4].Value = dt.Rows[0]["itemprice"].ToString();



                ////هبحث عن الفاتورة في جدول اذن المرتجع عشان لو استرجع منها حاجة قبل كده تجيب الكمية المسترجعه
                decimal EznQuantityDone = 0;


                dtCheckSubEznSrf = RetriveData.ExecuteQuery("select_SubMortgEstlam_byEznNo_itemcode",
                new RetriveData.prameter("@eznno", SqlDbType.Int, y.EznEstalmNoSearch ),
                new RetriveData.prameter("@itemcode", SqlDbType.BigInt, Int64.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())),
                new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

                if (dtCheckSubEznSrf.Rows.Count > 0)
                {
                    for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                    {
                        EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityMortg3"].ToString());

                    }
                    drow.Cells[3].Value = EznQuantityDone;
                }

                else
                {
                    drow.Cells[3].Value = 0;
                }

                drow.Cells[5].Value = (decimal.Parse(drow.Cells[3].Value.ToString()) * decimal.Parse(drow.Cells[4].Value.ToString()));

                y.dataGridView1.Rows.Add(drow);
                Close();


            }

        }
    }
}
