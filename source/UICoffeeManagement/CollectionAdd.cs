using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICoffeeManagement
{
    public partial class CollectionAdd : Form
    {
        public string id ;
        public string name;
        public string price;

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
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
