using System.Windows.Forms;

namespace CafeteriaManagement
{
    partial class FormMainLosed
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainLosed));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxToBigSize = new System.Windows.Forms.PictureBox();
            this.pictureBoxToSmallSize = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slideMenu = new System.Windows.Forms.Panel();
            this.btnStatic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelEditProfile = new System.Windows.Forms.Label();
            this.pictureBoxSetting = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.Queue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPayment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelAnimater = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TestAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFormFadeTransitionFormMain = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.timerSettingUp = new System.Windows.Forms.Timer(this.components);
            this.timerSettingDown = new System.Windows.Forms.Timer(this.components);
            this.ucHome1 = new CafeteriaManagement.CustomUserControl.UCHome();
            this.ucStaticNew1 = new CafeteriaManagement.CustomUserControl.UCStaticNew();
            this.ucSetting1 = new CafeteriaManagement.CustomUserControl.UCSetting();
            this.ucQueueBox1 = new CafeteriaManagement.UCQueueBox();
            this.ucOrderNew1 = new CafeteriaManagement.UCOrderNew();
            this.ucEmployeeNew1 = new CafeteriaManagement.UCEmployeeNew();
            this.ucEditMenuNew1 = new CafeteriaManagement.UCEditMenuNew();
            this.ucDisplayMusicNew1 = new CafeteriaManagement.UCDisplayMusicNew();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToBigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToSmallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.slideMenu.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pnlHeader.Controls.Add(this.pictureBoxToBigSize);
            this.pnlHeader.Controls.Add(this.pictureBoxToSmallSize);
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.TestAnimation.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1022, 44);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            // 
            // pictureBoxToBigSize
            // 
            this.pictureBoxToBigSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBoxToBigSize, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.pictureBoxToBigSize, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxToBigSize.Image = global::CafeteriaManagement.Properties.Resources.unchecked_checkbox_48px;
            this.pictureBoxToBigSize.Location = new System.Drawing.Point(942, 7);
            this.pictureBoxToBigSize.Name = "pictureBoxToBigSize";
            this.pictureBoxToBigSize.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxToBigSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToBigSize.TabIndex = 1;
            this.pictureBoxToBigSize.TabStop = false;
            this.pictureBoxToBigSize.Click += new System.EventHandler(this.pictureBoxToBigSize_Click);
            // 
            // pictureBoxToSmallSize
            // 
            this.pictureBoxToSmallSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBoxToSmallSize, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.pictureBoxToSmallSize, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxToSmallSize.Image = global::CafeteriaManagement.Properties.Resources.restore_window_32px;
            this.pictureBoxToSmallSize.Location = new System.Drawing.Point(942, 7);
            this.pictureBoxToSmallSize.Name = "pictureBoxToSmallSize";
            this.pictureBoxToSmallSize.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxToSmallSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToSmallSize.TabIndex = 4;
            this.pictureBoxToSmallSize.TabStop = false;
            this.pictureBoxToSmallSize.Click += new System.EventHandler(this.pictureBoxToSmallSize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::CafeteriaManagement.Properties.Resources.horizontal_line_48px;
            this.pictureBox3.Location = new System.Drawing.Point(904, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.daux_32;
            this.pictureBox1.Location = new System.Drawing.Point(978, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.slideMenu.Controls.Add(this.btnStatic);
            this.slideMenu.Controls.Add(this.pnlSetting);
            this.slideMenu.Controls.Add(this.pictureBoxSetting);
            this.slideMenu.Controls.Add(this.panelButton);
            this.slideMenu.Controls.Add(this.Queue);
            this.slideMenu.Controls.Add(this.btnEmployee);
            this.slideMenu.Controls.Add(this.btnMusic);
            this.slideMenu.Controls.Add(this.btnEdit);
            this.slideMenu.Controls.Add(this.btnPayment);
            this.slideMenu.Controls.Add(this.btnHome);
            this.slideMenu.Controls.Add(this.btnMenu);
            this.TestAnimation.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 0);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(200, 517);
            this.slideMenu.TabIndex = 1;
            // 
            // btnStatic
            // 
            this.btnStatic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnStatic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatic.BorderRadius = 0;
            this.btnStatic.ButtonText = "         Statistic";
            this.btnStatic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnStatic, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnStatic, BunifuAnimatorNS.DecorationType.None);
            this.btnStatic.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatic.Iconimage = global::CafeteriaManagement.Properties.Resources.icons8_bar_chart_32;
            this.btnStatic.Iconimage_right = null;
            this.btnStatic.Iconimage_right_Selected = null;
            this.btnStatic.Iconimage_Selected = null;
            this.btnStatic.IconMarginLeft = 0;
            this.btnStatic.IconMarginRight = 0;
            this.btnStatic.IconRightVisible = true;
            this.btnStatic.IconRightZoom = 0D;
            this.btnStatic.IconVisible = true;
            this.btnStatic.IconZoom = 42D;
            this.btnStatic.IsTab = false;
            this.btnStatic.Location = new System.Drawing.Point(3, 347);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnStatic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnStatic.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStatic.selected = false;
            this.btnStatic.Size = new System.Drawing.Size(199, 48);
            this.btnStatic.TabIndex = 13;
            this.btnStatic.Text = "         Statistic";
            this.btnStatic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatic.Textcolor = System.Drawing.Color.Silver;
            this.btnStatic.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.labelLogOut);
            this.pnlSetting.Controls.Add(this.labelChangePassword);
            this.pnlSetting.Controls.Add(this.labelEditProfile);
            this.TestAnimation.SetDecoration(this.pnlSetting, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this.pnlSetting, BunifuAnimatorNS.DecorationType.None);
            this.pnlSetting.Location = new System.Drawing.Point(70, 496);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(132, 118);
            this.pnlSetting.TabIndex = 12;
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.panelAnimater.SetDecoration(this.labelLogOut, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.labelLogOut, BunifuAnimatorNS.DecorationType.None);
            this.labelLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(3, 82);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(67, 21);
            this.labelLogOut.TabIndex = 13;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.panelAnimater.SetDecoration(this.labelChangePassword, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.labelChangePassword, BunifuAnimatorNS.DecorationType.None);
            this.labelChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.ForeColor = System.Drawing.Color.Silver;
            this.labelChangePassword.Location = new System.Drawing.Point(3, 50);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(82, 21);
            this.labelChangePassword.TabIndex = 12;
            this.labelChangePassword.Text = "PassWord";
            this.labelChangePassword.Click += new System.EventHandler(this.labelChangePassword_Click);
            // 
            // labelEditProfile
            // 
            this.labelEditProfile.AutoSize = true;
            this.panelAnimater.SetDecoration(this.labelEditProfile, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.labelEditProfile, BunifuAnimatorNS.DecorationType.None);
            this.labelEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditProfile.ForeColor = System.Drawing.Color.Silver;
            this.labelEditProfile.Location = new System.Drawing.Point(3, 17);
            this.labelEditProfile.Name = "labelEditProfile";
            this.labelEditProfile.Size = new System.Drawing.Size(90, 21);
            this.labelEditProfile.TabIndex = 11;
            this.labelEditProfile.Text = "Edit Proflie";
            this.labelEditProfile.Click += new System.EventHandler(this.labelEditProfile_Click);
            // 
            // pictureBoxSetting
            // 
            this.panelAnimater.SetDecoration(this.pictureBoxSetting, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.pictureBoxSetting, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxSetting.Image = global::CafeteriaManagement.Properties.Resources.icons8_settings_321;
            this.pictureBoxSetting.Location = new System.Drawing.Point(12, 479);
            this.pictureBoxSetting.Name = "pictureBoxSetting";
            this.pictureBoxSetting.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSetting.TabIndex = 11;
            this.pictureBoxSetting.TabStop = false;
            this.pictureBoxSetting.Click += new System.EventHandler(this.pictureBoxSetting_Click);
            this.pictureBoxSetting.MouseLeave += new System.EventHandler(this.pictureBoxSetting_MouseLeave);
            this.pictureBoxSetting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSetting_MouseMove);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TestAnimation.SetDecoration(this.panelButton, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this.panelButton, BunifuAnimatorNS.DecorationType.None);
            this.panelButton.Location = new System.Drawing.Point(0, 76);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(5, 48);
            this.panelButton.TabIndex = 8;
            // 
            // Queue
            // 
            this.Queue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Queue.BorderRadius = 0;
            this.Queue.ButtonText = "         Queue";
            this.Queue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.Queue, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.Queue, BunifuAnimatorNS.DecorationType.None);
            this.Queue.DisabledColor = System.Drawing.Color.Gray;
            this.Queue.Iconcolor = System.Drawing.Color.Transparent;
            this.Queue.Iconimage = global::CafeteriaManagement.Properties.Resources.que_32px;
            this.Queue.Iconimage_right = null;
            this.Queue.Iconimage_right_Selected = null;
            this.Queue.Iconimage_Selected = null;
            this.Queue.IconMarginLeft = 0;
            this.Queue.IconMarginRight = 0;
            this.Queue.IconRightVisible = true;
            this.Queue.IconRightZoom = 0D;
            this.Queue.IconVisible = true;
            this.Queue.IconZoom = 42D;
            this.Queue.IsTab = false;
            this.Queue.Location = new System.Drawing.Point(3, 213);
            this.Queue.Name = "Queue";
            this.Queue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Queue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Queue.OnHoverTextColor = System.Drawing.Color.White;
            this.Queue.selected = false;
            this.Queue.Size = new System.Drawing.Size(199, 48);
            this.Queue.TabIndex = 7;
            this.Queue.Text = "         Queue";
            this.Queue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Queue.Textcolor = System.Drawing.Color.Silver;
            this.Queue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Queue.Click += new System.EventHandler(this.Queue_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "         Employee";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
            this.btnEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconimage = global::CafeteriaManagement.Properties.Resources.contacts_32px;
            this.btnEmployee.Iconimage_right = null;
            this.btnEmployee.Iconimage_right_Selected = null;
            this.btnEmployee.Iconimage_Selected = null;
            this.btnEmployee.IconMarginLeft = 0;
            this.btnEmployee.IconMarginRight = 0;
            this.btnEmployee.IconRightVisible = true;
            this.btnEmployee.IconRightZoom = 0D;
            this.btnEmployee.IconVisible = true;
            this.btnEmployee.IconZoom = 42D;
            this.btnEmployee.IsTab = false;
            this.btnEmployee.Location = new System.Drawing.Point(1, 258);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(199, 48);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "         Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Textcolor = System.Drawing.Color.Silver;
            this.btnEmployee.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.BorderRadius = 0;
            this.btnMusic.ButtonText = "         Music";
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnMusic, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnMusic, BunifuAnimatorNS.DecorationType.None);
            this.btnMusic.DisabledColor = System.Drawing.Color.Gray;
            this.btnMusic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMusic.Iconimage = global::CafeteriaManagement.Properties.Resources.youtube_play_48px;
            this.btnMusic.Iconimage_right = null;
            this.btnMusic.Iconimage_right_Selected = null;
            this.btnMusic.Iconimage_Selected = null;
            this.btnMusic.IconMarginLeft = 0;
            this.btnMusic.IconMarginRight = 0;
            this.btnMusic.IconRightVisible = true;
            this.btnMusic.IconRightZoom = 0D;
            this.btnMusic.IconVisible = true;
            this.btnMusic.IconZoom = 42D;
            this.btnMusic.IsTab = false;
            this.btnMusic.Location = new System.Drawing.Point(1, 168);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnMusic.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMusic.selected = false;
            this.btnMusic.Size = new System.Drawing.Size(199, 48);
            this.btnMusic.TabIndex = 5;
            this.btnMusic.Text = "         Music";
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusic.Textcolor = System.Drawing.Color.Silver;
            this.btnMusic.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "         Edit Product";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = global::CafeteriaManagement.Properties.Resources.list_32px;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 42D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(1, 302);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(199, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "         Edit Product";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.Silver;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.ButtonText = "         Payment";
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnPayment, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnPayment, BunifuAnimatorNS.DecorationType.None);
            this.btnPayment.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayment.Iconimage = global::CafeteriaManagement.Properties.Resources.bank_cards66_48px;
            this.btnPayment.Iconimage_right = null;
            this.btnPayment.Iconimage_right_Selected = null;
            this.btnPayment.Iconimage_Selected = null;
            this.btnPayment.IconMarginLeft = 0;
            this.btnPayment.IconMarginRight = 0;
            this.btnPayment.IconRightVisible = true;
            this.btnPayment.IconRightZoom = 0D;
            this.btnPayment.IconVisible = true;
            this.btnPayment.IconZoom = 42D;
            this.btnPayment.IsTab = false;
            this.btnPayment.Location = new System.Drawing.Point(1, 123);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnPayment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnPayment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayment.selected = false;
            this.btnPayment.Size = new System.Drawing.Size(199, 48);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "         Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Textcolor = System.Drawing.Color.Silver;
            this.btnPayment.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "         Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::CafeteriaManagement.Properties.Resources.icons8_home_32;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 42D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(1, 76);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(199, 48);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Silver;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::CafeteriaManagement.Properties.Resources.icons8_menu_32;
            this.btnMenu.Location = new System.Drawing.Point(161, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelAnimater
            // 
            this.panelAnimater.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.panelAnimater.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimater.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucHome1);
            this.panel1.Controls.Add(this.ucStaticNew1);
            this.panel1.Controls.Add(this.ucSetting1);
            this.panel1.Controls.Add(this.ucQueueBox1);
            this.panel1.Controls.Add(this.ucOrderNew1);
            this.panel1.Controls.Add(this.ucEmployeeNew1);
            this.panel1.Controls.Add(this.ucEditMenuNew1);
            this.panel1.Controls.Add(this.ucDisplayMusicNew1);
            this.panel1.Controls.Add(this.slideMenu);
            this.TestAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 517);
            this.panel1.TabIndex = 3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // TestAnimation
            // 
            this.TestAnimation.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.TestAnimation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.TestAnimation.DefaultAnimation = animation2;
            // 
            // bunifuFormFadeTransitionFormMain
            // 
            this.bunifuFormFadeTransitionFormMain.Delay = 1;
            // 
            // timerSettingUp
            // 
            this.timerSettingUp.Interval = 1;
            this.timerSettingUp.Tick += new System.EventHandler(this.timerSettingUp_Tick);
            // 
            // timerSettingDown
            // 
            this.timerSettingDown.Interval = 1;
            this.timerSettingDown.Tick += new System.EventHandler(this.timerSettingDown_Tick);
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucHome1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucHome1, BunifuAnimatorNS.DecorationType.None);
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(200, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(822, 517);
            this.ucHome1.TabIndex = 9;
            // 
            // ucStaticNew1
            // 
            this.ucStaticNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucStaticNew1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucStaticNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucStaticNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStaticNew1.Location = new System.Drawing.Point(200, 0);
            this.ucStaticNew1.Name = "ucStaticNew1";
            this.ucStaticNew1.Size = new System.Drawing.Size(822, 517);
            this.ucStaticNew1.TabIndex = 8;
            // 
            // ucSetting1
            // 
            this.ucSetting1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ucSetting1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucSetting1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucSetting1, BunifuAnimatorNS.DecorationType.None);
            this.ucSetting1.Location = new System.Drawing.Point(200, 0);
            this.ucSetting1.Name = "ucSetting1";
            this.ucSetting1.Size = new System.Drawing.Size(819, 517);
            this.ucSetting1.TabIndex = 7;
            // 
            // ucQueueBox1
            // 
            this.ucQueueBox1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucQueueBox1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucQueueBox1, BunifuAnimatorNS.DecorationType.None);
            this.ucQueueBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQueueBox1.Location = new System.Drawing.Point(200, 0);
            this.ucQueueBox1.Name = "ucQueueBox1";
            this.ucQueueBox1.Size = new System.Drawing.Size(822, 517);
            this.ucQueueBox1.TabIndex = 6;
            // 
            // ucOrderNew1
            // 
            this.ucOrderNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucOrderNew1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucOrderNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucOrderNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderNew1.Location = new System.Drawing.Point(200, 0);
            this.ucOrderNew1.Name = "ucOrderNew1";
            this.ucOrderNew1.Size = new System.Drawing.Size(822, 517);
            this.ucOrderNew1.TabIndex = 5;
            // 
            // ucEmployeeNew1
            // 
            this.ucEmployeeNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucEmployeeNew1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucEmployeeNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucEmployeeNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmployeeNew1.Location = new System.Drawing.Point(200, 0);
            this.ucEmployeeNew1.Name = "ucEmployeeNew1";
            this.ucEmployeeNew1.Size = new System.Drawing.Size(822, 517);
            this.ucEmployeeNew1.TabIndex = 4;
            // 
            // ucEditMenuNew1
            // 
            this.ucEditMenuNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucEditMenuNew1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucEditMenuNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucEditMenuNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEditMenuNew1.Location = new System.Drawing.Point(200, 0);
            this.ucEditMenuNew1.Name = "ucEditMenuNew1";
            this.ucEditMenuNew1.Size = new System.Drawing.Size(822, 517);
            this.ucEditMenuNew1.TabIndex = 3;
            // 
            // ucDisplayMusicNew1
            // 
            this.ucDisplayMusicNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucDisplayMusicNew1, BunifuAnimatorNS.DecorationType.None);
            this.TestAnimation.SetDecoration(this.ucDisplayMusicNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucDisplayMusicNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisplayMusicNew1.Location = new System.Drawing.Point(200, 0);
            this.ucDisplayMusicNew1.Name = "ucDisplayMusicNew1";
            this.ucDisplayMusicNew1.Size = new System.Drawing.Size(822, 517);
            this.ucDisplayMusicNew1.TabIndex = 2;
            // 
            // FormMainLosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1022, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.TestAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimater.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainLosed";
            this.Text = "FormMainLosed";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToBigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToSmallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.slideMenu.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel slideMenu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private BunifuAnimatorNS.BunifuTransition panelAnimater;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxToBigSize;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnMusic;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayment;
        private Bunifu.Framework.UI.BunifuFlatButton Queue;
        private PictureBox pictureBoxToSmallSize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private UCQueueBox ucQueueBox1;
        private UCOrderNew ucOrderNew1;
        private UCEmployeeNew ucEmployeeNew1;
        private UCEditMenuNew ucEditMenuNew1;
        private UCDisplayMusicNew ucDisplayMusicNew1;
        private Panel panelButton;
        private Panel pnlSetting;
        private Label labelLogOut;
        private Label labelChangePassword;
        private Label labelEditProfile;
        private PictureBox pictureBoxSetting;
        private CustomUserControl.UCSetting ucSetting1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatic;
        private CustomUserControl.UCStaticNew ucStaticNew1;
        private BunifuAnimatorNS.BunifuTransition TestAnimation;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransitionFormMain;
        private Timer timerSettingUp;
        private Timer timerSettingDown;
        private CustomUserControl.UCHome ucHome1;
    }
}