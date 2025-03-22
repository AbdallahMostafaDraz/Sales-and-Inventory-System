using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;
using System.Data .SqlClient ;
using System.Windows .Forms ;
using Sales.Classes;
namespace Sales.Classes
{
    class Validation
    {


        //========================================================
        //ميثود لكتابة أرقام فقط

        public static void NumbersOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //===================================================
        //ميثود لكتابة ارقام وعلامات عشرية
        public static void Decimalonly(TextBox txtname, KeyPressEventArgs e)
        {
            if (txtname.Text == "")
            {
                switch (e.KeyChar)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case (char)Keys.Back:
                    case (char)Keys.Enter:
                        e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }

            }
            else if (txtname.Text.Contains("."))
            {

                switch (e.KeyChar)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':

                    case (char)Keys.Back:
                    case (char)Keys.Enter:
                        e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
            else
            {
                switch (e.KeyChar)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '.':
                    case (char)Keys.Back:
                    case (char)Keys.Enter:
                        e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
        }





        //=====================================================================
        // عمل ميثود لمسح الكلام الموجود في التكست بوكس والكومبو بوكس
        public static void TextClear(Form frm, Panel pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control itemPanel in pnl.Controls)
                    {
                        if (itemPanel is TextBox)
                        {
                            itemPanel.Text = "";
                        }
                        if (itemPanel is ComboBox)
                        {
                            itemPanel.Text = "";
                        }
                    }
                }
            }

        }

        // عمل ميثود لمسح الكلام الموجود في التكست بوكس فقط
        public static void TextClearOnly(Form frm, Panel pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control ItemPanel in pnl.Controls)
                    {
                        if (ItemPanel is TextBox)
                        {
                            ItemPanel.Text = "";
                        }
                    }
                }
            }
        }

        //======================================================

        // عمل ميثود لملئ الكومبو بوكس
        public static void FillComboBox(ComboBox cmboname, string storedprocedurename, string displaymember)
        {
            cmboname.DataSource = RetriveData.ExecuteQuery(storedprocedurename,
               new RetriveData.prameter("@companyname", SqlDbType.NVarChar, Login.CompanySelected));
            cmboname.DisplayMember = displaymember;

            cmboname.Text = "";
        }

        //=======================================================

        //عمل ميثود للحصول على رقم اخر اذن 
        public static void GetLasRecord(string FaildName, string TableName, TextBox TXTBOXName)
        {
            DBConnected db = new DBConnected();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = DBConnected.sqlcon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select max(" + FaildName + ") from " + TableName + " where companyname = '" + Login .CompanySelected +"'";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            if (dt.Rows[0][0].ToString() != "")
            {

                TXTBOXName.Text = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();
                TXTBOXName.ReadOnly = true;
            }
            else
            {
                TXTBOXName.Text = "";
                TXTBOXName.ReadOnly = false;
            }
        }


    }

}
