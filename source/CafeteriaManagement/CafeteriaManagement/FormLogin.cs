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
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            var isValidAccount = DataProcess.ValidateAccount(textBoxUsername.Text, textBoxPassword.Text);

            if (isValidAccount)
            {
                AccessMainForm(textBoxUsername.Text);
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccessMainForm(string username)
        {
            this.Hide();
            using (var formMain = new FormMainLosed())
            {
                OnLoginSucceeding(username);
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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                e.Cancel = true;
                textBoxUsername.Focus();
                errorProvider.SetError(textBoxUsername, "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxUsername, null);
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                e.Cancel = true;
                textBoxPassword.Focus();
                errorProvider.SetError(textBoxPassword, "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPassword, null);
            }
        }
    }
}
