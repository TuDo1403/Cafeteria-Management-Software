namespace CafeteriaManagement
{
    partial class FormMusicBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelYoutube = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchMusic = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonQueue = new System.Windows.Forms.Button();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControlOnlineLocal = new System.Windows.Forms.TabControl();
            this.tabPageOnline = new System.Windows.Forms.TabPage();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelLocalSearch = new System.Windows.Forms.Label();
            this.textBoxLocalSearch = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonQueue1 = new System.Windows.Forms.Button();
            this.dataGridViewLocalSongs = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControlOnlineLocal.SuspendLayout();
            this.tabPageOnline.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 353);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelYoutube);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.textBoxSearchMusic);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 60);
            this.panel3.TabIndex = 1;
            // 
            // labelYoutube
            // 
            this.labelYoutube.AutoSize = true;
            this.labelYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYoutube.Location = new System.Drawing.Point(10, 21);
            this.labelYoutube.Name = "labelYoutube";
            this.labelYoutube.Size = new System.Drawing.Size(54, 13);
            this.labelYoutube.TabIndex = 2;
            this.labelYoutube.Text = "Youtube";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(464, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchMusic
            // 
            this.textBoxSearchMusic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearchMusic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxSearchMusic.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMusic.Location = new System.Drawing.Point(70, 18);
            this.textBoxSearchMusic.Name = "textBoxSearchMusic";
            this.textBoxSearchMusic.Size = new System.Drawing.Size(368, 20);
            this.textBoxSearchMusic.TabIndex = 0;
            this.textBoxSearchMusic.Text = "Enter Keyword";
            this.textBoxSearchMusic.Enter += new System.EventHandler(this.textBoxSearchMusic_Enter);
            this.textBoxSearchMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchMusic_KeyDown);
            this.textBoxSearchMusic.Leave += new System.EventHandler(this.textBoxSearchMusic_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonQueue);
            this.panel2.Controls.Add(this.dataGridViewSearchResult);
            this.panel2.Location = new System.Drawing.Point(6, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 281);
            this.panel2.TabIndex = 0;
            // 
            // buttonQueue
            // 
            this.buttonQueue.Location = new System.Drawing.Point(464, 244);
            this.buttonQueue.Name = "buttonQueue";
            this.buttonQueue.Size = new System.Drawing.Size(75, 23);
            this.buttonQueue.TabIndex = 3;
            this.buttonQueue.Text = "Queue";
            this.buttonQueue.UseVisualStyleBackColor = true;
            this.buttonQueue.Click += new System.EventHandler(this.buttonQueue_Click);
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(13, 3);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(526, 235);
            this.dataGridViewSearchResult.TabIndex = 0;
            this.dataGridViewSearchResult.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearchResult_RowHeaderMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControlOnlineLocal);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(591, 404);
            this.panel4.TabIndex = 1;
            // 
            // tabControlOnlineLocal
            // 
            this.tabControlOnlineLocal.Controls.Add(this.tabPageOnline);
            this.tabControlOnlineLocal.Controls.Add(this.tabPageLocal);
            this.tabControlOnlineLocal.Location = new System.Drawing.Point(4, 3);
            this.tabControlOnlineLocal.Name = "tabControlOnlineLocal";
            this.tabControlOnlineLocal.SelectedIndex = 0;
            this.tabControlOnlineLocal.Size = new System.Drawing.Size(584, 393);
            this.tabControlOnlineLocal.TabIndex = 1;
            // 
            // tabPageOnline
            // 
            this.tabPageOnline.Controls.Add(this.panel1);
            this.tabPageOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageOnline.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnline.Name = "tabPageOnline";
            this.tabPageOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnline.Size = new System.Drawing.Size(576, 367);
            this.tabPageOnline.TabIndex = 0;
            this.tabPageOnline.Text = "Online";
            this.tabPageOnline.UseVisualStyleBackColor = true;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.panel5);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(576, 367);
            this.tabPageLocal.TabIndex = 1;
            this.tabPageLocal.Text = "Local";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(5, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(566, 353);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelLocalSearch);
            this.panel6.Controls.Add(this.textBoxLocalSearch);
            this.panel6.Location = new System.Drawing.Point(6, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 60);
            this.panel6.TabIndex = 1;
            // 
            // labelLocalSearch
            // 
            this.labelLocalSearch.AutoSize = true;
            this.labelLocalSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalSearch.Location = new System.Drawing.Point(10, 18);
            this.labelLocalSearch.Name = "labelLocalSearch";
            this.labelLocalSearch.Size = new System.Drawing.Size(103, 17);
            this.labelLocalSearch.TabIndex = 1;
            this.labelLocalSearch.Text = "Local Search";
            // 
            // textBoxLocalSearch
            // 
            this.textBoxLocalSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxLocalSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLocalSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLocalSearch.Location = new System.Drawing.Point(119, 17);
            this.textBoxLocalSearch.Name = "textBoxLocalSearch";
            this.textBoxLocalSearch.Size = new System.Drawing.Size(420, 20);
            this.textBoxLocalSearch.TabIndex = 0;
            this.textBoxLocalSearch.Text = "Enter Keyword";
            this.textBoxLocalSearch.Enter += new System.EventHandler(this.textBoxSearchMusic_Enter);
            this.textBoxLocalSearch.Leave += new System.EventHandler(this.textBoxSearchMusic_Leave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonQueue1);
            this.panel7.Controls.Add(this.dataGridViewLocalSongs);
            this.panel7.Location = new System.Drawing.Point(6, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(552, 281);
            this.panel7.TabIndex = 0;
            // 
            // buttonQueue1
            // 
            this.buttonQueue1.Location = new System.Drawing.Point(464, 244);
            this.buttonQueue1.Name = "buttonQueue1";
            this.buttonQueue1.Size = new System.Drawing.Size(75, 23);
            this.buttonQueue1.TabIndex = 3;
            this.buttonQueue1.Text = "Queue";
            this.buttonQueue1.UseVisualStyleBackColor = true;
            this.buttonQueue1.Click += new System.EventHandler(this.buttonQueue_Click);
            // 
            // dataGridViewLocalSongs
            // 
            this.dataGridViewLocalSongs.AllowUserToAddRows = false;
            this.dataGridViewLocalSongs.AllowUserToDeleteRows = false;
            this.dataGridViewLocalSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewLocalSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLocalSongs.Location = new System.Drawing.Point(13, 3);
            this.dataGridViewLocalSongs.Name = "dataGridViewLocalSongs";
            this.dataGridViewLocalSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLocalSongs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLocalSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocalSongs.Size = new System.Drawing.Size(526, 235);
            this.dataGridViewLocalSongs.TabIndex = 0;
            this.dataGridViewLocalSongs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearchResult_RowHeaderMouseDoubleClick);
            // 
            // FormMusicBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 425);
            this.Controls.Add(this.panel4);
            this.Name = "FormMusicBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabControlOnlineLocal.ResumeLayout(false);
            this.tabPageOnline.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchMusic;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.Button buttonQueue;
        private System.Windows.Forms.Label labelYoutube;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControlOnlineLocal;
        private System.Windows.Forms.TabPage tabPageOnline;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxLocalSearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonQueue1;
        private System.Windows.Forms.DataGridView dataGridViewLocalSongs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelLocalSearch;
    }
}