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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ucEditMenu1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           // ucOrderManager.BringToFront();
            paymentUserControl1.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           // ucEditMenu.BringToFront();
            collectionUserControl1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ucEmployee.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
