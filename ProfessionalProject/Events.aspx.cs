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
    public partial class Events : Page
    {

        public string content = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Events", con))
            {
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        content += "<div class=\"event-box\">"+
                                   "<p class=\"event-header\">"+sdr[1].ToString()+"</p>"+
                                   "<p class=\"event-date\"><span>Date: </span>"+DateTime.Parse(sdr[2].ToString()).ToString("dd/MM/yyyy")+" "+ DateTime.Parse(sdr[3].ToString()).ToString("H:mm")+" - "+ DateTime.Parse(sdr[4].ToString()).ToString("H:mm")+"</p>"+
                                   "<p class=\"event-description\"><span>Description: </span>"+sdr[5].ToString()+"</p>"+
                                   "</div>";
                    }
                }
            }

            con.Close();
        }
    }
}