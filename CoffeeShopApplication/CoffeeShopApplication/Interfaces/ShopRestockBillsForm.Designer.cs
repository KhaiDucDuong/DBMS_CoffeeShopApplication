namespace CoffeeShopApplication.Interfaces
{
    partial class ShopRestockBillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopRestockBillsForm));
            header1 = new UC.Header();
            dgvRestockBills = new DataGridView();
            restockBillIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalBillDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            restockBillBindingSource = new BindingSource(components);
            pbDelete = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            label3 = new Label();
            tbSupplierName = new TextBox();
            lbDate = new Label();
            label1 = new Label();
            tbId = new TextBox();
            dtpRestockBill = new DateTimePicker();
            btnViewDetails = new Button();
            pbRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRestockBills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)restockBillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -2);
            header1.Margin = new Padding(3, 2, 3, 2);
            header1.Name = "header1";
            header1.Size = new Size(1050, 125);
            header1.TabIndex = 9;
            // 
            // dgvRestockBills
            // 
            dgvRestockBills.AllowUserToAddRows = false;
            dgvRestockBills.AllowUserToDeleteRows = false;
            dgvRestockBills.AutoGenerateColumns = false;
            dgvRestockBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestockBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestockBills.Columns.AddRange(new DataGridViewColumn[] { restockBillIdDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, totalBillDataGridViewTextBoxColumn });
            dgvRestockBills.DataSource = restockBillBindingSource;
            dgvRestockBills.Location = new Point(12, 378);
            dgvRestockBills.MultiSelect = false;
            dgvRestockBills.Name = "dgvRestockBills";
            dgvRestockBills.ReadOnly = true;
            dgvRestockBills.RowHeadersWidth = 51;
            dgvRestockBills.Size = new Size(1026, 354);
            dgvRestockBills.TabIndex = 11;
            dgvRestockBills.CellContentClick += dgvRestockBills_CellContentClick;
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
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "supplierName";
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBillDataGridViewTextBoxColumn
            // 
            totalBillDataGridViewTextBoxColumn.DataPropertyName = "totalBill";
            totalBillDataGridViewTextBoxColumn.HeaderText = "totalBill";
            totalBillDataGridViewTextBoxColumn.Name = "totalBillDataGridViewTextBoxColumn";
            totalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restockBillBindingSource
            // 
            restockBillBindingSource.DataMember = "RestockBill";
            restockBillBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(876, 294);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(55, 55);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 29;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(778, 294);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 26;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(684, 294);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 27;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(588, 294);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 28;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            pbSearch.MouseHover += pbSearch_MouseHover;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(12, 294);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 4;
            tbSearch.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 220);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 35;
            label3.Text = "Supplier Name";
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupplierName.Location = new Point(249, 217);
            tbSupplierName.Multiline = true;
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.Size = new Size(333, 42);
            tbSupplierName.TabIndex = 3;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(515, 157);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(67, 32);
            lbDate.TabIndex = 33;
            lbDate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 153);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 34;
            label1.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(115, 150);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(333, 42);
            tbId.TabIndex = 1;
            // 
            // dtpRestockBill
            // 
            dtpRestockBill.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRestockBill.Location = new Point(614, 150);
            dtpRestockBill.MinimumSize = new Size(314, 42);
            dtpRestockBill.Name = "dtpRestockBill";
            dtpRestockBill.Size = new Size(412, 42);
            dtpRestockBill.TabIndex = 2;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(835, 217);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(191, 42);
            btnViewDetails.TabIndex = 37;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(971, 294);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 38;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // ShopRestockBillsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            ControlBox = false;
            Controls.Add(pbRefresh);
            Controls.Add(btnViewDetails);
            Controls.Add(dtpRestockBill);
            Controls.Add(label3);
            Controls.Add(tbSupplierName);
            Controls.Add(lbDate);
            Controls.Add(label1);
            Controls.Add(tbId);
            Controls.Add(pbDelete);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvRestockBills);
            Controls.Add(header1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopRestockBillsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Restock Bills";
            Load += ShopRestockBillsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRestockBills).EndInit();
            ((System.ComponentModel.ISupportInitialize)restockBillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private DataGridView dgvRestockBills;
        private PictureBox pbDelete;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private DataGridViewTextBoxColumn restockBillIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private BindingSource restockBillBindingSource;
        private Label label3;
        private TextBox tbSupplierName;
        private Label lbDate;
        private Label label1;
        private TextBox tbId;
        private DateTimePicker dtpRestockBill;
        private Button btnViewDetails;
        private PictureBox pbRefresh;
    }
}