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
            LoadTeam("");
        }

        protected void Overwatch_ServerClick(object sender, EventArgs e)
        {
            EntireTeam.Attributes["class"] = "";
            OverwatchTeam.Attributes["class"] = "active";
            RocketLeagueTeam.Attributes["class"] = "";
            lolTeam.Attributes["class"] = "";

            LoadTeam("Overwatch");
        }

        protected void RocketLeague_ServerClick(object sender, EventArgs e)
        {
            EntireTeam.Attributes["class"] = "";
            OverwatchTeam.Attributes["class"] = "";
            RocketLeagueTeam.Attributes["class"] = "active";
            lolTeam.Attributes["class"] = "";

            LoadTeam("Rocket League");
        }

        protected void LolTeam_ServerClick(object sender, EventArgs e)
        {
            EntireTeam.Attributes["class"] = "";
            OverwatchTeam.Attributes["class"] = "";
            RocketLeagueTeam.Attributes["class"] = "";
            lolTeam.Attributes["class"] = "active";

            LoadTeam("League Of Legends");
        }

        protected void EntireTeam_ServerClick(object sender, EventArgs e)
        {
            EntireTeam.Attributes["class"] = "active";
            OverwatchTeam.Attributes["class"] = "";
            RocketLeagueTeam.Attributes["class"] = "";
            lolTeam.Attributes["class"] = "";

            LoadTeam("");
        }

        private void LoadTeam(string game)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            string where = "";
            content = "";

            if(game != "")
            {
                where = " WHERE Game = '" + game + "'";
            }

            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Team" + where, con))
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