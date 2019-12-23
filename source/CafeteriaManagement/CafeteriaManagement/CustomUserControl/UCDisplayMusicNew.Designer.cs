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
            this.DatagridOnline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridViewSearchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SearchOffine = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DatagridOffline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerPanelOnline = new System.Windows.Forms.Timer(this.components);
            this.timerPanelOffline = new System.Windows.Forms.Timer(this.components);
            this.timerGreenOffline = new System.Windows.Forms.Timer(this.components);
            this.timerGreenOnline = new System.Windows.Forms.Timer(this.components);
            this.SearchOnline = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlOnline = new System.Windows.Forms.Panel();
            this.textBoxSearchMusic = new System.Windows.Forms.TextBox();
            this.buttonQueue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSearch = new System.Windows.Forms.PictureBox();
            this.labelYoutube = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.pnlGreen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.pnlOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridOnline
            // 
            this.DatagridOnline.ElipseRadius = 5;
            this.DatagridOnline.TargetControl = this.dataGridViewSearchResult;
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridViewSearchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSearchResult.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSearchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearchResult.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchResult.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(735, 308);
            this.dataGridViewSearchResult.TabIndex = 16;
            this.dataGridViewSearchResult.DoubleClick += new System.EventHandler(this.DataGridViewSearchResult_DoubleClick);
            // 
            // SearchOffine
            // 
            this.SearchOffine.ElipseRadius = 20;
            this.SearchOffine.TargetControl = this;
            // 
            // DatagridOffline
            // 
            this.DatagridOffline.ElipseRadius = 5;
            this.DatagridOffline.TargetControl = this;
            // 
            // timerPanelOnline
            // 
            this.timerPanelOnline.Interval = 1;
            this.timerPanelOnline.Tick += new System.EventHandler(this.TimerPanelOnline_Tick);
            // 
            // timerPanelOffline
            // 
            this.timerPanelOffline.Interval = 2;
            this.timerPanelOffline.Tick += new System.EventHandler(this.TimerPanelOffline_Tick);
            // 
            // timerGreenOffline
            // 
            this.timerGreenOffline.Interval = 1;
            this.timerGreenOffline.Tick += new System.EventHandler(this.TimerGreenOffline_Tick);
            // 
            // timerGreenOnline
            // 
            this.timerGreenOnline.Interval = 1;
            this.timerGreenOnline.Tick += new System.EventHandler(this.TimerGreenOnline_Tick);
            // 
            // SearchOnline
            // 
            this.SearchOnline.ElipseRadius = 20;
            this.SearchOnline.TargetControl = this;
            // 
            // pnlOnline
            // 
            this.pnlOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOnline.Controls.Add(this.textBoxSearchMusic);
            this.pnlOnline.Controls.Add(this.buttonQueue);
            this.pnlOnline.Controls.Add(this.dataGridViewSearchResult);
            this.pnlOnline.Controls.Add(this.buttonSearch);
            this.pnlOnline.Controls.Add(this.labelYoutube);
            this.pnlOnline.Location = new System.Drawing.Point(30, 66);
            this.pnlOnline.Name = "pnlOnline";
            this.pnlOnline.Size = new System.Drawing.Size(773, 426);
            this.pnlOnline.TabIndex = 2;
            // 
            // textBoxSearchMusic
            // 
            this.textBoxSearchMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchMusic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearchMusic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearchMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchMusic.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxSearchMusic.Location = new System.Drawing.Point(131, 17);
            this.textBoxSearchMusic.Name = "textBoxSearchMusic";
            this.textBoxSearchMusic.Size = new System.Drawing.Size(510, 25);
            this.textBoxSearchMusic.TabIndex = 18;
            this.textBoxSearchMusic.Text = "Enter Keyword";
            this.textBoxSearchMusic.Enter += new System.EventHandler(this.TextBoxSearchMusic_Enter);
            this.textBoxSearchMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchMusic_KeyDown);
            this.textBoxSearchMusic.Leave += new System.EventHandler(this.TextBoxSearchMusic_Leave);
            // 
            // buttonQueue
            // 
            this.buttonQueue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonQueue.Location = new System.Drawing.Point(667, 385);
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
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::CafeteriaManagement.Properties.Resources.search_48px;
            this.buttonSearch.Location = new System.Drawing.Point(677, 17);
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
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOnline.Location = new System.Drawing.Point(16, 17);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(68, 25);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Online";
            this.lblOnline.Click += new System.EventHandler(this.LblOnline_Click);
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.pnlGreen.Location = new System.Drawing.Point(17, 45);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(69, 3);
            this.pnlGreen.TabIndex = 18;
            // 
            // UCDisplayMusicNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnlOnline);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.lblOnline);
            this.Name = "UCDisplayMusicNew";
            this.Size = new System.Drawing.Size(838, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.pnlOnline.ResumeLayout(false);
            this.pnlOnline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse DatagridOnline;
        private Bunifu.Framework.UI.BunifuElipse SearchOffine;
        private Bunifu.Framework.UI.BunifuElipse DatagridOffline;
        private System.Windows.Forms.Timer timerPanelOnline;
        private System.Windows.Forms.Timer timerPanelOffline;
        private System.Windows.Forms.Timer timerGreenOffline;
        private System.Windows.Forms.Timer timerGreenOnline;
        private Bunifu.Framework.UI.BunifuElipse SearchOnline;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewSearchResult;
        private System.Windows.Forms.Panel pnlOnline;
        private Bunifu.Framework.UI.BunifuFlatButton buttonQueue;
        private System.Windows.Forms.PictureBox buttonSearch;
        private System.Windows.Forms.Label labelYoutube;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.TextBox textBoxSearchMusic;
    }
}
