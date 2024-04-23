namespace CoffeeShopApplication
{
    partial class ShopAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopAccountForm));
            label4 = new Label();
            tbEmployeeId = new TextBox();
            header1 = new UC.Header();
            pbDelete = new PictureBox();
            label3 = new Label();
            tbAccountId = new TextBox();
            cbDeleted = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            pbRefresh = new PictureBox();
            pbSave = new PictureBox();
            pbAdd = new PictureBox();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            dgvAccount = new DataGridView();
            accountIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            accountBindingSource = new BindingSource(components);
            label2 = new Label();
            label6 = new Label();
            cbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 340);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 41);
            label4.TabIndex = 60;
            label4.Text = "Employee ID";
            // 
            // tbEmployeeId
            // 
            tbEmployeeId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmployeeId.Location = new Point(261, 332);
            tbEmployeeId.Margin = new Padding(4);
            tbEmployeeId.Multiline = true;
            tbEmployeeId.Name = "tbEmployeeId";
            tbEmployeeId.Size = new Size(461, 56);
            tbEmployeeId.TabIndex = 59;
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, -3);
            header1.Margin = new Padding(4, 3, 4, 3);
            header1.Name = "header1";
            header1.Size = new Size(1350, 159);
            header1.TabIndex = 9;
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1128, 413);
            pbDelete.Margin = new Padding(4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(71, 77);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 58;
            pbDelete.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 41);
            label3.TabIndex = 57;
            label3.Text = "Account ID";
            // 
            // tbAccountId
            // 
            tbAccountId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAccountId.Location = new Point(261, 261);
            tbAccountId.Margin = new Padding(4);
            tbAccountId.Multiline = true;
            tbAccountId.Name = "tbAccountId";
            tbAccountId.Size = new Size(461, 56);
            tbAccountId.TabIndex = 46;
            // 
            // cbDeleted
            // 
            cbDeleted.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDeleted.FormattingEnabled = true;
            cbDeleted.Items.AddRange(new object[] { "Yes", "No" });
            cbDeleted.Location = new Point(1128, 332);
            cbDeleted.Margin = new Padding(4);
            cbDeleted.Name = "cbDeleted";
            cbDeleted.Size = new Size(187, 49);
            cbDeleted.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(964, 335);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 41);
            label5.TabIndex = 56;
            label5.Text = "Deleted";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 201);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 55;
            label1.Text = "Password";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(912, 196);
            tbUserName.Margin = new Padding(4);
            tbUserName.Multiline = true;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(403, 56);
            tbUserName.TabIndex = 45;
            // 
            // tbPassword
            // 
            tbPassword.Enabled = false;
            tbPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(261, 196);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(461, 56);
            tbPassword.TabIndex = 44;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = (Image)resources.GetObject("pbRefresh.Image");
            pbRefresh.Location = new Point(1245, 413);
            pbRefresh.Margin = new Padding(4);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(71, 77);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 50;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbSave
            // 
            pbSave.Image = (Image)resources.GetObject("pbSave.Image");
            pbSave.Location = new Point(1002, 413);
            pbSave.Margin = new Padding(4);
            pbSave.Name = "pbSave";
            pbSave.Size = new Size(71, 77);
            pbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSave.TabIndex = 51;
            pbSave.TabStop = false;
            // 
            // pbAdd
            // 
            pbAdd.Image = (Image)resources.GetObject("pbAdd.Image");
            pbAdd.InitialImage = (Image)resources.GetObject("pbAdd.InitialImage");
            pbAdd.Location = new Point(881, 413);
            pbAdd.Margin = new Padding(4);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(71, 77);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 52;
            pbAdd.TabStop = false;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.search1;
            pbSearch.Location = new Point(758, 413);
            pbSearch.Margin = new Padding(4);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(71, 77);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 53;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSave_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            tbSearch.ForeColor = SystemColors.ScrollBar;
            tbSearch.Location = new Point(17, 413);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(705, 65);
            tbSearch.TabIndex = 48;
            tbSearch.Text = "Search";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { accountIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvAccount.DataSource = accountBindingSource;
            dgvAccount.Location = new Point(17, 532);
            dgvAccount.Margin = new Padding(4);
            dgvAccount.MultiSelect = false;
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(1318, 496);
            dgvAccount.TabIndex = 49;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            accountIdDataGridViewTextBoxColumn.DataPropertyName = "accountId";
            accountIdDataGridViewTextBoxColumn.HeaderText = "accountId";
            accountIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "employeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            usernameDataGridViewTextBoxColumn.HeaderText = "username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            roleDataGridViewTextBoxColumn.HeaderText = "role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
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
            // accountBindingSource
            // 
            accountBindingSource.DataMember = "Account";
            accountBindingSource.DataSource = typeof(CoffeeShopDataset);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(731, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 54;
            label2.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(757, 265);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 41);
            label6.TabIndex = 62;
            label6.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Yes", "No" });
            cbRole.Location = new Point(903, 265);
            cbRole.Margin = new Padding(4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(412, 49);
            cbRole.TabIndex = 63;
            // 
            // ShopAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 1042);
            Controls.Add(cbRole);
            Controls.Add(label4);
            Controls.Add(tbEmployeeId);
            Controls.Add(pbDelete);
            Controls.Add(label3);
            Controls.Add(tbAccountId);
            Controls.Add(cbDeleted);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(tbUserName);
            Controls.Add(tbPassword);
            Controls.Add(pbRefresh);
            Controls.Add(pbSave);
            Controls.Add(header1);
            Controls.Add(pbAdd);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvAccount);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "ShopAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopAccountForm";
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UC.Header header1;
        private Label label4;
        private TextBox tbEmployeeId;
        private PictureBox pbDelete;
        private Label label3;
        private TextBox tbAccountId;
        private ComboBox cbDeleted;
        private Label label5;
        private Label label1;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private PictureBox pbRefresh;
        private PictureBox pbSave;
        private PictureBox pbAdd;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private DataGridView dgvAccount;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource accountBindingSource;
        private Label label2;
        private Label label6;
        private ComboBox cbRole;
    }
}