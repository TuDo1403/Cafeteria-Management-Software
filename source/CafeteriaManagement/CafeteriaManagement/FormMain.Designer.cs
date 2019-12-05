namespace CafeteriaManagement
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSliding = new System.Windows.Forms.Panel();
            this.labelLoggedInId = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonManageEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEditMenu = new System.Windows.Forms.Button();
            this.ucMusicDownloader = new CafeteriaManagement.UCMusicDownloader();
            this.ucQueueBox = new CafeteriaManagement.UCQueueBox();
            this.ucHome = new CafeteriaManagement.CustomUserControl.UCHome();
            this.ucEditMenuNew1 = new CafeteriaManagement.UCEditMenuNew();
            this.ucEmployeeNew1 = new CafeteriaManagement.UCEmployeeNew();
            this.ucOrderNew1 = new CafeteriaManagement.UCOrderNew();
            this.panelSliding.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(184, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(828, 60);
            this.panelTop.TabIndex = 4;
            // 
            // panelSliding
            // 
            this.panelSliding.Controls.Add(this.labelLoggedInId);
            this.panelSliding.Controls.Add(this.buttonMusic);
            this.panelSliding.Controls.Add(this.buttonStatistic);
            this.panelSliding.Controls.Add(this.buttonManageEmployee);
            this.panelSliding.Controls.Add(this.button3);
            this.panelSliding.Controls.Add(this.buttonHome);
            this.panelSliding.Controls.Add(this.buttonEditMenu);
            this.panelSliding.Location = new System.Drawing.Point(12, 78);
            this.panelSliding.Name = "panelSliding";
            this.panelSliding.Size = new System.Drawing.Size(166, 510);
            this.panelSliding.TabIndex = 5;
            // 
            // labelLoggedInId
            // 
            this.labelLoggedInId.AutoSize = true;
            this.labelLoggedInId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInId.Location = new System.Drawing.Point(23, 17);
            this.labelLoggedInId.Name = "labelLoggedInId";
            this.labelLoggedInId.Size = new System.Drawing.Size(110, 16);
            this.labelLoggedInId.TabIndex = 6;
            this.labelLoggedInId.Text = "Logged In As: {0}";
            // 
            // buttonMusic
            // 
            this.buttonMusic.Location = new System.Drawing.Point(3, 243);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(160, 60);
            this.buttonMusic.TabIndex = 5;
            this.buttonMusic.Text = "Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Location = new System.Drawing.Point(3, 312);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(160, 60);
            this.buttonStatistic.TabIndex = 4;
            this.buttonStatistic.Text = "Statistic";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            // 
            // buttonManageEmployee
            // 
            this.buttonManageEmployee.Location = new System.Drawing.Point(3, 177);
            this.buttonManageEmployee.Name = "buttonManageEmployee";
            this.buttonManageEmployee.Size = new System.Drawing.Size(160, 60);
            this.buttonManageEmployee.TabIndex = 3;
            this.buttonManageEmployee.Text = "Manage Employee";
            this.buttonManageEmployee.UseVisualStyleBackColor = true;
            this.buttonManageEmployee.Click += new System.EventHandler(this.ButtonUserInfo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Order Manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonOrderManager_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(3, 45);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 60);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // buttonEditMenu
            // 
            this.buttonEditMenu.Location = new System.Drawing.Point(3, 378);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(160, 60);
            this.buttonEditMenu.TabIndex = 0;
            this.buttonEditMenu.Text = "Edit Menu";
            this.buttonEditMenu.UseVisualStyleBackColor = true;
            this.buttonEditMenu.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // ucMusicDownloader
            // 
            this.ucMusicDownloader.Location = new System.Drawing.Point(184, 80);
            this.ucMusicDownloader.Name = "ucMusicDownloader";
            this.ucMusicDownloader.Size = new System.Drawing.Size(828, 512);
            this.ucMusicDownloader.TabIndex = 3;
            // 
            // ucQueueBox
            // 
            this.ucQueueBox.Location = new System.Drawing.Point(184, 78);
            this.ucQueueBox.Name = "ucQueueBox";
            this.ucQueueBox.Size = new System.Drawing.Size(828, 512);
            this.ucQueueBox.TabIndex = 7;
            // 
            // ucHome
            // 
            this.ucHome.Location = new System.Drawing.Point(184, 78);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(828, 510);
            this.ucHome.TabIndex = 9;
            // 
            // ucEditMenuNew1
            // 
            this.ucEditMenuNew1.BackColor = System.Drawing.Color.Silver;
            this.ucEditMenuNew1.Location = new System.Drawing.Point(184, 78);
            this.ucEditMenuNew1.Name = "ucEditMenuNew1";
            this.ucEditMenuNew1.Size = new System.Drawing.Size(828, 510);
            this.ucEditMenuNew1.TabIndex = 11;
            // 
            // ucEmployeeNew1
            // 
            this.ucEmployeeNew1.BackColor = System.Drawing.Color.Silver;
            this.ucEmployeeNew1.Location = new System.Drawing.Point(184, 80);
            this.ucEmployeeNew1.Name = "ucEmployeeNew1";
            this.ucEmployeeNew1.Size = new System.Drawing.Size(828, 510);
            this.ucEmployeeNew1.TabIndex = 12;
            // 
            // ucOrderNew1
            // 
            this.ucOrderNew1.BackColor = System.Drawing.Color.Silver;
            this.ucOrderNew1.Location = new System.Drawing.Point(184, 78);
            this.ucOrderNew1.Name = "ucOrderNew1";
            this.ucOrderNew1.Size = new System.Drawing.Size(828, 510);
            this.ucOrderNew1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.ucOrderNew1);
            this.Controls.Add(this.panelSliding);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.ucEditMenuNew1);
            this.Controls.Add(this.ucMusicDownloader);
            this.Controls.Add(this.ucQueueBox);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.ucEmployeeNew1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSliding.ResumeLayout(false);
            this.panelSliding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UCMusicDownloader ucMusicDownloader;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSliding;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonManageEmployee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonEditMenu;
        private UCQueueBox ucQueueBox;
        private CustomUserControl.UCHome ucHome;
        private System.Windows.Forms.Label labelLoggedInId;
        private UCEditMenuNew ucEditMenuNew1;
        private UCEmployeeNew ucEmployeeNew1;
        private UCOrderNew ucOrderNew1;
    }
}