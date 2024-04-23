namespace CoffeeShopApplication.Interfaces
{
    partial class ShopCalculateFrom
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
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            tbRestockCost = new TextBox();
            tbShopRevenue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 51);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 0;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 155);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 1;
            label2.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(385, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(303, 29);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(385, 164);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(303, 29);
            dateTimePicker2.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(946, 219);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(255, 57);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 252);
            label3.Name = "label3";
            label3.Size = new Size(203, 38);
            label3.TabIndex = 5;
            label3.Text = "Shop Revenue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 394);
            label4.Name = "label4";
            label4.Size = new Size(183, 38);
            label4.TabIndex = 6;
            label4.Text = "Restock Cost";
            // 
            // tbRestockCost
            // 
            tbRestockCost.Location = new Point(385, 404);
            tbRestockCost.Name = "tbRestockCost";
            tbRestockCost.Size = new Size(309, 29);
            tbRestockCost.TabIndex = 7;
            // 
            // tbShopRevenue
            // 
            tbShopRevenue.Location = new Point(385, 262);
            tbShopRevenue.Name = "tbShopRevenue";
            tbShopRevenue.Size = new Size(303, 29);
            tbShopRevenue.TabIndex = 8;
            // 
            // ShopCalculateFrom
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 515);
            Controls.Add(tbShopRevenue);
            Controls.Add(tbRestockCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShopCalculateFrom";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private TextBox tbRestockCost;
        private TextBox tbShopRevenue;
    }
}