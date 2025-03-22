using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data .SqlClient ;
using System.Data ;
using Sales.Classes ;

namespace Sales.Classes
{
    class RetriveData
    {
        public static Boolean saved = false;
        public static SqlConnection con = new SqlConnection(DBConnected.Text);

        //==============================================================
        // عمل فانكيشون هترجع داتا من غير ما تاخد بارمترز
        public static DataTable ExecuteQuery(string cmdtxt)
        {



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdtxt;

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }
        //===============================================================

        //===============================================================
        // عمل اوفر لودينج للفانكيشون السابقة عشان ابعتلها برامترز
        public static DataTable ExecuteQuery(string cmdtxt, params prameter[] prams)
        {



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdtxt;

            foreach (prameter prm in prams)
            {
                cmd.Parameters.Add(prm.pname, prm.ptype).Value = prm.pvalue;
            }

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];

        }
        //===============================================================


        //===============================================================
        // عمل فويد لتنفيذ جمل الانسيرت والابديت والدليت فشعان كده هستخدم اكسكيوت نون كويري
        public static void ExecuteNonQuery(string cmdtxt, params prameter[] prams)
        {




            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdtxt;

            foreach (prameter prm in prams)
            {
                cmd.Parameters.Add(prm.pname, prm.ptype).Value = prm.pvalue;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    saved = true;
                }
                else
                {
                    saved = false;
                }

            }
            catch
            {

                con.Close();
            }

        }




        //===============================================================


        //==================================================================     
        // عمل كلاس للبرامترز 
        public class prameter
        {



            public string pname;
            public SqlDbType ptype;
            public object pvalue;

            public prameter(string pname, SqlDbType ptype, object pvalue)
            {

                this.pname = pname;
                this.ptype = ptype;
                this.pvalue = pvalue;
            }


        }

    }
}
