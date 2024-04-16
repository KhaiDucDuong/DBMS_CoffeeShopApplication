namespace CoffeeShopApplication.Interfaces
{
    partial class ShopEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopEmployeesForm));
            header1 = new UC.Header();
            pbDelete = new PictureBox();
            label3 = new Label();
            tbPhoneNumber = new TextBox();
            cbDeleted = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbName = new TextBox();
            tbId = new TextBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            dgvEmployee = new DataGridView();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isWorkingDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            joinedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeBindingSource = new BindingSource(components);
            coffeeShopDatasetBindingSource = new BindingSource(components);
            tbEmail = new TextBox();
            label4 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -2);
            header1.Margin = new Padding(3, 2, 3, 2);
            header1.Name = "header1";
            header1.Size = new Size(1050, 114);
            header1.TabIndex = 9;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(876, 295);
            pbDelete.Margin = new Padding(4, 3, 4, 3);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(55, 55);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 39;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 38;
            label3.Text = "Phone number";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(228, 187);
            tbPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            tbPhoneNumber.Multiline = true;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(333, 42);
            tbPhoneNumber.TabIndex = 27;
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(876, 237);
            cbDeleted.Margin = new Padding(4, 3, 4, 3);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(147, 40);
            cbDeleted.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(748, 239);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 37;
            label5.Text = "Deleted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(587, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 35;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 36;
            label1.Text = "ID";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(708, 140);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(315, 42);
            tbName.TabIndex = 26;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(117, 140);
            tbId.Margin = new Padding(4, 3, 4, 3);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(333, 42);
            tbId.TabIndex = 25;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(967, 295);
            pbRefresh.Margin = new Padding(4, 3, 4, 3);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 31;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(778, 295);
            pbSave.Margin = new Padding(4, 3, 4, 3);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(55, 55);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 32;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(683, 295);
            pbAdd.Margin = new Padding(4, 3, 4, 3);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(55, 55);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 33;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(588, 295);
            pbSearch.Margin = new Padding(4, 3, 4, 3);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(55, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 34;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(11, 295);
            tbSearch.Margin = new Padding(4, 2, 4, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(549, 53);
            tbSearch.TabIndex = 29;
            tbSearch.Text = "Search";
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { employeeIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, isWorkingDataGridViewCheckBoxColumn, joinedAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvEmployee.DataSource = employeeBindingSource;
            dgvEmployee.Location = new Point(11, 380);
            dgvEmployee.Margin = new Padding(4, 3, 4, 3);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1026, 354);
            dgvEmployee.TabIndex = 30;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "employeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            addressDataGridViewTextBoxColumn.HeaderText = "address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            emailDataGridViewTextBoxColumn.HeaderText = "email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isWorkingDataGridViewCheckBoxColumn
            // 
            isWorkingDataGridViewCheckBoxColumn.DataPropertyName = "isWorking";
            isWorkingDataGridViewCheckBoxColumn.HeaderText = "isWorking";
            isWorkingDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isWorkingDataGridViewCheckBoxColumn.Name = "isWorkingDataGridViewCheckBoxColumn";
            isWorkingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // joinedAtDataGridViewTextBoxColumn
            // 
            joinedAtDataGridViewTextBoxColumn.DataPropertyName = "joinedAt";
            joinedAtDataGridViewTextBoxColumn.HeaderText = "joinedAt";
            joinedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            joinedAtDataGridViewTextBoxColumn.Name = "joinedAtDataGridViewTextBoxColumn";
            joinedAtDataGridViewTextBoxColumn.ReadOnly = true;
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
            // employeeBindingSource
            // 
            employeeBindingSource.DataMember = "Employee";
            employeeBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // coffeeShopDatasetBindingSource
            // 
            coffeeShopDatasetBindingSource.DataSource = typeof(CoffeeShopDataset);
            coffeeShopDatasetBindingSource.Position = 0;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(228, 237);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(333, 42);
            tbEmail.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 243);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 41;
            label4.Text = "Email";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(708, 187);
            tbAddress.Margin = new Padding(4, 3, 4, 3);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(315, 42);
            tbAddress.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(587, 189);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 43;
            label6.Text = "Address";
            // 
            // ShopEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            Controls.Add(header1);
            Controls.Add(tbAddress);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbPhoneNumber);
            Controls.Add(cbDeleted);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvEmployee);
            Controls.Add(label2);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopEmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Employees";
            Load += ShopEmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private PictureBox pbDelete;
        private Label label3;
        private TextBox tbPhoneNumber;
        private ComboBox cbDeleted;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private TextBox tbId;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isWorkingDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn joinedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource employeeBindingSource;
        private BindingSource coffeeShopDatasetBindingSource;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbAddress;
        private Label label6;
    }
}