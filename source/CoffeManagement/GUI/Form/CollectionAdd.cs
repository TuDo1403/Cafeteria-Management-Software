using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeManagement
{
    public partial class CollectionAdd : Form
    {
        public string id ;
        public string name;
        public string price;
        public int type;
        public int intprice;

        public CollectionAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            id = txtId.Text;
            name = txtName.Text;
            price = txtPrice.Text;
            type = int.Parse(txtType.Text);
            intprice = int.Parse(txtPrice.Text);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CollectionAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
