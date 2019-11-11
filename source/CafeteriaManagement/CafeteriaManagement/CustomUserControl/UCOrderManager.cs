using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CafeteriaManagement
{
    public partial class UCOrderManager : UserControl
    {



        public static List<Bill> lsBill = new List<Bill>();
        public static List<Product> lsproducts = new List<Product>();
        public static string nhan;


        public UCOrderManager()
        {
            InitializeComponent();
        }


        private void textBoxSearchMenu_Enter(object sender, EventArgs e)
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

        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
