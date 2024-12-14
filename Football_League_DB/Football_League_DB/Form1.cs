using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Football_League_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO SIGNUP(Username, Password) VALUES (@username, @password)";
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.Parameters.AddWithValue("@username", username);
                        cm.Parameters.AddWithValue("@password", password); // Save plain password
                        cm.ExecuteNonQuery();  // Insert data
                    }

                    MessageBox.Show("Data entered successfully.");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
