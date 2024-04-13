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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
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
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dgvIngredients.AutoGenerateColumns = false;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { ingredientIdDataGridViewTextBoxColumn, ingredientNameDataGridViewTextBoxColumn, manufacturerNameDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvIngredients.DataSource = ingredientBindingSource;
            dgvIngredients.Location = new Point(12, 378);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(1026, 354);
            dgvIngredients.TabIndex = 10;
            // 
            // ingredientIdDataGridViewTextBoxColumn
            // 
            ingredientIdDataGridViewTextBoxColumn.DataPropertyName = "ingredientId";
            ingredientIdDataGridViewTextBoxColumn.HeaderText = "ingredientId";
            ingredientIdDataGridViewTextBoxColumn.Name = "ingredientIdDataGridViewTextBoxColumn";
            ingredientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.HeaderText = "ingredientName";
            ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerNameDataGridViewTextBoxColumn
            // 
            manufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "manufacturerName";
            manufacturerNameDataGridViewTextBoxColumn.HeaderText = "manufacturerName";
            manufacturerNameDataGridViewTextBoxColumn.Name = "manufacturerNameDataGridViewTextBoxColumn";
            manufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataMember = "Ingredient";
            ingredientBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(921, 293);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 12;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(832, 293);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 13;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new Point(742, 293);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 14;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(652, 293);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 15;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(76, 293);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 11;
            tbSearch.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(600, 141);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 141);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(708, 138);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(314, 42);
            tbName.TabIndex = 16;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(110, 138);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(333, 42);
            tbId.TabIndex = 17;
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(876, 207);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(146, 40);
            cbDeleted.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(768, 208);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 20;
            label5.Text = "Deleted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 208);
            label3.Name = "label3";
            label3.Size = new Size(241, 32);
            label3.TabIndex = 23;
            label3.Text = "Manufacturer name";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(292, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 42);
            textBox1.TabIndex = 22;
            // 
            // ShopIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
    }
}