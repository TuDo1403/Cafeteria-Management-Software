using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CM.DAL;
using CM.BLL;

namespace CafeteriaManagement
{
    public partial class UCEditMenuNew : UserControl
    {
        public static event EventHandler<PRODUCT> ProductChosen;



        public UCEditMenuNew()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FormProductInfNew.ProductUpdated += FormProductInfo_ProductUpdatedHandler;
            FormMenuNew.ProductDeleted += FormProductInfo_ProductUpdatedHandler;
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

        private void FormProductInfo_ProductUpdatedHandler(object sender, EventArgs e)
        {
            var menu = DataProvider.RetrieveMenuFrom(comboBoxCategory.selectedValue);
            var products = new List<PRODUCT>();
            foreach (var item in menu)
            {
                var product = DataProvider.GetProductInfo(item);
                products.Add(product);
            }
            dataGridViewMenu.DataSource = null;
            dataGridViewMenu.DataSource = products;
            dataGridViewMenu.Columns[6].Visible = false;
            dataGridViewMenu.Columns[2].Visible = false;
            dataGridViewMenu.Columns[5].Visible = false;
        }

        private void UCEditMenuNew_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            using var formMenu = new FormMenuNew(comboBoxCategory.selectedValue);
            formMenu.ShowDialog();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using var formProductInfo = new FormProductInfNew(DataProcess.GetNextProductId(), true);
            formProductInfo.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            using var formMenu = new FormMenuNew(comboBoxCategory.selectedValue, true);
            formMenu.ShowDialog();
        }

        private void ComboBoxCategory_onItemSelected(object sender, EventArgs e)
        {
            var menu = DataProvider.RetrieveMenuFrom(comboBoxCategory.selectedValue);
            var products = new List<PRODUCT>();
            foreach (var item in menu)
            {
                var product = DataProvider.GetProductInfo(item);
                products.Add(product);
            }
            dataGridViewMenu.DataSource = null;
            dataGridViewMenu.DataSource = products;
            dataGridViewMenu.Columns[6].Visible = false;
            dataGridViewMenu.Columns[2].Visible = false;
            dataGridViewMenu.Columns[5].Visible = false;
        }




        private void DataGridViewMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewMenu.DataSource = DataProvider.RetrieveMenuFrom(comboBoxCategory.selectedValue);
        }

        private void DataGridViewMenu_Click(object sender, EventArgs e)
        {
            using var formProductInfo = new FormProductInfNew();
            var productName = dataGridViewMenu.SelectedRows[0].Cells[1].Value.ToString();
            OnProductChoosing(DataProvider.GetProductInfo(productName));
            formProductInfo.ShowDialog();
        }

        private void OnProductChoosing(PRODUCT product) => (ProductChosen as EventHandler<PRODUCT>)?.Invoke(this, product);

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                dataGridViewMenu.DataSource = null;
                dataGridViewMenu.DataSource = DataProcess.GetProductSortedByName(textBoxSearch.Text, comboBoxCategory.selectedValue);
                dataGridViewMenu.Columns[6].Visible = false;
                dataGridViewMenu.Columns[2].Visible = false;
                dataGridViewMenu.Columns[5].Visible = false;
            }
            else
            {
                FormProductInfo_ProductUpdatedHandler(sender, e);
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                FormProductInfo_ProductUpdatedHandler(sender, e);
            }
        }
    }
}
