namespace CoffeManagement
{
    partial class FormMain
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ucOrderManager1 = new CoffeManagement.UCOrderManager();
            this.ucHome = new CoffeManagement.UCHome();
            this.ucEmployee = new CoffeManagement.UCEmployee();
            this.ucEditMenu = new CoffeManagement.UCEditMenu();
            this.ucHome1 = new CoffeManagement.UCHome();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Location = new System.Drawing.Point(0, 69);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(146, 58);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrder.Location = new System.Drawing.Point(0, 133);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(146, 58);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Oder Manager";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.Location = new System.Drawing.Point(0, 197);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(146, 58);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(0, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployee.Location = new System.Drawing.Point(0, 325);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(146, 58);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Location = new System.Drawing.Point(0, 389);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 58);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ucOrderManager1
            // 
            this.ucOrderManager1.Location = new System.Drawing.Point(152, 31);
            this.ucOrderManager1.Name = "ucOrderManager1";
            this.ucOrderManager1.Size = new System.Drawing.Size(828, 510);
            this.ucOrderManager1.TabIndex = 12;
            // 
            // ucHome
            // 
            this.ucHome.Location = new System.Drawing.Point(75, 487);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(828, 510);
            this.ucHome.TabIndex = 9;
            this.ucHome.Load += new System.EventHandler(this.ucHome_Load);
            // 
            // ucEmployee
            // 
            this.ucEmployee.Location = new System.Drawing.Point(152, 31);
            this.ucEmployee.Name = "ucEmployee";
            this.ucEmployee.Size = new System.Drawing.Size(828, 510);
            this.ucEmployee.TabIndex = 7;
            this.ucEmployee.Load += new System.EventHandler(this.ucEmployee_Load);
            // 
            // ucEditMenu
            // 
            this.ucEditMenu.Location = new System.Drawing.Point(152, 31);
            this.ucEditMenu.Name = "ucEditMenu";
            this.ucEditMenu.Size = new System.Drawing.Size(828, 510);
            this.ucEditMenu.TabIndex = 0;
            this.ucEditMenu.Load += new System.EventHandler(this.ucEditMenu1_Load);
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(152, 31);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(828, 510);
            this.ucHome1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucOrderManager1);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.ucEmployee);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ucEditMenu);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private UCEditMenu ucEditMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button button6;
        private UCEmployee ucEmployee;
        private UCHome ucHome;
        private UCOrderManager ucOrderManager1;
        private UCHome ucHome1;
    }
}