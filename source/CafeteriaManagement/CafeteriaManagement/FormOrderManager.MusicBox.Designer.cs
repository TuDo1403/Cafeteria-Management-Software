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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchMusic = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.labelYoutube = new System.Windows.Forms.Label();
            this.buttonQueue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 353);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonQueue);
            this.panel3.Controls.Add(this.labelYoutube);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.textBoxSearchMusic);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 60);
            this.panel3.TabIndex = 1;
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
            this.textBoxSearchMusic.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSearchMusic.Location = new System.Drawing.Point(70, 18);
            this.textBoxSearchMusic.Name = "textBoxSearchMusic";
            this.textBoxSearchMusic.Size = new System.Drawing.Size(368, 20);
            this.textBoxSearchMusic.TabIndex = 0;
            this.textBoxSearchMusic.Text = "Search";
            this.textBoxSearchMusic.Enter += new System.EventHandler(this.textBoxSearchMusic_Enter);
            this.textBoxSearchMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchMusic_KeyDown);
            this.textBoxSearchMusic.Leave += new System.EventHandler(this.textBoxSearchMusic_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBarDownload);
            this.panel2.Controls.Add(this.dataGridViewSearchResult);
            this.panel2.Location = new System.Drawing.Point(6, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 281);
            this.panel2.TabIndex = 0;
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(13, 232);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(128, 23);
            this.progressBarDownload.TabIndex = 1;
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(13, 3);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(626, 213);
            this.dataGridViewSearchResult.TabIndex = 0;
            this.dataGridViewSearchResult.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearchResult_RowHeaderMouseDoubleClick);
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
            // buttonQueue
            // 
            this.buttonQueue.Location = new System.Drawing.Point(564, 16);
            this.buttonQueue.Name = "buttonQueue";
            this.buttonQueue.Size = new System.Drawing.Size(75, 23);
            this.buttonQueue.TabIndex = 3;
            this.buttonQueue.Text = "Queue";
            this.buttonQueue.UseVisualStyleBackColor = true;
            // 
            // FormMusicBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 381);
            this.Controls.Add(this.panel1);
            this.Name = "FormMusicBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMusicBox";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchMusic;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Button buttonQueue;
        private System.Windows.Forms.Label labelYoutube;
    }
}