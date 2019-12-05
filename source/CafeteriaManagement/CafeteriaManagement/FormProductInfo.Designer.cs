namespace CafeteriaManagement
{
    partial class FormProductInfo
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
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panelTextBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(130, 5);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(197, 28);
            this.comboBoxProductType.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxDescription);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Location = new System.Drawing.Point(413, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 149);
            this.panel1.TabIndex = 40;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(104, 4);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(259, 137);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(3, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 20);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelType.Location = new System.Drawing.Point(3, 8);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 37;
            this.labelType.Text = "Type";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.Location = new System.Drawing.Point(3, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxName.Location = new System.Drawing.Point(130, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 26);
            this.textBoxName.TabIndex = 33;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelId.Location = new System.Drawing.Point(3, 8);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(93, 20);
            this.labelId.TabIndex = 32;
            this.labelId.Text = "ID Product :";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxId.Location = new System.Drawing.Point(130, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(197, 26);
            this.textBoxId.TabIndex = 31;
            this.textBoxId.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPrice.Location = new System.Drawing.Point(3, 8);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Price :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Location = new System.Drawing.Point(371, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 27);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.Location = new System.Drawing.Point(371, 250);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(73, 27);
            this.buttonEdit.TabIndex = 36;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // panelTextBox
            // 
            this.panelTextBox.Controls.Add(this.textBoxId);
            this.panelTextBox.Controls.Add(this.labelId);
            this.panelTextBox.Location = new System.Drawing.Point(6, 30);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(330, 36);
            this.panelTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Controls.Add(this.textBoxPrice);
            this.panel2.Location = new System.Drawing.Point(6, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 36);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelType);
            this.panel3.Controls.Add(this.comboBoxProductType);
            this.panel3.Location = new System.Drawing.Point(6, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 36);
            this.panel3.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxPrice.Location = new System.Drawing.Point(130, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(197, 26);
            this.textBoxPrice.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelName);
            this.panel4.Controls.Add(this.textBoxName);
            this.panel4.Location = new System.Drawing.Point(6, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 36);
            this.panel4.TabIndex = 5;
            // 
            // groupBoxProductInfo
            // 
            this.groupBoxProductInfo.Controls.Add(this.panel4);
            this.groupBoxProductInfo.Controls.Add(this.panelTextBox);
            this.groupBoxProductInfo.Controls.Add(this.panel1);
            this.groupBoxProductInfo.Controls.Add(this.panel3);
            this.groupBoxProductInfo.Controls.Add(this.panel2);
            this.groupBoxProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductInfo.Name = "groupBoxProductInfo";
            this.groupBoxProductInfo.Size = new System.Drawing.Size(785, 212);
            this.groupBoxProductInfo.TabIndex = 41;
            this.groupBoxProductInfo.TabStop = false;
            this.groupBoxProductInfo.Text = "Product Info";
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 292);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxProductInfo);
            this.Name = "FormProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxProductInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Panel panelTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxProductInfo;
    }
}