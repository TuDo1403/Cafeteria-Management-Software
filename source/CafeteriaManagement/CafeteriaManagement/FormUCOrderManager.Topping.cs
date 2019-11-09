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
    public partial class FormTopping : Form
    {
        public static event EventHandler<List<string>> ToppingsSelected;
        public FormTopping()
        {
            InitializeComponent();
            UCOrderManager.ItemChosen += UCOrderManager_ItemChosenHandler;
        }

        private void UCOrderManager_ItemChosenHandler(object sender, IEnumerable<string> e)
        {
            foreach (var item in e)
            {
                checkedListBoxTopping.Items.Add(item);
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var selectedToppings = new List<string>();
            foreach (var item in checkedListBoxTopping.CheckedItems)
            {
                selectedToppings.Add(item as string);
            }
            OnToppingsSelecting(selectedToppings);
            this.Close();
        }

        private void OnToppingsSelecting(List<string> selectedToppings) => (ToppingsSelected as EventHandler<List<string>>)?.Invoke(this, selectedToppings);
    }
}
