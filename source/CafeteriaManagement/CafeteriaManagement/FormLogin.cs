using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();
        public static event EventHandler<string> LoginSucceeded;

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var id = DataProcess.GetAccountId(textBoxUsername.Text, textBoxPassword.Text);
            
            if (!string.IsNullOrEmpty(id))
            {
                AccessMainForm(id);
            }
        }

        private void OnLoginSucceeding(string id)
        {
            (LoginSucceeded as EventHandler<string>)?.Invoke(this, id);
        }

        private void AccessMainForm(string id)
        {
            this.Hide();
            using (var formMain = new FormMain())
            {
                OnLoginSucceeding(id);
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

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogin_Click(sender, e);
            }
        }
    }
}
