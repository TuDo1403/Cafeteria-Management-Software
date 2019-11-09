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
using CM.DTO;
using System.Globalization;

namespace CafeteriaManagement
{
    public partial class UCOrderManager : UserControl
    {
        private readonly List<Product> _selectedProducts = new List<Product>();

        public static event EventHandler<IEnumerable<string>> ItemChosen;



        public UCOrderManager()
        {
            InitializeComponent();
            comboBoxCatetory.DataSource = DataProcess.RetrieveCategory();
            FormTopping.ToppingsSelected += FormTopping_ToppingsSelectedHandler;
        }

        private void FormTopping_ToppingsSelectedHandler(object sender, List<string> e)
        {
            foreach (var topping in e)
            {
                var item = DataProcess.RetrieveProductFrom(topping);
                _selectedProducts.Add(item);
                UpdateSelectedItemsDataGrid(item);
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

        private void ComboBoxCatetory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuListView.Clear();
            foreach (var item in DataProcess.RetrieveMenuFrom(comboBoxCatetory.SelectedItem as string))
            {
                menuListView.Items.Add(item);
            }
        }

        private void MenuListView_DoubleClick(object sender, EventArgs e)
        {
            if (menuListView.SelectedItems.Count == 1)
            {
                var selectedItem = DataProcess.RetrieveProductFrom(menuListView.SelectedItems[0].Text);
                _selectedProducts.Add(selectedItem);
                UpdateSelectedItemsDataGrid(selectedItem);
            }
        }

        private void UpdateSelectedItemsDataGrid(Product selectedItem)
        {
            dataGridViewSelectedItems.DataSource = null;
            dataGridViewSelectedItems.DataSource = _selectedProducts;

            CalculateBill(selectedItem.Price);
        }

        private void CalculateBill(int itemPrice)
        {
            var currentPrice = Convert.ToInt32(labelSum.Text, CultureInfo.InvariantCulture);
            currentPrice += itemPrice;
            labelSum.Text = currentPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void DataGridViewSelectedItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var formTopping = new FormTopping())
            {
                var menuTopping = DataProcess.RetrieveMenuToppingFrom(_selectedProducts[e.RowIndex].Name);
                OnItemChoosing(menuTopping);
                formTopping.ShowDialog();
            };
        }

        private void OnItemChoosing(IEnumerable<string> menuTopping) => (ItemChosen as EventHandler<IEnumerable<string>>)?.Invoke(this, menuTopping);

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedItems.DataSource = null;
            labelSum.Text = Properties.Resources.initialPrice;
        }
    }
}
