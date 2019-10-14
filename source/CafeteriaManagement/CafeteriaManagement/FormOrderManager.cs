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
            if (textBoxSearchMenu.Text.Length == 0)
            {
                textBoxSearchMenu.Text = "Search";
                textBoxSearchMenu.ForeColor = Color.Gray;
            }
        }

        private void searchBoxStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMusicBox = new FormMusicBox();
            formMusicBox.Show();
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formQueue = FormQueue.CreateInstance();
            formQueue.ShowDialog();
            this.Show();
        }
    }
}
