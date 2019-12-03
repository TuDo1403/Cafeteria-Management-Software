using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class UCOrderNew : UserControl
    {
        public UCOrderNew()
        {
            InitializeComponent();



            IList<string> items = new List<string>();
            items.Add("Male");
            items.Add("Female");
            items.Add("Other");
            foreach (string item in items)
            {
              //  bunifuDropdown1.Items.addd
            }
            bunifuDropdown1.AddItem("hihi");


        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCOrderNew_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Add(
                new object[]
                {
                    "Coffee",
                    2,
                    "S",
                    20
                }
                );

            bunifuCustomDataGrid1.Rows.Add(
              new object[]
              {
                    "Capuchino",
                    1,
                    "M",
                    10
              }
              );

            bunifuCustomDataGrid1.Rows.Add(
              new object[]
              {
                    "Latte",
                    1,
                    "L",
                   15
              }
              );

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
