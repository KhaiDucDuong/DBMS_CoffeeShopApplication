namespace CoffeeShopApplication.Interfaces
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
            getRestockBillViewBindingSource = new BindingSource(components);
            restockBillIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dtpRestockBill = new DateTimePicker();
            lbDate = new Label();
            label1 = new Label();
            tbId = new TextBox();
            label3 = new Label();
            tbSupplierName = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            pbRefresh = new PictureBox();
            pbDelete = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
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
            dgvRestockBillDetails.Location = new Point(12, 245);
            dgvRestockBillDetails.MultiSelect = false;
            dgvRestockBillDetails.Name = "dgvRestockBillDetails";
            dgvRestockBillDetails.ReadOnly = true;
            dgvRestockBillDetails.RowHeadersWidth = 51;
            dgvRestockBillDetails.Size = new Size(1026, 354);
            dgvRestockBillDetails.TabIndex = 11;
            // 
            // getRestockBillViewBindingSource
            // 
            getRestockBillViewBindingSource.DataMember = "GetRestockBillView";
            getRestockBillViewBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // restockBillIdDataGridViewTextBoxColumn
            // 
            restockBillIdDataGridViewTextBoxColumn.DataPropertyName = "restockBillId";
            restockBillIdDataGridViewTextBoxColumn.HeaderText = "restockBillId";
            restockBillIdDataGridViewTextBoxColumn.Name = "restockBillIdDataGridViewTextBoxColumn";
            restockBillIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.HeaderText = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtpRestockBill
            // 
            dtpRestockBill.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Location = new Point(615, 12);
            dtpRestockBill.MinimumSize = new Size(314, 42);
            dtpRestockBill.Name = "dtpRestockBill";
            dtpRestockBill.Size = new Size(412, 42);
            dtpRestockBill.TabIndex = 36;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(516, 19);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(67, 32);
            lbDate.TabIndex = 37;
            lbDate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 38;
            label1.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(169, 9);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(333, 42);
            tbId.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 84);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 40;
            label3.Text = "Ingredient";
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupplierName.Location = new Point(169, 81);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(333, 42);
            tbSupplierName.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 42;
            label2.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(615, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 42);
            textBox1.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 168);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 44;
            label4.Text = "Quantity";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(169, 158);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 42);
            textBox2.TabIndex = 43;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(938, 145);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 48;
            pbRefresh.TabStop = false;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(843, 145);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(55, 55);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 47;
            pbDelete.TabStop = false;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(745, 145);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 45;
            pbSave.TabStop = false;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(651, 145);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 46;
            pbAdd.TabStop = false;
            // 
            // ShopRestockBillDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 611);
            Controls.Add(pbRefresh);
            Controls.Add(pbDelete);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(tbSupplierName);
            Controls.Add(dtpRestockBill);
            Controls.Add(lbDate);
            Controls.Add(label1);
            Controls.Add(tbId);
            Controls.Add(dgvRestockBillDetails);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopRestockBillDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restock Bill Details";
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
        private TextBox tbSupplierName;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pbRefresh;
        private PictureBox pbDelete;
        private PictureBox pbSave;
        private PictureBox pbAdd;
    }
}