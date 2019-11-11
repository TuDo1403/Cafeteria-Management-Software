namespace CafeteriaManagement
{
    partial class FormMainNew
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
            this.ucHome = new CafeteriaManagement.CustomUserControl.UCHome();
            this.ucEditMenu = new CafeteriaManagement.UCEditMenu();
            this.ucMusicDownloader1 = new CafeteriaManagement.UCMusicDownloader();
            this.ucOrderManager = new CafeteriaManagement.UCOrderManager();
            this.ucQueueBox1 = new CafeteriaManagement.UCQueueBox();
            this.ucEmployee = new CafeteriaManagement.CustomUserControl.UCEmployee();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.BtnMusic = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucHome
            // 
            this.ucHome.Location = new System.Drawing.Point(176, 60);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(828, 510);
            this.ucHome.TabIndex = 0;
            // 
            // ucEditMenu
            // 
            this.ucEditMenu.Location = new System.Drawing.Point(176, 48);
            this.ucEditMenu.Name = "ucEditMenu";
            this.ucEditMenu.Size = new System.Drawing.Size(828, 510);
            this.ucEditMenu.TabIndex = 1;
            // 
            // ucMusicDownloader1
            // 
            this.ucMusicDownloader1.Location = new System.Drawing.Point(176, 48);
            this.ucMusicDownloader1.Name = "ucMusicDownloader1";
            this.ucMusicDownloader1.Size = new System.Drawing.Size(828, 512);
            this.ucMusicDownloader1.TabIndex = 2;
            // 
            // ucOrderManager
            // 
            this.ucOrderManager.Location = new System.Drawing.Point(176, 48);
            this.ucOrderManager.Name = "ucOrderManager";
            this.ucOrderManager.Size = new System.Drawing.Size(828, 510);
            this.ucOrderManager.TabIndex = 3;
            // 
            // ucQueueBox1
            // 
            this.ucQueueBox1.Location = new System.Drawing.Point(271, 358);
            this.ucQueueBox1.Name = "ucQueueBox1";
            this.ucQueueBox1.Size = new System.Drawing.Size(828, 512);
            this.ucQueueBox1.TabIndex = 4;
            // 
            // ucEmployee
            // 
            this.ucEmployee.Location = new System.Drawing.Point(176, 48);
            this.ucEmployee.Name = "ucEmployee";
            this.ucEmployee.Size = new System.Drawing.Size(828, 510);
            this.ucEmployee.TabIndex = 5;
//            this.ucEmployee.Load += new System.EventHandler(this.ucEmployee_Load);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Location = new System.Drawing.Point(-1, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(143, 54);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrder.Location = new System.Drawing.Point(-1, 155);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(143, 54);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.Location = new System.Drawing.Point(-1, 215);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(143, 54);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployee.Location = new System.Drawing.Point(-1, 335);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(143, 54);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // BtnMusic
            // 
            this.BtnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnMusic.Location = new System.Drawing.Point(-1, 275);
            this.BtnMusic.Name = "BtnMusic";
            this.BtnMusic.Size = new System.Drawing.Size(143, 54);
            this.BtnMusic.TabIndex = 10;
            this.BtnMusic.Text = "Music";
            this.BtnMusic.UseVisualStyleBackColor = true;
            this.BtnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatic.Location = new System.Drawing.Point(-1, 395);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(143, 54);
            this.btnStatic.TabIndex = 11;
            this.btnStatic.Text = "Static";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // FormMainNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.BtnMusic);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ucEmployee);
            this.Controls.Add(this.ucQueueBox1);
            this.Controls.Add(this.ucOrderManager);
            this.Controls.Add(this.ucMusicDownloader1);
            this.Controls.Add(this.ucEditMenu);
            this.Controls.Add(this.ucHome);
            this.Name = "FormMainNew";
            this.Text = "FormMainNew";
     //       this.Load += new System.EventHandler(this.FormMainNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUserControl.UCHome ucHome;
        private UCEditMenu ucEditMenu;
        private UCMusicDownloader ucMusicDownloader1;
        private UCOrderManager ucOrderManager;
        private UCQueueBox ucQueueBox1;
        private CustomUserControl.UCEmployee ucEmployee;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button BtnMusic;
        private System.Windows.Forms.Button btnStatic;
    }
}