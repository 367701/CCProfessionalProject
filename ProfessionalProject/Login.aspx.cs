using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessionalProject
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateUser(string username, string password)
        {
            try { 
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                con.Open();

                string databasePassword = "";

                using (SqlCommand cmd = new SqlCommand("SELECT Password,Role,TeamId FROM Users WHERE (Email = '"+username+"' OR Username = '"+username+"')", con))
                {
                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            databasePassword = sdr[0].ToString();
                            userData = sdr[1].ToString() + "," + (sdr[2]==null?"":sdr[2].ToString());
                        }
                    }
                }

                con.Close();

                if(databasePassword != "")
                {
                    if(password == databasePassword)
                    {
                        return true;
                    }
                }
            } catch(Exception ex)
            {
                return false;
            }

            return false;
        }

        private string userData = "";

        protected void Login_ServerClick(object sender, EventArgs e)
        {
            if(ValidateUser(loginData_Username.Value, loginData_Password.Value) == true)
            {
                FormsAuthenticationTicket tkt = null;
                string cookiestr = null;
                HttpCookie ck = null;

                tkt = new FormsAuthenticationTicket(1, loginData_Username.Value, DateTime.Now,
                DateTime.Now.AddDays(30), loginData_RememberMe.Checked, userData);
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                if (loginData_RememberMe.Checked)
                {
                    ck.Expires = tkt.Expiration;
                }
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);

                Response.Redirect("Default");
            }
            else
            {
                Message.InnerText = "Invalid username or password.";
            }
        }
    }
}