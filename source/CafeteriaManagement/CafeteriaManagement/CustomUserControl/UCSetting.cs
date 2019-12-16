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

namespace CafeteriaManagement.CustomUserControl
{
    public partial class UCSetting : UserControl
    {
        private ACCOUNT _currentUser;
        private EMPLOYEE _currentEmployee;
        private ACCOUNT_IMAGE _accountImage;
        private Image _image;
        private string _imagePath;

        public UCSetting()
        {
            InitializeComponent();
            FormRegister.LoginSucceeded += FormRegister_LoginSucceededHandler;
            AutoValidate = AutoValidate.Disable;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                EditAccountRecord();
                EditEmployeeRecord();
                EditAccountImageRecord();
                DataProvider.UpdateEmployee(_currentEmployee);
                DataProvider.UpdateAccount(_currentUser);
                DataProvider.UpdateAccountImage(_accountImage);
                MessageBox.Show("Edit Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditAccountImageRecord()
        {
            using var memoryStream = new MemoryStream();
            var currentImage = Image.FromFile(_imagePath);
            currentImage.Save(memoryStream, ImageFormat.Jpeg);
            var bytes = memoryStream.ToArray();
            var binary = new Binary(bytes);
            _accountImage.Img = binary;
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

        private void textBoxCurrentPassword_OnValueChanged(object sender, EventArgs e)
        {
            textBoxCurrentPassword.isPassword = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelChangeImage.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelChangeImage.Visible = false;
        }
    }
}
