using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_League_DB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Set the PasswordChar property to hide the password
            textBox2.PasswordChar = '*'; // Use '*' or any other character for password masking
        }

        // Use this event for the LinkLabel click instead of button1_Click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=FOOTBALL_LEAGUE_SIGNUP;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT COUNT(*) 
                        FROM SIGNUP 
                        WHERE RTRIM(LTRIM(Username)) = RTRIM(LTRIM(@username)) 
                        AND RTRIM(LTRIM(Password)) = RTRIM(LTRIM(@password))";

                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.Parameters.AddWithValue("@username", username);
                        cm.Parameters.AddWithValue("@password", password);

                        int result = (int)cm.ExecuteScalar();  // Execute query

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();  // Hide Form2
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
