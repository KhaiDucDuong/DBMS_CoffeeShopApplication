namespace FinalProject_WinForm.Forms.CoffeeShop
{
    partial class ShopProducts
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
            ucMenu1 = new UCMenu();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(1, -8);
            ucMenu1.Margin = new Padding(3, 2, 3, 2);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1050, 61);
            ucMenu1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(418, 112);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(541, 427);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // ShopProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ucMenu1);
            Name = "ShopProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopProducts";
            ResumeLayout(false);
        }

        #endregion

        private UCMenu ucMenu1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}