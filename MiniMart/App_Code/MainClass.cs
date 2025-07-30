using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.App_Code
{
    class MainClass
    {
        public static readonly GlobalConnection g = new GlobalConnection();

        #region login
        //check user validation
        public static bool IsValidUser(string username, string password)
        {
            try
            {
                g.cn.Open();
                bool isValid = false;

                SqlCommand cmd = new SqlCommand("userLogin",g.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName",username);
                cmd.Parameters.AddWithValue("@hasPassword",password);
                cmd.Parameters.AddWithValue("@flag","getUserLogin");

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    isValid = true;
                    username = dt.Rows[0]["username"].ToString();
                }
                return isValid;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                g.cn.Close();
            }
        }
        #endregion

        #region username
        //create property for username
        public static string user;
        public static string username 
        {
            get 
            { 
                return user; 
            }
            private set 
            {
                user = value;
            }
        }
        #endregion

    }
}
