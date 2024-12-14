namespace Football_League_DB
{
    partial class Form3
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

        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.FromArgb(0, 123, 255);
            linkLabel1.Location = new Point(537, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(137, 32);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(-9, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(50);
            pictureBox1.Size = new Size(1222, 604);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(76, 175, 80);
            progressBar1.Location = new Point(462, 410);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 30);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(522, 105);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(152, 35);
            label1.TabIndex = 0;
            label1.Text = "WELCOME ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1500, 700);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Football League Database";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
