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
    public partial class FormOrderManager : Form
    {
        public FormOrderManager()
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

        private void textBoxSearchMenu_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMenu.Text == "")
            {
                textBoxSearchMenu.Text = "Search";
                textBoxSearchMenu.ForeColor = Color.Gray;
            }
        }

        private void addToQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMusicBox = new FormMusicBox();
            //this.Hide();
            formMusicBox.Show();
            //this.Show();
        }
    }
}
