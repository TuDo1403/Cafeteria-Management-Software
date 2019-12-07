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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.lblOffline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.NowPlaying = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NextUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.bunifuTrackbar2 = new Bunifu.Framework.UI.BunifuTrackbar();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid3 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid4 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).BeginInit();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
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
            this.pnlQueue.Controls.Add(this.bunifuTrackbar2);
            this.pnlQueue.Controls.Add(this.bunifuFlatButton4);
            this.pnlQueue.Controls.Add(this.bunifuFlatButton5);
            this.pnlQueue.Controls.Add(this.bunifuFlatButton6);
            this.pnlQueue.Controls.Add(this.bunifuCustomDataGrid3);
            this.pnlQueue.Controls.Add(this.bunifuCustomDataGrid4);
            this.pnlQueue.Controls.Add(this.label3);
            this.pnlQueue.Controls.Add(this.label4);
            this.pnlQueue.Location = new System.Drawing.Point(15, 62);
            this.pnlQueue.Name = "pnlQueue";
            this.pnlQueue.Size = new System.Drawing.Size(785, 434);
            this.pnlQueue.TabIndex = 31;
            // 
            // bunifuTrackbar2
            // 
            this.bunifuTrackbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar2.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuTrackbar2.BorderRadius = 0;
            this.bunifuTrackbar2.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuTrackbar2.Location = new System.Drawing.Point(111, 401);
            this.bunifuTrackbar2.MaximumValue = 100;
            this.bunifuTrackbar2.Name = "bunifuTrackbar2";
            this.bunifuTrackbar2.Size = new System.Drawing.Size(590, 30);
            this.bunifuTrackbar2.SliderRadius = 0;
            this.bunifuTrackbar2.TabIndex = 38;
            this.bunifuTrackbar2.Value = 0;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 5;
            this.bunifuFlatButton4.ButtonText = "Next";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(476, 351);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(81, 34);
            this.bunifuFlatButton4.TabIndex = 37;
            this.bunifuFlatButton4.Text = "Next";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 5;
            this.bunifuFlatButton5.ButtonText = "Previous";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(249, 351);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(81, 34);
            this.bunifuFlatButton5.TabIndex = 36;
            this.bunifuFlatButton5.Text = "Previous";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 5;
            this.bunifuFlatButton6.ButtonText = "Play";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(363, 351);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(81, 34);
            this.bunifuFlatButton6.TabIndex = 35;
            this.bunifuFlatButton6.Text = "Play";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // bunifuCustomDataGrid3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid3.BackgroundColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid3.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid3.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid3.DoubleBuffered = true;
            this.bunifuCustomDataGrid3.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid3.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid3.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomDataGrid3.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid3.Location = new System.Drawing.Point(42, 189);
            this.bunifuCustomDataGrid3.Name = "bunifuCustomDataGrid3";
            this.bunifuCustomDataGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid3.RowHeadersVisible = false;
            this.bunifuCustomDataGrid3.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid3.Size = new System.Drawing.Size(735, 146);
            this.bunifuCustomDataGrid3.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name Music";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bunifuCustomDataGrid4
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid4.BackgroundColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid4.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid4.DefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid4.DoubleBuffered = true;
            this.bunifuCustomDataGrid4.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid4.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomDataGrid4.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.Location = new System.Drawing.Point(42, 52);
            this.bunifuCustomDataGrid4.Name = "bunifuCustomDataGrid4";
            this.bunifuCustomDataGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid4.RowHeadersVisible = false;
            this.bunifuCustomDataGrid4.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid4.Size = new System.Drawing.Size(735, 80);
            this.bunifuCustomDataGrid4.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Order";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Name Music";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Next Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Now Playing";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.bunifuCustomDataGrid1);
            this.pnlHistory.Location = new System.Drawing.Point(2, 504);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(785, 466);
            this.pnlHistory.TabIndex = 39;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(42, 25);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(735, 303);
            this.bunifuCustomDataGrid1.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name Music";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bunifuElipseHistory
            // 
            this.bunifuElipseHistory.ElipseRadius = 5;
            this.bunifuElipseHistory.TargetControl = this.bunifuCustomDataGrid1;
            // 
            // bunifuElipseNextUp
            // 
            this.bunifuElipseNextUp.ElipseRadius = 5;
            this.bunifuElipseNextUp.TargetControl = this.bunifuCustomDataGrid3;
            // 
            // bunifuElipseNowPlaying
            // 
            this.bunifuElipseNowPlaying.ElipseRadius = 5;
            this.bunifuElipseNowPlaying.TargetControl = this.bunifuCustomDataGrid4;
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).EndInit();
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuTrackbar bunifuTrackbar2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlHistory;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseHistory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseNextUp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseNowPlaying;
        private System.Windows.Forms.Timer timerQueue;
        private System.Windows.Forms.Timer timerHistory;
        private System.Windows.Forms.Timer timerQueueBack;
        private System.Windows.Forms.Timer timerHistoryBack;
        private System.Windows.Forms.Timer timerPanelGreenHistory;
        private System.Windows.Forms.Timer timerPanelGreenQueue;
    }
}
