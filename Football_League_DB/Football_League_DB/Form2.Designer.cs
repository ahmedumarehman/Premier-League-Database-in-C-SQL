namespace Football_League_DB
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.BackColor = Color.White;  // TextBox background color
            textBox1.ForeColor = Color.Black;  // TextBox text color
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.BackColor = Color.White;  // TextBox background color
            textBox2.ForeColor = Color.Black;  // TextBox text color
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 146);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.ForeColor = Color.Black;  // Text color for label
            label1.BackColor = Color.White;  // Background color for label
            label1.Font = new Font("Arial", 12, FontStyle.Regular);  // Font styling
            label1.Padding = new Padding(5);  // Padding around text
            label1.TextAlign = ContentAlignment.MiddleLeft;  // Text alignment
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 230);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.ForeColor = Color.Black;  // Text color for label
            label2.BackColor = Color.White;  // Background color for label
            label2.Font = new Font("Arial", 12, FontStyle.Regular);  // Font styling
            label2.Padding = new Padding(5);  // Padding around text
            label2.TextAlign = ContentAlignment.MiddleLeft;  // Text alignment
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 54);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Sign In";
            label3.Font = new Font("Arial", 14, FontStyle.Bold);  // Set to bold, size 14
            label3.ForeColor = Color.Black;  // Text color for label
            label3.BackColor = Color.White;  // Background color for label
            label3.TextAlign = ContentAlignment.MiddleCenter;  // Center the text
            label3.Padding = new Padding(5);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(346, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Font = new Font("Arial", 10, FontStyle.Underline);  // Underlined text
            linkLabel1.ForeColor = Color.Blue;  // Text color for the link
            linkLabel1.BackColor = Color.White;  // Background color for the link
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 481);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            BackColor = Color.LightBlue;  // Set the form background color to light blue
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
