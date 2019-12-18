using Bunifu.Framework.UI;
using CM.BLL;
using CM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormMenuNew : Form
    {
        public static event EventHandler<PRODUCT> ProductChosen;
        public static event EventHandler ProductDeleted;
        private bool _isDeleting;
        private int _dialogueResult;



        public FormMenuNew(string typeMenu, bool isDeleting = false)
        {
            InitializeComponent();
            FormAnnouncementNew.DialogueResultReturned += FormAnnouncementNew_DialogueResultReturnedHandler;
            LoadDataFromDatabase(typeMenu);
            _isDeleting = isDeleting;
        }

        private void FormAnnouncementNew_DialogueResultReturnedHandler(object sender, int e)
        {
            _dialogueResult = e;
        }

        private void LoadDataFromDatabase(string typeMenu)
        {
            var menu = DataProvider.RetrieveMenuFrom(typeMenu);
            foreach (var item in menu)
            {
                var button = new BunifuFlatButton { Text = item, Size = new Size(430, 50) };
                button.Click += Button_Click;
                flowLayoutPanelMenu.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (_isDeleting)
            {
                using var result = new FormAnnouncementNew();
                result.ShowMessage("Do you sure you want to delete this product from database?", "Warning", true);
                if (_dialogueResult == 1)
                {
                    DataProcess.DeleteBillBy((sender as BunifuFlatButton).Text);
                    DataProcess.DeleteProduct((sender as BunifuFlatButton).Text);
                    OnProductDeleting();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                EditProduct(sender);
                this.Close();
            }
        }

        private void OnProductDeleting() => (ProductDeleted as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void EditProduct(object sender)
        {
            using var formProductInfo = new FormProductInfNew(DataProvider.GetProductIdFrom((sender as BunifuFlatButton).Text));
            OnProductChoosing((sender as BunifuFlatButton).Text);
            formProductInfo.ShowDialog();
        }

        private void OnProductChoosing(string productName)
        {
            (ProductChosen as EventHandler<PRODUCT>)?.Invoke(this, DataProvider.GetProductInfo(productName));
        }

        private void flowLayoutPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
