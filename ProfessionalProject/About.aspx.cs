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
    public partial class About : Page
    {
        public string content = "";

        protected void Page_Load(object sender, EventArgs e)
        {    
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();

            using(SqlCommand cmd = new SqlCommand("SELECT Content FROM Pages WHERE Page = 'About'", con))
            {
                using(SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        content = sdr[0].ToString();
                    }
                }
            }

            con.Close();
        }
    }
}