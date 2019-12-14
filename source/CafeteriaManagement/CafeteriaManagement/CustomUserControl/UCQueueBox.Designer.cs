namespace CafeteriaManagement
{

    partial class UCQueueBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.lblOffline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.NowPlaying = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NextUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPause = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPlaying = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSongDuration = new Bunifu.Framework.UI.BunifuTrackbar();
            this.dataGridViewNextUp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.dataGridViewHistory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipseHistory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseNextUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseNowPlaying = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerQueue = new System.Windows.Forms.Timer(this.components);
            this.timerHistory = new System.Windows.Forms.Timer(this.components);
            this.timerQueueBack = new System.Windows.Forms.Timer(this.components);
            this.timerHistoryBack = new System.Windows.Forms.Timer(this.components);
            this.timerPanelGreenHistory = new System.Windows.Forms.Timer(this.components);
            this.timerPanelGreenQueue = new System.Windows.Forms.Timer(this.components);
            this.pnlQueue.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNextUp)).BeginInit();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.pnlGreen.Location = new System.Drawing.Point(25, 50);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(69, 3);
            this.pnlGreen.TabIndex = 21;
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOffline.Location = new System.Drawing.Point(121, 22);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(75, 25);
            this.lblOffline.TabIndex = 20;
            this.lblOffline.Text = "History";
            this.lblOffline.Click += new System.EventHandler(this.lblOffline_Click);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOnline.Location = new System.Drawing.Point(22, 22);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(68, 25);
            this.lblOnline.TabIndex = 19;
            this.lblOnline.Text = "Queue";
            this.lblOnline.Click += new System.EventHandler(this.lblOnline_Click);
            // 
            // NowPlaying
            // 
            this.NowPlaying.ElipseRadius = 5;
            this.NowPlaying.TargetControl = this;
            // 
            // NextUp
            // 
            this.NextUp.ElipseRadius = 5;
            this.NextUp.TargetControl = this;
            // 
            // pnlQueue
            // 
            this.pnlQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueue.Controls.Add(this.labelDuration);
            this.pnlQueue.Controls.Add(this.labelTime);
            this.pnlQueue.Controls.Add(this.tableLayoutPanel1);
            this.pnlQueue.Location = new System.Drawing.Point(15, 62);
            this.pnlQueue.Name = "pnlQueue";
            this.pnlQueue.Size = new System.Drawing.Size(785, 434);
            this.pnlQueue.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPlaying, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarSongDuration, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewNextUp, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.976798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.27378F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.280743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.97912F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.06497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.048724F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 434);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.buttonPause);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Location = new System.Drawing.Point(223, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 45);
            this.panel1.TabIndex = 43;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.BorderRadius = 5;
            this.buttonPlay.ButtonText = "Play";
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPlay.Iconimage = null;
            this.buttonPlay.Iconimage_right = null;
            this.buttonPlay.Iconimage_right_Selected = null;
            this.buttonPlay.Iconimage_Selected = null;
            this.buttonPlay.IconMarginLeft = 0;
            this.buttonPlay.IconMarginRight = 0;
            this.buttonPlay.IconRightVisible = true;
            this.buttonPlay.IconRightZoom = 0D;
            this.buttonPlay.IconVisible = true;
            this.buttonPlay.IconZoom = 90D;
            this.buttonPlay.IsTab = false;
            this.buttonPlay.Location = new System.Drawing.Point(131, 7);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPlay.selected = false;
            this.buttonPlay.Size = new System.Drawing.Size(81, 34);
            this.buttonPlay.TabIndex = 35;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPlay.Textcolor = System.Drawing.Color.White;
            this.buttonPlay.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.BorderRadius = 5;
            this.buttonPause.ButtonText = "Pause";
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPause.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPause.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPause.Iconimage = null;
            this.buttonPause.Iconimage_right = null;
            this.buttonPause.Iconimage_right_Selected = null;
            this.buttonPause.Iconimage_Selected = null;
            this.buttonPause.IconMarginLeft = 0;
            this.buttonPause.IconMarginRight = 0;
            this.buttonPause.IconRightVisible = true;
            this.buttonPause.IconRightZoom = 0D;
            this.buttonPause.IconVisible = true;
            this.buttonPause.IconZoom = 90D;
            this.buttonPause.IsTab = false;
            this.buttonPause.Location = new System.Drawing.Point(131, 6);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPause.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPause.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPause.selected = false;
            this.buttonPause.Size = new System.Drawing.Size(81, 34);
            this.buttonPause.TabIndex = 39;
            this.buttonPause.Text = "Pause";
            this.buttonPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPause.Textcolor = System.Drawing.Color.White;
            this.buttonPause.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.BorderRadius = 5;
            this.buttonPrevious.ButtonText = "Previous";
            this.buttonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevious.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPrevious.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPrevious.Iconimage = null;
            this.buttonPrevious.Iconimage_right = null;
            this.buttonPrevious.Iconimage_right_Selected = null;
            this.buttonPrevious.Iconimage_Selected = null;
            this.buttonPrevious.IconMarginLeft = 0;
            this.buttonPrevious.IconMarginRight = 0;
            this.buttonPrevious.IconRightVisible = true;
            this.buttonPrevious.IconRightZoom = 0D;
            this.buttonPrevious.IconVisible = true;
            this.buttonPrevious.IconZoom = 90D;
            this.buttonPrevious.IsTab = false;
            this.buttonPrevious.Location = new System.Drawing.Point(18, 7);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPrevious.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPrevious.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPrevious.selected = false;
            this.buttonPrevious.Size = new System.Drawing.Size(81, 34);
            this.buttonPrevious.TabIndex = 36;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrevious.Textcolor = System.Drawing.Color.White;
            this.buttonPrevious.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.BorderRadius = 5;
            this.buttonNext.ButtonText = "Next";
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNext.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonNext.Iconimage = null;
            this.buttonNext.Iconimage_right = null;
            this.buttonNext.Iconimage_right_Selected = null;
            this.buttonNext.Iconimage_Selected = null;
            this.buttonNext.IconMarginLeft = 0;
            this.buttonNext.IconMarginRight = 0;
            this.buttonNext.IconRightVisible = true;
            this.buttonNext.IconRightZoom = 0D;
            this.buttonNext.IconVisible = true;
            this.buttonNext.IconZoom = 90D;
            this.buttonNext.IsTab = false;
            this.buttonNext.Location = new System.Drawing.Point(244, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonNext.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNext.selected = false;
            this.buttonNext.Size = new System.Drawing.Size(81, 34);
            this.buttonNext.TabIndex = 37;
            this.buttonNext.Text = "Next";
            this.buttonNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNext.Textcolor = System.Drawing.Color.White;
            this.buttonNext.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Now Playing";
            // 
            // dataGridViewPlaying
            // 
            this.dataGridViewPlaying.AllowUserToAddRows = false;
            this.dataGridViewPlaying.AllowUserToDeleteRows = false;
            this.dataGridViewPlaying.AllowUserToResizeColumns = false;
            this.dataGridViewPlaying.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewPlaying.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaying.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlaying.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewPlaying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPlaying.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPlaying.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlaying.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewPlaying.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPlaying.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPlaying.DoubleBuffered = true;
            this.dataGridViewPlaying.EnableHeadersVisualStyles = false;
            this.dataGridViewPlaying.GridColor = System.Drawing.Color.White;
            this.dataGridViewPlaying.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewPlaying.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewPlaying.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewPlaying.MultiSelect = false;
            this.dataGridViewPlaying.Name = "dataGridViewPlaying";
            this.dataGridViewPlaying.ReadOnly = true;
            this.dataGridViewPlaying.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPlaying.RowHeadersVisible = false;
            this.dataGridViewPlaying.RowTemplate.Height = 30;
            this.dataGridViewPlaying.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlaying.Size = new System.Drawing.Size(779, 89);
            this.dataGridViewPlaying.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Next Up";
            // 
            // trackBarSongDuration
            // 
            this.trackBarSongDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarSongDuration.BackColor = System.Drawing.Color.Transparent;
            this.trackBarSongDuration.BackgroudColor = System.Drawing.Color.DarkGray;
            this.trackBarSongDuration.BorderRadius = 0;
            this.trackBarSongDuration.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.trackBarSongDuration.Location = new System.Drawing.Point(97, 398);
            this.trackBarSongDuration.MaximumValue = 100;
            this.trackBarSongDuration.Name = "trackBarSongDuration";
            this.trackBarSongDuration.Size = new System.Drawing.Size(590, 30);
            this.trackBarSongDuration.SliderRadius = 0;
            this.trackBarSongDuration.TabIndex = 38;
            this.trackBarSongDuration.Value = 0;
            // 
            // dataGridViewNextUp
            // 
            this.dataGridViewNextUp.AllowUserToAddRows = false;
            this.dataGridViewNextUp.AllowUserToDeleteRows = false;
            this.dataGridViewNextUp.AllowUserToResizeColumns = false;
            this.dataGridViewNextUp.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewNextUp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewNextUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNextUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNextUp.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewNextUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNextUp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNextUp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNextUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewNextUp.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNextUp.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewNextUp.DoubleBuffered = true;
            this.dataGridViewNextUp.EnableHeadersVisualStyles = false;
            this.dataGridViewNextUp.GridColor = System.Drawing.Color.White;
            this.dataGridViewNextUp.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewNextUp.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewNextUp.Location = new System.Drawing.Point(3, 179);
            this.dataGridViewNextUp.MultiSelect = false;
            this.dataGridViewNextUp.Name = "dataGridViewNextUp";
            this.dataGridViewNextUp.ReadOnly = true;
            this.dataGridViewNextUp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewNextUp.RowHeadersVisible = false;
            this.dataGridViewNextUp.RowTemplate.Height = 30;
            this.dataGridViewNextUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNextUp.Size = new System.Drawing.Size(779, 160);
            this.dataGridViewNextUp.TabIndex = 34;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(726, 401);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(22, 17);
            this.labelDuration.TabIndex = 41;
            this.labelDuration.Text = "-:-";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(57, 401);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(22, 17);
            this.labelTime.TabIndex = 40;
            this.labelTime.Text = "-:-";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.dataGridViewHistory);
            this.pnlHistory.Location = new System.Drawing.Point(15, 502);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(785, 466);
            this.pnlHistory.TabIndex = 39;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewHistory.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewHistory.DoubleBuffered = true;
            this.dataGridViewHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewHistory.GridColor = System.Drawing.Color.White;
            this.dataGridViewHistory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewHistory.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewHistory.Location = new System.Drawing.Point(42, 25);
            this.dataGridViewHistory.MultiSelect = false;
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.RowTemplate.Height = 30;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(735, 303);
            this.dataGridViewHistory.TabIndex = 34;
            // 
            // bunifuElipseHistory
            // 
            this.bunifuElipseHistory.ElipseRadius = 5;
            this.bunifuElipseHistory.TargetControl = this.dataGridViewHistory;
            // 
            // bunifuElipseNextUp
            // 
            this.bunifuElipseNextUp.ElipseRadius = 5;
            this.bunifuElipseNextUp.TargetControl = this.dataGridViewNextUp;
            // 
            // bunifuElipseNowPlaying
            // 
            this.bunifuElipseNowPlaying.ElipseRadius = 5;
            this.bunifuElipseNowPlaying.TargetControl = this.dataGridViewPlaying;
            // 
            // timerQueue
            // 
            this.timerQueue.Interval = 1;
            this.timerQueue.Tick += new System.EventHandler(this.timerQueue_Tick);
            // 
            // timerHistory
            // 
            this.timerHistory.Interval = 1;
            this.timerHistory.Tick += new System.EventHandler(this.timerHistory_Tick);
            // 
            // timerQueueBack
            // 
            this.timerQueueBack.Interval = 1;
            this.timerQueueBack.Tick += new System.EventHandler(this.timerQueueBack_Tick);
            // 
            // timerHistoryBack
            // 
            this.timerHistoryBack.Interval = 1;
            this.timerHistoryBack.Tick += new System.EventHandler(this.timerHistoryBack_Tick);
            // 
            // timerPanelGreenHistory
            // 
            this.timerPanelGreenHistory.Interval = 1;
            this.timerPanelGreenHistory.Tick += new System.EventHandler(this.timerPanelGreen_Tick);
            // 
            // timerPanelGreenQueue
            // 
            this.timerPanelGreenQueue.Interval = 1;
            this.timerPanelGreenQueue.Tick += new System.EventHandler(this.timerPanelGreenQueue_Tick);
            // 
            // UCQueueBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlQueue);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.lblOnline);
            this.Name = "UCQueueBox";
            this.Size = new System.Drawing.Size(828, 510);
            this.Load += new System.EventHandler(this.UCQueueBox_Load);
            this.pnlQueue.ResumeLayout(false);
            this.pnlQueue.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNextUp)).EndInit();
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Label lblOnline;
        private Bunifu.Framework.UI.BunifuElipse NowPlaying;
        private Bunifu.Framework.UI.BunifuElipse NextUp;
        private System.Windows.Forms.Panel pnlQueue;
        private Bunifu.Framework.UI.BunifuTrackbar trackBarSongDuration;
        private Bunifu.Framework.UI.BunifuFlatButton buttonNext;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPrevious;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPlay;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewNextUp;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewPlaying;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlHistory;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewHistory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseHistory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseNextUp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseNowPlaying;
        private System.Windows.Forms.Timer timerQueue;
        private System.Windows.Forms.Timer timerHistory;
        private System.Windows.Forms.Timer timerQueueBack;
        private System.Windows.Forms.Timer timerHistoryBack;
        private System.Windows.Forms.Timer timerPanelGreenHistory;
        private System.Windows.Forms.Timer timerPanelGreenQueue;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPause;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
