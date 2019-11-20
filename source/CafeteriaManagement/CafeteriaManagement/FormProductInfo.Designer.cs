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
            this.panelProductInfo = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.panelProductInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProductInfo
            // 
            this.panelProductInfo.Controls.Add(this.panelInfo);
            this.panelProductInfo.Controls.Add(this.panelImage);
            this.panelProductInfo.Location = new System.Drawing.Point(12, 12);
            this.panelProductInfo.Name = "panelProductInfo";
            this.panelProductInfo.Size = new System.Drawing.Size(498, 364);
            this.panelProductInfo.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.comboBoxProductType);
            this.panelInfo.Controls.Add(this.panel1);
            this.panelInfo.Controls.Add(this.labelType);
            this.panelInfo.Controls.Add(this.labelName);
            this.panelInfo.Controls.Add(this.textBoxPrice);
            this.panelInfo.Controls.Add(this.textBoxName);
            this.panelInfo.Controls.Add(this.labelId);
            this.panelInfo.Controls.Add(this.textBoxId);
            this.panelInfo.Controls.Add(this.labelPrice);
            this.panelInfo.Controls.Add(this.buttonAdd);
            this.panelInfo.Controls.Add(this.buttonEdit);
            this.panelInfo.Location = new System.Drawing.Point(185, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(310, 358);
            this.panelInfo.TabIndex = 1;
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(107, 154);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(197, 28);
            this.comboBoxProductType.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxDescription);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Location = new System.Drawing.Point(3, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 100);
            this.panel1.TabIndex = 40;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(104, 4);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(197, 74);
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
            this.labelType.Location = new System.Drawing.Point(3, 153);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 37;
            this.labelType.Text = "Type";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.Location = new System.Drawing.Point(3, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Name :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxPrice.Location = new System.Drawing.Point(107, 109);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(197, 26);
            this.textBoxPrice.TabIndex = 34;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxName.Location = new System.Drawing.Point(107, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 26);
            this.textBoxName.TabIndex = 33;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelId.Location = new System.Drawing.Point(3, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(93, 20);
            this.labelId.TabIndex = 32;
            this.labelId.Text = "ID Product :";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxId.Location = new System.Drawing.Point(107, 9);
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
            this.labelPrice.Location = new System.Drawing.Point(3, 112);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Price :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Location = new System.Drawing.Point(234, 328);
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
            this.buttonEdit.Location = new System.Drawing.Point(234, 328);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(73, 27);
            this.buttonEdit.TabIndex = 36;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBoxProductImage);
            this.panelImage.Location = new System.Drawing.Point(3, 3);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(176, 258);
            this.panelImage.TabIndex = 0;
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(170, 173);
            this.pictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductImage.TabIndex = 27;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 388);
            this.Controls.Add(this.panelProductInfo);
            this.Name = "FormProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductInfo";
            this.panelProductInfo.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxProductType;
    }
}