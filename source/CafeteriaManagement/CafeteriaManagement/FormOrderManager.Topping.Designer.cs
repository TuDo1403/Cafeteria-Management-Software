namespace CafeteriaManagement
{
    partial class FormTopping
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBoxFood);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 364);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(283, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 364);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 138);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 157);
            this.panel4.TabIndex = 1;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(259, 138);
            this.pictureBoxFood.TabIndex = 0;
            this.pictureBoxFood.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 214);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(361, 51);
            this.panel6.TabIndex = 2;
            // 
            // FormTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTopping";
            this.Text = "Add Topping";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}