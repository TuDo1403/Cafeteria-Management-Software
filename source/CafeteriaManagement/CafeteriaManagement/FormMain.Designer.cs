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
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.ucOrderManager = new CafeteriaManagement.UCOrderManager();
            this.ucEditMenu = new CafeteriaManagement.UCEditMenu();
            this.ucMusicDownloader = new CafeteriaManagement.UCMusicDownloader();
            this.ucQueueBox = new CafeteriaManagement.UCQueueBox();
            this.ucHome = new CafeteriaManagement.CustomUserControl.UCHome();
            this.ucAccountInfo = new CafeteriaManagement.CustomUserControl.UCAccountInfo();
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
            this.panelSliding.Controls.Add(this.buttonMusic);
            this.panelSliding.Controls.Add(this.buttonStatistic);
            this.panelSliding.Controls.Add(this.buttonUserInfo);
            this.panelSliding.Controls.Add(this.button3);
            this.panelSliding.Controls.Add(this.buttonHome);
            this.panelSliding.Controls.Add(this.buttonAdmin);
            this.panelSliding.Location = new System.Drawing.Point(12, 78);
            this.panelSliding.Name = "panelSliding";
            this.panelSliding.Size = new System.Drawing.Size(166, 510);
            this.panelSliding.TabIndex = 5;
            // 
            // buttonMusic
            // 
            this.buttonMusic.Location = new System.Drawing.Point(3, 331);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(160, 60);
            this.buttonMusic.TabIndex = 5;
            this.buttonMusic.Text = "Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Location = new System.Drawing.Point(3, 275);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(160, 60);
            this.buttonStatistic.TabIndex = 4;
            this.buttonStatistic.Text = "Statistic";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(3, 218);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(160, 60);
            this.buttonUserInfo.TabIndex = 3;
            this.buttonUserInfo.Text = "User Info";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUserInfo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Order Manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonOrderManager_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(3, 105);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 60);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(3, 48);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(160, 60);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // ucOrderManager
            // 
            this.ucOrderManager.Location = new System.Drawing.Point(184, 78);
            this.ucOrderManager.Name = "ucOrderManager";
            this.ucOrderManager.Size = new System.Drawing.Size(828, 510);
            this.ucOrderManager.TabIndex = 0;
            // 
            // ucEditMenu1
            // 
            this.ucEditMenu.Location = new System.Drawing.Point(184, 82);
            this.ucEditMenu.Name = "ucEditMenu1";
            this.ucEditMenu.Size = new System.Drawing.Size(828, 510);
            this.ucEditMenu.TabIndex = 8;
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
            // ucAccountInfo1
            // 
            this.ucAccountInfo.Location = new System.Drawing.Point(184, 78);
            this.ucAccountInfo.Name = "ucAccountInfo1";
            this.ucAccountInfo.Size = new System.Drawing.Size(828, 510);
            this.ucAccountInfo.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.ucOrderManager);
            this.Controls.Add(this.panelSliding);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.ucEditMenu);
            this.Controls.Add(this.ucMusicDownloader);
            this.Controls.Add(this.ucQueueBox);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.ucAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSliding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCOrderManager ucOrderManager;
        private UCMusicDownloader ucMusicDownloader;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSliding;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAdmin;
        private UCQueueBox ucQueueBox;
        private UCEditMenu ucEditMenu;
        private CustomUserControl.UCHome ucHome;
        private CustomUserControl.UCAccountInfo ucAccountInfo;
    }
}