namespace CafeteriaManagement
{
    partial class UCEditMenu
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuListView = new System.Windows.Forms.ListView();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxCatetory = new System.Windows.Forms.ComboBox();
            this.textBoxSearchMenu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(688, 138);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(688, 85);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 32);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuListView);
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Location = new System.Drawing.Point(51, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 387);
            this.panel1.TabIndex = 17;
            // 
            // menuListView
            // 
            this.menuListView.HideSelection = false;
            this.menuListView.Location = new System.Drawing.Point(3, 29);
            this.menuListView.Name = "menuListView";
            this.menuListView.Size = new System.Drawing.Size(469, 352);
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
            this.menuLabel.Size = new System.Drawing.Size(469, 31);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBoxCatetory);
            this.panel5.Controls.Add(this.textBoxSearchMenu);
            this.panel5.Location = new System.Drawing.Point(51, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 37);
            this.panel5.TabIndex = 16;
            // 
            // comboBoxCatetory
            // 
            this.comboBoxCatetory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatetory.FormattingEnabled = true;
            this.comboBoxCatetory.Location = new System.Drawing.Point(258, 3);
            this.comboBoxCatetory.Name = "comboBoxCatetory";
            this.comboBoxCatetory.Size = new System.Drawing.Size(214, 30);
            this.comboBoxCatetory.TabIndex = 1;
            this.comboBoxCatetory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCatetory_SelectedIndexChanged);
            // 
            // textBoxSearchMenu
            // 
            this.textBoxSearchMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMenu.Location = new System.Drawing.Point(3, 4);
            this.textBoxSearchMenu.Name = "textBoxSearchMenu";
            this.textBoxSearchMenu.Size = new System.Drawing.Size(189, 29);
            this.textBoxSearchMenu.TabIndex = 4;
            this.textBoxSearchMenu.Text = "Search";
            this.textBoxSearchMenu.Enter += new System.EventHandler(this.TextBoxSearchMenu_Enter);
            this.textBoxSearchMenu.Leave += new System.EventHandler(this.TextBoxSearchMenu_Leave);
            // 
            // UCEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Name = "UCEditMenu";
            this.Size = new System.Drawing.Size(828, 510);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView menuListView;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxCatetory;
        private System.Windows.Forms.TextBox textBoxSearchMenu;
    }
}
