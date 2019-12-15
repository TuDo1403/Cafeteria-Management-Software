using CafeteriaManagement;
using Bunifu.Framework.UI;
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
using CM.BLL;

namespace CafeteriaManagement
{
    public partial class FormProductInfNew : Form
    {
        public static event EventHandler ProductUpdated;

        public FormProductInfNew(string initialProductId = "", bool isAdding = false)
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
            foreach (var item in DataProvider.RetrieveCategory())
            {
                comboBoxProductType.AddItem(item);
            }
            UCEditMenuNew.ProductChosen += UCEditMenu_ProductChosenHandler;
            FormMenuNew.ProductChosen += UCEditMenu_ProductChosenHandler;
        }

        private void UCEditMenu_ProductChosenHandler(object sender, PRODUCT e)
        {
            textBoxId.Text = e.Id;
            textBoxName.Text = e.Name;
            textBoxPrice.Text = ((int)e.Price).ToString(CultureInfo.InvariantCulture);
            comboBoxProductType.selectedIndex = DataProvider.RetrieveCategory().IndexOf(DataProvider.GetProductTypeFrom(e.ProductId));
            richTextBoxDescription.Text = e.Description;
        }

        private void FormProductInfNew_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  this.WindowState = MaximumSize();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            var addedProduct = new PRODUCT()
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture),
                ProductId = DataProvider.GetProductTypeIDFrom(comboBoxProductType.selectedValue),
                IsTopping = false,
                Description = richTextBoxDescription.Text
            };
            DataProcess.InsertProduct(addedProduct);
            OnProductUpdating();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            var updatedProduct = new PRODUCT()
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture),
                ProductId = DataProvider.GetProductTypeIDFrom(comboBoxProductType.selectedValue),
                Description = richTextBoxDescription.Text
            };
            DataProvider.UpdateProduct(updatedProduct);
            OnProductUpdating();
            this.Close();
        }

        private void OnProductUpdating() => (ProductUpdated as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as BunifuMaterialTextbox).Text))
            {
                e.Cancel = true;
                errorProvider.SetError(sender as BunifuMaterialTextbox, "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(sender as BunifuMaterialTextbox, null);
            }
        }

        private void comboBoxProductType_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxProductType.selectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(comboBoxProductType, "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxProductType, null);
            }
        }
    }
}
