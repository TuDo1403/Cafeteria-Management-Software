using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CM.DAL;
using System.Globalization;
using CM.BLL;

namespace CafeteriaManagement
{
    public partial class UCEmployeeNew : UserControl
    {
        private int _clickCount = 0;
        private EMPLOYEE _employee;
        private readonly List<BunifuFlatButton> _buttons = new List<BunifuFlatButton>();
        private string _employeeId;
        private string _buttonName;
        private int _dialogueResult;



        public UCEmployeeNew()
        {
            InitializeComponent();
            FormAnnouncementNew.DialogueResultReturned += FormAnnouncementNew_DialogueResultReturnedHandler;
            dataGridViewEmployeeList.DataSource = DataProcess.GetEMPLOYEEs();

            _buttons.Add(buttonAdd);
            _buttons.Add(buttonEdit);
            _buttons.Add(buttonDelete);

            LoadEmployeeToControl();

            textBoxPhone.Validating += TextBoxPhone_ValidatingHandler;
            textBoxEmail.Validating += TextBoxEmail_ValidatingHandler;
            textBoxName.Validating += TextBoxName_ValidatingHandler;
        }

        private void FormAnnouncementNew_DialogueResultReturnedHandler(object sender, int e)
        {
            _dialogueResult = e;
        }

        private void TextBoxName_ValidatingHandler(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (!textBoxName.Text.IsValidName())
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxName, "Wrong name format!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBoxName, null);
                }
            }
        }

        private void TextBoxEmail_ValidatingHandler(object sender, CancelEventArgs e)
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

        private void TextBoxPhone_ValidatingHandler(object sender, CancelEventArgs e)
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

        private void LoadEmployeeToControl()
        {
            if (DataProvider.GetEMPLOYEEs().Any(c => true))
            {
                var currentEmployee = DataProvider.GetEMPLOYEEs().ToList()[0] as EMPLOYEE;
                _employeeId = currentEmployee.Id;
                textBoxName.Text = currentEmployee.Name;
                datePickerBirthday.Value = (DateTime)currentEmployee.Birthday;
                datePickerDateStart.Value = (DateTime)currentEmployee.Daystart;
                textBoxPhone.Text = currentEmployee.PhoneNumber.ToString(CultureInfo.InvariantCulture);
                textBoxEmail.Text = currentEmployee.Email;


                if (currentEmployee.Gender == null)
                {
                    radioButtonNone.Checked = true;
                }
                else if (currentEmployee.Gender == true)
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }
                AlterControls(false);
            }
        }

        private void AlterControls(bool option)
        {
            textBoxName.Enabled = option;
            textBoxPhone.Enabled = option;
            textBoxEmail.Enabled = option;
            datePickerBirthday.Enabled = option;
            datePickerDateStart.Enabled = option;
            radioButtonFemale.Enabled = option;
            radioButtonMale.Enabled = option;
            radioButtonNone.Enabled = option;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _clickCount++;
            if (_clickCount == 1)
            {
                buttonCancel.Enabled = true;
                _buttonName = (sender as BunifuFlatButton).Text;
                (sender as BunifuFlatButton).Text = "Apply";
                SetControls(sender as BunifuFlatButton);

                foreach (var item in _buttons)
                {
                    if (item != (sender as BunifuFlatButton))
                    {
                        item.Enabled = false;
                    }
                }
                textBoxName.Focus();
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    _clickCount = 0;
                    (sender as BunifuFlatButton).Text = _buttonName;
                    _buttonName = "";
                    CreateRecordFromUserInput();
                    ExecuteTask((sender as BunifuFlatButton));
                    RefreshEmployeesList();
                    foreach (var item in _buttons)
                    {
                        if (item != (sender as BunifuFlatButton))
                        {
                            item.Enabled = !item.Enabled;
                        }
                    }
                    buttonCancel.Enabled = false;
                }
            }
        }

        private void RefreshEmployeesList()
        {
            dataGridViewEmployeeList.DataSource = null;
            dataGridViewEmployeeList.DataSource = DataProcess.GetEMPLOYEEs();
            LoadEmployeeToControl();
        }

        private void ExecuteTask(BunifuFlatButton button)
        {
            if (button == buttonAdd)
            {
                DataProvider.InsertRecord(_employee, "EMPLOYEE");
            }
            else if (button == buttonEdit)
            {
                DataProvider.UpdateEmployee(_employee);
            }
            using var result = new FormAnnouncementNew();
            result.ShowMessage($"Employee {button.Name.Remove(0, 6)}ed!", "Success", false);

        }

        private void CreateRecordFromUserInput()
        {
            bool? gender = null;
            if (radioButtonMale.Checked)
            {
                gender = true;
            }
            if (radioButtonFemale.Checked)
            {
                gender = false;
            }
            _employee = new EMPLOYEE()
            {
                Name = textBoxName.Text,
                Birthday = datePickerBirthday.Value,
                Daystart = datePickerDateStart.Value,
                PhoneNumber = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                Gender = gender
            };
            if (buttonAdd.Enabled)
            {
                _employee.Id = DataProcess.GetNextEmployeeId();
            }
            else
            {
                _employee.Id = _employeeId;
            }
        }

        private void SetControls(BunifuFlatButton button)
        {
            if (button == buttonAdd)
            {
                ClearControl();
                AlterControls(true);
            }
            if (button == buttonEdit)
            {
                AlterControls(true);
            }
        }

        private void ClearControl()
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            radioButtonNone.Checked = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            using var result = new FormAnnouncementNew();
            result.ShowMessage("Do you want to delete this record?", "Warning!", true);
            if (_dialogueResult == 1)
            {
                DataProvider.DeleteEmployee(dataGridViewEmployeeList.SelectedRows[0].Cells[0].Value.ToString());
                RefreshEmployeesList();
            }
        }

        private void DataGridViewEmployeeList_Click(object sender, EventArgs e)
        {
            var cells = dataGridViewEmployeeList.SelectedRows[0].Cells;
            _employeeId = cells[0].Value.ToString();
            textBoxName.Text = cells[1].Value.ToString();
            var birthday = cells[2].Value.ToString();
            var dateStart = cells[3].Value.ToString();
            datePickerBirthday.Value = DateTime.Parse(birthday, CultureInfo.InvariantCulture);
            datePickerDateStart.Value = DateTime.Parse(dateStart, CultureInfo.InvariantCulture);
            textBoxPhone.Text = cells[5].Value.ToString();
            textBoxEmail.Text = cells[6].Value.ToString();

            if (cells[4].Value == null)
            {
                radioButtonNone.Checked = true;
            }
            else if (cells[4].Value.ToString() == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (cells[4].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            AlterControls(false);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _clickCount = 0;
            RefreshEmployeesList();
            foreach (var item in _buttons)
            {
                if (item.Enabled == true)
                {
                    item.Text = _buttonName;
                }
                else
                {
                    item.Enabled = true;
                }
            }
            buttonCancel.Enabled = false;
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length != 0)
            {
                textBoxName.Text = textBoxName.Text.Standardlize();
            }
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

        private void LabelBirthDay_Click(object sender, EventArgs e)
        {

        }

        private void DatePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelGender_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonNone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LabelPhone_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPhone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            var cells = dataGridViewEmployeeList.SelectedRows[0].Cells;
            var id = cells[0].Value.ToString();
            Clipboard.SetText(id.GetMD5HashedString());
            using var result = new FormAnnouncementNew();
            result.ShowMessage("Id Code copied to clipboard!", "Information", false);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                dataGridViewEmployeeList.DataSource = null;
                dataGridViewEmployeeList.DataSource = DataProcess.GetEmployeesSortedByName(textBoxSearch.Text);
                LoadEmployeeToControl();
            }
            else
            {
                RefreshEmployeesList();
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                RefreshEmployeesList();
            }
        }

        private void UCEmployeeNew_Load(object sender, EventArgs e)
        {

        }
    }
}
