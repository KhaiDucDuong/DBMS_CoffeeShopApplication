namespace FinalProject_WinForm
{
    partial class AddItems
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
            ucMenu1 = new UCMenu();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtProductDiscription = new TextBox();
            pbAddCart = new PictureBox();
            panel2 = new Panel();
            pbPictureUpload2 = new PictureBox();
            pbPictureUpload1 = new PictureBox();
            pbItemsPicture2 = new PictureBox();
            pbItemsPicture1 = new PictureBox();
            pbPictureUpload = new PictureBox();
            pbItemsPicture = new PictureBox();
            panel4 = new Panel();
            label8 = new Label();
            txtProductPrice = new TextBox();
            txtQuality = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtOriginPrice = new TextBox();
            txtYear = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            txtProductQuantity = new TextBox();
            lbMode = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddCart).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-8, 0);
            ucMenu1.Margin = new Padding(3, 2, 3, 2);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1312, 86);
            ucMenu1.TabIndex = 0;
            ucMenu1.Load += ucMenu1_Load;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox1.Location = new Point(-8, 64);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1050, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(txtProductDiscription);
            panel3.Location = new Point(24, 70);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 62);
            panel3.TabIndex = 4;
            // 
            // txtProductDiscription
            // 
            txtProductDiscription.BackColor = SystemColors.ControlLight;
            txtProductDiscription.BorderStyle = BorderStyle.None;
            txtProductDiscription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductDiscription.Location = new Point(3, 2);
            txtProductDiscription.Margin = new Padding(3, 2, 3, 2);
            txtProductDiscription.Name = "txtProductDiscription";
            txtProductDiscription.PlaceholderText = "Write some discription about ypur product";
            txtProductDiscription.Size = new Size(397, 16);
            txtProductDiscription.TabIndex = 4;
            // 
            // pbAddCart
            // 
            pbAddCart.Image = Properties.Resources.up_loading;
            pbAddCart.Location = new Point(621, 374);
            pbAddCart.Margin = new Padding(3, 2, 3, 2);
            pbAddCart.Name = "pbAddCart";
            pbAddCart.Size = new Size(44, 38);
            pbAddCart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddCart.TabIndex = 3;
            pbAddCart.TabStop = false;
            pbAddCart.Click += pbAddCart_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbPictureUpload2);
            panel2.Controls.Add(pbPictureUpload1);
            panel2.Controls.Add(pbItemsPicture2);
            panel2.Controls.Add(pbItemsPicture1);
            panel2.Controls.Add(pbPictureUpload);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pbAddCart);
            panel2.Controls.Add(pbItemsPicture);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtProductName);
            panel2.Location = new Point(302, 114);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 424);
            panel2.TabIndex = 2;
            // 
            // pbPictureUpload2
            // 
            pbPictureUpload2.Image = Properties.Resources.add;
            pbPictureUpload2.Location = new Point(612, 273);
            pbPictureUpload2.Margin = new Padding(3, 2, 3, 2);
            pbPictureUpload2.Name = "pbPictureUpload2";
            pbPictureUpload2.Size = new Size(52, 45);
            pbPictureUpload2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload2.TabIndex = 19;
            pbPictureUpload2.TabStop = false;
            pbPictureUpload2.Click += pbPictureUpload2_Click;
            // 
            // pbPictureUpload1
            // 
            pbPictureUpload1.Image = Properties.Resources.add;
            pbPictureUpload1.Location = new Point(499, 273);
            pbPictureUpload1.Margin = new Padding(3, 2, 3, 2);
            pbPictureUpload1.Name = "pbPictureUpload1";
            pbPictureUpload1.Size = new Size(52, 45);
            pbPictureUpload1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload1.TabIndex = 18;
            pbPictureUpload1.TabStop = false;
            pbPictureUpload1.Click += pbPictureUpload1_Click;
            // 
            // pbItemsPicture2
            // 
            pbItemsPicture2.Image = Properties.Resources.product_placeholder;
            pbItemsPicture2.Location = new Point(560, 228);
            pbItemsPicture2.Margin = new Padding(3, 2, 3, 2);
            pbItemsPicture2.Name = "pbItemsPicture2";
            pbItemsPicture2.Size = new Size(105, 90);
            pbItemsPicture2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture2.TabIndex = 15;
            pbItemsPicture2.TabStop = false;
            // 
            // pbItemsPicture1
            // 
            pbItemsPicture1.Image = Properties.Resources.product_placeholder;
            pbItemsPicture1.Location = new Point(446, 228);
            pbItemsPicture1.Margin = new Padding(3, 2, 3, 2);
            pbItemsPicture1.Name = "pbItemsPicture1";
            pbItemsPicture1.Size = new Size(105, 90);
            pbItemsPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture1.TabIndex = 14;
            pbItemsPicture1.TabStop = false;
            // 
            // pbPictureUpload
            // 
            pbPictureUpload.Image = Properties.Resources.add;
            pbPictureUpload.Location = new Point(612, 174);
            pbPictureUpload.Margin = new Padding(3, 2, 3, 2);
            pbPictureUpload.Name = "pbPictureUpload";
            pbPictureUpload.Size = new Size(52, 45);
            pbPictureUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload.TabIndex = 9;
            pbPictureUpload.TabStop = false;
            pbPictureUpload.Click += pbPictureUpload_Click;
            // 
            // pbItemsPicture
            // 
            pbItemsPicture.Image = Properties.Resources.product_placeholder;
            pbItemsPicture.Location = new Point(446, 32);
            pbItemsPicture.Margin = new Padding(3, 2, 3, 2);
            pbItemsPicture.Name = "pbItemsPicture";
            pbItemsPicture.Size = new Size(219, 188);
            pbItemsPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture.TabIndex = 0;
            pbItemsPicture.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtProductPrice);
            panel4.Controls.Add(txtQuality);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtOriginPrice);
            panel4.Controls.Add(txtYear);
            panel4.Controls.Add(label4);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(24, 174);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 238);
            panel4.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 9);
            label8.Margin = new Padding(3, 4, 3, 8);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 16;
            label8.Text = "Quality:";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(36, 200);
            txtProductPrice.Margin = new Padding(3, 2, 3, 2);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(332, 23);
            txtProductPrice.TabIndex = 6;
            // 
            // txtQuality
            // 
            txtQuality.Location = new Point(35, 35);
            txtQuality.Margin = new Padding(35, 2, 35, 2);
            txtQuality.Name = "txtQuality";
            txtQuality.Size = new Size(333, 23);
            txtQuality.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 120);
            label3.Margin = new Padding(3, 4, 3, 8);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 64);
            label6.Margin = new Padding(3, 4, 3, 8);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 12;
            label6.Text = "Year:";
            // 
            // txtOriginPrice
            // 
            txtOriginPrice.Location = new Point(36, 146);
            txtOriginPrice.Margin = new Padding(3, 2, 3, 2);
            txtOriginPrice.Name = "txtOriginPrice";
            txtOriginPrice.Size = new Size(332, 23);
            txtOriginPrice.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(35, 87);
            txtYear.Margin = new Padding(3, 2, 3, 2);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(333, 23);
            txtYear.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 178);
            label4.Margin = new Padding(3, 4, 3, 8);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 10;
            label4.Text = "Original Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 138);
            label1.Name = "label1";
            label1.Size = new Size(111, 36);
            label1.TabIndex = 2;
            label1.Text = "ABOUT:";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Control;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(24, 12);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(400, 54);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 233, 255);
            label2.Location = new Point(13, 8);
            label2.Margin = new Padding(3, 4, 3, 8);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 5;
            label2.Text = "Quantity:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lbMode);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(28, 114);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 207);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 85, 111);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtProductQuantity);
            panel5.Location = new Point(16, 46);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 86);
            panel5.TabIndex = 21;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(13, 41);
            txtProductQuantity.Margin = new Padding(13, 2, 13, 2);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(204, 23);
            txtProductQuantity.TabIndex = 5;
            // 
            // lbMode
            // 
            lbMode.AutoSize = true;
            lbMode.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMode.ForeColor = Color.FromArgb(204, 233, 255);
            lbMode.Location = new Point(74, 146);
            lbMode.Name = "lbMode";
            lbMode.Size = new Size(93, 36);
            lbMode.TabIndex = 17;
            lbMode.Text = "Mode:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(204, 233, 255);
            label7.Location = new Point(29, 9);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(169, 37);
            label7.TabIndex = 11;
            label7.Text = "INVENTORY";
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(ucMenu1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddItems";
            Text = "Form1";
            Load += AddItems_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UCMenu ucMenu1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pbAddCart;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pbItemsPicture;
        private Label label1;
        private Label label2;
        private TextBox txtProductQuantity;
        private TextBox txtProductDiscription;
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtProductPrice;
        private PictureBox pbPictureUpload;
        private Label label4;
        private TextBox txtOriginPrice;
        private Label label6;
        private TextBox txtYear;
        private Label label8;
        private PictureBox pbItemsPicture2;
        private PictureBox pbItemsPicture1;
        private TextBox txtQuality;
        private PictureBox pbPictureUpload2;
        private PictureBox pbPictureUpload1;
        private Label label7;
        private Label lbMode;
        private Panel panel4;
        private Panel panel5;
    }
}