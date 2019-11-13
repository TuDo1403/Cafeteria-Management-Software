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
    public partial class OrderManagerTopping : Form
    {
        public string size ;
        public int number = -1;

        public OrderManagerTopping(Product temp)
        {
            InitializeComponent();
            lblNameProduct.Text = temp.name;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderManagerTopping_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;


            number = int.Parse(txtNumber.Text);
            if (rdoSizeS.Checked)
                size = "S";
            else if (rdoSizeM.Checked)
                size = "M";
            else if (rdoSizeL.Checked)
                size = "L";



        }
    }
}
