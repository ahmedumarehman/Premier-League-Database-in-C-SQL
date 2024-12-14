using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_League_DB
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate to Form4
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // INSERT operation
            try
            {
                string query = $@"
                    INSERT INTO Team
                        (TeamID, TeamName, Coach, FoundedYear, Stadium, Country, TotalPlayers, Trophies)
                    VALUES
                        ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', {textBox4.Text}, '{textBox5.Text}', '{textBox6.Text}', {textBox7.Text}, {textBox8.Text});
                ";

                ExecuteQuery(query, "Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // UPDATE operation
            try
            {
                string query = $@"
                    UPDATE Team
                    SET 
                        TeamName = '{textBox2.Text}', 
                        Coach = '{textBox3.Text}', 
                        FoundedYear = {textBox4.Text}, 
                        Stadium = '{textBox5.Text}', 
                        Country = '{textBox6.Text}', 
                        TotalPlayers = {textBox7.Text}, 
                        Trophies = {textBox8.Text}
                    WHERE TeamID = '{textBox1.Text}';
                ";

                ExecuteQuery(query, "Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // DELETE operation (Referee)
            try
            {
                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    MessageBox.Show("Please enter a valid RefereeID to delete.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmation = MessageBox.Show(
                    $"Are you sure you want to delete the referee with ID '{textBox9.Text}'?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    string query = $@"
                        DELETE FROM Referee 
                        WHERE RefereeID = {textBox9.Text};
                    ";

                    ExecuteQuery(query, "Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteQuery(string query, string action)
        {
            string connectionString = "Data Source=.;Initial Catalog=FOOTBALL_LEAGUE_SIGNUP;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{action} operation executed successfully. Rows affected: {rowsAffected}.", $"{action} Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("REFERENCE constraint"))
                    {
                        MessageBox.Show("Unable to perform operation due to foreign key constraints. Please ensure no dependent data exists.", "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional handler for real-time changes in textBox2
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Optional handler for real-time changes in textBox9
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
