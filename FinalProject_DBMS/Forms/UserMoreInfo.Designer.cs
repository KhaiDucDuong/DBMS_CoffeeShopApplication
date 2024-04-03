﻿namespace FinalProject_WinForm
{
    partial class UserMoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMoreInfo));
            pbUserAvatar = new PictureBox();
            panel2 = new Panel();
            pbUpdateAvatar = new PictureBox();
            pbUpload = new PictureBox();
            pbDelete = new PictureBox();
            ucGender = new UCCheckBox();
            label6 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ucMenu1 = new UCMenu();
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbUserAvatar
            // 
            pbUserAvatar.Image = (Image)resources.GetObject("pbUserAvatar.Image");
            pbUserAvatar.Location = new Point(144, 127);
            pbUserAvatar.Name = "pbUserAvatar";
            pbUserAvatar.Size = new Size(240, 240);
            pbUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserAvatar.TabIndex = 13;
            pbUserAvatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pbUpdateAvatar);
            panel2.Controls.Add(pbUpload);
            panel2.Controls.Add(pbDelete);
            panel2.Controls.Add(ucGender);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(89, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 495);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pbUpdateAvatar
            // 
            pbUpdateAvatar.Image = (Image)resources.GetObject("pbUpdateAvatar.Image");
            pbUpdateAvatar.Location = new Point(55, 141);
            pbUpdateAvatar.Name = "pbUpdateAvatar";
            pbUpdateAvatar.Size = new Size(50, 50);
            pbUpdateAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateAvatar.TabIndex = 28;
            pbUpdateAvatar.TabStop = false;
            pbUpdateAvatar.Click += pbUpdateAvatar_Click;
            // 
            // pbUpload
            // 
            pbUpload.Image = Properties.Resources.up_loading;
            pbUpload.Location = new Point(923, 420);
            pbUpload.Name = "pbUpload";
            pbUpload.Size = new Size(50, 50);
            pbUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpload.TabIndex = 27;
            pbUpload.TabStop = false;
            pbUpload.Click += pbUpload_Click;
            // 
            // pbDelete
            // 
            pbDelete.Image = Properties.Resources.delete;
            pbDelete.Location = new Point(55, 420);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(50, 50);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 26;
            pbDelete.TabStop = false;
            // 
            // ucGender
            // 
            ucGender.Femaleimage = null;
            ucGender.Location = new Point(471, 334);
            ucGender.Maleimage = null;
            ucGender.Name = "ucGender";
            ucGender.Otherimage = null;
            ucGender.Size = new Size(436, 56);
            ucGender.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(364, 358);
            label6.Margin = new Padding(3, 0, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 24;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(364, 290);
            label5.Margin = new Padding(3, 0, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(471, 290);
            txtAddress.Margin = new Padding(3, 20, 3, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(502, 38);
            txtAddress.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(471, 219);
            txtEmail.Margin = new Padding(3, 20, 3, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(502, 38);
            txtEmail.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(584, 158);
            txtPassword.Margin = new Padding(3, 20, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(389, 38);
            txtPassword.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(364, 229);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 19;
            label4.Text = "Email:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(471, 168);
            label3.Margin = new Padding(3, 0, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 18;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(584, 95);
            txtName.Margin = new Padding(3, 20, 3, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 38);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(471, 105);
            label2.Margin = new Padding(3, 20, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 16;
            label2.Text = "User Name:";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 0);
            label1.Name = "label1";
            label1.Size = new Size(630, 81);
            label1.TabIndex = 15;
            label1.Text = "Personal Information";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-5, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 710);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-5, -2);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1500, 114);
            ucMenu1.TabIndex = 17;
            // 
            // UserMoreInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(pbUserAvatar);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            Name = "UserMoreInfo";
            Text = "UserMoreInfo";
            Load += UserMoreInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnUpdUser;
        private PictureBox pbUserAvatar;
        private Button btnMainReturn;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private TextBox txtAddress;
        private UCMenu ucMenu1;
        private UCCheckBox ucGender;
        private PictureBox pbDelete;
        private PictureBox pbUpload;
        private PictureBox pbUpdateAvatar;
    }
}