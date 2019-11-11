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
            this.ucEditMenu = new CoffeManagement.UCEditMenu();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ucEmployee = new CoffeManagement.UCEmployee();
            this.ucOrderManager = new CoffeManagement.UCOrderManager();
            this.ucHome = new CoffeManagement.UCHome();
            this.collectionUserControl1 = new CoffeManagement.CollectionUserControl();
            this.paymentUserControl1 = new CoffeManagement.PaymentUserControl();
            this.SuspendLayout();
            // 
            // ucEditMenu
            // 
            this.ucEditMenu.Location = new System.Drawing.Point(163, 27);
            this.ucEditMenu.Name = "ucEditMenu";
            this.ucEditMenu.Size = new System.Drawing.Size(828, 510);
            this.ucEditMenu.TabIndex = 0;
            this.ucEditMenu.Load += new System.EventHandler(this.ucEditMenu1_Load);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Location = new System.Drawing.Point(0, 69);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(164, 58);
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
            this.btnOrder.Size = new System.Drawing.Size(164, 58);
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
            this.btnMenu.Size = new System.Drawing.Size(164, 58);
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
            this.button4.Size = new System.Drawing.Size(164, 58);
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
            this.btnEmployee.Size = new System.Drawing.Size(164, 58);
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
            this.button6.Size = new System.Drawing.Size(164, 58);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ucEmployee
            // 
            this.ucEmployee.Location = new System.Drawing.Point(163, 27);
            this.ucEmployee.Name = "ucEmployee";
            this.ucEmployee.Size = new System.Drawing.Size(828, 510);
            this.ucEmployee.TabIndex = 7;
            // 
            // ucOrderManager
            // 
            this.ucOrderManager.Location = new System.Drawing.Point(170, 27);
            this.ucOrderManager.Name = "ucOrderManager";
            this.ucOrderManager.Size = new System.Drawing.Size(828, 510);
            this.ucOrderManager.TabIndex = 8;
            // 
            // ucHome
            // 
            this.ucHome.Location = new System.Drawing.Point(163, 27);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(828, 510);
            this.ucHome.TabIndex = 9;
            // 
            // collectionUserControl1
            // 
            this.collectionUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.collectionUserControl1.Location = new System.Drawing.Point(212, 39);
            this.collectionUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.collectionUserControl1.Name = "collectionUserControl1";
            this.collectionUserControl1.Size = new System.Drawing.Size(779, 507);
            this.collectionUserControl1.TabIndex = 10;
            // 
            // paymentUserControl1
            // 
            this.paymentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.paymentUserControl1.Location = new System.Drawing.Point(212, 30);
            this.paymentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentUserControl1.Name = "paymentUserControl1";
            this.paymentUserControl1.Size = new System.Drawing.Size(779, 507);
            this.paymentUserControl1.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 536);
            this.Controls.Add(this.paymentUserControl1);
            this.Controls.Add(this.collectionUserControl1);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.ucOrderManager);
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
        private UCOrderManager ucOrderManager;
        private UCHome ucHome;
        private CollectionUserControl collectionUserControl1;
        private PaymentUserControl paymentUserControl1;
    }
}