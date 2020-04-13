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
    public partial class Profile : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack != true) { 
            if(Request.QueryString["id"] != null)
            {
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Team WHERE Id = '"+Request.QueryString["id"]+"'", con))
                {
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            Fullname.Text = sdr[1].ToString();
                            IGN.Text = sdr[3].ToString();
                            Game.Text = sdr[2].ToString();
                            Biography.Text = sdr[4].ToString();
                        }
                    }
                }

                con.Close();
            }
            else
            {
                Response.Redirect("Default");
            }
            }
        }

        protected void Update_ServerClick(object sender, EventArgs e)
        {
            try { 
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                con.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE Team SET Fullname = '"+Fullname.Text+"', Game = '"+Game.Text+ "', IGN = '"+ IGN.Text + "', Biography = '"+ Biography.Text + "' WHERE Id = '"+ Request.QueryString["id"] + "'", con))
                {
                    cmd.ExecuteNonQuery();
                }

                con.Close();

                Message.InnerText = "Successfully updated profile!";

            }
            catch(Exception ex)
            {
                Message.InnerText = "Error updating profile!";
            }
        }
    }
}