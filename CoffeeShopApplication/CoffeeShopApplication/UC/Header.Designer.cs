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
            pbAppIcon.Image = Properties.Resources.coffeeshopicon;
            pbAppIcon.Location = new Point(3, 10);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(146, 144);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 0;
            pbAppIcon.TabStop = false;
            // 
            // pbInventory
            // 
            pbInventory.BackColor = Color.Transparent;
            pbInventory.Image = (Image)resources.GetObject("pbInventory.Image");
            pbInventory.Location = new Point(1040, 10);
            pbInventory.Name = "pbInventory";
            pbInventory.Size = new Size(144, 144);
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
            pbRestockOrder.Image = (Image)resources.GetObject("pbRestockOrder.Image");
            pbRestockOrder.Location = new Point(890, 10);
            pbRestockOrder.Name = "pbRestockOrder";
            pbRestockOrder.Size = new Size(144, 144);
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
            pbOrder.Image = (Image)resources.GetObject("pbOrder.Image");
            pbOrder.Location = new Point(740, 10);
            pbOrder.Name = "pbOrder";
            pbOrder.Size = new Size(144, 144);
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
            pbEmployee.Image = (Image)resources.GetObject("pbEmployee.Image");
            pbEmployee.Location = new Point(590, 10);
            pbEmployee.Name = "pbEmployee";
            pbEmployee.Size = new Size(144, 144);
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
            pbProduct.Image = (Image)resources.GetObject("pbProduct.Image");
            pbProduct.Location = new Point(440, 10);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(144, 144);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.Click += pbProduct_Click;
            pbProduct.MouseLeave += pbProduct_MouseLeave;
            pbProduct.MouseHover += pbProduct_MouseHover;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(pbProduct);
            Controls.Add(pbEmployee);
            Controls.Add(pbOrder);
            Controls.Add(pbRestockOrder);
            Controls.Add(pbInventory);
            Controls.Add(pbAppIcon);
            ForeColor = SystemColors.Highlight;
            Name = "Header";
            Size = new Size(1200, 163);
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
