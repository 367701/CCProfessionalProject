using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessionalProject
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                LoginButton.Attributes["class"] = "hidden";
                UserDropdown.Attributes["class"] = "dropdown";

                if(Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value);
                    string userData = ticket.UserData;
                    //System.Diagnostics.Debug.WriteLine(userData);
                    if(userData.Split(',')[0] == "Administrator")
                    {
                        AdministratorPanel.Attributes["class"] = "";
                    }
                    
                    if(userData.Split(',')[1] == "")
                    {
                        ViewProfile.Attributes["class"] = "hidden";
                    }
                    else
                    {
                        ViewProfile.InnerHtml = "<a href=\"Profile?id="+ userData.Split(',')[1]+ "\">View Profile</a>";
                    }
                    
                } 
            }
        }

        protected void Logout_ServerClick(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Default");
        }
    }
}