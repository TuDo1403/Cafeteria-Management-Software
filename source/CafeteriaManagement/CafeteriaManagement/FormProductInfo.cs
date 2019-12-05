using BLL;
using CM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormProductInfo : Form
    {

        public static event EventHandler ProductUpdated;


        public FormProductInfo(string initialProductId = "", bool isAdding = false)
        {
            InitializeComponent();
            textBoxId.Text = initialProductId;
            if (isAdding)
            {
                buttonAdd.BringToFront();
            }
            else
            {
                buttonEdit.BringToFront();
            }
            UCEditMenuNew.ProductChosen += UCEditMenu_ProductChosenHandler;
            FormMenu.ProductChosen += UCEditMenu_ProductChosenHandler;
            comboBoxProductType.DataSource = DataProvider.RetrieveCategory();
        }

        

        private void UCEditMenu_ProductChosenHandler(object sender, PRODUCT e)
        {
            textBoxId.Text = e.Id;
            textBoxName.Text = e.Name;
            textBoxPrice.Text = ((int)e.Price).ToString(CultureInfo.InvariantCulture);
            comboBoxProductType.SelectedItem = DataProvider.GetProductTypeFrom(e.ProductId);
            richTextBoxDescription.Text = e.Description;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var updatedProduct = new PRODUCT()
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture),
                ProductId = DataProvider.GetProductTypeIDFrom(comboBoxProductType.SelectedItem as string),
                Description = richTextBoxDescription.Text
            };
            DataProvider.UpdateProduct(updatedProduct);
            OnProductUpdating();
            this.Close();
        }

        private void OnProductUpdating() => (ProductUpdated as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addedProduct = new PRODUCT()
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture),
                ProductId = DataProvider.GetProductTypeIDFrom(comboBoxProductType.SelectedItem as string),
                IsTopping = false,
                Description = richTextBoxDescription.Text
            };
            DataProcess.InsertProduct(addedProduct);
            OnProductUpdating();
            this.Close();
        }
    }
}
