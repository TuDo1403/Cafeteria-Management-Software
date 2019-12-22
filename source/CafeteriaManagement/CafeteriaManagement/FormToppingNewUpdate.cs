using CM.BLL;
using CM.DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormProductInfNewUpdate : Form
    {
        public static event EventHandler<List<string>> ToppingsSelected;

        public FormProductInfNewUpdate()
        {
            InitializeComponent();
            UCOrderNew.ItemChosen += UCOrderNew_ItemChosenHandler;
        }

        private void UCOrderNew_ItemChosenHandler(object sender, ItemChosenEventArgs e)
        {
            foreach (var item in e.Toppings)
            {
                var checkBoxTopping = new MaterialCheckBox();
                checkBoxTopping.Text = item;
                flowLayoutPanelTopping.Controls.Add(checkBoxTopping);
            }
            var checkedToppings = SelectedList.GetSelectedItems().Single(c => c.Name == e.Name).Description;
            //foreach (var control in flowLayoutPanelTopping.Controls)
            //{
            //    if (checkedToppings.Contains((control as MaterialCheckBox).Text))
            //    {
            //        (control as MaterialCheckBox).Checked = true;
            //    }
            //}
        }

        private void FormProductInfNewUpdate_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  this.WindowState = MaximumSize();
            this.Close();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var selectedToppings = new List<string>();
            foreach (var control in flowLayoutPanelTopping.Controls)
            {
                if ((control as MaterialCheckBox).Checked)
                {
                    selectedToppings.Add((control as MaterialCheckBox).Text);
                }
                
            }
            OnToppingsSelecting(selectedToppings);
            this.Close();
        }

        private void OnToppingsSelecting(List<string> selectedToppings) => (ToppingsSelected as EventHandler<List<string>>)?.Invoke(this, selectedToppings);

        private void flowLayoutPanelTopping_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
