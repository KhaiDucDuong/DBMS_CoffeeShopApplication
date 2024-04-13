namespace CoffeeShopApplication
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            header1 = new UC.Header();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = SystemColors.MenuHighlight;
            header1.ForeColor = SystemColors.Highlight;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1202, 163);
            header1.TabIndex = 10;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 867);
            Controls.Add(header1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Menu";
            ResumeLayout(false);
        }

        #endregion

        private UC.Header header1;
    }
}
