namespace CoffeeShopApplication.Interfaces
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(587, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 260);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(616, 314);
            label1.Name = "label1";
            label1.Size = new Size(207, 68);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(279, 459);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 63);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(406, 629);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(255, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Salmon;
            panel3.Location = new Point(283, 550);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 1);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Location = new Point(283, 675);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 1);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.reset_password;
            pictureBox3.Location = new Point(279, 590);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 62);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = SystemColors.Window;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.ForeColor = Color.Salmon;
            tbUserName.Location = new Point(434, 459);
            tbUserName.Multiline = true;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(649, 63);
            tbUserName.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Salmon;
            tbPassword.Location = new Point(434, 589);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(649, 63);
            tbPassword.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(283, 767);
            button1.Name = "button1";
            button1.Size = new Size(803, 64);
            button1.TabIndex = 10;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Salmon;
            label2.Location = new Point(640, 875);
            label2.Name = "label2";
            label2.Size = new Size(92, 46);
            label2.TabIndex = 11;
            label2.Text = "EXIT";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Salmon;
            label3.Location = new Point(929, 706);
            label3.Name = "label3";
            label3.Size = new Size(154, 38);
            label3.TabIndex = 12;
            label3.Text = "Clear Field";
            label3.Click += label3_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1350, 963);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += LogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}