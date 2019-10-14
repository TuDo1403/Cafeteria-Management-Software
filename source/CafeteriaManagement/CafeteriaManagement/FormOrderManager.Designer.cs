namespace CafeteriaManagement
{
    partial class FormOrderManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearchMenu = new System.Windows.Forms.TextBox();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonBill = new System.Windows.Forms.Button();
            this.buttonAddTopping = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCatetory = new System.Windows.Forms.ComboBox();
            this.listViewItemAdded = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSearchMenu);
            this.panel1.Controls.Add(this.flowLayoutMenu);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 483);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearchMenu
            // 
            this.textBoxSearchMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMenu.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearchMenu.Name = "textBoxSearchMenu";
            this.textBoxSearchMenu.Size = new System.Drawing.Size(399, 20);
            this.textBoxSearchMenu.TabIndex = 4;
            this.textBoxSearchMenu.Text = "Search";
            this.textBoxSearchMenu.Enter += new System.EventHandler(this.textBoxSearchMenu_Enter);
            this.textBoxSearchMenu.Leave += new System.EventHandler(this.textBoxSearchMenu_Leave);
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.Location = new System.Drawing.Point(4, 29);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(398, 451);
            this.flowLayoutMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Controls.Add(this.textBoxTotal);
            this.panel2.Controls.Add(this.buttonBill);
            this.panel2.Controls.Add(this.buttonAddTopping);
            this.panel2.Controls.Add(this.labelCategory);
            this.panel2.Controls.Add(this.comboBoxCatetory);
            this.panel2.Controls.Add(this.listViewItemAdded);
            this.panel2.Location = new System.Drawing.Point(423, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 483);
            this.panel2.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(5, 392);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 25);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(72, 380);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(318, 38);
            this.textBoxTotal.TabIndex = 10;
            // 
            // buttonBill
            // 
            this.buttonBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBill.Location = new System.Drawing.Point(157, 427);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(233, 53);
            this.buttonBill.TabIndex = 9;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            // 
            // buttonAddTopping
            // 
            this.buttonAddTopping.Location = new System.Drawing.Point(10, 427);
            this.buttonAddTopping.Name = "buttonAddTopping";
            this.buttonAddTopping.Size = new System.Drawing.Size(141, 53);
            this.buttonAddTopping.TabIndex = 7;
            this.buttonAddTopping.UseVisualStyleBackColor = true;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(7, 7);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 17);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCatetory
            // 
            this.comboBoxCatetory.FormattingEnabled = true;
            this.comboBoxCatetory.Location = new System.Drawing.Point(86, 3);
            this.comboBoxCatetory.Name = "comboBoxCatetory";
            this.comboBoxCatetory.Size = new System.Drawing.Size(304, 21);
            this.comboBoxCatetory.TabIndex = 1;
            // 
            // listViewItemAdded
            // 
            this.listViewItemAdded.HideSelection = false;
            this.listViewItemAdded.Location = new System.Drawing.Point(3, 30);
            this.listViewItemAdded.Name = "listViewItemAdded";
            this.listViewItemAdded.Size = new System.Drawing.Size(387, 344);
            this.listViewItemAdded.TabIndex = 0;
            this.listViewItemAdded.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.musicBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.logoutToolStripMenuItem.Text = "Shift Change";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.logOutToolStripMenuItem1.Text = "Log out";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // editMenuToolStripMenuItem
            // 
            this.editMenuToolStripMenuItem.Name = "editMenuToolStripMenuItem";
            this.editMenuToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editMenuToolStripMenuItem.Text = "Edit Menu";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.statisticToolStripMenuItem.Text = "Statistic";
            // 
            // musicBoxToolStripMenuItem
            // 
            this.musicBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToQueueToolStripMenuItem,
            this.queueToolStripMenuItem});
            this.musicBoxToolStripMenuItem.Name = "musicBoxToolStripMenuItem";
            this.musicBoxToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.musicBoxToolStripMenuItem.Text = "Music Box";
            // 
            // addToQueueToolStripMenuItem
            // 
            this.addToQueueToolStripMenuItem.Name = "addToQueueToolStripMenuItem";
            this.addToQueueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToQueueToolStripMenuItem.Text = "Search Box";
            this.addToQueueToolStripMenuItem.Click += new System.EventHandler(this.searchBoxStripMenuItem_Click);
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queueToolStripMenuItem.Text = "Queue";
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
            // 
            // FormOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrderManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearchMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCatetory;
        private System.Windows.Forms.ListView listViewItemAdded;
        private System.Windows.Forms.Button buttonAddTopping;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
    }
}