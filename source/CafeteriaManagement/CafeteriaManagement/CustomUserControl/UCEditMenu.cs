using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CM.DAL;

namespace CafeteriaManagement
{
    public partial class UCEditMenu : UserControl
    {
        public static event EventHandler<PRODUCT> ProductChosen;
        public UCEditMenu()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FormProductInfo.ProductUpdated += FormProductInfo_ProductUpdatedHandler;
        }

        private void LoadDataFromDatabase()
        {
            comboBoxCatetory.DataSource = DataProvider.RetrieveCategory();
        }

        private void FormProductInfo_ProductUpdatedHandler(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void ComboBoxCatetory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuListView.Clear();
            foreach (var item in DataProvider.RetrieveMenuFrom(comboBoxCatetory.SelectedItem as string))
            {
                menuListView.Items.Add(item);
            }
        }

        private void TextBoxSearchMenu_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchMenu.Text == "Search")
            {
                textBoxSearchMenu.Text = "";
                textBoxSearchMenu.ForeColor = Color.Black;
            }
        }

        private void TextBoxSearchMenu_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMenu.Text.Length == 0)
            {
                textBoxSearchMenu.Text = Properties.Resources.textBoxSearchMenuText;
                textBoxSearchMenu.ForeColor = Color.Gray;
            }
        }

        private void MenuListView_DoubleClick(object sender, EventArgs e)
        {
            if (menuListView.SelectedItems.Count == 1)
            {
                using var formProductInfo = new FormProductInfo();
                var productName = menuListView.SelectedItems[0].Text;
                OnProductChoosing(DataProvider.GetProductInfo(productName));
                formProductInfo.ShowDialog();
            }
        }

        private void OnProductChoosing(PRODUCT product)
        {
            (ProductChosen as EventHandler<PRODUCT>)?.Invoke(this, product);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            using var formProductInfo = new FormProductInfo(DataProcess.GetNextProductId(), true);
            formProductInfo.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (menuListView.SelectedItems.Count == 1)
            {
                DataProcess.DeleteProduct(menuListView.SelectedItems[0].Text);
                LoadDataFromDatabase();
            }
        }
    }
}
