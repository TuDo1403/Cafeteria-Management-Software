using CM.BLL;
using CM.DAL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormRegister : Form
    {
        public static event EventHandler<string> LoginSucceeded;

        public FormRegister()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            SetRegisterControlsStatus(false);
        }

        private void SetRegisterControlsStatus(bool state)
        {
            textBoxRegisterPassword.Enabled = state;
            textBoxRegisterUsername.Enabled = state;
            textBoxReenterPassword.Enabled = state;
            textBoxCode.Enabled = state;

            textBoxRegisterPassword.Text = "";
            textBoxRegisterUsername.Text = "";
            textBoxReenterPassword.Text = "";
            textBoxCode.Text = "";

            textBoxUsername_Leave(textBoxRegisterUsername, EventArgs.Empty);
            textBoxPassword_Leave(textBoxRegisterPassword, EventArgs.Empty);
            textBoxReenterPassword_Leave(textBoxReenterPassword, EventArgs.Empty);
            TextBoxCode_Leave(textBoxCode, EventArgs.Empty);

            errorProvider.Clear();
        }

        private void TestRegisterForm_Load(object sender, EventArgs e)
        {
            //bunifuFormFadeTransitionFormRegister.ShowAsyc(this);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (panelSignIn.Left >= 320)
                timerSignIn.Start();
            else
                timerRegister.Start();
            SetRegisterControlsStatus(!textBoxRegisterUsername.Enabled);
            SetSignInControlsStatus(!textBoxUsername.Enabled);
        }

        private void SetSignInControlsStatus(bool state)
        {
            textBoxUsername.Enabled = state;
            textBoxPassword.Enabled = state;

            textBoxUsername.Text = "";
            textBoxPassword.Text = "";

            textBoxUsername_Leave(textBoxUsername, EventArgs.Empty);
            textBoxPassword_Leave(textBoxPassword, EventArgs.Empty);

            errorProvider.Clear();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSignIn_Tick(object sender, EventArgs e)
        {
            if (panelRegister.Left > 320)
            {
                panelRegister.Left -= 10;
                panelSignIn.Left -= 10;
            }
            else
                timerSignIn.Stop();
        }

        private void timerRegister_Tick(object sender, EventArgs e)
        {
            if (panelSignIn.Left < 320)
            {
                panelRegister.Left += 10;
                panelSignIn.Left += 10;
            }
            else
                timerRegister.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Username")
            {
                (sender as TextBox).Text = "";
                (sender as TextBox).ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                (sender as TextBox).Text = Properties.Resources.textBoxUsername;
                (sender as TextBox).ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Password")
            {
                (sender as TextBox).Text = "";
                (sender as TextBox).UseSystemPasswordChar = true;
                (sender as TextBox).ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                (sender as TextBox).UseSystemPasswordChar = false;
                (sender as TextBox).Text = Properties.Resources.textBoxPassword;
                (sender as TextBox).ForeColor = Color.Gray;
            }
        }

        private void textBoxReenterPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxReenterPassword.Text == "Re-enter Password")
            {
                textBoxReenterPassword.Text = "";
                textBoxReenterPassword.UseSystemPasswordChar = true;
                textBoxReenterPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxReenterPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxReenterPassword.Text.Length == 0)
            {
                textBoxReenterPassword.UseSystemPasswordChar = false;
                textBoxReenterPassword.Text = Properties.Resources.textBoxReEnterPassword;
                textBoxReenterPassword.ForeColor = Color.Gray;
            }
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            textBoxUsername.CausesValidation = true;
            textBoxPassword.CausesValidation = true;
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            var accountId = DataProcess.ValidateAccount(textBoxUsername.Text, textBoxPassword.Text);

            if (!string.IsNullOrEmpty(accountId))
            {
                AccessMainForm(accountId);
            }
            else
            {
                using var result = new FormAnnouncementNew();
                result.ShowMessage("Wrong username or password!", "Error!", false);
            }
        }

        private void AccessMainForm(string accountId)
        {
            this.Hide();
            
            using (var formMain = new FormMainLosed())
            {
                OnLoginSucceeding(accountId);
                TestCheckMark.showDialog("Login Successfully");
                formMain.ShowDialog();
            }
            this.Show();
        }

        private void OnLoginSucceeding(string id) => (LoginSucceeded as EventHandler<string>)?.Invoke(this, id);


        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            textBoxRegisterUsername.CausesValidation = true;
            textBoxRegisterPassword.CausesValidation = true;
            textBoxCode.CausesValidation = true;
            textBoxReenterPassword.CausesValidation = true;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            DataProcess.RegisterUser(textBoxRegisterUsername.Text, textBoxRegisterPassword.Text, textBoxCode.Text);
            // MessageBox.Show("Register sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TestCheckMark.showDialog("Register successfully");
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextBox).Text == "Username")
            {
                e.Cancel = true;
                errorProvider.SetError((sender as TextBox), "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError((sender as TextBox), null);
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextBox).Text == "Password")
            {
                e.Cancel = true;
                errorProvider.SetError((sender as TextBox), "Cannot left this empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError((sender as TextBox), null);
            }
        }



        private void textBoxReenterPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxReenterPassword.Text == "Re-enter Password")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxReenterPassword, "Cannot left this empty!");
            }
            else if (textBoxReenterPassword.Text != textBoxRegisterPassword.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxReenterPassword, "Not match password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxReenterPassword, null);
            }
        }

        private void TextBoxCode_Enter(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "Code")
            {
                textBoxCode.Text = "";
                textBoxCode.ForeColor = Color.Black;
            }
        }

        private void TextBoxCode_Leave(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length == 0)
            {
                textBoxCode.Text = Properties.Resources.textBoxCode;
                textBoxCode.ForeColor = Color.Gray;
            }
        }

        private void TextBoxCode_Validating(object sender, CancelEventArgs e)
        {
            if (!DataProcess.ValidateEmployeeId(textBoxCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxCode, "Code invalid!");
            }
            else if (DataProcess.CheckExistedAccount(textBoxCode.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxCode, "Account existed!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxCode, null);
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSignIn_Click(sender, e);
            }
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {

            if (panelSignIn.Left >= 320)
            {
                timerSignIn.Start();
                btnKichHoat.Text = "Log In";
                btnKichHoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            }
            else
            {
                timerRegister.Start();
                btnKichHoat.Text = "Register";
                btnKichHoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            }
            SetRegisterControlsStatus(!textBoxRegisterUsername.Enabled);
            SetSignInControlsStatus(!textBoxUsername.Enabled);
           
       }
    }
}
