using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PUBGWinsUI
{
    public partial class UI : Form
    {
        private static string WinDB; // The connection string to the DB

        public UI()
        {
            InitializeComponent();

            // Set defaults.
            MenuPerspective.Text = "FPP";
            MenuServer.Text = "NA";

            // SQL database.
            WinDB = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Alex\\source\\repos\\PUBGWins\\PUBGWinsUI\\WinDB.mdf; Integrated Security = True";
        }

        private void ButtonStore_Click(object sender, EventArgs e)
        {
            
            int kills = int.Parse(BoxKills.Text);
            string perspective = MenuPerspective.Text;
            string server = MenuServer.Text;
            string map = MenuMap.Text;
            string teammate1 = BoxTeammate1.Text;
            string teammate2 = BoxTeammate2.Text;
            string teammate3 = BoxTeammate3.Text;
            string description = BoxDescription.Text;
            int teammates = 0;

            // Count the teamates
            if (teammate1 != "")
            {
                teammates++;
            }
            if (teammate2 != "")
            {
                teammates++;
            }
            if (teammate3 != "")
            {
                teammates++;
            }


            // Store with SQL
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    // Create a game with no info.
                    using (SqlCommand command = new SqlCommand("INSERT INTO Wins (Empty) VALUES (1)", conn, trans))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        LabelDebug.Text = "Rows affected = " + rowsAffected;
                    }

                    // Set data for this game.
                    if (teammates == 0)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            command.Parameters.AddWithValue("@Kills", kills);
                            command.Parameters.AddWithValue("@Map", map);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Server", server);
                            command.Parameters.AddWithValue("@Perspective", perspective);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                LabelDebug.Text = "A row was updated.";
                            }
                            else
                            {
                                LabelDebug.Text = rowsAffected + " rows were effectied.";
                            }

                        }
                    }
                    else if (teammates == 1)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            command.Parameters.AddWithValue("@Kills", kills);
                            command.Parameters.AddWithValue("@Map", map);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Server", server);
                            command.Parameters.AddWithValue("@Perspective", perspective);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                LabelDebug.Text = "A row was updated.";
                            }
                            else
                            {
                                LabelDebug.Text = rowsAffected + " rows were effectied.";
                            }

                        }
                    }
                    else if (teammates == 2)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            command.Parameters.AddWithValue("@Kills", kills);
                            command.Parameters.AddWithValue("@Map", map);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Server", server);
                            command.Parameters.AddWithValue("@Perspective", perspective);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                LabelDebug.Text = "A row was updated.";
                            }
                            else
                            {
                                LabelDebug.Text = rowsAffected + " rows were effectied.";
                            }

                        }
                    }
                    else if (teammates == 3)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Teammate3 = @Teammate3, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            command.Parameters.AddWithValue("@Kills", kills);
                            command.Parameters.AddWithValue("@Map", map);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.Parameters.AddWithValue("@Teammate3", teammate3);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Server", server);
                            command.Parameters.AddWithValue("@Perspective", perspective);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                LabelDebug.Text = "A row was updated.";
                            }
                            else
                            {
                                LabelDebug.Text = rowsAffected + " rows were effectied.";
                            }

                        }
                    }
                    trans.Commit();
                }
            }
            //SetStats();
            BoxDescription.Text = "";
        }             


        private void SetStats()
        {
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    // Build stats.
                    int erangelWins = 0;
                    int miramarWins = 0;
                    int savageWins = 0;

                    
                    int erangelKills = GetKillCount("Erangel", out erangelWins, conn, trans);
                    int miramarKills = GetKillCount("Miramar", out miramarWins, conn, trans);
                    int savageKills = GetKillCount("Savage", out savageWins, conn, trans);

                    int totalKills = 0;
                    int totalWins = 0;

                    /*
                    // Get erangel count and kills.
                    erangelKills = GetKillCount("Erangel", out erangelWins, conn, trans);
                    miramarKills = GetKillCount("Miramar", out miramarWins, conn, trans);
                    */

                    /*
                    using (SqlCommand command = new SqlCommand("SELECT Kills FROM Wins WHERE Map = 'Erangel'", conn, trans))
                    {
                        SqlDataReader dbReader = command.ExecuteReader();
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                erangelWins++;
                                erangelKills += (int)dbReader.GetSqlInt32(0);
                            }
                        }
                        WinsErangel.Text = "" + erangelWins;
                        KillsErangel.Text = "" + erangelKills;
                        dbReader.Close();
                    }
                    */

                    // Display stats
                    WinsErangel.Text = "" + erangelWins;
                    WinsMiramar.Text = "" + miramarWins;
                    WinsSavage.Text = "" + savageWins;

                    KillsErangel.Text = "" + erangelKills;
                    KillsMiramar.Text = "" + miramarKills;
                    KillsSavage.Text = "" + savageKills;


                    // Total stats.
                    totalKills = erangelKills + miramarKills + savageKills;
                    totalWins = erangelWins + miramarWins + savageKills;

                    WinsTotal.Text = "" + totalWins;
                    KillsTotal.Text = "" + totalKills;
                }
            }
        }

        /// <summary>
        /// Get the kill count and play count.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="played"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        private int GetKillCount(string map, out int played, SqlConnection conn, SqlTransaction trans)
        {
            int kills = 0;
            played = 0;
            using (SqlCommand command = new SqlCommand("SELECT Kills FROM Wins WHERE Map = @Map", conn, trans))
            {
                command.Parameters.AddWithValue("@Map", map);
                SqlDataReader dbReader = command.ExecuteReader();
                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        played++;
                        kills += (int)dbReader.GetSqlInt32(0);
                    }
                }
                dbReader.Close();
            }
            return kills;
        }

        private void ButtonStats_Click(object sender, EventArgs e)
        {
            SetStats();
        }
    }


}
