using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sales.Classes
{
    class DBConnected 
    {


        public static string Text;
        public SqlCommand cmd = new SqlCommand();
        public DBConnected()
        {

            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                Text = @"Server=" + Properties.Settings.Default.ServerName + "; Database =" + Properties.Settings.Default.DatabaseName + "; Integrated Security=false; User ID=" + Properties.Settings.Default.UserName + "; Password=" + Properties.Settings.Default.Password + "";
                sqlcon = new SqlConnection(Text);
            }
            else
            {
                Text = @"Server=" + Properties.Settings.Default.ServerName + "; Database=" + Properties.Settings.Default.DatabaseName + "; Integrated Security=true";
                sqlcon = new SqlConnection(Text);

            }
            OpenConn();
        }
        public static SqlConnection sqlcon = new SqlConnection(Text );

        public void OpenConn()
        {
            if(sqlcon.State == ConnectionState.Open)
            {
               sqlcon.Close();
            }

               sqlcon.Open();
        }
     
       
    }
}
