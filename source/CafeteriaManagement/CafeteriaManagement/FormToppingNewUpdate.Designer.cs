namespace CafeteriaManagement
{
    partial class FormProductInfNewUpdate
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
            this.buttonOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControlMove = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanelTopping = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(432, 31);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.daux_32;
            this.pictureBox1.Location = new System.Drawing.Point(402, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOk.BorderRadius = 2;
            this.buttonOk.ButtonText = "OK";
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DisabledColor = System.Drawing.Color.Gray;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonOk.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonOk.Iconimage = null;
            this.buttonOk.Iconimage_right = null;
            this.buttonOk.Iconimage_right_Selected = null;
            this.buttonOk.Iconimage_Selected = null;
            this.buttonOk.IconMarginLeft = 0;
            this.buttonOk.IconMarginRight = 0;
            this.buttonOk.IconRightVisible = true;
            this.buttonOk.IconRightZoom = 0D;
            this.buttonOk.IconVisible = true;
            this.buttonOk.IconZoom = 90D;
            this.buttonOk.IsTab = false;
            this.buttonOk.Location = new System.Drawing.Point(333, 239);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonOk.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonOk.selected = false;
            this.buttonOk.Size = new System.Drawing.Size(80, 27);
            this.buttonOk.TabIndex = 25;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOk.Textcolor = System.Drawing.Color.White;
            this.buttonOk.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControlMove
            // 
            this.bunifuDragControlMove.Fixed = true;
            this.bunifuDragControlMove.Horizontal = true;
            this.bunifuDragControlMove.TargetControl = this.panelHeader;
            this.bunifuDragControlMove.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 40);
            this.panel1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Topping";
            // 
            // flowLayoutPanelTopping
            // 
            this.flowLayoutPanelTopping.AutoScroll = true;
            this.flowLayoutPanelTopping.Location = new System.Drawing.Point(25, 91);
            this.flowLayoutPanelTopping.Name = "flowLayoutPanelTopping";
            this.flowLayoutPanelTopping.Size = new System.Drawing.Size(388, 142);
            this.flowLayoutPanelTopping.TabIndex = 51;
            this.flowLayoutPanelTopping.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelTopping_Paint);
            // 
            // FormProductInfNewUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(431, 279);
            this.Controls.Add(this.flowLayoutPanelTopping);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductInfNewUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProductInfNew";
            this.Load += new System.EventHandler(this.FormProductInfNewUpdate_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuFlatButton buttonOk;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopping;
    }
}