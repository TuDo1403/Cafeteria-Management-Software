namespace CafeteriaManagement
{
    partial class FormProductInfNew
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControlMove = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductType = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(392, 35);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.daux_32;
            this.pictureBox1.Location = new System.Drawing.Point(355, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelName.Location = new System.Drawing.Point(21, 161);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 21);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxName.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxName.HintText = "";
            this.textBoxName.isPassword = false;
            this.textBoxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxName.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxName.LineThickness = 4;
            this.textBoxName.Location = new System.Drawing.Point(125, 152);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 29);
            this.textBoxName.TabIndex = 18;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(21, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Price:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxPrice.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPrice.HintText = "";
            this.textBoxPrice.isPassword = false;
            this.textBoxPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxPrice.LineThickness = 4;
            this.textBoxPrice.Location = new System.Drawing.Point(125, 201);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(233, 29);
            this.textBoxPrice.TabIndex = 20;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(21, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(21, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.richTextBoxDescription.Location = new System.Drawing.Point(125, 312);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(233, 123);
            this.richTextBoxDescription.TabIndex = 24;
            this.richTextBoxDescription.Text = "   ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.buttonAdd.Location = new System.Drawing.Point(278, 461);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdd.selected = false;
            this.buttonAdd.Size = new System.Drawing.Size(80, 27);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.Textcolor = System.Drawing.Color.White;
            this.buttonAdd.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.richTextBoxDescription;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.buttonEdit.Location = new System.Drawing.Point(278, 461);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonEdit.selected = false;
            this.buttonEdit.Size = new System.Drawing.Size(80, 27);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEdit.Textcolor = System.Drawing.Color.White;
            this.buttonEdit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // bunifuDragControlMove
            // 
            this.bunifuDragControlMove.Fixed = true;
            this.bunifuDragControlMove.Horizontal = true;
            this.bunifuDragControlMove.TargetControl = this.panelHeader;
            this.bunifuDragControlMove.Vertical = true;
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 5;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 40);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Edit";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxProductType.BorderRadius = 3;
            this.comboBoxProductType.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductType.Items = new string[0];
            this.comboBoxProductType.Location = new System.Drawing.Point(125, 258);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.comboBoxProductType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.comboBoxProductType.selectedIndex = -1;
            this.comboBoxProductType.Size = new System.Drawing.Size(233, 35);
            this.comboBoxProductType.TabIndex = 36;
            this.comboBoxProductType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxProductType_Validating);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelId.Location = new System.Drawing.Point(21, 107);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 21);
            this.labelId.TabIndex = 37;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxId.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxId.HintText = "";
            this.textBoxId.isPassword = false;
            this.textBoxId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxId.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(117)))), ((int)(((byte)(39)))));
            this.textBoxId.LineThickness = 4;
            this.textBoxId.Location = new System.Drawing.Point(125, 98);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(233, 29);
            this.textBoxId.TabIndex = 38;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormProductInfNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(392, 514);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductInfNew";
            this.Text = "FormProductInfNew";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMove;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown comboBoxProductType;
        private System.Windows.Forms.Label labelId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxId;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}