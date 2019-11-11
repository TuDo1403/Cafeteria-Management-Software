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
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formMain = new FormMainNew())
            {
                formMain.ShowDialog();
            }
            this.Show();
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username or Phone")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
            {
                textBoxUsername.Text = Properties.Resources.textBoxText;
                textBoxUsername.ForeColor = Color.Gray;
            }
        }
    }
}
