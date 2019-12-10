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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slideMenu = new System.Windows.Forms.Panel();
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
            this.ucDisplayMusicNew1 = new CafeteriaManagement.UCDisplayMusicNew();
            this.ucOrderNew1 = new CafeteriaManagement.UCOrderNew();
            this.ucEditMenuNew1 = new CafeteriaManagement.UCEditMenuNew();
            this.ucQueueBox1 = new CafeteriaManagement.UCQueueBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.slideMenu.SuspendLayout();
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
            this.pnlHeader.Controls.Add(this.pictureBox3);
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.panelAnimater.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1022, 44);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::CafeteriaManagement.Properties.Resources.horizontal_line_48px;
            this.pictureBox3.Location = new System.Drawing.Point(904, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::CafeteriaManagement.Properties.Resources.unchecked_checkbox_48px;
            this.pictureBox2.Location = new System.Drawing.Point(942, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.daux_32;
            this.pictureBox1.Location = new System.Drawing.Point(978, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.slideMenu.Controls.Add(this.Queue);
            this.slideMenu.Controls.Add(this.btnEmployee);
            this.slideMenu.Controls.Add(this.btnMusic);
            this.slideMenu.Controls.Add(this.btnEdit);
            this.slideMenu.Controls.Add(this.btnPayment);
            this.slideMenu.Controls.Add(this.btnHome);
            this.slideMenu.Controls.Add(this.btnMenu);
            this.panelAnimater.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 44);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(200, 517);
            this.slideMenu.TabIndex = 1;
            // 
            // Queue
            // 
            this.Queue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Queue.BorderRadius = 0;
            this.Queue.ButtonText = "         Queue";
            this.Queue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.Queue, BunifuAnimatorNS.DecorationType.None);
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
            this.Queue.Location = new System.Drawing.Point(3, 314);
            this.Queue.Name = "Queue";
            this.Queue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Queue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
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
            this.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "         Employee";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnEmployee, BunifuAnimatorNS.DecorationType.None);
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
            this.btnEmployee.Location = new System.Drawing.Point(3, 260);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(199, 48);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "         Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Textcolor = System.Drawing.Color.Silver;
            this.btnEmployee.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnMusic
            // 
            this.btnMusic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.BorderRadius = 0;
            this.btnMusic.ButtonText = "         Music";
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnMusic, BunifuAnimatorNS.DecorationType.None);
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
            this.btnMusic.Location = new System.Drawing.Point(3, 217);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
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
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "         Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
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
            this.btnEdit.Location = new System.Drawing.Point(3, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(199, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "         Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.Silver;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.ButtonText = "         Payment";
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnPayment, BunifuAnimatorNS.DecorationType.None);
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
            this.btnPayment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
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
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "         Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimater.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
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
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(199, 48);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Silver;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimater.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::CafeteriaManagement.Properties.Resources.icons8_menu_32;
            this.btnMenu.Location = new System.Drawing.Point(161, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(33, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.panelAnimater.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            this.panel1.Controls.Add(this.ucQueueBox1);
            this.panel1.Controls.Add(this.ucDisplayMusicNew1);
            this.panel1.Controls.Add(this.ucOrderNew1);
            this.panel1.Controls.Add(this.ucEditMenuNew1);
            this.panelAnimater.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 517);
            this.panel1.TabIndex = 3;
            // 
            // ucDisplayMusicNew1
            // 
            this.ucDisplayMusicNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucDisplayMusicNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucDisplayMusicNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisplayMusicNew1.Location = new System.Drawing.Point(0, 0);
            this.ucDisplayMusicNew1.Name = "ucDisplayMusicNew1";
            this.ucDisplayMusicNew1.Size = new System.Drawing.Size(822, 517);
            this.ucDisplayMusicNew1.TabIndex = 2;
            // 
            // ucOrderNew1
            // 
            this.ucOrderNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucOrderNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucOrderNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderNew1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderNew1.Name = "ucOrderNew1";
            this.ucOrderNew1.Size = new System.Drawing.Size(822, 517);
            this.ucOrderNew1.TabIndex = 1;
            // 
            // ucEditMenuNew1
            // 
            this.ucEditMenuNew1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucEditMenuNew1, BunifuAnimatorNS.DecorationType.None);
            this.ucEditMenuNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEditMenuNew1.Location = new System.Drawing.Point(0, 0);
            this.ucEditMenuNew1.Name = "ucEditMenuNew1";
            this.ucEditMenuNew1.Size = new System.Drawing.Size(822, 517);
            this.ucEditMenuNew1.TabIndex = 0;
            // 
            // ucQueueBox1
            // 
            this.ucQueueBox1.BackColor = System.Drawing.Color.Silver;
            this.panelAnimater.SetDecoration(this.ucQueueBox1, BunifuAnimatorNS.DecorationType.None);
            this.ucQueueBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQueueBox1.Location = new System.Drawing.Point(0, 0);
            this.ucQueueBox1.Name = "ucQueueBox1";
            this.ucQueueBox1.Size = new System.Drawing.Size(822, 517);
            this.ucQueueBox1.TabIndex = 3;
            // 
            // FormMainLosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1022, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slideMenu);
            this.Controls.Add(this.pnlHeader);
            this.panelAnimater.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainLosed";
            this.Text = "FormMainLosed";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.slideMenu.ResumeLayout(false);
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
        private UCEditMenuNew ucEditMenuNew1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnMusic;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayment;
        private UCOrderNew ucOrderNew1;
        private UCDisplayMusicNew ucDisplayMusicNew1;
        private Bunifu.Framework.UI.BunifuFlatButton Queue;
        private UCQueueBox ucQueueBox1;
        // private UCQueueBox ucQueueBox1;
        // private UCDisplayMusicNew ucDisplayMusicNew1;
    }
}