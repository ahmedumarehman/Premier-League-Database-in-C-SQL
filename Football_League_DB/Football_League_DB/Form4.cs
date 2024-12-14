using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_League_DB
{
    public partial class Form4 : Form
    {
        // Connection string to connect to your SQL Server database
        private string connectionString = @"Server=AHMED;Database=FOOTBALL_LEAGUE_SIGNUP;Integrated Security=True;";

        public Form4()
        {
            InitializeComponent();  // Initializes the form and its components
        }

        // Event handler for the "Show Team Data" button click
        private void btnTeam_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT * FROM Team");
        }

        // Method to execute the SQL query and display results
        private void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Team Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, " Team Data ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPlayerData();
        }


        private void ShowPlayerData()
        {
            string query = "SELECT * FROM Player";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Player Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Player Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }

        private void ShowMatchData()
        {
            string query = "SELECT * FROM Match";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Match Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Match Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowMatchData();
        }

        private void ShowStandingData()
        {
            string query = "SELECT * FROM Standing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Standing Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Standing Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ShowStandingData();
        }

        private void ShowRefereeData()
        {
            string query = "SELECT * FROM Referee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Referee Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Referee Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ShowRefereeData();
        }

        private void ShowGoalData()
        {
            string query = "SELECT * FROM Goal";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Goal Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Goal Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ShowGoalData();
        }

        private void ShowSubstitutionData()
        {
            string query = "SELECT * FROM Substitution";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Substitution Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Substitution Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubstitutionData();
        }

        private void ShowTicketData()
        {
            string query = "SELECT * FROM Ticket";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the data in a simple MessageBox
                    string result = "Ticket Data:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            result += item + " ";
                        }
                        result += "\n";
                    }
                    MessageBox.Show(result, "Ticket Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            ShowTicketData();
        }

        private void ShowAverageTrophies()
        {
            string query = "SELECT AVG(Trophies) AS AverageTrophies FROM Team";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Retrieve the average value from the DataTable
                    if (dataTable.Rows.Count > 0)
                    {
                        string result = "Average Trophies: " + dataTable.Rows[0]["AverageTrophies"].ToString();
                        MessageBox.Show(result, "Average Trophies");
                    }
                    else
                    {
                        MessageBox.Show("No data found for the query.", "Query Result");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            ShowAverageTrophies();
        }

        private void ShowMatchLocations()
        {
            string query = "SELECT Location AS Stadium, COUNT(*) AS Total_Matches_Played " +
                           "FROM Match " +
                           "GROUP BY Location;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Match Locations and Total Matches Played:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Stadium: {row["Stadium"]}, Total Matches Played: {row["Total_Matches_Played"]}\n";
                    }

                    MessageBox.Show(result, "Match Locations and Total Matches Played");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button9_Click(object sender, EventArgs e)
        {
            ShowMatchLocations();
        }

        private void ShowForwardsPlayers()
        {
            string query = "SELECT Playername AS Forwards " +
                           "FROM Player " +
                           "WHERE [Position] = 'Forward';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Forwards Players:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Forward: {row["Forwards"]}\n";
                    }

                    MessageBox.Show(result, "Forwards Players");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            ShowForwardsPlayers();
        }

        private void ShowTeamsFoundedBefore1900()
        {
            string query = "SELECT * " +
                           "FROM Team " +
                           "WHERE FoundedYear < 1900;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams Founded Before 1900:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"ID: {row["TeamID"]}, Name: {row["TeamName"]}, Founded: {row["FoundedYear"]}\n";
                    }

                    MessageBox.Show(result, "Teams Founded Before 1900");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            ShowTeamsFoundedBefore1900();
        }

        private void ShowPlayersFromEngland()
        {
            string query = "SELECT PlayerName, Nationality " +
                           "FROM Player " +
                           "WHERE Nationality = 'England';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Players from England:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Name: {row["PlayerName"]}, Nationality: {row["Nationality"]}\n";
                    }

                    MessageBox.Show(result, "Players from England");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button12_Click(object sender, EventArgs e)
        {
            ShowPlayersFromEngland();
        }

        private void ShowPlayersAfter1995()
        {
            string query = "SELECT PlayerID, PlayerName, DateOfBirth " +
                           "FROM Player " +
                           "WHERE DateOfBirth > '1995-01-01';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Players Born After 1995:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"ID: {row["PlayerID"]}, Name: {row["PlayerName"]}, Date of Birth: {row["DateOfBirth"]}\n";
                    }

                    MessageBox.Show(result, "Players Born After 1995");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }





        private void button13_Click(object sender, EventArgs e)
        {
            ShowPlayersAfter1995();
        }

        private void ShowTeamsWithTrophiesGreaterThan50()
        {
            string query = "SELECT TeamName AS Team, Trophies " +
                           "FROM Team " +
                           "WHERE Trophies > 50";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams with Trophies > 50:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Team: {row["Team"]}, Trophies: {row["Trophies"]}\n";
                    }

                    MessageBox.Show(result, "Teams with Trophies > 50");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button14_Click(object sender, EventArgs e)
        {
            ShowTeamsWithTrophiesGreaterThan50();
        }

        private void ShowTeamsWithTotalPlayersEqualTo24()
        {
            string query = "SELECT TeamName AS Team, TotalPlayers " +
                           "FROM Team " +
                           "WHERE TotalPlayers = 24";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams with exactly 24 players:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Team: {row["Team"]}, Total Players: {row["TotalPlayers"]}\n";
                    }

                    MessageBox.Show(result, "Teams with exactly 24 players");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button15_Click(object sender, EventArgs e)
        {
            ShowTeamsWithTotalPlayersEqualTo24();
        }

        private void ShowPlayerTeamInfo()
        {
            string query = "SELECT P.PlayerName, T.TeamName " +
                           "FROM Player P " +
                           "JOIN Team T ON P.TeamID = T.TeamID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Player-Team Info:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Player: {row["PlayerName"]}, Team: {row["TeamName"]}\n";
                    }

                    MessageBox.Show(result, "Player-Team Info");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button16_Click(object sender, EventArgs e)
        {
            ShowPlayerTeamInfo();
        }

        private void ShowExperiencedReferees()
        {
            string query = "SELECT RefereeName AS Name, Nationality AS Country, ExperienceYears AS Experience_Years " +
                           "FROM Referee " +
                           "WHERE ExperienceYears > 15";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Experienced Referees:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Name: {row["Name"]}, Country: {row["Country"]}, Experience Years: {row["Experience_Years"]}\n";
                    }

                    MessageBox.Show(result, "Experienced Referees greater than 15 years");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button17_Click(object sender, EventArgs e)
        {
            ShowExperiencedReferees();
        }

        private void ShowPlayersWithNoGoals()
        {
            string query = "SELECT P.PlayerID, P.PlayerName " +
                           "FROM Player P " +
                           "LEFT JOIN Goal G ON P.PlayerID = G.PlayerID " +
                           "WHERE G.GoalID IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Players with No Goals:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Player ID: {row["PlayerID"]}, Player Name: {row["PlayerName"]}\n";
                    }

                    MessageBox.Show(result, "Players with No Goals");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button18_Click(object sender, EventArgs e)
        {
            ShowPlayersWithNoGoals();
        }

        private void ShowTeamsWithMoreThan20PlayersAnd30Trophies()
        {
            string query = "SELECT TeamName, TotalPlayers, Trophies " +
                           "FROM Team " +
                           "WHERE TotalPlayers > 20 " +
                           "AND Trophies > 30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams with More Than 20 Players and 30 Trophies:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Team Name: {row["TeamName"]}, Total Players: {row["TotalPlayers"]}, Trophies: {row["Trophies"]}\n";
                    }

                    MessageBox.Show(result, "Teams with More Than 20 Players and 30 Trophies");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button19_Click(object sender, EventArgs e)
        {
            ShowTeamsWithMoreThan20PlayersAnd30Trophies();
        }

        private void ShowPlayerGoals()
        {
            string query = "SELECT P.PlayerName, COUNT(G.GoalID) AS TotalGoals " +
                           "FROM Goal G " +
                           "JOIN Player P ON G.PlayerID = P.PlayerID " +
                           "GROUP BY P.PlayerName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Players and their Total Goals:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Player Name: {row["PlayerName"]}, Total Goals: {row["TotalGoals"]}\n";
                    }

                    MessageBox.Show(result, "Players and their Total Goals");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button20_Click(object sender, EventArgs e)
        {
            ShowPlayerGoals();
        }

        private void ShowTeamGoals()
        {
            string query = "SELECT T.TeamName, COUNT(G.GoalID) AS TotalGoals " +
                           "FROM Goal G " +
                           "JOIN Match M ON G.MatchID = M.MatchID " +
                           "JOIN Team T ON M.HomeTeamID = T.TeamID OR M.AwayTeamID = T.TeamID " +
                           "GROUP BY T.TeamName " +
                           "ORDER BY TotalGoals DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams and their Total Goals:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Team Name: {row["TeamName"]}, Total Goals: {row["TotalGoals"]}\n";
                    }

                    MessageBox.Show(result, "Teams and their Total Goals");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }





        private void button21_Click(object sender, EventArgs e)
        {
            ShowTeamGoals();
        }

        private void ShowMatchesAtAnfield()
        {
            string query = "SELECT M.MatchID AS Matchday_Week, " +
                           "M.Date, " +
                           "M.Location AS Stadium, " +
                           "M.Score, " +
                           "HT.TeamName AS HomeTeamName, " +
                           "AT.TeamName AS AwayTeamName " +
                           "FROM Match M " +
                           "JOIN Team HT ON M.HomeTeamID = HT.TeamID " +
                           "JOIN Team AT ON M.AwayTeamID = AT.TeamID " +
                           "WHERE HT.Stadium = 'Anfield'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Matches at Anfield:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Match Week: {row["Matchday_Week"]}, Date: {row["Date"]}, " +
                                  $"Stadium: {row["Stadium"]}, Score: {row["Score"]}, " +
                                  $"Home Team: {row["HomeTeamName"]}, Away Team: {row["AwayTeamName"]}\n";
                    }

                    MessageBox.Show(result, "Matches at Anfield");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ShowMatchesAtAnfield();
        }

        private void ShowHighScoringHomeMatches()
        {
            string query = "SELECT M.MatchID, " +
                           "M.Date, " +
                           "M.Location, " +
                           "M.Score, " +
                           "HT.TeamName AS HomeTeam, " +
                           "AT.TeamName AS AwayTeam " +
                           "FROM Match M " +
                           "JOIN Team HT ON M.HomeTeamID = HT.TeamID " +
                           "JOIN Team AT ON M.AwayTeamID = AT.TeamID " +
                           "WHERE CAST(SUBSTRING(M.Score, 1, CHARINDEX('-', M.Score) - 1) AS INT) > 2";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "High Scoring Home Matches:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"MatchID: {row["MatchID"]}, Date: {row["Date"]}, " +
                                  $"Location: {row["Location"]}, Score: {row["Score"]}, " +
                                  $"Home Team: {row["HomeTeam"]}, Away Team: {row["AwayTeam"]}\n";
                    }

                    MessageBox.Show(result, "High Scoring Home Matches");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button23_Click(object sender, EventArgs e)
        {
            ShowHighScoringHomeMatches();
        }

        private void ShowGoalsByMatch()
        {
            string query = "SELECT M.MatchID, " +
                           "M.Date, " +
                           "P.PlayerName, " +
                           "G.MinuteScored " +
                           "FROM Goal G " +
                           "JOIN Player P ON G.PlayerID = P.PlayerID " +
                           "JOIN Match M ON G.MatchID = M.MatchID " +
                           "ORDER BY M.MatchID, G.MinuteScored";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Goals by Match:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"MatchID: {row["MatchID"]}, Date: {row["Date"]}, " +
                                  $"Player: {row["PlayerName"]}, Minute Scored: {row["MinuteScored"]}\n";
                    }

                    MessageBox.Show(result, "Goals by Match");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button24_Click(object sender, EventArgs e)
        {
            ShowGoalsByMatch();
        }

        private void ShowMatchesWithScore22()
        {
            string query = "SELECT M.MatchID AS Week, " +
                           "M.Date, " +
                           "M.Location, " +
                           "M.Score, " +
                           "HT.TeamName AS HomeTeam, " +
                           "AT.TeamName AS AwayTeam " +
                           "FROM Match M " +
                           "JOIN Team HT ON M.HomeTeamID = HT.TeamID " +
                           "JOIN Team AT ON M.AwayTeamID = AT.TeamID " +
                           "WHERE M.Score = '2-2'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Matches with Score 2-2:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Match Week: {row["Week"]}, Date: {row["Date"]}, " +
                                  $"Location: {row["Location"]}, Score: {row["Score"]}, " +
                                  $"Home Team: {row["HomeTeam"]}, Away Team: {row["AwayTeam"]}\n";
                    }

                    MessageBox.Show(result, "Matches with Score 2-2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button25_Click(object sender, EventArgs e)
        {
            ShowMatchesWithScore22();
        }

        private void ShowSubstitutions()
        {
            string query = "SELECT M.MatchID, " +
                           "M.Date, " +
                           "POut.PlayerName AS PlayerOut, " +
                           "PIn.PlayerName AS PlayerIn, " +
                           "S.[Minute] " +
                           "FROM Substitution S " +
                           "JOIN Match M ON S.MatchID = M.MatchID " +
                           "JOIN Player POut ON S.PlayerOutID = POut.PlayerID " +
                           "JOIN Player PIn ON S.PlayerInID = PIn.PlayerID " +
                           "ORDER BY M.MatchID, S.[Minute]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Substitution Details:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Match ID: {row["MatchID"]}, Date: {row["Date"]}, " +
                                  $"Player Out: {row["PlayerOut"]}, Player In: {row["PlayerIn"]}, " +
                                  $"Minute: {row["Minute"]}\n";
                    }

                    MessageBox.Show(result, "Substitution Details");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button26_Click(object sender, EventArgs e)
        {
            ShowSubstitutions();
        }

        private void ShowAverageTicketPrice()
        {
            string query = "SELECT HT.TeamName AS HomeTeam, " +
                           "AT.TeamName AS AwayTeam, " +
                           "AVG(T.Price) AS AverageTicketPrice " +
                           "FROM Ticket T " +
                           "JOIN Match M ON T.MatchID = M.MatchID " +
                           "JOIN Team HT ON M.HomeTeamID = HT.TeamID " +
                           "JOIN Team AT ON M.AwayTeamID = AT.TeamID " +
                           "WHERE M.Location = 'Etihad Stadium' " +
                           "GROUP BY HT.TeamName, AT.TeamName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Average Ticket Prices at Etihad Stadium:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"Home Team: {row["HomeTeam"]}, Away Team: {row["AwayTeam"]}, " +
                                  $"Average Ticket Price: {row["AverageTicketPrice"]}\n";
                    }

                    MessageBox.Show(result, "Average Ticket Prices at Etihad Stadium");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }


        private void button27_Click(object sender, EventArgs e)
        {
            ShowAverageTicketPrice();
        }

        private void ShowWinPercentage()
        {
            string query = "SELECT T.TeamName, " +
                           "(CAST(SUM(CASE WHEN M.Score LIKE CONCAT('%', T.TeamName, '%') THEN 1 ELSE 0 END) AS FLOAT) / " +
                           "CAST(COUNT(M.MatchID) AS FLOAT)) * 100 AS WinPercentage " +
                           "FROM Standing S " +
                           "JOIN Team T ON S.TeamID = T.TeamID " +
                           "LEFT JOIN Match M ON M.HomeTeamID = T.TeamID OR M.AwayTeamID = T.TeamID " +
                           "GROUP BY T.TeamName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Win Percentages:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: {row["WinPercentage"]}%\n";
                    }

                    MessageBox.Show(result, "Win Percentages:\\");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }





        private void button28_Click(object sender, EventArgs e)
        {
            ShowWinPercentage();
        }

        private void ShowTotalGoalsPerTeam()
        {
            string query = @"
        WITH PlayerGoals AS
        (
            SELECT
                p.TeamID,
                COUNT(g.GoalID) AS TotalGoals
            FROM
                Player p
                LEFT JOIN Goal g ON p.PlayerID = g.PlayerID
            GROUP BY 
                p.TeamID
        )
        SELECT
            t.TeamName,
            COALESCE(pg.TotalGoals, 0) AS TotalGoals
        FROM
            Team t
            LEFT JOIN PlayerGoals pg ON t.TeamID = pg.TeamID
        ORDER BY 
            TotalGoals DESC;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Total Goals Per Team:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: {row["TotalGoals"]} goals\n";
                    }

                    MessageBox.Show(result, "Total Goals Per Team");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button29_Click(object sender, EventArgs e)
        {
            ShowTotalGoalsPerTeam();
        }

        private void ShowMaxGoalsPerNationality()
        {
            string query = @"
        WITH MaxGoalsPerNationality AS
        (
            SELECT
                p1.Nationality,
                MAX(g1.TotalGoals) AS MaxGoals
            FROM
                (
                    SELECT
                        PlayerID,
                        COUNT(GoalID) AS TotalGoals
                    FROM
                        Goal
                    GROUP BY 
                        PlayerID
                ) g1
                JOIN Player p1 ON g1.PlayerID = p1.PlayerID
            GROUP BY 
                p1.Nationality
        )
        SELECT
            p.Nationality,
            p.PlayerName,
            g.TotalGoals
        FROM
            Player p
            JOIN
            (
                SELECT
                    PlayerID,
                    COUNT(GoalID) AS TotalGoals
                FROM
                    Goal
                GROUP BY 
                    PlayerID
            ) g ON p.PlayerID = g.PlayerID
            JOIN MaxGoalsPerNationality mgn ON p.Nationality = mgn.Nationality AND g.TotalGoals = mgn.MaxGoals;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Players with Max Goals Per Nationality:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["Nationality"]}: {row["PlayerName"]} - {row["TotalGoals"]} goals\n";
                    }

                    MessageBox.Show(result, "Players with Max Goals Per Nationality");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }





        private void button30_Click(object sender, EventArgs e)
        {
            ShowMaxGoalsPerNationality();
        }

        private void ShowHomeAwayWins()
        {
            string query = @"
        SELECT
            T.TeamName,
            SUM(CASE 
                    WHEN CAST(SUBSTRING(M.Score, 1, CHARINDEX('-', M.Score) - 1) AS INT) > 
                         CAST(SUBSTRING(M.Score, CHARINDEX('-', M.Score) + 1, LEN(M.Score)) AS INT)
                    THEN 1
                    ELSE 0
                END) AS TotalHomeWins,
            SUM(CASE 
                    WHEN CAST(SUBSTRING(M.Score, CHARINDEX('-', M.Score) + 1, LEN(M.Score)) AS INT) > 
                         CAST(SUBSTRING(M.Score, 1, CHARINDEX('-', M.Score) - 1) AS INT)
                    THEN 1
                    ELSE 0
                END) AS TotalAwayWins
        FROM
            Match M
            JOIN Team T ON M.HomeTeamID = T.TeamID
        GROUP BY 
            T.TeamName;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Home and Away Wins per Team:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: Home Wins = {row["TotalHomeWins"]}, Away Wins = {row["TotalAwayWins"]}\n";
                    }

                    MessageBox.Show(result, "Home and Away Wins per Team");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button31_Click(object sender, EventArgs e)
        {
            ShowHomeAwayWins();
        }

        private void ShowAvgGoalsPerMatch()
        {
            string query = @"
        SELECT
            T.TeamName,
            AVG(G.GoalsScored) AS AvgGoalsPerMatch
        FROM
            Team T
            JOIN Match M ON T.TeamID = M.HomeTeamID OR T.TeamID = M.AwayTeamID
            JOIN
            (
                SELECT
                    MatchID,
                    HomeTeamID AS TeamID,
                    CAST(SUBSTRING(Score, 1, CHARINDEX('-', Score) - 1) AS INT) AS GoalsScored
                FROM
                    Match
                UNION ALL
                SELECT
                    MatchID,
                    AwayTeamID AS TeamID,
                    CAST(SUBSTRING(Score, CHARINDEX('-', Score) + 1, LEN(Score)) AS INT) AS GoalsScored
                FROM
                    Match
            ) AS G ON T.TeamID = G.TeamID
        GROUP BY 
            T.TeamName
        HAVING 
            AVG(G.GoalsScored) > 2;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams with Avg Goals per Match > 2:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: {row["AvgGoalsPerMatch"]} goals per match\n";
                    }

                    MessageBox.Show(result, "Teams with Avg Goals per Match > 2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button32_Click(object sender, EventArgs e)
        {
            ShowAvgGoalsPerMatch();
        }
        //--------------------------------------------------------------------
        private void ShowAvgGoalsPerMatchByTeam()
        {
            string query = @"
        SELECT
            T.TeamName,
            AVG(G.GoalsScored) AS AvgGoalsPerMatch
        FROM
            Team T
            JOIN Match M ON T.TeamID = M.HomeTeamID OR T.TeamID = M.AwayTeamID
            JOIN
            (
                SELECT
                    MatchID,
                    HomeTeamID AS TeamID,
                    CAST(SUBSTRING(Score, 1, CHARINDEX('-', Score) - 1) AS INT) AS GoalsScored
                FROM
                    Match
                UNION ALL
                SELECT
                    MatchID,
                    AwayTeamID AS TeamID,
                    CAST(SUBSTRING(Score, CHARINDEX('-', Score) + 1, LEN(Score)) AS INT) AS GoalsScored
                FROM
                    Match
            ) AS G ON T.TeamID = G.TeamID
        GROUP BY 
            T.TeamID, T.TeamName;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams and Their Avg Goals per Match:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: {row["AvgGoalsPerMatch"]} goals per match\n";
                    }

                    MessageBox.Show(result, "Teams and Their Avg Goals per Match:");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button33_Click(object sender, EventArgs e)
        {
            ShowAvgGoalsPerMatchByTeam();
        }

        private void ShowAvgGoalsPerPlayer()
        {
            string query = @"
        SELECT
            t.TeamName,
            AVG(PlayerGoals.TotalGoals) AS AvgGoalsPerPlayer
        FROM
            Team t
            JOIN Player p ON t.TeamID = p.TeamID
            JOIN
            (
                SELECT
                    PlayerID,
                    COUNT(GoalID) AS TotalGoals
                FROM
                    Goal
                GROUP BY 
                    PlayerID
            ) PlayerGoals ON p.PlayerID = PlayerGoals.PlayerID
        GROUP BY 
            t.TeamName
        ORDER BY 
            AvgGoalsPerPlayer DESC;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Teams and Their Avg Goals per Player:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]}: {row["AvgGoalsPerPlayer"]} goals per player\n";
                    }

                    MessageBox.Show(result, "Teams and Their Avg Goals per Player");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button34_Click(object sender, EventArgs e)
        {
            ShowAvgGoalsPerPlayer();
        }

        private void ShowRefereeGoals()
        {
            string query = @"
        SELECT
            r.RefereeName,
            m.MatchID,
            (
                SELECT
                    COUNT(*)
                FROM
                    Goal g
                WHERE 
                    g.MatchID = m.MatchID
            ) AS TotalGoals
        FROM
            Referee r
            JOIN Match m ON r.RefereeID = (
                SELECT
                    RefereeID
                FROM
                (
                    -- Example logic to assign referees
                    SELECT
                        ROW_NUMBER() OVER (ORDER BY MatchID) AS RefereeID,
                        MatchID
                    FROM Match
                ) RefMatches
                WHERE RefMatches.MatchID = m.MatchID
            )
        ORDER BY 
            TotalGoals DESC;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Referee, Match and Total Goals:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["RefereeName"]} - Match ID: {row["MatchID"]} - Total Goals: {row["TotalGoals"]}\n";
                    }

                    MessageBox.Show(result, "Referee, Match and Total Goals");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }




        private void button35_Click(object sender, EventArgs e)
        {
            ShowRefereeGoals();
        }

        private void ShowTeamWithHighestAvgAge()
        {
            string query = @"
        WITH AvgPlayerAgeCTE AS
        (
            SELECT
                t.TeamID,
                t.TeamName,
                AVG(YEAR(GETDATE()) - YEAR(p.DateOfBirth)) AS AvgPlayerAge
            FROM
                Team t
                JOIN Player p ON t.TeamID = p.TeamID
            GROUP BY 
                t.TeamID, t.TeamName
        )
        SELECT
            TeamName,
            AvgPlayerAge
        FROM
            AvgPlayerAgeCTE
        WHERE 
            AvgPlayerAge = (SELECT MAX(AvgPlayerAge) FROM AvgPlayerAgeCTE);
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Open the database connection
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Fill the DataTable with query results

                    // Display the results in a MessageBox
                    string result = "Team with the Highest Average Player Age:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result += $"{row["TeamName"]} - Avg Age: {row["AvgPlayerAge"]}\n";
                    }

                    MessageBox.Show(result, "Team with the Highest Average Player Age");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Error");
                }
            }
        }



        private void button36_Click(object sender, EventArgs e)
        {
            ShowTeamWithHighestAvgAge();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{

        //}
    }
}
