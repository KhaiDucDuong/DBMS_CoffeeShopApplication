using System.Resources;
using System.Windows.Forms;

namespace CoffeeShopApplication
{
    partial class ShopProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopProductsForm));
            tbSearch = new TextBox();
            dataGridView1 = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            productBindingSource = new BindingSource(components);
            pbSearch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(243, 183);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 7;
            tbSearch.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productSizeDataGridViewTextBoxColumn, productPriceDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(12, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1026, 354);
            dataGridView1.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSizeDataGridViewTextBoxColumn
            // 
            productSizeDataGridViewTextBoxColumn.DataPropertyName = "productSize";
            productSizeDataGridViewTextBoxColumn.HeaderText = "productSize";
            productSizeDataGridViewTextBoxColumn.Name = "productSizeDataGridViewTextBoxColumn";
            productSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            productPriceDataGridViewTextBoxColumn.HeaderText = "productPrice";
            productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataMember = "Product";
            productBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(813, 183);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 53);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 8;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // ShopProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Products";
            Load += ShopProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource productBindingSource;
        private PictureBox pbSearch;
    }
}