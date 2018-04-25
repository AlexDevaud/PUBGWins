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
            int teammates = int.Parse(MenuTeammates.Text);
            string description = BoxDescription.Text;
            

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
                        trans.Commit();
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
                }
            }
            

            /*
            // 2nd connection.
            using (SqlConnection conn = new SqlConnection(WinDB))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand("SELECT Kills From Wins WHERE Empty = 1", conn, trans))
                    {
                        //int? killsFound = (int)command.ExecuteScalar();


                        SqlDataReader resultDB = command.ExecuteReader();

                        if (resultDB.HasRows)
                        {
                            // There is already a pending game.
                            LabelDebug.Text = "Wins exist" + resultDB.FieldCount;

                        }
                        resultDB.Close();
                    }
                }
            }
            */
        }             
    }
}
