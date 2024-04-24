namespace CoffeeShopApplication
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            header1 = new UC.Header();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogOut = new Button();
            pbAccounts = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAccounts).BeginInit();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(1, 0);
            header1.Name = "header1";
            header1.Size = new Size(1200, 167);
            header1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(429, 173);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(371, 592);
            label1.MaximumSize = new Size(571, 267);
            label1.Name = "label1";
            label1.Size = new Size(525, 138);
            label1.TabIndex = 2;
            label1.Text = "Coffee Shop Management Tool";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(968, 173);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(218, 56);
            btnLogOut.TabIndex = 38;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pbAccounts
            // 
            pbAccounts.Image = Properties.Resources.user;
            pbAccounts.Location = new Point(24, 173);
            pbAccounts.Name = "pbAccounts";
            pbAccounts.Size = new Size(113, 98);
            pbAccounts.SizeMode = PictureBoxSizeMode.CenterImage;
            pbAccounts.TabIndex = 39;
            pbAccounts.TabStop = false;
            pbAccounts.Click += pbAccounts_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 992);
            ControlBox = false;
            Controls.Add(pbAccounts);
            Controls.Add(btnLogOut);
            Controls.Add(label1);
            Controls.Add(header1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Menu";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UC.Header headerUc;
        private UC.Header header1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLogOut;
        private PictureBox pbAccounts;
    }
}
