namespace CoffeeShopApplication
{
    partial class ShopOrderBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopOrderBillForm));
            tbEmployeeId = new TextBox();
            label4 = new Label();
            header1 = new UC.Header();
            tbFinalBill = new TextBox();
            pbDelete = new PictureBox();
            label3 = new Label();
            tbInitialBill = new TextBox();
            label1 = new Label();
            tbBillId = new TextBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            dgvOrderBill = new DataGridView();
            billIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rewardPointsUsedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            initialBillDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalBillDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBillBindingSource = new BindingSource(components);
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbRewardPointUsed = new TextBox();
            cbDeleted = new ComboBox();
            label7 = new Label();
            pbRefreshOrderBill = new PictureBox();
            dgvCustomer = new DataGridView();
            customerIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rewardPointDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            customerBindingSource = new BindingSource(components);
            employeeBindingSource = new BindingSource(components);
            coffeeShopDatasetBindingSource = new BindingSource(components);
            tbCustomerId = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefreshOrderBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tbEmployeeId
            // 
            tbEmployeeId.Enabled = false;
            tbEmployeeId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmployeeId.Location = new Point(555, 476);
            tbEmployeeId.Margin = new Padding(4);
            tbEmployeeId.Multiline = true;
            tbEmployeeId.Name = "tbEmployeeId";
            tbEmployeeId.Size = new Size(209, 54);
            tbEmployeeId.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 319);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 41);
            label4.TabIndex = 64;
            label4.Text = "Final Bill";
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -3);
            header1.Margin = new Padding(4, 3, 4, 3);
            header1.Name = "header1";
            header1.Size = new Size(1200, 151);
            header1.TabIndex = 9;
            // 
            // tbFinalBill
            // 
            tbFinalBill.Enabled = false;
            tbFinalBill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFinalBill.Location = new Point(186, 316);
            tbFinalBill.Margin = new Padding(4);
            tbFinalBill.Multiline = true;
            tbFinalBill.Name = "tbFinalBill";
            tbFinalBill.Size = new Size(175, 54);
            tbFinalBill.TabIndex = 63;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1106, 775);
            pbDelete.Margin = new Padding(4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(63, 73);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 62;
            pbDelete.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 247);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 61;
            label3.Text = "Initial Bill";
            // 
            // tbInitialBill
            // 
            tbInitialBill.Enabled = false;
            tbInitialBill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbInitialBill.Location = new Point(186, 244);
            tbInitialBill.Margin = new Padding(4);
            tbInitialBill.Multiline = true;
            tbInitialBill.Name = "tbInitialBill";
            tbInitialBill.Size = new Size(175, 54);
            tbInitialBill.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 186);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 41);
            label1.TabIndex = 59;
            label1.Text = "Bill Id";
            // 
            // tbBillId
            // 
            tbBillId.Enabled = false;
            tbBillId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBillId.Location = new Point(186, 182);
            tbBillId.Margin = new Padding(4);
            tbBillId.Multiline = true;
            tbBillId.Name = "tbBillId";
            tbBillId.Size = new Size(175, 54);
            tbBillId.TabIndex = 48;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1106, 171);
            pbRefresh.Margin = new Padding(4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(63, 65);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 54;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(1106, 666);
            pbSave.Margin = new Padding(4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(63, 73);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 55;
            pbSave.TabStop = false;
            pbSave.Click += pbSave_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(1106, 901);
            pbAdd.Margin = new Padding(4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(63, 73);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 56;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(1034, 171);
            pbSearch.Margin = new Padding(4);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(63, 65);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 57;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(555, 171);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(471, 65);
            tbSearch.TabIndex = 52;
            // 
            // dgvOrderBill
            // 
            dgvOrderBill.AllowUserToAddRows = false;
            dgvOrderBill.AllowUserToDeleteRows = false;
            dgvOrderBill.AutoGenerateColumns = false;
            dgvOrderBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderBill.Columns.AddRange(new DataGridViewColumn[] { billIdDataGridViewTextBoxColumn, rewardPointsUsedDataGridViewTextBoxColumn, initialBillDataGridViewTextBoxColumn, finalBillDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, employeeIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn });
            dgvOrderBill.DataSource = orderBillBindingSource;
            dgvOrderBill.Location = new Point(13, 562);
            dgvOrderBill.Margin = new Padding(4);
            dgvOrderBill.MultiSelect = false;
            dgvOrderBill.Name = "dgvOrderBill";
            dgvOrderBill.ReadOnly = true;
            dgvOrderBill.RowHeadersWidth = 51;
            dgvOrderBill.Size = new Size(1051, 412);
            dgvOrderBill.TabIndex = 53;
            dgvOrderBill.CellClick += dgvOrderBill_CellContentClick;
            dgvOrderBill.CellContentDoubleClick += dgvOrderBill_CellContentDoubleClick;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            billIdDataGridViewTextBoxColumn.DataPropertyName = "billId";
            billIdDataGridViewTextBoxColumn.HeaderText = "billId";
            billIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rewardPointsUsedDataGridViewTextBoxColumn
            // 
            rewardPointsUsedDataGridViewTextBoxColumn.DataPropertyName = "rewardPointsUsed";
            rewardPointsUsedDataGridViewTextBoxColumn.HeaderText = "rewardPointsUsed";
            rewardPointsUsedDataGridViewTextBoxColumn.MinimumWidth = 6;
            rewardPointsUsedDataGridViewTextBoxColumn.Name = "rewardPointsUsedDataGridViewTextBoxColumn";
            rewardPointsUsedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialBillDataGridViewTextBoxColumn
            // 
            initialBillDataGridViewTextBoxColumn.DataPropertyName = "initialBill";
            initialBillDataGridViewTextBoxColumn.HeaderText = "initialBill";
            initialBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            initialBillDataGridViewTextBoxColumn.Name = "initialBillDataGridViewTextBoxColumn";
            initialBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalBillDataGridViewTextBoxColumn
            // 
            finalBillDataGridViewTextBoxColumn.DataPropertyName = "finalBill";
            finalBillDataGridViewTextBoxColumn.HeaderText = "finalBill";
            finalBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            finalBillDataGridViewTextBoxColumn.Name = "finalBillDataGridViewTextBoxColumn";
            finalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "employeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBillBindingSource
            // 
            orderBillBindingSource.DataMember = "OrderBill";
            orderBillBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(401, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 64);
            label2.TabIndex = 58;
            label2.Text = "Customer \r\nName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 480);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 41);
            label6.TabIndex = 66;
            label6.Text = "Employee Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(28, 393);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 64);
            label5.TabIndex = 68;
            label5.Text = "Reward \r\nPoint Used";
            // 
            // tbRewardPointUsed
            // 
            tbRewardPointUsed.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRewardPointUsed.Location = new Point(186, 393);
            tbRewardPointUsed.Margin = new Padding(4);
            tbRewardPointUsed.Multiline = true;
            tbRewardPointUsed.Name = "tbRewardPointUsed";
            tbRewardPointUsed.Size = new Size(175, 54);
            tbRewardPointUsed.TabIndex = 67;
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(186, 476);
            cbDeleted.Margin = new Padding(4);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(167, 49);
            cbDeleted.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 479);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 41);
            label7.TabIndex = 70;
            label7.Text = "Deleted";
            // 
            // pbRefreshOrderBill
            // 
            pbRefreshOrderBill.Image = (Image)resources.GetObject("pbRefreshOrderBill.Image");
            pbRefreshOrderBill.Location = new Point(1106, 562);
            pbRefreshOrderBill.Margin = new Padding(4);
            pbRefreshOrderBill.Name = "pbRefreshOrderBill";
            pbRefreshOrderBill.Size = new Size(63, 73);
            pbRefreshOrderBill.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefreshOrderBill.TabIndex = 72;
            pbRefreshOrderBill.TabStop = false;
            pbRefreshOrderBill.Click += pbRefreshOrderBill_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn1, customerNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, rewardPointDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn1, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn1 });
            dgvCustomer.DataSource = customerBindingSource;
            dgvCustomer.Location = new Point(401, 247);
            dgvCustomer.Margin = new Padding(5, 4, 5, 4);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(768, 177);
            dgvCustomer.TabIndex = 96;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // customerIdDataGridViewTextBoxColumn1
            // 
            customerIdDataGridViewTextBoxColumn1.DataPropertyName = "customerId";
            customerIdDataGridViewTextBoxColumn1.HeaderText = "customerId";
            customerIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
            customerIdDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // rewardPointDataGridViewTextBoxColumn
            // 
            rewardPointDataGridViewTextBoxColumn.DataPropertyName = "rewardPoint";
            rewardPointDataGridViewTextBoxColumn.HeaderText = "rewardPoint";
            rewardPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            rewardPointDataGridViewTextBoxColumn.Name = "rewardPointDataGridViewTextBoxColumn";
            rewardPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn1
            // 
            createdAtDataGridViewTextBoxColumn1.DataPropertyName = "createdAt";
            createdAtDataGridViewTextBoxColumn1.HeaderText = "createdAt";
            createdAtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            createdAtDataGridViewTextBoxColumn1.Name = "createdAtDataGridViewTextBoxColumn1";
            createdAtDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "updatedAt";
            updatedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn1
            // 
            isDeletedDataGridViewCheckBoxColumn1.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn1.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            isDeletedDataGridViewCheckBoxColumn1.Name = "isDeletedDataGridViewCheckBoxColumn1";
            isDeletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataMember = "Customer";
            customerBindingSource.DataSource = typeof(CoffeeShopDataset);
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
            // tbCustomerId
            // 
            tbCustomerId.Enabled = false;
            tbCustomerId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCustomerId.Location = new Point(960, 477);
            tbCustomerId.Margin = new Padding(4);
            tbCustomerId.Multiline = true;
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(209, 54);
            tbCustomerId.TabIndex = 97;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(769, 481);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(190, 41);
            label8.TabIndex = 98;
            label8.Text = "Customer Id";
            // 
            // ShopOrderBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 992);
            Controls.Add(tbCustomerId);
            Controls.Add(label8);
            Controls.Add(dgvCustomer);
            Controls.Add(pbRefreshOrderBill);
            Controls.Add(cbDeleted);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(tbRewardPointUsed);
            Controls.Add(tbEmployeeId);
            Controls.Add(label4);
            Controls.Add(tbFinalBill);
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbInitialBill);
            Controls.Add(label1);
            Controls.Add(tbBillId);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(header1);
            Controls.Add(tbSearch);
            Controls.Add(dgvOrderBill);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "ShopOrderBillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop OrderBill";
            Load += ShopOrderBillForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefreshOrderBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeShopDatasetBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private TextBox tbEmployeeId;
        private Label label4;
        private TextBox tbFinalBill;
        private PictureBox pbDelete;
        private Label label3;
        private TextBox tbInitialBill;
        private Label label1;
        private TextBox tbBillId;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private DataGridView dgvOrderBill;
        private Label label2;
        private Label label6;
        private DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rewardPointsUsedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn initialBillDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalBillDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private BindingSource orderBillBindingSource;
        private Label label5;
        private TextBox tbRewardPointUsed;
        private ComboBox cbDeleted;
        private Label label7;
        private PictureBox pbRefreshOrderBill;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rewardPointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn1;
        private BindingSource customerBindingSource;
        private BindingSource employeeBindingSource;
        private BindingSource coffeeShopDatasetBindingSource;
        private TextBox tbCustomerId;
        private Label label8;
    }
}