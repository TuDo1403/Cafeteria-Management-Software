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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.lblOffline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.NowPlaying = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NextUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPrev = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.PictureBox();
            this.buttonPause = new System.Windows.Forms.PictureBox();
            this.dataGridViewPlaying = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSongDuration = new Bunifu.Framework.UI.BunifuTrackbar();
            this.dataGridViewNextUp = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPause)).BeginInit();
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
            // labelDuration
            // 
            this.labelDuration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(57, 401);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(22, 17);
            this.labelTime.TabIndex = 40;
            this.labelTime.Text = "-:-";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPlaying, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarSongDuration, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewNextUp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 434);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.buttonPrev);
            this.panel2.Controls.Add(this.buttonNext);
            this.panel2.Controls.Add(this.buttonPlay);
            this.panel2.Controls.Add(this.buttonPause);
            this.panel2.Location = new System.Drawing.Point(223, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 45);
            this.panel2.TabIndex = 44;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Image = global::CafeteriaManagement.Properties.Resources.icons8_back3_32;
            this.buttonPrev.Location = new System.Drawing.Point(87, 8);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(37, 37);
            this.buttonPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.TabStop = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Image = global::CafeteriaManagement.Properties.Resources.icons8_forward3_32;
            this.buttonNext.Location = new System.Drawing.Point(221, 8);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(37, 37);
            this.buttonNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNext.TabIndex = 2;
            this.buttonNext.TabStop = false;
            this.buttonNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = global::CafeteriaManagement.Properties.Resources.icons8_circled_play_32;
            this.buttonPlay.Location = new System.Drawing.Point(156, 8);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(37, 37);
            this.buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Image = global::CafeteriaManagement.Properties.Resources.icons8_pause_button_32;
            this.buttonPause.Location = new System.Drawing.Point(156, 8);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(37, 37);
            this.buttonPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPause.TabIndex = 0;
            this.buttonPause.TabStop = false;
            this.buttonPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // dataGridViewPlaying
            // 
            this.dataGridViewPlaying.AllowUserToAddRows = false;
            this.dataGridViewPlaying.AllowUserToDeleteRows = false;
            this.dataGridViewPlaying.AllowUserToResizeColumns = false;
            this.dataGridViewPlaying.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewPlaying.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaying.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlaying.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewPlaying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPlaying.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPlaying.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlaying.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPlaying.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPlaying.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewNextUp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNextUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNextUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNextUp.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewNextUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNextUp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNextUp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNextUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNextUp.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNextUp.DefaultCellStyle = dataGridViewCellStyle6;
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
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.dataGridViewHistory);
            this.pnlHistory.Location = new System.Drawing.Point(12, 53);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewHistory.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewHistory.DoubleBuffered = true;
            this.dataGridViewHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewHistory.GridColor = System.Drawing.Color.White;
            this.dataGridViewHistory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewHistory.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewHistory.Location = new System.Drawing.Point(11, 20);
            this.dataGridViewHistory.MultiSelect = false;
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.RowTemplate.Height = 30;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(761, 303);
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
            this.Controls.Add(this.pnlQueue);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.pnlHistory);
            this.Name = "UCQueueBox";
            this.Size = new System.Drawing.Size(828, 510);
            this.Load += new System.EventHandler(this.UCQueueBox_Load);
            this.pnlQueue.ResumeLayout(false);
            this.pnlQueue.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPause)).EndInit();
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
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox buttonPrev;
        private System.Windows.Forms.PictureBox buttonNext;
        private System.Windows.Forms.PictureBox buttonPlay;
        private System.Windows.Forms.PictureBox buttonPause;
    }
}
