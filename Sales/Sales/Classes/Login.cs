using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Classes;
using System.Data.SqlClient;

namespace Sales.Classes
{
    class Login
    {

        public static string CompanySelected = "";
        public static string AdminUserName;
        public static string UserName;
        public static bool SearchState;
        public static bool CustomersSearchState;
        public static bool VendorsSearchState;

        public static bool ItemsSearchState;

        public static bool MainItemsSearch;
        public static bool MainItemsSearch2; //للبحث عن الأطقم نفسها وليس الأصناف التي تتكون منها مثل اللي فوقها

        public static bool EznEstlamSearch; // لجعل شاشة بحث الأصناف تحمل الأصناف العادية والأطقم
        public static bool EznEstlamSearch2;

        public static bool BillSearch;
        public static bool BillSearch2;

        public static bool Items_Visable;

        public static bool EznSrfSearch;
        public static bool EznSrfSearch2;


        public static bool Df3MaliSearch2;

        public static bool EstlamMaliSerach2;

        public static bool EznMortg3Search;
        public static bool EznMortg3Search2;

        public static bool EznMortg3EstlamSearch;
        public static bool EznMortg3EstlamSearch2;

        public static bool  SettingFromLogin;
        public static bool SettingFromMain;

        public static bool billfrm;
        public static bool fastbillfrm;
        public static bool fastbillfrm2;

    }
}
