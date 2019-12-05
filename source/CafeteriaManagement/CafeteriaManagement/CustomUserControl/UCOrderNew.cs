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
using CM.DTO;
using System.Globalization;
using Bunifu.Framework.UI;

namespace CafeteriaManagement
{
    public partial class UCOrderNew : UserControl
    {
        private string _currentUser;
        public static event EventHandler<IEnumerable<string>> ItemChosen;

        public UCOrderNew()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FormTopping.ToppingsSelected += FormTopping_ToppingsSelectedHandler;
            FormLogin.LoginSucceeded += FormLogin_LoginSucceededHandler;
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
            throw new NotImplementedException();
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
                DataProcess.InsertBill(SelectedList.GetSelectedItems(), labelSum.Text, _currentUser);
                RefreshPage();
            }
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
            flowLayoutPanelMenu.Controls.Clear();
            foreach (var item in DataProvider.RetrieveMenuFrom(comboBoxCategory.selectedValue as string))
            {
                var button = new BunifuFlatButton { Text = item as string, Size = new Size(120, 50) };
                button.Click += Button_Click;
                flowLayoutPanelMenu.Controls.Add(button);
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
            using (var formTopping = new FormTopping())
            {
                var menuTopping = DataProcess.RetrieveMenuToppingFrom(SelectedList.GetSelectedItems()[e.RowIndex].Name);
                if (menuTopping != null)
                {
                    OnItemChoosing(menuTopping);
                    formTopping.ShowDialog();
                }
            };
        }

        private void OnItemChoosing(IEnumerable<string> menuTopping)
        {
            (ItemChosen as EventHandler<IEnumerable<string>>)?.Invoke(this, menuTopping);
        }
    }
}
