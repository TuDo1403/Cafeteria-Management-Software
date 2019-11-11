namespace CoffeManagement
{
    partial class UCOrderManager
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbCateGory = new System.Windows.Forms.ComboBox();
            this.textBoxSearchMenu = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lstbSelectedItems = new System.Windows.Forms.ListBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.labelRefresh = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.panelBill = new System.Windows.Forms.Panel();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSelectedItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbCateGory);
            this.panel5.Controls.Add(this.textBoxSearchMenu);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 37);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmbCateGory
            // 
            this.cmbCateGory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCateGory.FormattingEnabled = true;
            this.cmbCateGory.Location = new System.Drawing.Point(7, 3);
            this.cmbCateGory.Name = "cmbCateGory";
            this.cmbCateGory.Size = new System.Drawing.Size(258, 30);
            this.cmbCateGory.TabIndex = 1;
            this.cmbCateGory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCatetory_SelectedIndexChanged);
            // 
            // textBoxSearchMenu
            // 
            this.textBoxSearchMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMenu.Location = new System.Drawing.Point(414, 3);
            this.textBoxSearchMenu.Name = "textBoxSearchMenu";
            this.textBoxSearchMenu.Size = new System.Drawing.Size(225, 29);
            this.textBoxSearchMenu.TabIndex = 4;
            this.textBoxSearchMenu.Enter += new System.EventHandler(this.textBoxSearchMenu_Enter);
            this.textBoxSearchMenu.Leave += new System.EventHandler(this.TextBoxSearchMenu_Leave);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.lstbSelectedItems);
            this.panelUser.Controls.Add(this.panelButton);
            this.panelUser.Controls.Add(this.panelBill);
            this.panelUser.Controls.Add(this.labelSelectedItems);
            this.panelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelUser.Location = new System.Drawing.Point(414, 46);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(408, 457);
            this.panelUser.TabIndex = 7;
            // 
            // lstbSelectedItems
            // 
            this.lstbSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstbSelectedItems.FormattingEnabled = true;
            this.lstbSelectedItems.ItemHeight = 25;
            this.lstbSelectedItems.Location = new System.Drawing.Point(6, 26);
            this.lstbSelectedItems.Name = "lstbSelectedItems";
            this.lstbSelectedItems.Size = new System.Drawing.Size(399, 354);
            this.lstbSelectedItems.TabIndex = 10;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.labelRefresh);
            this.panelButton.Controls.Add(this.buttonBill);
            this.panelButton.Location = new System.Drawing.Point(219, 419);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(186, 38);
            this.panelButton.TabIndex = 7;
            // 
            // labelRefresh
            // 
            this.labelRefresh.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelRefresh.Location = new System.Drawing.Point(3, 3);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(94, 31);
            this.labelRefresh.TabIndex = 7;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonBill
            // 
            this.buttonBill.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonBill.Location = new System.Drawing.Point(126, 3);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(56, 31);
            this.buttonBill.TabIndex = 9;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            // 
            // panelBill
            // 
            this.panelBill.Controls.Add(this.labelSum);
            this.panelBill.Controls.Add(this.labelTotal);
            this.panelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelBill.Location = new System.Drawing.Point(3, 379);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(402, 38);
            this.panelBill.TabIndex = 5;
            // 
            // labelSum
            // 
            this.labelSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(216, 7);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(146, 23);
            this.labelSum.TabIndex = 12;
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotal.Location = new System.Drawing.Point(101, 7);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 23);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // labelSelectedItems
            // 
            this.labelSelectedItems.AutoSize = true;
            this.labelSelectedItems.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSelectedItems.Location = new System.Drawing.Point(143, 0);
            this.labelSelectedItems.Name = "labelSelectedItems";
            this.labelSelectedItems.Size = new System.Drawing.Size(142, 23);
            this.labelSelectedItems.TabIndex = 5;
            this.labelSelectedItems.Text = "Selected Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstProduct);
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 457);
            this.panel1.TabIndex = 6;
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 25;
            this.lstProduct.Location = new System.Drawing.Point(3, 34);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(402, 429);
            this.lstProduct.TabIndex = 6;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuLabel.Location = new System.Drawing.Point(6, 3);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(399, 31);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panel1);
            this.Name = "UCOrderManager";
            this.Size = new System.Drawing.Size(828, 510);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbCateGory;
        private System.Windows.Forms.TextBox textBoxSearchMenu;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button labelRefresh;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSelectedItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ListBox lstbSelectedItems;
        private System.Windows.Forms.ListBox lstProduct;
    }
}
