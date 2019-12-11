namespace CafeteriaManagement
{
    partial class FormMenu
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
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.flowLayoutPanelMenu);
            this.groupBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(440, 297);
            this.groupBoxProducts.TabIndex = 0;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Menu";
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(428, 272);
            this.flowLayoutPanelMenu.TabIndex = 0;
            this.flowLayoutPanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMenu_Paint);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.groupBoxProducts);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBoxProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
    }
}