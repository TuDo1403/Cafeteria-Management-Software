using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM.DAL;
using CM.BLL;
using System.IO;
using System.Data.Linq;
using System.Drawing.Imaging;
using Bunifu.Framework.UI;

namespace CafeteriaManagement.CustomUserControl
{
    public partial class UCSetting : UserControl
    {
        private ACCOUNT _currentUser;
        private EMPLOYEE _currentEmployee;
        private ACCOUNT_IMAGE _accountImage;
        private string _imagePath;


        public UCSetting()
        {
            InitializeComponent();
            foreach (Control control in panelChangePassword.Controls)
            {
                control.Enabled = !control.Enabled;
            }
            FormRegister.LoginSucceeded += FormRegister_LoginSucceededHandler;
            FormMainLosed.PasswordChangeNeeded += FormMainLosed_PasswordChangeNeededHandler;
            FormMainLosed.EditProfileNeeded += FormMainLosed_EditProfileNeededHandler;
            textBoxCurrentPassword.Validating += TextBox_Validating;
            textBoxPasswordCurrent.Validating += TextBoxCurrentPassword_Validating;
            textBoxReenterPassword.Validating += TextBoxReenterPassword_ValidatingHandler;
            textBoxNewPassword.Validating += TextBoxNewPassword_ValidatingHandler;
            AutoValidate = AutoValidate.Disable;
        }

        private void TextBoxNewPassword_ValidatingHandler(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                if (textBoxPasswordCurrent.Text == textBoxNewPassword.Text)
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxNewPassword, "Dupplicate with current password!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBoxNewPassword, null);
                }
            }
            
        }

        private void TextBoxReenterPassword_ValidatingHandler(object sender, CancelEventArgs e)
        {
            if (textBoxNewPassword.Text != textBoxReenterPassword.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxReenterPassword, "Re-enter password not match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxReenterPassword, null);
            }
        }

        private void FormMainLosed_EditProfileNeededHandler(object sender, EventArgs e)
        {
            foreach (Control control in panelChangePassword.Controls)
            {
                control.Enabled = false;
            }
            foreach (Control control in panelEditProfile.Controls)
            {
                control.Enabled = true;
            }
         //   buttonSave.BringToFront();
            panelEditProfile.BringToFront();
        }

        private void FormMainLosed_PasswordChangeNeededHandler(object sender, EventArgs e)
        {
            foreach (Control control in panelEditProfile.Controls)
            {
                control.Enabled = false;
            }
            foreach (Control control in panelChangePassword.Controls)
            {
                control.Enabled = true;
            }
            buttonChangePassword.BringToFront();
            panelChangePassword.BringToFront();
        }

        private void FormRegister_LoginSucceededHandler(object sender, string e)
        {
            _currentUser = DataProvider.GetACCOUNTFrom(e);
            _currentEmployee = DataProvider.GetCurrentEmployee(_currentUser.EmployeeId);
            _accountImage = DataProvider.GetAccountImageBy(_currentUser.Id);
            if (_accountImage != null && _accountImage.Img != null)
            {
                var image = _accountImage.Img.ToArray();
                using var stream = new MemoryStream(image);
                stream.Write(image, image.Length, 0);
                pictureBox1.Image = Image.FromStream(stream);
            }

            textBoxUsername.Text = _currentUser.UserName;
            textBoxPhone.Text = _currentEmployee.PhoneNumber;
            textBoxEmail.Text = _currentEmployee.Email;
            textBoxDisplayName.Text = _currentUser.DisplayName;
            if (_currentEmployee.Gender == null)
            {
                radioButtonNone.Checked = true;
            }
            else if ((bool)_currentEmployee.Gender)
            {
                radioButtonMale.Checked = true;
            }
            else if (!(bool)_currentEmployee.Gender)
            {
                radioButtonFemale.Checked = true;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelChangeImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            InitializeOpenFileDialog(ref openFileDialog);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var imageAddress = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imageAddress);
                _imagePath = imageAddress;
            }
            openFileDialog.Dispose();
        }

        private void InitializeOpenFileDialog(ref OpenFileDialog openFileDialog)
        {
            openFileDialog.Title = "Open Image";
            openFileDialog.InitialDirectory = @"C:\Users";
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
        }

        private void UCSetting_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCurrentPassword.Text.GetMD5HashedString() != _currentUser.PassWord)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxCurrentPassword, "Wrong password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxCurrentPassword, null);
            }
        }

     

        private void EditAccountImageRecord()
        {
            if (_imagePath != null)
            {
                var bytes = File.ReadAllBytes(_imagePath);
                var binary = new Binary(bytes);
                _accountImage.Img = binary;
            }
        }

        private void EditEmployeeRecord()
        {
            _currentEmployee.Email = textBoxEmail.Text;
            _currentEmployee.PhoneNumber = textBoxPhone.Text;
            if (radioButtonFemale.Checked)
            {
                _currentEmployee.Gender = false;
            }
            if (radioButtonMale.Checked)
            {
                _currentEmployee.Gender = true;
            }
            if (radioButtonNone.Checked)
            {
                _currentEmployee.Gender = null;
            }
        }

        private void EditAccountRecord()
        {
            _currentUser.UserName = textBoxUsername.Text;
            _currentUser.DisplayName = textBoxDisplayName.Text;
        }

        private void TextBoxCurrentPassword_OnValueChanged(object sender, EventArgs e)
        {
            (sender as BunifuMaterialTextbox).isPassword = true;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelChangeImage.Visible = true;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelChangeImage.Visible = false;
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as BunifuMaterialTextbox).Text))
            {
                e.Cancel = true;
                errorProvider.SetError(sender as BunifuMaterialTextbox, "Cannot left this empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(sender as BunifuMaterialTextbox, null);
            }
        }

        private void TextBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPhone.Text))
            {
                if (!textBoxPhone.Text.IsValidNumber())
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxPhone, "Wrong phone number format!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBoxPhone, null);
                }
            }
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                if (!textBoxEmail.Text.IsValidEmail())
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxEmail, "Wrong email format!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBoxEmail, null);
                }
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _currentUser.PassWord = textBoxNewPassword.Text;
                DataProvider.UpdateAccount(_currentUser);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                EditAccountRecord();
                EditEmployeeRecord();
                EditAccountImageRecord();
                DataProvider.UpdateEmployee(_currentEmployee);
                DataProvider.UpdateAccount(_currentUser);
                DataProvider.UpdateAccountImage(_accountImage);
                using var result = new FormAnnouncementNew();
                result.ShowMessage("Edit Successfully", "Information", false);
            }
        }
    }
}
