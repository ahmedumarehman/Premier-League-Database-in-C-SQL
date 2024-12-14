using System;
using System.Drawing;
using System.Windows.Forms;

namespace Football_League_DB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Display a success message on the form
            Label successLabel = new Label
            {
                Text = "WELCOME TO FOOTBALL LEAGUE DATABASE, NOW CLICK HERE TO SEE QUERIES",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(100, 100)  // Adjust location as needed
            };
            this.Controls.Add(successLabel);  // Add label to form
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Ensure the ProgressBar has a defined maximum value
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;  // Increment by 10
            }
            else
            {
                MessageBox.Show("Progress complete!");
                progressBar1.Value = 0;  // Reset the progress bar
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of Form4 and show it
            Form4 form4 = new Form4();
            form4.Show();  // Display Form4
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Placeholder for picture box click event
        }
    }
}
