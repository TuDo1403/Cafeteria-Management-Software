namespace CafeteriaManagement.CustomUserControl
{
    partial class UCStaticNew
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChartStatic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridBill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOverview = new System.Windows.Forms.Panel();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.bunifuElipseOverview = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipseSearch = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelCurrentPageIndex = new MaterialSkin.Controls.MaterialLabel();
            this.labelCurrentYear = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPreviousYear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonNextYear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipseDatagrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.panelOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartStatic
            // 
            this.ChartStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartStatic.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 12;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Size = 0F;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Size = 3F;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartStatic.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ChartStatic.Legends.Add(legend1);
            this.ChartStatic.Location = new System.Drawing.Point(228, 50);
            this.ChartStatic.Name = "ChartStatic";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "ChartLine";
            this.ChartStatic.Series.Add(series1);
            this.ChartStatic.Size = new System.Drawing.Size(576, 220);
            this.ChartStatic.TabIndex = 0;
            this.ChartStatic.Text = "chart1";
            // 
            // dataGridBill
            // 
            this.dataGridBill.AllowUserToAddRows = false;
            this.dataGridBill.AllowUserToDeleteRows = false;
            this.dataGridBill.AllowUserToResizeColumns = false;
            this.dataGridBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBill.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBill.ColumnHeadersHeight = 30;
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBill.DoubleBuffered = true;
            this.dataGridBill.EnableHeadersVisualStyles = false;
            this.dataGridBill.GridColor = System.Drawing.Color.White;
            this.dataGridBill.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridBill.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridBill.Location = new System.Drawing.Point(34, 272);
            this.dataGridBill.MultiSelect = false;
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.ReadOnly = true;
            this.dataGridBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBill.RowHeadersVisible = false;
            this.dataGridBill.RowTemplate.Height = 30;
            this.dataGridBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBill.Size = new System.Drawing.Size(761, 185);
            this.dataGridBill.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Overview";
            // 
            // panelOverview
            // 
            this.panelOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.panelOverview.Controls.Add(this.labelTotalIncome);
            this.panelOverview.Controls.Add(this.labelTotalBill);
            this.panelOverview.Controls.Add(this.label2);
            this.panelOverview.Controls.Add(this.label1);
            this.panelOverview.Controls.Add(this.labelDateStart);
            this.panelOverview.Controls.Add(this.label3);
            this.panelOverview.Location = new System.Drawing.Point(34, 50);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(188, 207);
            this.panelOverview.TabIndex = 53;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelTotalIncome.Location = new System.Drawing.Point(23, 171);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(66, 25);
            this.labelTotalIncome.TabIndex = 56;
            this.labelTotalIncome.Text = "$ 1120";
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.AutoSize = true;
            this.labelTotalBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotalBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelTotalBill.Location = new System.Drawing.Point(62, 68);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(72, 25);
            this.labelTotalBill.TabIndex = 55;
            this.labelTotalBill.Text = "97 Bills";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 51);
            this.label2.TabIndex = 54;
            this.label2.Text = "This is the paid amount for\r\ninvoices issue in this year.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Total pay amount:";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDateStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelDateStart.Location = new System.Drawing.Point(14, 45);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(75, 17);
            this.labelDateStart.TabIndex = 9;
            this.labelDateStart.Text = "Total open:";
            // 
            // bunifuElipseOverview
            // 
            this.bunifuElipseOverview.ElipseRadius = 5;
            this.bunifuElipseOverview.TargetControl = this.panelOverview;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(621, 9);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(183, 25);
            this.textBoxSearch.TabIndex = 54;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CafeteriaManagement.Properties.Resources.icons8_search_32;
            this.pictureBox1.Location = new System.Drawing.Point(589, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipseSearch
            // 
            this.bunifuElipseSearch.ElipseRadius = 25;
            this.bunifuElipseSearch.TargetControl = this.textBoxSearch;
            // 
            // buttonNext
            // 
            this.buttonNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.BorderRadius = 2;
            this.buttonNext.ButtonText = "Next";
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.buttonNext.Location = new System.Drawing.Point(715, 469);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonNext.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNext.selected = false;
            this.buttonNext.Size = new System.Drawing.Size(80, 27);
            this.buttonNext.TabIndex = 56;
            this.buttonNext.Text = "Next";
            this.buttonNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNext.Textcolor = System.Drawing.Color.White;
            this.buttonNext.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.BorderRadius = 2;
            this.buttonPrevious.ButtonText = "Previous";
            this.buttonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevious.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.buttonPrevious.Location = new System.Drawing.Point(34, 469);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonPrevious.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPrevious.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPrevious.selected = false;
            this.buttonPrevious.Size = new System.Drawing.Size(80, 27);
            this.buttonPrevious.TabIndex = 59;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrevious.Textcolor = System.Drawing.Color.White;
            this.buttonPrevious.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // labelCurrentPageIndex
            // 
            this.labelCurrentPageIndex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCurrentPageIndex.AutoSize = true;
            this.labelCurrentPageIndex.Depth = 0;
            this.labelCurrentPageIndex.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCurrentPageIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCurrentPageIndex.Location = new System.Drawing.Point(406, 469);
            this.labelCurrentPageIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCurrentPageIndex.Name = "labelCurrentPageIndex";
            this.labelCurrentPageIndex.Size = new System.Drawing.Size(17, 19);
            this.labelCurrentPageIndex.TabIndex = 60;
            this.labelCurrentPageIndex.Text = "1";
            // 
            // labelCurrentYear
            // 
            this.labelCurrentYear.AutoSize = true;
            this.labelCurrentYear.Depth = 0;
            this.labelCurrentYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCurrentYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCurrentYear.Location = new System.Drawing.Point(98, 26);
            this.labelCurrentYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCurrentYear.Name = "labelCurrentYear";
            this.labelCurrentYear.Size = new System.Drawing.Size(41, 19);
            this.labelCurrentYear.TabIndex = 61;
            this.labelCurrentYear.Text = "2019";
            // 
            // buttonPreviousYear
            // 
            this.buttonPreviousYear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPreviousYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonPreviousYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousYear.BorderRadius = 2;
            this.buttonPreviousYear.ButtonText = "<<";
            this.buttonPreviousYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviousYear.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPreviousYear.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPreviousYear.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPreviousYear.Iconimage = null;
            this.buttonPreviousYear.Iconimage_right = null;
            this.buttonPreviousYear.Iconimage_right_Selected = null;
            this.buttonPreviousYear.Iconimage_Selected = null;
            this.buttonPreviousYear.IconMarginLeft = 0;
            this.buttonPreviousYear.IconMarginRight = 0;
            this.buttonPreviousYear.IconRightVisible = true;
            this.buttonPreviousYear.IconRightZoom = 0D;
            this.buttonPreviousYear.IconVisible = true;
            this.buttonPreviousYear.IconZoom = 90D;
            this.buttonPreviousYear.IsTab = false;
            this.buttonPreviousYear.Location = new System.Drawing.Point(42, 28);
            this.buttonPreviousYear.Name = "buttonPreviousYear";
            this.buttonPreviousYear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonPreviousYear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPreviousYear.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPreviousYear.selected = false;
            this.buttonPreviousYear.Size = new System.Drawing.Size(36, 18);
            this.buttonPreviousYear.TabIndex = 62;
            this.buttonPreviousYear.Text = "<<";
            this.buttonPreviousYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPreviousYear.Textcolor = System.Drawing.Color.White;
            this.buttonPreviousYear.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPreviousYear.Click += new System.EventHandler(this.ButtonPreviousYear_Click);
            // 
            // buttonNextYear
            // 
            this.buttonNextYear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonNextYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonNextYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextYear.BorderRadius = 2;
            this.buttonNextYear.ButtonText = ">>";
            this.buttonNextYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextYear.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNextYear.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNextYear.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonNextYear.Iconimage = null;
            this.buttonNextYear.Iconimage_right = null;
            this.buttonNextYear.Iconimage_right_Selected = null;
            this.buttonNextYear.Iconimage_Selected = null;
            this.buttonNextYear.IconMarginLeft = 0;
            this.buttonNextYear.IconMarginRight = 0;
            this.buttonNextYear.IconRightVisible = true;
            this.buttonNextYear.IconRightZoom = 0D;
            this.buttonNextYear.IconVisible = true;
            this.buttonNextYear.IconZoom = 90D;
            this.buttonNextYear.IsTab = false;
            this.buttonNextYear.Location = new System.Drawing.Point(173, 28);
            this.buttonNextYear.Name = "buttonNextYear";
            this.buttonNextYear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonNextYear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonNextYear.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNextYear.selected = false;
            this.buttonNextYear.Size = new System.Drawing.Size(36, 18);
            this.buttonNextYear.TabIndex = 63;
            this.buttonNextYear.Text = ">>";
            this.buttonNextYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNextYear.Textcolor = System.Drawing.Color.White;
            this.buttonNextYear.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNextYear.Click += new System.EventHandler(this.ButtonNextYear_Click);
            // 
            // bunifuElipseDatagrid
            // 
            this.bunifuElipseDatagrid.ElipseRadius = 5;
            this.bunifuElipseDatagrid.TargetControl = this.dataGridBill;
            // 
            // UCStaticNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.buttonNextYear);
            this.Controls.Add(this.buttonPreviousYear);
            this.Controls.Add(this.labelCurrentYear);
            this.Controls.Add(this.labelCurrentPageIndex);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelOverview);
            this.Controls.Add(this.dataGridBill);
            this.Controls.Add(this.ChartStatic);
            this.Name = "UCStaticNew";
            this.Size = new System.Drawing.Size(828, 510);
            ((System.ComponentModel.ISupportInitialize)(this.ChartStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.panelOverview.ResumeLayout(false);
            this.panelOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStatic;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelOverview;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateStart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseOverview;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseSearch;
        private Bunifu.Framework.UI.BunifuFlatButton buttonNext;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPrevious;
        private MaterialSkin.Controls.MaterialLabel labelCurrentPageIndex;
        private MaterialSkin.Controls.MaterialLabel labelCurrentYear;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPreviousYear;
        private Bunifu.Framework.UI.BunifuFlatButton buttonNextYear;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseDatagrid;
    }
}
