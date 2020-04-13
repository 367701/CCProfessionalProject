using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessionalProject
{
    public partial class Apply : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_ServerClick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Applications (FullName,Email,About) VALUES ('"+Fullname.Value+"','"+Email.Value+"','"+About.Value+"')", con))
            {
                cmd.ExecuteNonQuery();
            }

            con.Close();


            Fullname.Value = "";
            Email.Value = "";
            About.Value = "";
            Message.InnerText = "Application submitted successfully!";
        }
    }
}