using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGWinsUI
{
    class Controller
    {

        Interface view;

        private static string WinDB; // The connection string to the DB
        private int lastPlayedID; // The last game entered into the database.
        private int currentOldID; // The game we are lookin at.

        public Controller(Interface view)
        {
            this.view = view;

            // Set defaults.
            view.TextPerspective = "FPP";
            view.TextServer = "NA";
            lastPlayedID = 0;
            currentOldID = 0;

            // SQL database.
            WinDB = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Alex\\source\\repos\\PUBGWins\\PUBGWinsUI\\WinDB.mdf; Integrated Security = True";

            // Hooking
            view.EventStore += HandleStore;
            view.EventRemove += HandleRemove;
            view.EventMostRecentWin += HandleMostRecentWin;
            view.EventLessRecentWin += HandleLessRecentWin;
            view.EventUpdate += HandleUpdate;

            SetStats();
        }

        /// <summary>
        /// Store the data of a new win entered by the user.
        /// </summary>
        public void HandleStore()
        {
            string teammate1 = view.TextTeammate1;
            string teammate2 = view.TextTeammate2;
            string teammate3 = view.TextTeammate3;
            int teammates = 0;

            // Update last ID if it is stored
            if (lastPlayedID != 0)
            {
                lastPlayedID++;
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
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 1)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 2)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 3)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Teammate3 = @Teammate3, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Empty = 1", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.Parameters.AddWithValue("@Teammate3", teammate3);
                            command.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                }
            }
            SetStats();
            view.TextDescription = "";
        }

        /// <summary>
        /// Add values that are the same for any number of teammates.
        /// </summary>
        /// <param name="command"></param>
        private void AddCommonParameters(SqlCommand command)
        {
            command.Parameters.AddWithValue("@Kills", int.Parse(view.TextKills));
            command.Parameters.AddWithValue("@Map", view.TextMap);
            command.Parameters.AddWithValue("@Description", view.TextDescription);
            command.Parameters.AddWithValue("@Server", view.TextServer);
            command.Parameters.AddWithValue("@Perspective", view.TextPerspective);
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
                    int sanhokWins = 0;


                    int erangelKills = GetKillCount("Erangel", out erangelWins, conn, trans);
                    int miramarKills = GetKillCount("Miramar", out miramarWins, conn, trans);
                    int sanhokKills = GetKillCount("Sanhok", out sanhokWins, conn, trans);

                    int totalKills = 0;
                    int totalWins = 0;

                    // Display stats
                    view.TextWinsErangel = "" + erangelWins;
                    view.TextWinsMiramar = "" + miramarWins;
                    view.TextWinsSanhok = "" + sanhokWins;

                    view.TextKillsErangel = "" + erangelKills;
                    view.TextKillsMiramar = "" + miramarKills;
                    view.TextKillsSanhok = "" + sanhokKills;

                    view.TextWinsNA = "" + GetServerCount("NA", conn, trans);
                    view.TextWinsAS = "" + GetServerCount("AS", conn, trans);
                    view.TextWinsEU = "" + GetServerCount("EU", conn, trans);
                    view.TextWinsTest = "" + GetServerCount("Test", conn, trans);
                    view.TextWinsSEA = "" + GetServerCount("SEA", conn, trans);
                    view.TextWinsSA = "" + GetServerCount("SA", conn, trans);

                    view.TextWinsSolo = "" + GetTeamSizeCount(0, conn, trans);
                    view.TextWinsDuo = "" + GetTeamSizeCount(1, conn, trans);
                    view.TextWinsTrio = "" + GetTeamSizeCount(2, conn, trans);
                    view.TextWinsSquad = "" + GetTeamSizeCount(3, conn, trans);

                    // Total stats.
                    totalKills = erangelKills + miramarKills + sanhokKills;
                    totalWins = erangelWins + miramarWins + sanhokWins;

                    view.TextWinsTotal = "" + totalWins;
                    view.TextKillsTotal = "" + totalKills;
                    double averageKills = 1.0 * totalKills / totalWins;
                    string averageString = "" + averageKills;
                    if (averageString.Length > 5)
                    {
                        averageString = averageString.Substring(0, 5);
                    }
                    view.TextKillsAverage = averageString;
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

       

        /// <summary>
        /// Show the most recent win.
        /// </summary>
        private void HandleMostRecentWin()
        {
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    // Get all the games and find the largest gameID.
                    using (SqlCommand command = new SqlCommand("SELECT ID FROM Wins", conn, trans))
                    {
                        SqlDataReader dbReader = command.ExecuteReader();
                        if (dbReader.HasRows)
                        {
                            int currentID;
                            while (dbReader.Read())
                            {
                                currentID = dbReader.GetInt32(0);
                                if (currentID > lastPlayedID)
                                {
                                    lastPlayedID = currentID;
                                }
                            }
                        }
                        dbReader.Close();
                    }
                    currentOldID = lastPlayedID;
                    // Get the last game.
                    // Find and display the last played game.
                    while (true)
                    {
                        if (currentOldID == 0 || ShowOldGame(currentOldID, conn, trans))
                        {
                            break;
                        }
                        else
                        {
                            currentOldID--;
                        }
                    }
                    // Show additional options.
                    view.ButtonPreviousVisible = true;
                    view.ButtonRemoveVisible = true;
                    view.ButtonUpdateVisible = true;
                }
            }
        }

        /// <summary>
        /// Display info about a game pulled from the DB.
        /// Returns if this is a valid game ID. It may have been deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        private bool ShowOldGame(int id, SqlConnection conn, SqlTransaction trans)
        {
            // This game may not exist.

            // Get the parameter game.
            using (SqlCommand command = new SqlCommand("SELECT Kills, Perspective, Server, Map, Description, Teammate1, Teammate2, Teammate3 FROM Wins WHERE ID = @LastID", conn, trans))
            {
                command.Parameters.AddWithValue("LastID", id);
                SqlDataReader dbReader = command.ExecuteReader();
                if (dbReader.HasRows)
                {
                    dbReader.Read();
                    view.TextKills = "" + dbReader.GetInt32(0);
                    view.TextPerspective = dbReader.GetString(1);
                    view.TextServer = dbReader.GetString(2);
                    view.TextMap = dbReader.GetString(3);
                    view.TextDescription = dbReader.GetString(4);

                    // Teammate names may be null.
                    if (!dbReader.IsDBNull(5))
                    {
                        view.TextTeammate1 = dbReader.GetString(5);
                    }
                    else
                    {
                        view.TextTeammate1 = "";
                    }

                    if (!dbReader.IsDBNull(6))
                    {
                        view.TextTeammate2 = dbReader.GetString(6);
                    }
                    else
                    {
                        view.TextTeammate2 = "";
                    }

                    if (!dbReader.IsDBNull(7))
                    {
                        view.TextTeammate3 = dbReader.GetString(7);
                    }
                    else
                    {
                        view.TextTeammate3 = "";
                    }
                    dbReader.Close();
                    return true;
                }
                else
                {
                    dbReader.Close();
                    return false;
                }

            }
        }

        /// <summary>
        /// Go back by one less recently played game.
        /// </summary>
        private void HandleLessRecentWin()
        {
            currentOldID--;

            // Load this game.
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    // Find and display the last played game.
                    while (true)
                    {
                        if (currentOldID == 0 || ShowOldGame(currentOldID, conn, trans))
                        {
                            break;
                        }
                        else
                        {
                            currentOldID--;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Update the info of this win in the DB.
        /// </summary>
        private void HandleUpdate()
        {
            string teammate1 = view.TextTeammate1;
            string teammate2 = view.TextTeammate2;
            string teammate3 = view.TextTeammate3;
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
                    // Set data for this game.
                    if (teammates == 0)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Id = @Id", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Id", currentOldID);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 1)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Id = @Id", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Id", currentOldID);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 2)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Id = @Id", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Id", currentOldID);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (teammates == 3)
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE Wins SET Kills = @Kills, Map = @Map, Teammates = @Teammates, Teammate1 = @Teammate1, Teammate2 = @Teammate2, Teammate3 = @Teammate3, Description = @Description, Server = @Server, Perspective = @Perspective, Empty = 0 WHERE Id = @Id", conn, trans))
                        {
                            AddCommonParameters(command);
                            command.Parameters.AddWithValue("@Id", currentOldID);
                            command.Parameters.AddWithValue("@Teammates", teammates);
                            command.Parameters.AddWithValue("@Teammate1", teammate1);
                            command.Parameters.AddWithValue("@Teammate2", teammate2);
                            command.Parameters.AddWithValue("@Teammate3", teammate3);
                            command.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                }
            }
            SetStats();
            view.TextDescription = "";
        }

        /// <summary>
        /// Remove this win from the DB.
        /// </summary>
        private void HandleRemove()
        {
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand("DELETE Wins WHERE Id = @ID", conn, trans))
                    {
                        command.Parameters.AddWithValue("ID", currentOldID);
                        command.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
            }
            SetStats();

            // Clear the boxes.
            view.TextKills = "";
            view.TextTeammate1 = "";
            view.TextTeammate2 = "";
            view.TextTeammate3 = "";
            view.TextDescription = "";

            // Show the newest added game.
            HandleLessRecentWin();
        }
    }
}
