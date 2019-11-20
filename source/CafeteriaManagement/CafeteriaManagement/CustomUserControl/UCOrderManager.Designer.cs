namespace CafeteriaManagement
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
            this.comboBoxCatetory = new System.Windows.Forms.ComboBox();
            this.textBoxSearchMenu = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.dataGridViewSelectedItems = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.labelRefresh = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.panelBill = new System.Windows.Forms.Panel();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSelectedItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuListView = new System.Windows.Forms.ListView();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBoxCatetory);
            this.panel5.Controls.Add(this.textBoxSearchMenu);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 37);
            this.panel5.TabIndex = 8;
            // 
            // comboBoxCatetory
            // 
            this.comboBoxCatetory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatetory.FormattingEnabled = true;
            this.comboBoxCatetory.Location = new System.Drawing.Point(411, 3);
            this.comboBoxCatetory.Name = "comboBoxCatetory";
            this.comboBoxCatetory.Size = new System.Drawing.Size(258, 30);
            this.comboBoxCatetory.TabIndex = 1;
            this.comboBoxCatetory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCatetory_SelectedIndexChanged);
            // 
            // textBoxSearchMenu
            // 
            this.textBoxSearchMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMenu.Location = new System.Drawing.Point(3, 4);
            this.textBoxSearchMenu.Name = "textBoxSearchMenu";
            this.textBoxSearchMenu.Size = new System.Drawing.Size(225, 29);
            this.textBoxSearchMenu.TabIndex = 4;
            this.textBoxSearchMenu.Text = "Search";
            this.textBoxSearchMenu.Enter += new System.EventHandler(this.TextBoxSearchMenu_Enter);
            this.textBoxSearchMenu.Leave += new System.EventHandler(this.TextBoxSearchMenu_Leave);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.dataGridViewSelectedItems);
            this.panelUser.Controls.Add(this.panelButton);
            this.panelUser.Controls.Add(this.panelBill);
            this.panelUser.Controls.Add(this.labelSelectedItems);
            this.panelUser.Location = new System.Drawing.Point(414, 46);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(408, 457);
            this.panelUser.TabIndex = 7;
            // 
            // dataGridViewSelectedItems
            // 
            this.dataGridViewSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedItems.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewSelectedItems.Name = "dataGridViewSelectedItems";
            this.dataGridViewSelectedItems.Size = new System.Drawing.Size(402, 343);
            this.dataGridViewSelectedItems.TabIndex = 8;
            this.dataGridViewSelectedItems.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSelectedItems_RowHeaderMouseDoubleClick);
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
            this.labelRefresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefresh.Location = new System.Drawing.Point(3, 3);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(94, 31);
            this.labelRefresh.TabIndex = 7;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.UseVisualStyleBackColor = true;
            this.labelRefresh.Click += new System.EventHandler(this.LabelRefresh_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBill.Location = new System.Drawing.Point(126, 3);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(56, 31);
            this.buttonBill.TabIndex = 9;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.ButtonBill_Click);
            // 
            // panelBill
            // 
            this.panelBill.Controls.Add(this.labelSum);
            this.panelBill.Controls.Add(this.labelTotal);
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
            this.labelSum.Text = "0";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(101, 7);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(50, 22);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // labelSelectedItems
            // 
            this.labelSelectedItems.AutoSize = true;
            this.labelSelectedItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedItems.Location = new System.Drawing.Point(145, 8);
            this.labelSelectedItems.Name = "labelSelectedItems";
            this.labelSelectedItems.Size = new System.Drawing.Size(120, 19);
            this.labelSelectedItems.TabIndex = 5;
            this.labelSelectedItems.Text = "Selected Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuListView);
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 457);
            this.panel1.TabIndex = 6;
            // 
            // menuListView
            // 
            this.menuListView.HideSelection = false;
            this.menuListView.Location = new System.Drawing.Point(3, 29);
            this.menuListView.Name = "menuListView";
            this.menuListView.Size = new System.Drawing.Size(399, 425);
            this.menuListView.TabIndex = 6;
            this.menuListView.UseCompatibleStateImageBehavior = false;
            this.menuListView.View = System.Windows.Forms.View.List;
            this.menuListView.DoubleClick += new System.EventHandler(this.MenuListView_DoubleClick);
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.menuLabel.Location = new System.Drawing.Point(3, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxCatetory;
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
        private System.Windows.Forms.ListView menuListView;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.DataGridView dataGridViewSelectedItems;
    }
}
