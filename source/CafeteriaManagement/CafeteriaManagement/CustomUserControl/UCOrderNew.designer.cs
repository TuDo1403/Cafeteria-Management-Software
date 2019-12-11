namespace CafeteriaManagement
{
    partial class UCOrderNew
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSelectedItems = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.comboBoxCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelMenu = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnMau = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectedItems
            // 
            this.dataGridViewSelectedItems.AllowUserToAddRows = false;
            this.dataGridViewSelectedItems.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedItems.AllowUserToResizeColumns = false;
            this.dataGridViewSelectedItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewSelectedItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectedItems.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSelectedItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSelectedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSelectedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSelectedItems.ColumnHeadersHeight = 30;
            this.dataGridViewSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSelectedItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSelectedItems.DoubleBuffered = true;
            this.dataGridViewSelectedItems.EnableHeadersVisualStyles = false;
            this.dataGridViewSelectedItems.GridColor = System.Drawing.Color.White;
            this.dataGridViewSelectedItems.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewSelectedItems.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewSelectedItems.Location = new System.Drawing.Point(459, 66);
            this.dataGridViewSelectedItems.MultiSelect = false;
            this.dataGridViewSelectedItems.Name = "dataGridViewSelectedItems";
            this.dataGridViewSelectedItems.ReadOnly = true;
            this.dataGridViewSelectedItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSelectedItems.RowHeadersVisible = false;
            this.dataGridViewSelectedItems.RowTemplate.Height = 30;
            this.dataGridViewSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelectedItems.Size = new System.Drawing.Size(347, 336);
            this.dataGridViewSelectedItems.TabIndex = 0;
            this.dataGridViewSelectedItems.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSelectedItems_RowHeaderMouseDoubleClick);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCategory.BorderRadius = 5;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxCategory.Items = new string[0];
            this.comboBoxCategory.Location = new System.Drawing.Point(23, 25);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.comboBoxCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.comboBoxCategory.selectedIndex = -1;
            this.comboBoxCategory.Size = new System.Drawing.Size(240, 30);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.onItemSelected += new System.EventHandler(this.ComboBoxCategory_onItemSelected);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.dataGridViewSelectedItems;
            // 
            // labelMenu
            // 
            this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(23, 66);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(411, 30);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Menu";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.labelMenu;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(23, 108);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(411, 294);
            this.flowLayoutPanelMenu.TabIndex = 3;
            this.flowLayoutPanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMenu_Paint);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelSum.Location = new System.Drawing.Point(454, 405);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(60, 28);
            this.labelSum.TabIndex = 8;
            this.labelSum.Text = "Total:";
            // 
            // buttonBill
            // 
            this.buttonBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBill.BorderRadius = 2;
            this.buttonBill.ButtonText = "BILL";
            this.buttonBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBill.DisabledColor = System.Drawing.Color.Gray;
            this.buttonBill.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonBill.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonBill.Iconimage = null;
            this.buttonBill.Iconimage_right = null;
            this.buttonBill.Iconimage_right_Selected = null;
            this.buttonBill.Iconimage_Selected = null;
            this.buttonBill.IconMarginLeft = 0;
            this.buttonBill.IconMarginRight = 0;
            this.buttonBill.IconRightVisible = true;
            this.buttonBill.IconRightZoom = 0D;
            this.buttonBill.IconVisible = true;
            this.buttonBill.IconZoom = 90D;
            this.buttonBill.IsTab = false;
            this.buttonBill.Location = new System.Drawing.Point(726, 462);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonBill.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonBill.selected = false;
            this.buttonBill.Size = new System.Drawing.Size(80, 27);
            this.buttonBill.TabIndex = 10;
            this.buttonBill.Text = "BILL";
            this.buttonBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBill.Textcolor = System.Drawing.Color.White;
            this.buttonBill.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonBill.Click += new System.EventHandler(this.ButtonBill_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.BorderRadius = 2;
            this.buttonRefresh.ButtonText = "REFRESH";
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Iconimage = null;
            this.buttonRefresh.Iconimage_right = null;
            this.buttonRefresh.Iconimage_right_Selected = null;
            this.buttonRefresh.Iconimage_Selected = null;
            this.buttonRefresh.IconMarginLeft = 0;
            this.buttonRefresh.IconMarginRight = 0;
            this.buttonRefresh.IconRightVisible = true;
            this.buttonRefresh.IconRightZoom = 0D;
            this.buttonRefresh.IconVisible = true;
            this.buttonRefresh.IconZoom = 90D;
            this.buttonRefresh.IsTab = false;
            this.buttonRefresh.Location = new System.Drawing.Point(601, 462);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonRefresh.selected = false;
            this.buttonRefresh.Size = new System.Drawing.Size(80, 27);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonRefresh.Textcolor = System.Drawing.Color.White;
            this.buttonRefresh.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelTotal.Location = new System.Drawing.Point(661, 405);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(145, 28);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMau
            // 
            this.btnMau.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnMau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMau.BorderRadius = 4;
            this.btnMau.ButtonText = "Nút Mẫu";
            this.btnMau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMau.DisabledColor = System.Drawing.Color.Gray;
            this.btnMau.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMau.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMau.Iconimage = null;
            this.btnMau.Iconimage_right = null;
            this.btnMau.Iconimage_right_Selected = null;
            this.btnMau.Iconimage_Selected = null;
            this.btnMau.IconMarginLeft = 0;
            this.btnMau.IconMarginRight = 0;
            this.btnMau.IconRightVisible = true;
            this.btnMau.IconRightZoom = 0D;
            this.btnMau.IconVisible = true;
            this.btnMau.IconZoom = 90D;
            this.btnMau.IsTab = false;
            this.btnMau.Location = new System.Drawing.Point(27, 427);
            this.btnMau.Name = "btnMau";
            this.btnMau.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnMau.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMau.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMau.selected = false;
            this.btnMau.Size = new System.Drawing.Size(130, 46);
            this.btnMau.TabIndex = 12;
            this.btnMau.Text = "Nút Mẫu";
            this.btnMau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMau.Textcolor = System.Drawing.Color.White;
            this.btnMau.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // UCOrderNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.dataGridViewSelectedItems);
            this.Name = "UCOrderNew";
            this.Size = new System.Drawing.Size(828, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewSelectedItems;
        private Bunifu.Framework.UI.BunifuDropdown comboBoxCategory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label labelMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Label labelSum;
        private Bunifu.Framework.UI.BunifuFlatButton buttonBill;
        private Bunifu.Framework.UI.BunifuFlatButton buttonRefresh;
        private System.Windows.Forms.Label labelTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnMau;
    }
}
