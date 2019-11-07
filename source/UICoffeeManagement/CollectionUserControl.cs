using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICoffeeManagement
{
    public partial class CollectionUserControl : UserControl
    {
        static List<CateGory> lsCateGory = new List<CateGory>();

        public CollectionUserControl()
        {
            InitializeComponent();


            CateGory temp1 = new CateGory();
            temp1.name = "Drinking";
            CateGory temp2 = new CateGory();
            temp2.name = "Desert";
            CateGory temp3 = new CateGory();
            temp3.name = "Items";

            lsCateGory.Add(temp1);
            lsCateGory.Add(temp2);
            lsCateGory.Add(temp3);

            foreach (CateGory temp in lsCateGory)
            {
                cbmListItems.Items.Add(temp);
            }

        }

        static int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            // Random rd = new Random();
            lbl.Text = count + " ";
            lbl.Width = 180;
            lbl.Height =100;
            lbl.BackColor = System.Drawing.Color.LightGray;
               //  this.label1.BackColor = System.Drawing.Color.LightGray;
            flpProduct.Controls.Add(lbl);
            // btn.Click += Btn_Click;

            count++;
            if (count == 4)
            {
                flpProduct.AutoScroll = true;
            }
        }
    }
}
