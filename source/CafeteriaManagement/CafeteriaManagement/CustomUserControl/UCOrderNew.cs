using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CM.DAL;
using CM.DTO;
using System.Globalization;
using Bunifu.Framework.UI;
using CM.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;
using Font = iTextSharp.text.Font;
using FastMember;

namespace CafeteriaManagement
{
    public partial class UCOrderNew : UserControl
    {
        private string _currentUser;
        public static event EventHandler<ItemChosenEventArgs> ItemChosen;
        public static event EventHandler Billed;

        public UCOrderNew()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FormProductInfNewUpdate.ToppingsSelected += FormTopping_ToppingsSelectedHandler;
            FormRegister.LoginSucceeded += FormLogin_LoginSucceededHandler;
        }

        private void UpdateSelectedItemsDataGrid(Product selectedItem)
        {
            dataGridViewSelectedItems.DataSource = null;
            dataGridViewSelectedItems.DataSource = SelectedList.GetSelectedItems();

            CalculateBill(selectedItem.Price);
        }

        private void CalculateBill(int itemPrice)
        {
            //var currentPrice = Convert.ToDouble(labelTotal.Text.Remove(labelTotal.Text.Length-1, 1), CultureInfo.InvariantCulture);
            //currentPrice += (double)itemPrice / 22000;
            //labelTotal.Text = string.Format(CultureInfo.InvariantCulture, "{0:0.00}", currentPrice) + "$";
            var currentPrice = Convert.ToDouble(labelTotal.Text, CultureInfo.InvariantCulture);
            currentPrice += itemPrice;
            labelTotal.Text = currentPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void FormLogin_LoginSucceededHandler(object sender, string e) => _currentUser = e;

        private void FormTopping_ToppingsSelectedHandler(object sender, List<string> e)
        {
            var selectedItemIndex = dataGridViewSelectedItems.SelectedRows[0].Index;
            foreach (var topping in e)
            {
                var item = DataProvider.RetrieveProductFrom(topping);
                SelectedList.AddTopping(item, selectedItemIndex);
                UpdateSelectedItemsDataGrid(item);
            }
        }

        private void LoadDataFromDatabase()
        {
            var category = DataProvider.RetrieveCategory();
            foreach (var item in category)
            {
                comboBoxCategory.AddItem(item);
            }
            comboBoxCategory.selectedIndex = 0;
        }

        private void ButtonBill_Click(object sender, EventArgs e)
        {
            if (SelectedList.GetSelectedItems().Count > 0)
            {
                var nextBillId = DataProcess.GetNextBillId();
                CreatePDFBill(SelectedList.GetSelectedItems(), labelTotal.Text, nextBillId);
                DataProcess.InsertBillAndBillDetails(SelectedList.GetSelectedItems(), labelTotal.Text, _currentUser);
                RefreshPage();
                OnBilling();
            }
        }

        private void CreatePDFBill(List<Product> list, string text, string nextBillId)
        {
            try
            {
                DataTable dtbl = MakeDataTable(list);
                ExportDataTableToPdf(dtbl, @$"C:\Users\{Environment.UserName}\Documents\{nextBillId}.pdf", nextBillId, text);
                if (checkBoxShowBill.Checked)
                {
                    System.Diagnostics.Process.Start(@$"C:\Users\{Environment.UserName}\Documents\{nextBillId}.pdf");
                    //  this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private DataTable MakeDataTable(List<Product> list)
        {
            var table = new DataTable();
            using (var reader = ObjectReader.Create(list, "Name", "Amount", "Price"))
            {
                table.Load(reader);
            }
            return table;
        }


        private void OnBilling()
        {
            (Billed as EventHandler)?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshPage()
        {
            dataGridViewSelectedItems.DataSource = null;
            labelTotal.Text = Properties.Resources.initialPrice;
            SelectedList.ClearList();
            comboBoxCategory.Clear();
            LoadDataFromDatabase();
            ComboBoxCategory_onItemSelected(this, EventArgs.Empty);
        }



        private void ComboBoxCategory_onItemSelected(object sender, EventArgs e)
        {
            tableLayoutPanelMenu.Controls.Clear();
            foreach (var item in DataProvider.RetrieveMenuFrom(comboBoxCategory.selectedValue))
            {
                var button = new BunifuFlatButton
                {
                    Text = item as string,
                    Size = new Size(130, 49),
                    Activecolor = Color.FromArgb(46, 139, 87),
                    BackColor = Color.FromArgb(55, 71, 79),
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    BorderRadius = 5,
                    DisabledColor = Color.Gray,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))),
                    Iconcolor = System.Drawing.Color.Transparent,
                    Iconimage = null,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))),
                    Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79))))),
                    OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77))))),
                    OnHoverTextColor = System.Drawing.Color.White,
                    Dock = DockStyle.Fill,
                };
                button.Click += Button_Click;
                // flowLayoutPanelMenu.Controls.Add(button);
                tableLayoutPanelMenu.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var selectedItem = DataProvider.RetrieveProductFrom((sender as BunifuFlatButton).Text);
            SelectedList.Add(selectedItem);
            UpdateSelectedItemsDataGrid(selectedItem);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e) => RefreshPage();

        private void DataGridViewSelectedItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void OnItemChoosing(IEnumerable<string> menuTopping, string name)
        {
            (ItemChosen as EventHandler<ItemChosenEventArgs>)?.Invoke(this, new ItemChosenEventArgs(menuTopping, name));
        }

        private void flowLayoutPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewSelectedItems_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedItems.SelectedRows.Count == 1)
            {
                using (var formTopping = new FormProductInfNewUpdate())
                {
                    var index = dataGridViewSelectedItems.SelectedRows[0].Index;
                    var menuTopping = DataProcess.RetrieveMenuToppingFrom(SelectedList.GetSelectedItems()[index].Name);
                    if (menuTopping != null)
                    {
                        OnItemChoosing(menuTopping, dataGridViewSelectedItems.SelectedRows[0].Cells[0].Value as string);
                        formTopping.ShowDialog();
                    }
                };
            }
        }

        private void UCOrderNew_Load(object sender, EventArgs e)
        {

        }


        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader, string totalPrice)
        {
            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A5);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Author : Nguyen Chi Thanh", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);


            Paragraph prgAutho = new Paragraph();
            BaseFont btnAutho = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAutho = new Font(btnAutho, 10, 2, BaseColor.BLACK);
            prgAutho.Alignment = Element.ALIGN_RIGHT;
            prgAutho.Add(new Chunk( "TOTAL: "+totalPrice, fntAutho));

            document.Add(prgAutho);



            document.Close();
            writer.Close();
            fs.Close();
        }

        private void dataGridViewSelectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
