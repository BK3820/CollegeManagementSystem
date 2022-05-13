using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeManagementSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string strUserName = txtuserName.Text;
            string strPassword = txtPassword.Text;
           
            LoginDAL objDAL = new LoginDAL();
            bool bValidate = objDAL.ValidateLogin(strUserName, strPassword);

            lblError.Text = bValidate == true ? "Login Success " : "Login Failed";

            if (bValidate == true)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}