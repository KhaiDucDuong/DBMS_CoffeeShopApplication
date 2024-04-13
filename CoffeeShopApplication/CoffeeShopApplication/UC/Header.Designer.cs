namespace CoffeeShopApplication.UC
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            pbAppIcon = new PictureBox();
            pbInventory = new PictureBox();
            pbRestockOrder = new PictureBox();
            pbOrder = new PictureBox();
            pbEmployee = new PictureBox();
            pbProduct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRestockOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // pbAppIcon
            // 
            pbAppIcon.Cursor = Cursors.Hand;
            pbAppIcon.Image = Properties.Resources.coffeeshopicon;
            pbAppIcon.Location = new Point(3, 8);
            pbAppIcon.Margin = new Padding(3, 2, 3, 2);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(128, 108);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 0;
            pbAppIcon.TabStop = false;
            pbAppIcon.Click += pbAppIcon_Click;
            // 
            // pbInventory
            // 
            pbInventory.BackColor = Color.Transparent;
            pbInventory.Cursor = Cursors.Hand;
            pbInventory.Image = (Image)resources.GetObject("pbInventory.Image");
            pbInventory.Location = new Point(910, 8);
            pbInventory.Margin = new Padding(3, 2, 3, 2);
            pbInventory.Name = "pbInventory";
            pbInventory.Size = new Size(126, 108);
            pbInventory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInventory.TabIndex = 0;
            pbInventory.TabStop = false;
            pbInventory.Click += pbInventory_Click;
            pbInventory.MouseLeave += pbInventory_MouseLeave;
            pbInventory.MouseHover += pbInventory_MouseHover;
            // 
            // pbRestockOrder
            // 
            pbRestockOrder.BackColor = Color.Transparent;
            pbRestockOrder.Cursor = Cursors.Hand;
            pbRestockOrder.Image = (Image)resources.GetObject("pbRestockOrder.Image");
            pbRestockOrder.Location = new Point(779, 8);
            pbRestockOrder.Margin = new Padding(3, 2, 3, 2);
            pbRestockOrder.Name = "pbRestockOrder";
            pbRestockOrder.Size = new Size(126, 108);
            pbRestockOrder.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRestockOrder.TabIndex = 0;
            pbRestockOrder.TabStop = false;
            pbRestockOrder.Click += pbRestockOrder_Click;
            pbRestockOrder.MouseLeave += pbRestockOrder_MouseLeave;
            pbRestockOrder.MouseHover += pbRestockOrder_MouseHover;
            // 
            // pbOrder
            // 
            pbOrder.BackColor = Color.Transparent;
            pbOrder.Cursor = Cursors.Hand;
            pbOrder.Image = (Image)resources.GetObject("pbOrder.Image");
            pbOrder.Location = new Point(648, 8);
            pbOrder.Margin = new Padding(3, 2, 3, 2);
            pbOrder.Name = "pbOrder";
            pbOrder.Size = new Size(126, 108);
            pbOrder.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrder.TabIndex = 0;
            pbOrder.TabStop = false;
            pbOrder.Click += pbOrder_Click;
            pbOrder.MouseLeave += pbOrder_MouseLeave;
            pbOrder.MouseHover += pbOrder_MouseHover;
            // 
            // pbEmployee
            // 
            pbEmployee.BackColor = Color.Transparent;
            pbEmployee.Cursor = Cursors.Hand;
            pbEmployee.Image = (Image)resources.GetObject("pbEmployee.Image");
            pbEmployee.Location = new Point(516, 8);
            pbEmployee.Margin = new Padding(3, 2, 3, 2);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(126, 108);
            pbEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployee.TabIndex = 0;
            pbEmployee.TabStop = false;
            pbEmployee.Click += pbEmployee_Click;
            pbEmployee.MouseLeave += pbEmployee_MouseLeave;
            pbEmployee.MouseHover += pbEmployee_MouseHover;
            // 
            // pbProduct
            // 
            pbProduct.BackColor = Color.Transparent;
            pbProduct.Cursor = Cursors.Hand;
            pbProduct.Image = (Image)resources.GetObject("pbProduct.Image");
            pbProduct.Location = new Point(385, 8);
            pbProduct.Margin = new Padding(3, 2, 3, 2);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(126, 108);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.Click += pbProduct_Click;
            pbProduct.MouseLeave += pbProduct_MouseLeave;
            pbProduct.MouseHover += pbProduct_MouseHover;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(pbProduct);
            Controls.Add(pbEmployee);
            Controls.Add(pbOrder);
            Controls.Add(pbRestockOrder);
            Controls.Add(pbInventory);
            Controls.Add(pbAppIcon);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Header";
            Size = new Size(1050, 122);
            Load += Header_Load;
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRestockOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbAppIcon;
        private PictureBox pbInventory;
        private PictureBox pbRestockOrder;
        private PictureBox pbOrder;
        private PictureBox pbEmployee;
        private PictureBox pbProduct;
    }
}
