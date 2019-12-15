using System;

namespace CafeteriaManagement
{
    partial class UCEditMenuNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.buttonEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewMenu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipseMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCategory.BorderRadius = 4;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxCategory.Items = new string[0];
            this.comboBoxCategory.Location = new System.Drawing.Point(26, 25);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.comboBoxCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.comboBoxCategory.selectedIndex = -1;
            this.comboBoxCategory.Size = new System.Drawing.Size(240, 30);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.onItemSelected += new System.EventHandler(this.ComboBoxCategory_onItemSelected);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.BorderRadius = 2;
            this.buttonEdit.ButtonText = "Edit";
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.DisabledColor = System.Drawing.Color.Gray;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonEdit.Iconimage = null;
            this.buttonEdit.Iconimage_right = null;
            this.buttonEdit.Iconimage_right_Selected = null;
            this.buttonEdit.Iconimage_Selected = null;
            this.buttonEdit.IconMarginLeft = 0;
            this.buttonEdit.IconMarginRight = 0;
            this.buttonEdit.IconRightVisible = true;
            this.buttonEdit.IconRightZoom = 0D;
            this.buttonEdit.IconVisible = true;
            this.buttonEdit.IconZoom = 90D;
            this.buttonEdit.IsTab = false;
            this.buttonEdit.Location = new System.Drawing.Point(582, 467);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonEdit.selected = false;
            this.buttonEdit.Size = new System.Drawing.Size(80, 27);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEdit.Textcolor = System.Drawing.Color.White;
            this.buttonEdit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.BorderRadius = 2;
            this.buttonAdd.ButtonText = "Add";
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdd.Iconimage = null;
            this.buttonAdd.Iconimage_right = null;
            this.buttonAdd.Iconimage_right_Selected = null;
            this.buttonAdd.Iconimage_Selected = null;
            this.buttonAdd.IconMarginLeft = 0;
            this.buttonAdd.IconMarginRight = 0;
            this.buttonAdd.IconRightVisible = true;
            this.buttonAdd.IconRightZoom = 0D;
            this.buttonAdd.IconVisible = true;
            this.buttonAdd.IconZoom = 90D;
            this.buttonAdd.IsTab = false;
            this.buttonAdd.Location = new System.Drawing.Point(683, 467);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdd.selected = false;
            this.buttonAdd.Size = new System.Drawing.Size(80, 27);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.Textcolor = System.Drawing.Color.White;
            this.buttonAdd.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.BorderRadius = 2;
            this.buttonDelete.ButtonText = "Delete";
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonDelete.Iconimage = null;
            this.buttonDelete.Iconimage_right = null;
            this.buttonDelete.Iconimage_right_Selected = null;
            this.buttonDelete.Iconimage_Selected = null;
            this.buttonDelete.IconMarginLeft = 0;
            this.buttonDelete.IconMarginRight = 0;
            this.buttonDelete.IconRightVisible = true;
            this.buttonDelete.IconRightZoom = 0D;
            this.buttonDelete.IconVisible = true;
            this.buttonDelete.IconZoom = 90D;
            this.buttonDelete.IsTab = false;
            this.buttonDelete.Location = new System.Drawing.Point(473, 467);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonDelete.selected = false;
            this.buttonDelete.Size = new System.Drawing.Size(80, 27);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonDelete.Textcolor = System.Drawing.Color.White;
            this.buttonDelete.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.AllowUserToResizeColumns = false;
            this.dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMenu.ColumnHeadersHeight = 30;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMenu.DoubleBuffered = true;
            this.dataGridViewMenu.EnableHeadersVisualStyles = false;
            this.dataGridViewMenu.GridColor = System.Drawing.Color.White;
            this.dataGridViewMenu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewMenu.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewMenu.Location = new System.Drawing.Point(27, 111);
            this.dataGridViewMenu.MultiSelect = false;
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMenu.RowTemplate.Height = 30;
            this.dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Size = new System.Drawing.Size(765, 327);
            this.dataGridViewMenu.TabIndex = 10;
            this.dataGridViewMenu.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewMenu_RowHeaderMouseClick);
            this.dataGridViewMenu.Click += new System.EventHandler(this.DataGridViewMenu_Click);
            // 
            // bunifuElipseMenu
            // 
            this.bunifuElipseMenu.ElipseRadius = 4;
            this.bunifuElipseMenu.TargetControl = this.label1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 4;
            this.bunifuElipse2.TargetControl = this.dataGridViewMenu;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(364, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // UCEditMenuNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "UCEditMenuNew";
            this.Size = new System.Drawing.Size(828, 510);
            this.Load += new System.EventHandler(this.UCEditMenuNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown comboBoxCategory;
        private Bunifu.Framework.UI.BunifuFlatButton buttonEdit;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdd;
        private Bunifu.Framework.UI.BunifuFlatButton buttonDelete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}
