namespace CoffeeShopApplication.Interfaces
{
    partial class ShopInventoryCheckDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopInventoryCheckDetailsForm));
            cbIngredient = new ComboBox();
            label4 = new Label();
            tbQuantity = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbCheckId = new TextBox();
            pbDelete = new PictureBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            dgvInventoryCheckDetails = new DataGridView();
            checkIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getInventoryCheckDetailsViewBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryCheckDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getInventoryCheckDetailsViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbIngredient
            // 
            cbIngredient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIngredient.FormattingEnabled = true;
            cbIngredient.IntegralHeight = false;
            cbIngredient.ItemHeight = 41;
            cbIngredient.Location = new Point(842, 53);
            cbIngredient.Margin = new Padding(4);
            cbIngredient.MinimumSize = new Size(427, 0);
            cbIngredient.Name = "cbIngredient";
            cbIngredient.Size = new Size(427, 49);
            cbIngredient.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 41);
            label4.TabIndex = 51;
            label4.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(225, 152);
            tbQuantity.Margin = new Padding(4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(441, 45);
            tbQuantity.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(667, 61);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 41);
            label3.TabIndex = 50;
            label3.Text = "Ingredient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 49;
            label1.Text = "Check ID";
            // 
            // tbCheckId
            // 
            tbCheckId.Enabled = false;
            tbCheckId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCheckId.Location = new Point(225, 53);
            tbCheckId.Margin = new Padding(4);
            tbCheckId.Multiline = true;
            tbCheckId.Name = "tbCheckId";
            tbCheckId.Size = new Size(427, 49);
            tbCheckId.TabIndex = 45;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1081, 155);
            pbDelete.Margin = new Padding(4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(71, 77);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 57;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1193, 155);
            pbRefresh.Margin = new Padding(4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(71, 77);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 53;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(971, 155);
            pbSave.Margin = new Padding(4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(71, 77);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 54;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(850, 155);
            pbAdd.Margin = new Padding(4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(71, 77);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 55;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // dgvInventoryCheckDetails
            // 
            dgvInventoryCheckDetails.AllowUserToAddRows = false;
            dgvInventoryCheckDetails.AllowUserToDeleteRows = false;
            dgvInventoryCheckDetails.AutoGenerateColumns = false;
            dgvInventoryCheckDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventoryCheckDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryCheckDetails.Columns.AddRange(new DataGridViewColumn[] { checkIdDataGridViewTextBoxColumn, ingredientNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dgvInventoryCheckDetails.DataSource = getInventoryCheckDetailsViewBindingSource;
            dgvInventoryCheckDetails.Location = new Point(11, 251);
            dgvInventoryCheckDetails.Margin = new Padding(4);
            dgvInventoryCheckDetails.MultiSelect = false;
            dgvInventoryCheckDetails.Name = "dgvInventoryCheckDetails";
            dgvInventoryCheckDetails.ReadOnly = true;
            dgvInventoryCheckDetails.RowHeadersWidth = 51;
            dgvInventoryCheckDetails.Size = new Size(1342, 479);
            dgvInventoryCheckDetails.TabIndex = 58;
            dgvInventoryCheckDetails.CellContentClick += dgvInventoryCheckDetails_CellContentClick;
            // 
            // checkIdDataGridViewTextBoxColumn
            // 
            checkIdDataGridViewTextBoxColumn.DataPropertyName = "checkId";
            checkIdDataGridViewTextBoxColumn.HeaderText = "checkId";
            checkIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkIdDataGridViewTextBoxColumn.Name = "checkIdDataGridViewTextBoxColumn";
            checkIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // getInventoryCheckDetailsViewBindingSource
            // 
            getInventoryCheckDetailsViewBindingSource.DataMember = "GetInventoryCheckDetailsView";
            getInventoryCheckDetailsViewBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // ShopInventoryCheckDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 743);
            Controls.Add(dgvInventoryCheckDetails);
            Controls.Add(pbDelete);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(cbIngredient);
            Controls.Add(label4);
            Controls.Add(tbQuantity);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbCheckId);
            Name = "ShopInventoryCheckDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopInventoryCheckDetailsForm";
            Load += ShopInventoryCheckDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryCheckDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)getInventoryCheckDetailsViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbIngredient;
        private Label label4;
        private TextBox tbQuantity;
        private Label label3;
        private Label label1;
        private TextBox tbCheckId;
        private PictureBox pbDelete;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private DataGridView dgvInventoryCheckDetails;
        private DataGridViewTextBoxColumn ingredientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource getInventoryCheckDetailsViewBindingSource;
    }
}