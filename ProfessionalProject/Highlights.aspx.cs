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
    public partial class Highlights : Page
    {
        public string content = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Highlights", con))
            {
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        content += "<div class=\"gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6\">"+
                                    "<iframe type=\"text/html\" width=\"100%\" src=\""+sdr[3].ToString()+"\"></iframe>"+        
                                    "<div class=\"highlight-body\">"+
                                    "<h1>"+sdr[1].ToString()+"</h1>"+
                                    "<p>"+sdr[2].ToString()+"</p>"+
                                    "</div>"+
                                    "</div>";
                    }
                }
            }

            con.Close();
        }
    }
}