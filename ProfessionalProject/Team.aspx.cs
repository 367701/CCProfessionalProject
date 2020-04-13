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
    public partial class Team : Page
    {
        public string content = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Team", con))
            {
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        content += "<div class=\"event-box\">" +
                                   "<p class=\"event-header\">" + sdr[1].ToString() + " \"" + sdr[3].ToString() + "\"" + "</p>" +
                                   "<p class=\"event-date\"><span>Game: </span>" + sdr[2].ToString() + "</p>" +
                                   "<p class=\"event-description\"><span>Biography: </span>" + sdr[4].ToString() + "</p>" +
                                   "</div>";
                    }
                }
            }

            con.Close();
        }
    }
}