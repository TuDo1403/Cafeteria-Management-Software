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
    public partial class FormSignUp : MaterialSkin.Controls.MaterialForm
    {
        public FormSignUp()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkin.MaterialSkinManager.Instance.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            MaterialSkin.MaterialSkinManager.Instance.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Amber700, MaterialSkin.TextShade.WHITE);
        }

        private void LogIn3_SignIn_Load(object sender, EventArgs e)
        {

        }

        private void Label_Login_Click(object sender, EventArgs e)
        {
            using var formLogin = new FormLogin();
            formLogin.ShowDialog();
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

        private void TextBoxPasswordMatch_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordMatch.Text == "Re-enter Password")
            {
                textBoxPasswordMatch.Text = "";
                textBoxPasswordMatch.UseSystemPasswordChar = true;
                textBoxPasswordMatch.ForeColor = Color.Black;
            }
        }

        private void TextBoxPasswordMatch_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordMatch.Text.Length == 0)
            {
                textBoxPasswordMatch.UseSystemPasswordChar = false;
                textBoxPasswordMatch.Text = Properties.Resources.textBoxReEnterPassword;
                textBoxPasswordMatch.ForeColor = Color.Gray;
            }
        }

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                textBoxEmail.Text = Properties.Resources.textBoxEmail;
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            // some logic
            DataProcess.RegisterUser(textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text);
        }
    }
}
