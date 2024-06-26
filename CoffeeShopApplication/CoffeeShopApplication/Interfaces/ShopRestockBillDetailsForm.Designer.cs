﻿namespace CoffeeShopApplication.Interfaces
{
    partial class ShopRestockBillDetailsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopRestockBillDetailsForm));
            dgvRestockBillDetails = new DataGridView();
            restockBillIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getRestockBillViewBindingSource = new BindingSource(components);
            dtpRestockBill = new DateTimePicker();
            lbDate = new Label();
            label1 = new Label();
            tbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            tbQuantity = new TextBox();
            pbRefresh = new PictureBox();
            pbDelete = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            cbIngredient = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRestockBillDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getRestockBillViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            SuspendLayout();
            // 
            // dgvRestockBillDetails
            // 
            dgvRestockBillDetails.AllowUserToAddRows = false;
            dgvRestockBillDetails.AllowUserToDeleteRows = false;
            dgvRestockBillDetails.AutoGenerateColumns = false;
            dgvRestockBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestockBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestockBillDetails.Columns.AddRange(new DataGridViewColumn[] { restockBillIdDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, ingredientNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dgvRestockBillDetails.DataSource = getRestockBillViewBindingSource;
            dgvRestockBillDetails.Location = new Point(15, 343);
            dgvRestockBillDetails.Margin = new Padding(4, 4, 4, 4);
            dgvRestockBillDetails.MultiSelect = false;
            dgvRestockBillDetails.Name = "dgvRestockBillDetails";
            dgvRestockBillDetails.ReadOnly = true;
            dgvRestockBillDetails.RowHeadersWidth = 51;
            dgvRestockBillDetails.Size = new Size(1319, 496);
            dgvRestockBillDetails.TabIndex = 11;
            dgvRestockBillDetails.CellContentClick += dgvRestockBillDetails_CellContentClick;
            // 
            // restockBillIdDataGridViewTextBoxColumn
            // 
            restockBillIdDataGridViewTextBoxColumn.DataPropertyName = "restockBillId";
            restockBillIdDataGridViewTextBoxColumn.HeaderText = "restockBillId";
            restockBillIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            restockBillIdDataGridViewTextBoxColumn.Name = "restockBillIdDataGridViewTextBoxColumn";
            restockBillIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.HeaderText = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getRestockBillViewBindingSource
            // 
            getRestockBillViewBindingSource.DataMember = "GetRestockBillView";
            getRestockBillViewBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // dtpRestockBill
            // 
            dtpRestockBill.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Enabled = false;
            dtpRestockBill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Location = new Point(788, 39);
            dtpRestockBill.Margin = new Padding(4, 4, 4, 4);
            dtpRestockBill.MinimumSize = new Size(403, 42);
            dtpRestockBill.Name = "dtpRestockBill";
            dtpRestockBill.Size = new Size(529, 47);
            dtpRestockBill.TabIndex = 2;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(661, 49);
            lbDate.Margin = new Padding(4, 0, 4, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(84, 41);
            lbDate.TabIndex = 37;
            lbDate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 41);
            label1.TabIndex = 38;
            label1.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(215, 35);
            tbId.Margin = new Padding(4, 4, 4, 4);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(427, 57);
            tbId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 41);
            label3.TabIndex = 40;
            label3.Text = "Ingredient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(666, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 42;
            label2.Text = "Price";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(788, 136);
            tbPrice.Margin = new Padding(4, 4, 4, 4);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(529, 57);
            tbPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 258);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 41);
            label4.TabIndex = 44;
            label4.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(215, 244);
            tbQuantity.Margin = new Padding(4, 4, 4, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(427, 57);
            tbQuantity.TabIndex = 5;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1203, 225);
            pbRefresh.Margin = new Padding(4, 4, 4, 4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(71, 77);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 48;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1081, 225);
            pbDelete.Margin = new Padding(4, 4, 4, 4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(71, 77);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 47;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(955, 225);
            pbSave.Margin = new Padding(4, 4, 4, 4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(71, 77);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 45;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(834, 225);
            pbAdd.Margin = new Padding(4, 4, 4, 4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(71, 77);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 46;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // cbIngredient
            // 
            cbIngredient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIngredient.FormattingEnabled = true;
            cbIngredient.IntegralHeight = false;
            cbIngredient.ItemHeight = 41;
            cbIngredient.Location = new Point(215, 136);
            cbIngredient.Margin = new Padding(4, 4, 4, 4);
            cbIngredient.MinimumSize = new Size(427, 0);
            cbIngredient.Name = "cbIngredient";
            cbIngredient.Size = new Size(427, 49);
            cbIngredient.TabIndex = 3;
            cbIngredient.SelectedIndexChanged += cbIngredient_SelectedIndexChanged;
            // 
            // ShopRestockBillDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 855);
            Controls.Add(cbIngredient);
            Controls.Add(pbRefresh);
            Controls.Add(pbDelete);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(label4);
            Controls.Add(tbQuantity);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(dtpRestockBill);
            Controls.Add(lbDate);
            Controls.Add(label1);
            Controls.Add(tbId);
            Controls.Add(dgvRestockBillDetails);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "ShopRestockBillDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restock Bill Details";
            Load += ShopRestockBillDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRestockBillDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)getRestockBillViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRestockBillDetails;
        private DataGridViewTextBoxColumn restockBillIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource getRestockBillViewBindingSource;
        private DateTimePicker dtpRestockBill;
        private Label lbDate;
        private Label label1;
        private TextBox tbId;
        private Label label3;
        private Label label2;
        private TextBox tbPrice;
        private Label label4;
        private TextBox tbQuantity;
        private PictureBox pbRefresh;
        private PictureBox pbDelete;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private ComboBox cbIngredient;
    }
}