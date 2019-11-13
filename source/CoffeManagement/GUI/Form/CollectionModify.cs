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
    public partial class CollectionModify : Form
    {
        public string id;
        public string name;
        public int price;
        public int type;


        public CollectionModify(Product pr)
        {
            InitializeComponent();
            txtId.Text = pr.id;
            txtName.Text = pr.name;
            txtPrice.Text= pr.price+"";
            txtType.Text = pr.type + "";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            id = txtId.Text;
            name = txtName.Text;
            price = int.Parse(txtPrice.Text);
            type = int.Parse(txtType.Text);


        }
    }
}
