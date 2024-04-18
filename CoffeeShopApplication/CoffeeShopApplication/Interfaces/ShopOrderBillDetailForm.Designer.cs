namespace CoffeeShopApplication
{
    partial class ShopOrderBillDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopOrderBillDetailForm));
            label5 = new Label();
            label4 = new Label();
            tbQuantity = new TextBox();
            header1 = new UC.Header();
            pbDelete = new PictureBox();
            label3 = new Label();
            tbProductId = new TextBox();
            label1 = new Label();
            tbBillId = new TextBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            dgvOrderBillDetail = new DataGridView();
            billIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBillDetailsBindingSource = new BindingSource(components);
            dgvProduct = new DataGridView();
            pbRefreshProduct = new PictureBox();
            listProductViewBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderBillDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBillDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefreshProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listProductViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(444, 143);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 89;
            label5.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 243);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 85;
            label4.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(178, 241);
            tbQuantity.Margin = new Padding(4, 3, 4, 3);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(213, 42);
            tbQuantity.TabIndex = 84;
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -2);
            header1.Margin = new Padding(4, 2, 4, 2);
            header1.Name = "header1";
            header1.Size = new Size(1050, 113);
            header1.TabIndex = 9;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(234, 303);
            pbDelete.Margin = new Padding(4, 3, 4, 3);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(55, 55);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 83;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 82;
            label3.Text = "Product Id";
            // 
            // tbProductId
            // 
            tbProductId.Enabled = false;
            tbProductId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProductId.Location = new Point(178, 187);
            tbProductId.Margin = new Padding(4, 3, 4, 3);
            tbProductId.Multiline = true;
            tbProductId.Name = "tbProductId";
            tbProductId.Size = new Size(213, 42);
            tbProductId.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 81;
            label1.Text = "Bill Id";
            // 
            // tbBillId
            // 
            tbBillId.Enabled = false;
            tbBillId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBillId.Location = new Point(178, 134);
            tbBillId.Margin = new Padding(4, 3, 4, 3);
            tbBillId.Multiline = true;
            tbBillId.Name = "tbBillId";
            tbBillId.Size = new Size(213, 42);
            tbBillId.TabIndex = 71;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(335, 303);
            pbRefresh.Margin = new Padding(4, 3, 4, 3);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 76;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(132, 303);
            pbSave.Margin = new Padding(4, 3, 4, 3);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 77;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(38, 303);
            pbAdd.Margin = new Padding(4, 3, 4, 3);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 78;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(906, 134);
            pbSearch.Margin = new Padding(4, 3, 4, 3);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 79;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(643, 134);
            tbSearch.Margin = new Padding(4, 2, 4, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(257, 53);
            tbSearch.TabIndex = 74;
            // 
            // dgvOrderBillDetail
            // 
            dgvOrderBillDetail.AllowUserToAddRows = false;
            dgvOrderBillDetail.AllowUserToDeleteRows = false;
            dgvOrderBillDetail.AutoGenerateColumns = false;
            dgvOrderBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderBillDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderBillDetail.Columns.AddRange(new DataGridViewColumn[] { billIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dgvOrderBillDetail.DataSource = orderBillDetailsBindingSource;
            dgvOrderBillDetail.Location = new Point(13, 380);
            dgvOrderBillDetail.Margin = new Padding(4, 3, 4, 3);
            dgvOrderBillDetail.MultiSelect = false;
            dgvOrderBillDetail.Name = "dgvOrderBillDetail";
            dgvOrderBillDetail.ReadOnly = true;
            dgvOrderBillDetail.RowHeadersWidth = 51;
            dgvOrderBillDetail.Size = new Size(1026, 354);
            dgvOrderBillDetail.TabIndex = 75;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            billIdDataGridViewTextBoxColumn.DataPropertyName = "billId";
            billIdDataGridViewTextBoxColumn.HeaderText = "billId";
            billIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBillDetailsBindingSource
            // 
            orderBillDetailsBindingSource.DataMember = "OrderBillDetails";
            orderBillDetailsBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, productIdDataGridViewTextBoxColumn2 });
            dgvProduct.DataSource = listProductViewBindingSource;
            dgvProduct.Location = new Point(452, 195);
            dgvProduct.Margin = new Padding(4, 3, 4, 3);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(571, 163);
            dgvProduct.TabIndex = 90;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // pbRefreshProduct
            // 
            pbRefreshProduct.Image = (Image)resources.GetObject("pbRefreshProduct.Image");
            pbRefreshProduct.Location = new Point(969, 134);
            pbRefreshProduct.Margin = new Padding(4, 3, 4, 3);
            pbRefreshProduct.Name = "pbRefreshProduct";
            pbRefreshProduct.Size = new Size(55, 55);
            pbRefreshProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefreshProduct.TabIndex = 91;
            pbRefreshProduct.TabStop = false;
            pbRefreshProduct.Click += pbRefreshProduct_Click;
            // 
            // listProductViewBindingSource
            // 
            listProductViewBindingSource.DataMember = "ListProductView";
            listProductViewBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "productName";
            dataGridViewTextBoxColumn1.HeaderText = "productName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn2
            // 
            productIdDataGridViewTextBoxColumn2.DataPropertyName = "productId";
            productIdDataGridViewTextBoxColumn2.HeaderText = "productId";
            productIdDataGridViewTextBoxColumn2.Name = "productIdDataGridViewTextBoxColumn2";
            productIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ShopOrderBillDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            Controls.Add(pbRefreshProduct);
            Controls.Add(dgvProduct);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbQuantity);
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbProductId);
            Controls.Add(label1);
            Controls.Add(tbBillId);
            Controls.Add(header1);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvOrderBillDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShopOrderBillDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderBillDetail";
            Load += ShopOrderBillDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderBillDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBillDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefreshProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)listProductViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private ComboBox cbDeleted;
        private Label label7;
        private Label label5;
        private TextBox tbEmployeeId;
        private Label label4;
        private TextBox tbQuantity;
        private PictureBox pbDelete;
        private Label label3;
        private TextBox tbProductId;
        private Label label1;
        private TextBox tbCustomerId;
        private TextBox tbBillId;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private DataGridView dgvOrderBillDetail;
        private DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource orderBillDetailsBindingSource;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private Label label2;
        private Label label6;
        private PictureBox pbRefreshProduct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn2;
        private BindingSource listProductViewBindingSource;
    }
}