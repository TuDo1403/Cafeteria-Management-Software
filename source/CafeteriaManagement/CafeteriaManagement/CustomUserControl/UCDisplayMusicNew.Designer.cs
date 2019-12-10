namespace CafeteriaManagement
{
    partial class UCDisplayMusicNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlOffline = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOffline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.pnlOnline = new System.Windows.Forms.Panel();
            this.buttonQueue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewSearchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonSearch = new System.Windows.Forms.PictureBox();
            this.labelYoutube = new System.Windows.Forms.Label();
            this.textBoxSearchMusic = new System.Windows.Forms.TextBox();
            this.DatagridOnline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SearchOffine = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DatagridOffline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerPanelOnline = new System.Windows.Forms.Timer(this.components);
            this.timerPanelOffline = new System.Windows.Forms.Timer(this.components);
            this.timerGreenOffline = new System.Windows.Forms.Timer(this.components);
            this.timerGreenOnline = new System.Windows.Forms.Timer(this.components);
            this.SearchOnline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.pnlOffline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGreen);
            this.panel1.Controls.Add(this.pnlOffline);
            this.panel1.Controls.Add(this.lblOffline);
            this.panel1.Controls.Add(this.lblOnline);
            this.panel1.Controls.Add(this.pnlOnline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 510);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.pnlGreen.Location = new System.Drawing.Point(25, 52);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(69, 3);
            this.pnlGreen.TabIndex = 18;
            // 
            // pnlOffline
            // 
            this.pnlOffline.Controls.Add(this.bunifuFlatButton2);
            this.pnlOffline.Controls.Add(this.bunifuCustomDataGrid2);
            this.pnlOffline.Controls.Add(this.pictureBox2);
            this.pnlOffline.Controls.Add(this.label4);
            this.pnlOffline.Controls.Add(this.textBox2);
            this.pnlOffline.Location = new System.Drawing.Point(816, 63);
            this.pnlOffline.Name = "pnlOffline";
            this.pnlOffline.Size = new System.Drawing.Size(764, 439);
            this.pnlOffline.TabIndex = 18;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "     Queue";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(667, 394);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(81, 34);
            this.bunifuFlatButton2.TabIndex = 17;
            this.bunifuFlatButton2.Text = "     Queue";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(13, 71);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersVisible = false;
            this.bunifuCustomDataGrid2.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(735, 306);
            this.bunifuCustomDataGrid2.TabIndex = 16;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(676, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(41, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local Seach";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(154, 11);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 31);
            this.textBox2.TabIndex = 1;
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOffline.Location = new System.Drawing.Point(123, 24);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(71, 25);
            this.lblOffline.TabIndex = 4;
            this.lblOffline.Text = "Offline";
            this.lblOffline.Click += new System.EventHandler(this.lblOffline_Click);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOnline.Location = new System.Drawing.Point(24, 24);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(68, 25);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Online";
            this.lblOnline.Click += new System.EventHandler(this.lblOnline_Click);
            // 
            // pnlOnline
            // 
            this.pnlOnline.Controls.Add(this.buttonQueue);
            this.pnlOnline.Controls.Add(this.dataGridViewSearchResult);
            this.pnlOnline.Controls.Add(this.buttonSearch);
            this.pnlOnline.Controls.Add(this.labelYoutube);
            this.pnlOnline.Controls.Add(this.textBoxSearchMusic);
            this.pnlOnline.Location = new System.Drawing.Point(30, 63);
            this.pnlOnline.Name = "pnlOnline";
            this.pnlOnline.Size = new System.Drawing.Size(771, 439);
            this.pnlOnline.TabIndex = 2;
            // 
            // buttonQueue
            // 
            this.buttonQueue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQueue.BorderRadius = 5;
            this.buttonQueue.ButtonText = " Queue";
            this.buttonQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQueue.DisabledColor = System.Drawing.Color.Gray;
            this.buttonQueue.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonQueue.Iconimage = null;
            this.buttonQueue.Iconimage_right = null;
            this.buttonQueue.Iconimage_right_Selected = null;
            this.buttonQueue.Iconimage_Selected = null;
            this.buttonQueue.IconMarginLeft = 0;
            this.buttonQueue.IconMarginRight = 0;
            this.buttonQueue.IconRightVisible = true;
            this.buttonQueue.IconRightZoom = 0D;
            this.buttonQueue.IconVisible = true;
            this.buttonQueue.IconZoom = 90D;
            this.buttonQueue.IsTab = false;
            this.buttonQueue.Location = new System.Drawing.Point(667, 394);
            this.buttonQueue.Name = "buttonQueue";
            this.buttonQueue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonQueue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonQueue.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonQueue.selected = false;
            this.buttonQueue.Size = new System.Drawing.Size(81, 34);
            this.buttonQueue.TabIndex = 17;
            this.buttonQueue.Text = " Queue";
            this.buttonQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonQueue.Textcolor = System.Drawing.Color.White;
            this.buttonQueue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQueue.Click += new System.EventHandler(this.ButtonQueue_Click);
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewSearchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSearchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSearchResult.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchResult.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSearchResult.DoubleBuffered = true;
            this.dataGridViewSearchResult.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchResult.GridColor = System.Drawing.Color.White;
            this.dataGridViewSearchResult.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewSearchResult.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(13, 71);
            this.dataGridViewSearchResult.MultiSelect = false;
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.ReadOnly = true;
            this.dataGridViewSearchResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSearchResult.RowHeadersVisible = false;
            this.dataGridViewSearchResult.RowTemplate.Height = 30;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(735, 306);
            this.dataGridViewSearchResult.TabIndex = 16;
            this.dataGridViewSearchResult.DoubleClick += new System.EventHandler(this.DataGridViewSearchResult_DoubleClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(676, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(33, 33);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelYoutube
            // 
            this.labelYoutube.AutoSize = true;
            this.labelYoutube.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelYoutube.Location = new System.Drawing.Point(41, 17);
            this.labelYoutube.Name = "labelYoutube";
            this.labelYoutube.Size = new System.Drawing.Size(84, 25);
            this.labelYoutube.TabIndex = 4;
            this.labelYoutube.Text = "YouTube";
            // 
            // textBoxSearchMusic
            // 
            this.textBoxSearchMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchMusic.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchMusic.Location = new System.Drawing.Point(144, 26);
            this.textBoxSearchMusic.Name = "textBoxSearchMusic";
            this.textBoxSearchMusic.Size = new System.Drawing.Size(502, 13);
            this.textBoxSearchMusic.TabIndex = 1;
            this.textBoxSearchMusic.Text = "Enter Keyword";
            this.textBoxSearchMusic.Enter += new System.EventHandler(this.TextBoxSearchMusic_Enter);
            this.textBoxSearchMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchMusic_KeyDown);
            this.textBoxSearchMusic.Leave += new System.EventHandler(this.TextBoxSearchMusic_Leave);
            // 
            // DatagridOnline
            // 
            this.DatagridOnline.ElipseRadius = 5;
            this.DatagridOnline.TargetControl = this.dataGridViewSearchResult;
            // 
            // SearchOffine
            // 
            this.SearchOffine.ElipseRadius = 20;
            this.SearchOffine.TargetControl = this.textBox2;
            // 
            // DatagridOffline
            // 
            this.DatagridOffline.ElipseRadius = 5;
            this.DatagridOffline.TargetControl = this.bunifuCustomDataGrid2;
            // 
            // timerPanelOnline
            // 
            this.timerPanelOnline.Interval = 1;
            this.timerPanelOnline.Tick += new System.EventHandler(this.timerPanelOnline_Tick);
            // 
            // timerPanelOffline
            // 
            this.timerPanelOffline.Interval = 2;
            this.timerPanelOffline.Tick += new System.EventHandler(this.timerPanelOffline_Tick);
            // 
            // timerGreenOffline
            // 
            this.timerGreenOffline.Interval = 1;
            this.timerGreenOffline.Tick += new System.EventHandler(this.timerGreenOffline_Tick);
            // 
            // timerGreenOnline
            // 
            this.timerGreenOnline.Interval = 1;
            this.timerGreenOnline.Tick += new System.EventHandler(this.timerGreenOnline_Tick);
            // 
            // SearchOnline
            // 
            this.SearchOnline.ElipseRadius = 20;
            this.SearchOnline.TargetControl = this.textBoxSearchMusic;
            // 
            // UCDisplayMusicNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "UCDisplayMusicNew";
            this.Size = new System.Drawing.Size(828, 510);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOffline.ResumeLayout(false);
            this.pnlOffline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlOnline.ResumeLayout(false);
            this.pnlOnline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Panel pnlOnline;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Label labelYoutube;
        private System.Windows.Forms.TextBox textBoxSearchMusic;
        private System.Windows.Forms.PictureBox buttonSearch;
        private System.Windows.Forms.Panel pnlOffline;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonQueue;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewSearchResult;
        private Bunifu.Framework.UI.BunifuElipse DatagridOnline;
        private Bunifu.Framework.UI.BunifuElipse SearchOffine;
        private Bunifu.Framework.UI.BunifuElipse DatagridOffline;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Timer timerPanelOnline;
        private System.Windows.Forms.Timer timerPanelOffline;
        private System.Windows.Forms.Timer timerGreenOffline;
        private System.Windows.Forms.Timer timerGreenOnline;
        private Bunifu.Framework.UI.BunifuElipse SearchOnline;
    }
}
