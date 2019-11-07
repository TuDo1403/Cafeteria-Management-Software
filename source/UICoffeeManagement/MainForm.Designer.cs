namespace UICoffeeManagement
{
    partial class MainForm
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
            this.buttonStatic = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonPayMent = new System.Windows.Forms.Button();
            this.buttonCollection = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.collectionUserControl1 = new UICoffeeManagement.CollectionUserControl();
            this.paymentUserControl1 = new UICoffeeManagement.PaymentUserControl();
            this.button1 = new System.Windows.Forms.Button();
            this.homeUserControl1 = new UICoffeeManagement.HomeUserControl();
            this.employeeUserControl1 = new UICoffeeManagement.EmployeeUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStatic);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.Controls.Add(this.buttonMusic);
            this.panel1.Controls.Add(this.buttonPayMent);
            this.panel1.Controls.Add(this.buttonCollection);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 549);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonStatic
            // 
            this.buttonStatic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStatic.FlatAppearance.BorderSize = 0;
            this.buttonStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonStatic.Location = new System.Drawing.Point(0, 343);
            this.buttonStatic.Name = "buttonStatic";
            this.buttonStatic.Size = new System.Drawing.Size(177, 56);
            this.buttonStatic.TabIndex = 5;
            this.buttonStatic.Text = "Static";
            this.buttonStatic.UseVisualStyleBackColor = true;
            this.buttonStatic.Click += new System.EventHandler(this.buttonStatic_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEmployee.Location = new System.Drawing.Point(0, 289);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(177, 56);
            this.buttonEmployee.TabIndex = 4;
            this.buttonEmployee.Text = "Emplyee";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMusic.FlatAppearance.BorderSize = 0;
            this.buttonMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMusic.Location = new System.Drawing.Point(0, 235);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(177, 56);
            this.buttonMusic.TabIndex = 3;
            this.buttonMusic.Text = "Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // buttonPayMent
            // 
            this.buttonPayMent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPayMent.FlatAppearance.BorderSize = 0;
            this.buttonPayMent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPayMent.Location = new System.Drawing.Point(0, 181);
            this.buttonPayMent.Name = "buttonPayMent";
            this.buttonPayMent.Size = new System.Drawing.Size(177, 56);
            this.buttonPayMent.TabIndex = 2;
            this.buttonPayMent.Text = "Payment";
            this.buttonPayMent.UseVisualStyleBackColor = true;
            this.buttonPayMent.Click += new System.EventHandler(this.buttonPayMent_Click);
            // 
            // buttonCollection
            // 
            this.buttonCollection.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCollection.FlatAppearance.BorderSize = 0;
            this.buttonCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCollection.Location = new System.Drawing.Point(0, 127);
            this.buttonCollection.Name = "buttonCollection";
            this.buttonCollection.Size = new System.Drawing.Size(177, 56);
            this.buttonCollection.TabIndex = 1;
            this.buttonCollection.Text = "Collection";
            this.buttonCollection.UseVisualStyleBackColor = true;
            this.buttonCollection.Click += new System.EventHandler(this.buttonCollection_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonHome.Location = new System.Drawing.Point(0, 73);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(177, 57);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(177, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 539);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.employeeUserControl1);
            this.panel4.Controls.Add(this.homeUserControl1);
            this.panel4.Controls.Add(this.collectionUserControl1);
            this.panel4.Controls.Add(this.paymentUserControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(779, 507);
            this.panel4.TabIndex = 1;
            // 
            // collectionUserControl1
            // 
            this.collectionUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.collectionUserControl1.Location = new System.Drawing.Point(0, 2);
            this.collectionUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.collectionUserControl1.Name = "collectionUserControl1";
            this.collectionUserControl1.Size = new System.Drawing.Size(779, 507);
            this.collectionUserControl1.TabIndex = 1;
            this.collectionUserControl1.Load += new System.EventHandler(this.collectionUserControl1_Load);
            // 
            // paymentUserControl1
            // 
            this.paymentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.paymentUserControl1.Location = new System.Drawing.Point(-4, 2);
            this.paymentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentUserControl1.Name = "paymentUserControl1";
            this.paymentUserControl1.Size = new System.Drawing.Size(779, 507);
            this.paymentUserControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homeUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(779, 507);
            this.homeUserControl1.TabIndex = 2;
            // 
            // employeeUserControl1
            // 
            this.employeeUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.employeeUserControl1.Location = new System.Drawing.Point(0, -5);
            this.employeeUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeUserControl1.Name = "employeeUserControl1";
            this.employeeUserControl1.Size = new System.Drawing.Size(779, 507);
            this.employeeUserControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStatic;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonPayMent;
        private System.Windows.Forms.Button buttonCollection;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private PaymentUserControl paymentUserControl1;
        private CollectionUserControl collectionUserControl1;
        private HomeUserControl homeUserControl1;
        private EmployeeUserControl employeeUserControl1;
    }
}

