using BLL;
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
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public static event EventHandler<string> LoginSucceeded;

        public FormLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkin.MaterialSkinManager.Instance.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            MaterialSkin.MaterialSkinManager.Instance.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Amber700, MaterialSkin.TextShade.WHITE);
        }


        private void LabelRegister_Click(object sender, EventArgs e)
        {
            using var formSignUp = new FormSignUp();
            formSignUp.ShowDialog();
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
            {
                textBoxUsername.Text = Properties.Resources.textBoxUsername;
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var id = DataProcess.GetAccountId(textBoxUsername.Text, textBoxPassword.Text);

            if (!string.IsNullOrEmpty(id))
            {
                AccessMainForm(id);
            }
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

        private void OnLoginSucceeding(string id) => (LoginSucceeded as EventHandler<string>)?.Invoke(this, id);

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = Properties.Resources.textBoxPassword;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void LabelLostPass_Click(object sender, EventArgs e)
        {

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
