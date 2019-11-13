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
            this.cmbCateGory = new System.Windows.Forms.ComboBox();
            this.labelRefresh = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSelectedItems = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.lvDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmbCateGory
            // 
            this.cmbCateGory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCateGory.FormattingEnabled = true;
            this.cmbCateGory.Location = new System.Drawing.Point(18, 23);
            this.cmbCateGory.Name = "cmbCateGory";
            this.cmbCateGory.Size = new System.Drawing.Size(258, 30);
            this.cmbCateGory.TabIndex = 1;
            this.cmbCateGory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCatetory_SelectedIndexChanged);
            // 
            // labelRefresh
            // 
            this.labelRefresh.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelRefresh.Location = new System.Drawing.Point(604, 471);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(94, 31);
            this.labelRefresh.TabIndex = 7;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.UseVisualStyleBackColor = true;
            this.labelRefresh.Click += new System.EventHandler(this.labelRefresh_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBill.Location = new System.Drawing.Point(713, 471);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(94, 31);
            this.btnBill.TabIndex = 9;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(661, 433);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(146, 31);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotal.Location = new System.Drawing.Point(571, 441);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 23);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // labelSelectedItems
            // 
            this.labelSelectedItems.AutoSize = true;
            this.labelSelectedItems.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSelectedItems.Location = new System.Drawing.Point(456, 64);
            this.labelSelectedItems.Name = "labelSelectedItems";
            this.labelSelectedItems.Size = new System.Drawing.Size(142, 23);
            this.labelSelectedItems.TabIndex = 5;
            this.labelSelectedItems.Text = "Selected Items";
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuLabel.Location = new System.Drawing.Point(18, 64);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(411, 31);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            // 
            // lvDetails
            // 
            this.lvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvDetails.FullRowSelect = true;
            this.lvDetails.GridLines = true;
            this.lvDetails.HideSelection = false;
            this.lvDetails.Location = new System.Drawing.Point(460, 90);
            this.lvDetails.Name = "lvDetails";
            this.lvDetails.Size = new System.Drawing.Size(347, 336);
            this.lvDetails.TabIndex = 8;
            this.lvDetails.UseCompatibleStateImageBehavior = false;
            this.lvDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sum";
            // 
            // flProduct
            // 
            this.flProduct.Location = new System.Drawing.Point(18, 109);
            this.flProduct.Name = "flProduct";
            this.flProduct.Size = new System.Drawing.Size(420, 328);
            this.flProduct.TabIndex = 13;
            // 
            // UCOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flProduct);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.labelRefresh);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lvDetails);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.labelSelectedItems);
            this.Controls.Add(this.cmbCateGory);
            this.Name = "UCOrderManager";
            this.Size = new System.Drawing.Size(828, 510);
            this.Load += new System.EventHandler(this.UCOrderManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCateGory;
        private System.Windows.Forms.Button labelRefresh;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSelectedItems;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ListView lvDetails;
        private System.Windows.Forms.FlowLayoutPanel flProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
