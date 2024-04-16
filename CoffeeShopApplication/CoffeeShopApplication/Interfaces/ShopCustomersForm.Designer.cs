namespace CoffeeShopApplication.Interfaces
{
    partial class ShopCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopCustomersForm));
            header1 = new UC.Header();
            dgvCustomers = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            customerBindingSource = new BindingSource(components);
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
            tbPhoneNumber = new TextBox();
            pbDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
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
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvCustomers.DataSource = customerBindingSource;
            dgvCustomers.Location = new Point(15, 529);
            dgvCustomers.Margin = new Padding(4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1319, 496);
            dgvCustomers.TabIndex = 10;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // customerBindingSource
            // 
            customerBindingSource.DataMember = "customer";
            customerBindingSource.DataSource = typeof(CoffeeShopDataset);
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
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
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
            label2.Location = new Point(755, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 41);
            label2.TabIndex = 18;
            label2.Text = "Fullname";
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
            tbId.Location = new Point(151, 193);
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
            label3.Size = new Size(224, 41);
            label3.TabIndex = 23;
            label3.Text = "Phone number";
            label3.Click += label3_Click;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(322, 282);
            tbPhoneNumber.Margin = new Padding(4);
            tbPhoneNumber.Multiline = true;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(427, 57);
            tbPhoneNumber.TabIndex = 3;
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
            // ShopCustomersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 1042);
            ControlBox = false;
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbPhoneNumber);
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
            Controls.Add(dgvCustomers);
            Controls.Add(header1);
            Margin = new Padding(4);
            Name = "ShopCustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Customers";
            Load += ShopCustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource customerBindingSource;
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
        private TextBox tbPhoneNumber;
        private PictureBox pbDelete;
    }
}