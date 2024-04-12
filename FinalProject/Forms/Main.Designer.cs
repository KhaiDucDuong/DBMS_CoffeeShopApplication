﻿namespace FinalProject_WinForm
{
    partial class HomePage
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
            flpList = new FlowLayoutPanel();
            tbSearch = new TextBox();
            pbSearch = new PictureBox();
            pictureBox2 = new PictureBox();
            ucMenu1 = new UCMenu();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.White;
            flpList.Location = new Point(56, 142);
            flpList.Margin = new Padding(3, 2, 3, 2);
            flpList.Name = "flpList";
            flpList.Size = new Size(930, 376);
            flpList.TabIndex = 6;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(214, 68);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 7;
            tbSearch.Text = "Search";
            // 
            // pbSearch
            // 
            pbSearch.BackColor = Color.White;
            pbSearch.Image = Properties.Resources.search2;
            pbSearch.Location = new Point(777, 68);
            pbSearch.Margin = new Padding(3, 2, 3, 2);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(57, 49);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 8;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseEnter += pbSearch_MouseEnter;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-9, 47);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1050, 532);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-9, -6);
            ucMenu1.Margin = new Padding(3, 2, 3, 2);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1312, 86);
            ucMenu1.TabIndex = 10;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(flpList);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            ForeColor = Color.FromArgb(204, 233, 255);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpList;
        private TextBox tbSearch;
        private PictureBox pbSearch;
        private PictureBox pictureBox2;
        private UCMenu ucMenu1;
    }
}