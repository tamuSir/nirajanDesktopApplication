using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.App_Code
{
    public class GlobalConnection
    {
        public SqlConnection cn;
        public GlobalConnection() 
        {
            string sqlcon= System.Configuration.ConfigurationManager.AppSettings.Get("connector").ToString();
            cn = new SqlConnection(sqlcon);
        }
    }
}
