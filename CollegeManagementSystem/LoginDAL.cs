using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CollegeManagementSystem
{
    public class LoginDAL
    {
        public const string CONNECTION_STRING = @" Data Source=HP\SQLEXPRESS;Initial Catalog = CollegeMgntSystem; Integrated Security = True";
        public bool ValidateLogin(string strUserName, string strPassword)
        {
            bool bflag = false;

            SqlConnection objCon = new SqlConnection();
            SqlCommand objcmd = new SqlCommand();
            try
            {
                objCon.ConnectionString = CONNECTION_STRING;
                objCon.Open();
                //validate
                objcmd.CommandType = System.Data.CommandType.Text;
                string SQLQUERY = string.Format("select COUNT(*) from login where username='{0}' and pass='{1}'", strUserName, strPassword);
                objcmd.CommandText = SQLQUERY;//SQL Query to verify usename n password
                objcmd.Connection = objCon;
                int iResult = (int)objcmd.ExecuteScalar();
                bflag = iResult == 1 ? true : false;
            }
            catch (Exception ex)
            {
                bflag = false;
            }
            finally
            {
                objCon.Dispose();
                objcmd.Dispose();
            }
            return bflag;
        }
    }
}