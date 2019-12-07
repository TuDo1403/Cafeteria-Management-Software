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
    public partial class FormMainLosed : Form
    {
        public FormMainLosed()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(slideMenu.Width==50)
            {
                slideMenu.Visible = false;
                slideMenu.Width = 200;
                panelAnimater.ShowSync(slideMenu);

            }
            else
            {
                slideMenu.Visible = false;
                slideMenu.Width = 50;
                panelAnimater.ShowSync(slideMenu);
            }
        }
    }
}
