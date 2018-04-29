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
        private int lastID;

        /// <summary>
        /// Construtor
        /// </summary>
        public UI()
        {
            InitializeComponent();

            // Set defaults.
            MenuPerspective.Text = "FPP";
            MenuServer.Text = "NA";
            lastID = 0;

            // SQL database.
            WinDB = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Alex\\source\\repos\\PUBGWins\\PUBGWinsUI\\WinDB.mdf; Integrated Security = True";

            SetStats();
        }

        /// <summary>
        /// Store a game that has been entered.
        /// Also updates the stats when done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            // Update last ID if it is stored
            if (lastID != 0)
            {
                lastID++;
            }

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

                            command.ExecuteNonQuery();
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

                            command.ExecuteNonQuery();
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


                            command.ExecuteNonQuery();
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


                            command.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                }
            }
            SetStats();
            BoxDescription.Text = "";
        }

        /// <summary>
        /// Calculate and display stats from the game info in the DB.
        /// </summary>
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

                    // Display stats
                    WinsErangel.Text = "" + erangelWins;
                    WinsMiramar.Text = "" + miramarWins;
                    WinsSavage.Text = "" + savageWins;

                    KillsErangel.Text = "" + erangelKills;
                    KillsMiramar.Text = "" + miramarKills;
                    KillsSavage.Text = "" + savageKills;

                    NAWins.Text = "" + GetServerCount("NA", conn, trans);
                    ASWins.Text = "" + GetServerCount("AS", conn, trans);
                    EUWins.Text = "" + GetServerCount("EU", conn, trans);
                    TestWins.Text = "" + GetServerCount("Test", conn, trans);
                    SEAWins.Text = "" + GetServerCount("SEA", conn, trans);
                    SAWins.Text = "" + GetServerCount("SA", conn, trans);

                    SoloWins.Text = "" + GetTeamSizeCount(0, conn, trans);
                    DuoWins.Text = "" + GetTeamSizeCount(1, conn, trans);
                    TrioWins.Text = "" + GetTeamSizeCount(2, conn, trans);
                    SquadWins.Text = "" + GetTeamSizeCount(3, conn, trans);

                    // Total stats.
                    totalKills = erangelKills + miramarKills + savageKills;
                    totalWins = erangelWins + miramarWins + savageKills;

                    WinsTotal.Text = "" + totalWins;
                    KillsTotal.Text = "" + totalKills;
                    double averageKills = 1.0 * totalKills / totalWins;
                    string averageString = "" + averageKills;
                    if (averageString.Length > 5)
                    {
                        averageString = averageString.Substring(0, 5);
                    }
                    KillsPerWin.Text = averageString;
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

        /// <summary>
        /// Get games won on a server.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        private int GetServerCount(string server, SqlConnection conn, SqlTransaction trans)
        {
            int wins = 0;
            using (SqlCommand command = new SqlCommand("SELECT Kills FROM Wins WHERE Server = @Server", conn, trans))
            {
                command.Parameters.AddWithValue("@Server", server);
                SqlDataReader dbReader = command.ExecuteReader();
                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        wins++;
                    }
                }
                dbReader.Close();
            }
            return wins;
        }

        /// <summary>
        /// Click a button to display the stats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStats_Click(object sender, EventArgs e)
        {
            SetStats();
        }

        /// <summary>
        /// Returns the number of games won with the given number of teammates.
        /// </summary>
        /// <param name="teammates"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        private int GetTeamSizeCount(int teammates, SqlConnection conn, SqlTransaction trans)
        {
            int wins = 0;
            using (SqlCommand command = new SqlCommand("SELECT Kills FROM Wins WHERE Teammates = @Teammates", conn, trans))
            {
                command.Parameters.AddWithValue("Teammates", teammates);
                SqlDataReader dbReader = command.ExecuteReader();
                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        wins++;
                    }
                }
                dbReader.Close();
            }
            return wins;
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    // Get all the games and find the largest gameID.
                    if (lastID == 0)
                    {
                        using (SqlCommand command = new SqlCommand("SELECT ID FROM Wins", conn, trans))
                        {
                            SqlDataReader dbReader = command.ExecuteReader();
                            if (dbReader.HasRows)
                            {
                                int currentID;
                                while (dbReader.Read())
                                {
                                    currentID = dbReader.GetInt32(0);
                                    if (currentID > lastID)
                                    {
                                        lastID = currentID;
                                    }
                                }
                            }
                            dbReader.Close();
                        }
                    }
                    // Get the last game.
                    using (SqlCommand command = new SqlCommand("SELECT Kills, Perspective, Server, Map, Description, Teammate1, Teammate2, Teammate3 FROM Wins WHERE ID = @LastID", conn, trans))
                    {
                        command.Parameters.AddWithValue("LastID", lastID);
                        SqlDataReader dbReader = command.ExecuteReader();
                        if (dbReader.HasRows)
                        {
                            dbReader.Read();
                            BoxKills.Text = "" + dbReader.GetInt32(0);
                            MenuPerspective.Text = dbReader.GetString(1);
                            MenuServer.Text = dbReader.GetString(2);
                            MenuMap.Text = dbReader.GetString(3);
                            BoxDescription.Text = dbReader.GetString(4);

                            string teammate1 = dbReader.GetString(5);
                            string teammate2 = dbReader.GetString(6);
                            string teammate3 = dbReader.GetString(7);
                            if (teammate1 != null)
                            {
                                BoxTeammate1.Text = teammate1;
                            }
                            if (teammate2 != null)
                            {
                                BoxTeammate2.Text = teammate2;
                            }
                            if (teammate3 != null)
                            {
                                BoxTeammate3.Text = teammate3;
                            }

                        }
                        dbReader.Close();
                    }

                }
            }
        }
    }
    
}
