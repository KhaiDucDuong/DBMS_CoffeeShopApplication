namespace CoffeeShopApplication.Interfaces
{
    partial class ShopInventoryCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopInventoryCheckForm));
            header1 = new UC.Header();
            dtpCheckDate = new DateTimePicker();
            lbDate = new Label();
            label1 = new Label();
            tbCheckId = new TextBox();
            cbInventory = new ComboBox();
            label3 = new Label();
            cbEmployee = new ComboBox();
            label2 = new Label();
            btnViewDetails = new Button();
            pbDelete = new PictureBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            dtpSearch = new DateTimePicker();
            dgvInventoryCheck = new DataGridView();
            checkIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getInventoryCheckViewBindingSource = new BindingSource(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getInventoryCheckViewBindingSource).BeginInit();
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
            // dtpCheckDate
            // 
            dtpCheckDate.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckDate.Location = new Point(835, 193);
            dtpCheckDate.MinimumSize = new Size(314, 42);
            dtpCheckDate.Name = "dtpCheckDate";
            dtpCheckDate.Size = new Size(412, 47);
            dtpCheckDate.TabIndex = 2;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(655, 193);
            lbDate.Margin = new Padding(4, 0, 4, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(84, 41);
            lbDate.TabIndex = 41;
            lbDate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 187);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 42;
            label1.Text = "Check ID";
            // 
            // tbCheckId
            // 
            tbCheckId.Enabled = false;
            tbCheckId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCheckId.Location = new Point(209, 179);
            tbCheckId.Margin = new Padding(4);
            tbCheckId.Multiline = true;
            tbCheckId.Name = "tbCheckId";
            tbCheckId.Size = new Size(427, 57);
            tbCheckId.TabIndex = 39;
            tbCheckId.Click += tbCheckId_Click;
            tbCheckId.TextChanged += tbCheckId_TextChanged;
            // 
            // cbInventory
            // 
            cbInventory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbInventory.FormattingEnabled = true;
            cbInventory.IntegralHeight = false;
            cbInventory.ItemHeight = 41;
            cbInventory.Location = new Point(209, 272);
            cbInventory.Margin = new Padding(4);
            cbInventory.MinimumSize = new Size(427, 0);
            cbInventory.Name = "cbInventory";
            cbInventory.Size = new Size(427, 49);
            cbInventory.TabIndex = 43;
            cbInventory.SelectedIndexChanged += cbInventory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 44;
            label3.Text = "Inventory";
            label3.Click += label3_Click;
            // 
            // cbEmployee
            // 
            cbEmployee.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.IntegralHeight = false;
            cbEmployee.ItemHeight = 41;
            cbEmployee.Location = new Point(835, 276);
            cbEmployee.Margin = new Padding(4);
            cbEmployee.MinimumSize = new Size(427, 0);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(427, 49);
            cbEmployee.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(655, 280);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 46;
            label2.Text = "Employee";
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(980, 361);
            btnViewDetails.Margin = new Padding(4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(246, 59);
            btnViewDetails.TabIndex = 47;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1089, 466);
            pbDelete.Margin = new Padding(4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(71, 77);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 52;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            pbDelete.MouseLeave += pbDelete_MouseLeave;
            pbDelete.MouseHover += pbDelete_MouseHover;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1219, 466);
            pbRefresh.Margin = new Padding(4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(71, 77);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 48;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            pbRefresh.MouseLeave += pbRefresh_MouseLeave;
            pbRefresh.MouseHover += pbRefresh_MouseHover;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(958, 466);
            pbSave.Margin = new Padding(4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(71, 77);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 49;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            pbSave.MouseLeave += pbSave_MouseLeave;
            pbSave.MouseHover += pbSave_MouseHover;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(835, 466);
            pbAdd.Margin = new Padding(4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(71, 77);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 50;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            pbAdd.MouseLeave += pbAdd_MouseLeave;
            pbAdd.MouseHover += pbAdd_MouseHover;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(700, 466);
            pbSearch.Margin = new Padding(4);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(71, 77);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 51;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            pbSearch.MouseHover += pbSearch_MouseHover;
            // 
            // dtpSearch
            // 
            dtpSearch.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSearch.Location = new Point(177, 479);
            dtpSearch.MinimumSize = new Size(314, 42);
            dtpSearch.Name = "dtpSearch";
            dtpSearch.Size = new Size(412, 47);
            dtpSearch.TabIndex = 2;
            // 
            // dgvInventoryCheck
            // 
            dgvInventoryCheck.AllowUserToAddRows = false;
            dgvInventoryCheck.AllowUserToDeleteRows = false;
            dgvInventoryCheck.AutoGenerateColumns = false;
            dgvInventoryCheck.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventoryCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryCheck.Columns.AddRange(new DataGridViewColumn[] { checkIdDataGridViewTextBoxColumn, checkDateDataGridViewTextBoxColumn, inventoryNameDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn });
            dgvInventoryCheck.DataSource = getInventoryCheckViewBindingSource;
            dgvInventoryCheck.Location = new Point(18, 565);
            dgvInventoryCheck.Margin = new Padding(4);
            dgvInventoryCheck.MultiSelect = false;
            dgvInventoryCheck.Name = "dgvInventoryCheck";
            dgvInventoryCheck.ReadOnly = true;
            dgvInventoryCheck.RowHeadersWidth = 51;
            dgvInventoryCheck.Size = new Size(1319, 496);
            dgvInventoryCheck.TabIndex = 54;
            dgvInventoryCheck.CellContentClick += dgvInventoryCheck_CellContentClick;
            // 
            // checkIdDataGridViewTextBoxColumn
            // 
            checkIdDataGridViewTextBoxColumn.DataPropertyName = "checkId";
            checkIdDataGridViewTextBoxColumn.HeaderText = "checkId";
            checkIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkIdDataGridViewTextBoxColumn.Name = "checkIdDataGridViewTextBoxColumn";
            checkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            checkDateDataGridViewTextBoxColumn.DataPropertyName = "check date";
            checkDateDataGridViewTextBoxColumn.HeaderText = "check date";
            checkDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            checkDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryNameDataGridViewTextBoxColumn
            // 
            inventoryNameDataGridViewTextBoxColumn.DataPropertyName = "inventory name";
            inventoryNameDataGridViewTextBoxColumn.HeaderText = "inventory name";
            inventoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            inventoryNameDataGridViewTextBoxColumn.Name = "inventoryNameDataGridViewTextBoxColumn";
            inventoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employee name";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "employee name";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getInventoryCheckViewBindingSource
            // 
            getInventoryCheckViewBindingSource.DataMember = "GetInventoryCheckView";
            getInventoryCheckViewBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 484);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 41);
            label4.TabIndex = 44;
            label4.Text = "Search";
            label4.Click += label3_Click;
            // 
            // ShopInventoryCheckForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 1042);
            Controls.Add(dgvInventoryCheck);
            Controls.Add(dtpSearch);
            Controls.Add(pbDelete);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(btnViewDetails);
            Controls.Add(cbEmployee);
            Controls.Add(label2);
            Controls.Add(cbInventory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpCheckDate);
            Controls.Add(lbDate);
            Controls.Add(label1);
            Controls.Add(tbCheckId);
            Controls.Add(header1);
            Name = "ShopInventoryCheckForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopInventoryCheckForm";
            Load += ShopInventoryCheckForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)getInventoryCheckViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private DateTimePicker dtpCheckDate;
        private Label lbDate;
        private Label label1;
        private TextBox tbCheckId;
        private ComboBox cbInventory;
        private Label label3;
        private ComboBox cbEmployee;
        private Label label2;
        private Button btnViewDetails;
        private PictureBox pbDelete;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private DateTimePicker dtpSearch;
        private DataGridView dgvInventoryCheck;
        private DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private BindingSource getInventoryCheckViewBindingSource;
        private Label label4;
    }
}