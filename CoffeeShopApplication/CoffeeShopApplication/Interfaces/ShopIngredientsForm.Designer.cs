namespace CoffeeShopApplication.Interfaces
{
    partial class ShopIngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopIngredientsForm));
            header1 = new UC.Header();
            dgvIngredients = new DataGridView();
            ingredientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ingredientBindingSource = new BindingSource(components);
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbName = new TextBox();
            tbId = new TextBox();
            cbDeleted = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            tbManufacturerName = new TextBox();
            pbDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -3);
            header1.Margin = new Padding(4, 3, 4, 3);
            header1.Name = "header1";
            header1.Size = new Size(1350, 175);
            header1.TabIndex = 9;
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dgvIngredients.AutoGenerateColumns = false;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { ingredientIdDataGridViewTextBoxColumn, ingredientNameDataGridViewTextBoxColumn, manufacturerNameDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvIngredients.DataSource = ingredientBindingSource;
            dgvIngredients.Location = new Point(15, 529);
            dgvIngredients.Margin = new Padding(4);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(1319, 496);
            dgvIngredients.TabIndex = 10;
            dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;
            // 
            // ingredientIdDataGridViewTextBoxColumn
            // 
            ingredientIdDataGridViewTextBoxColumn.DataPropertyName = "ingredientId";
            ingredientIdDataGridViewTextBoxColumn.HeaderText = "ingredientId";
            ingredientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingredientIdDataGridViewTextBoxColumn.Name = "ingredientIdDataGridViewTextBoxColumn";
            ingredientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.HeaderText = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerNameDataGridViewTextBoxColumn
            // 
            manufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "manufacturerName";
            manufacturerNameDataGridViewTextBoxColumn.HeaderText = "manufacturerName";
            manufacturerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            manufacturerNameDataGridViewTextBoxColumn.Name = "manufacturerNameDataGridViewTextBoxColumn";
            manufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataMember = "Ingredient";
            ingredientBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1243, 410);
            pbRefresh.Margin = new Padding(4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(71, 77);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 12;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(1000, 410);
            pbSave.Margin = new Padding(4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(71, 77);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 13;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(879, 410);
            pbAdd.Margin = new Padding(4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(71, 77);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 14;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(756, 410);
            pbSearch.Margin = new Padding(4);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(71, 77);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 15;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            pbSearch.MouseHover += pbSearch_MouseHover;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(15, 410);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(705, 65);
            tbSearch.TabIndex = 5;
            tbSearch.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(771, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 41);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 197);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 41);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(910, 193);
            tbName.Margin = new Padding(4);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(403, 57);
            tbName.TabIndex = 2;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(141, 193);
            tbId.Margin = new Padding(4);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(427, 57);
            tbId.TabIndex = 1;
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(1126, 290);
            cbDeleted.Margin = new Padding(4);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(187, 49);
            cbDeleted.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(987, 291);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 41);
            label5.TabIndex = 20;
            label5.Text = "Deleted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 291);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(296, 41);
            label3.TabIndex = 23;
            label3.Text = "Manufacturer name";
            // 
            // tbManufacturerName
            // 
            tbManufacturerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbManufacturerName.Location = new Point(375, 287);
            tbManufacturerName.Margin = new Padding(4);
            tbManufacturerName.Multiline = true;
            tbManufacturerName.Name = "tbManufacturerName";
            tbManufacturerName.Size = new Size(427, 57);
            tbManufacturerName.TabIndex = 3;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1126, 410);
            pbDelete.Margin = new Padding(4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(71, 77);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 24;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // ShopIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 1042);
            ControlBox = false;
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbManufacturerName);
            Controls.Add(cbDeleted);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvIngredients);
            Controls.Add(header1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ShopIngredientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Ingredients";
            Load += ShopIngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private DataGridView dgvIngredients;
        private DataGridViewTextBoxColumn ingredientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource ingredientBindingSource;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private TextBox tbId;
        private ComboBox cbDeleted;
        private Label label5;
        private Label label3;
        private TextBox tbManufacturerName;
        private PictureBox pbDelete;
    }
}