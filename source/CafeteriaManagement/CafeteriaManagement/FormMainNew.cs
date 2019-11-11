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
    public partial class FormMainNew : Form
    {
        public FormMainNew()
        {
            InitializeComponent();
        }

      

     

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ucOrderManager.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ucEditMenu.BringToFront();
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            ucMusicDownloader1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ucEmployee.BringToFront();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {

        }
    }
}
