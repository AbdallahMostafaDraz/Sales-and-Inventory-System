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
    public partial class AllItemsINBillFrm : Form
    {
        public AllItemsINBillFrm()
        {
            InitializeComponent();
        }

        private void AllItemsINBillFrm_Load(object sender, EventArgs e)
        {
            try
            {

                var y = Application.OpenForms["EznsrfFrm"] as EznSrfFrm;


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = RetriveData.ExecuteQuery("SubBills_SelectByBillNo_le_EznSrf",
                    new RetriveData.prameter("@billno", SqlDbType.Int, y.billNoSearch),
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

                
       
            var y = Application.OpenForms["EznSrfFrm"] as EznSrfFrm ;
            
            for (int i = 0; i < y.dataGridView1.Rows.Count; i++)
            {
                if (Int64 .Parse (y.dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString()) == Int64 .Parse  (dataGridView1 .CurrentRow .Cells [1].Value.ToString ()))
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

            drow.Cells.Add(dcell0);
            drow.Cells.Add(dcell1);
            drow.Cells.Add(dcell2);
            drow.Cells.Add(dcell3);
            drow.Cells.Add(dcell4);

 
            drow.Cells[0].Value = dataGridView1.CurrentRow.Cells[1].Value;
            drow.Cells[1].Value = dataGridView1.CurrentRow.Cells[2].Value;
            drow.Cells[2].Value = dataGridView1.CurrentRow.Cells[3].Value;
         
           drow.Cells[4].Value = 0;


            ////هبحث عن الفاتورة في جدول اذن الصرف عشان لو اتصرف منها حاجة قبل كده تجيب الكمية المصروفة
            decimal EznQuantityDone = 0;

            dtCheckSubEznSrf = RetriveData.ExecuteQuery("Select_SubEznSrf_byBillNo",
            new RetriveData.prameter("@Billno", SqlDbType.Int, y.billNoSearch),
            new RetriveData.prameter("@itemcode", SqlDbType.BigInt , Int64 .Parse (dataGridView1.CurrentRow.Cells[1].Value.ToString())),
            new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));

            if (dtCheckSubEznSrf.Rows.Count > 0)
            {
                for (int s = 0; s < dtCheckSubEznSrf.Rows.Count; s++)
                {
                    EznQuantityDone = EznQuantityDone + decimal.Parse(dtCheckSubEznSrf.Rows[s]["QuantityDone"].ToString());

                }
                drow .Cells [3].Value  = EznQuantityDone;
            }

            else
            {
        drow .Cells [3].Value  = 0;
            }



            y.dataGridView1.Rows.Add(drow);
             Close (); 
               

         }

            
  
        }
    }
}
