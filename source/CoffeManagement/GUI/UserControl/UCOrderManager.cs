using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CoffeManagement
{
    public partial class UCOrderManager : UserControl
    {


        List<BillDetails> lsBillDetails = new List<BillDetails>();
        Button Lasted = null;
        int price = 0;

        public UCOrderManager()
        {
            InitializeComponent();
        }


        private void textBoxSearchMenu_Enter(object sender, EventArgs e)
        {
          
        }

        private void TextBoxSearchMenu_Leave(object sender, EventArgs e)
        {
          
        }

        private void ComboBoxCatetory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuLabel_Click(object sender, EventArgs e)
        {

        }

        private void UCOrderManager_Load(object sender, EventArgs e)
        {
            ProductBLL dspr = new ProductBLL();
            List<Product> lspr = dspr.TakeAllProductBLL();
            flProduct.Controls.Clear();

            foreach (Product pr in lspr)
            {
                Button lbl = new Button();
                // Random rd = new Random();
                lbl.Text = pr.ToString();
                lbl.Width = 130;
                lbl.Height = 70;
                lbl.BackColor = System.Drawing.Color.LightGray;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                // lbl.ImageIndex = count++;
                lbl.MouseMove += Btn_Move;
                lbl.MouseLeave += Btn_leave;
                lbl.MouseClick += Btn_Click;
                lbl.Tag = pr;


                // this.label1.BackColor = System.Drawing.Color.LightGray;
                flProduct.Controls.Add(lbl);
                // btn.Click += Btn_Click;
            }


        }

        private void Btn_leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.LightGray;

        }

        private void Btn_Move(object sender, EventArgs e)
        {

            //object sender là cái control mà chúng ta nhấn vào,ở đây là button
            // EventArgs e là các sự kiện tác động lên nó như mouse click, mouse up,...
            if (Lasted != null)
            {
                Lasted.BackColor = System.Drawing.Color.LightGray;
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Pink;
            Lasted = btn;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            

            Button btn = sender as Button;

            Product pr = btn.Tag as Product;
            price = pr.price;

            OrderManagerTopping f = new OrderManagerTopping(pr);

          
            if (f.ShowDialog() == DialogResult.OK)
            {
                BillDetails temp = new BillDetails();
                temp.idBill = "0001";
                temp.idProduct = pr.id;
                temp.name = pr.name;
                temp.size = f.size;
                temp.number = f.number;
                temp.priceThisProduct = pr.price;
                

                lsBillDetails.Add(temp);
                ShowDetails(lsBillDetails);





            }
        }
       
        public void ShowDetails(List<BillDetails> lsBillDetails)
        {
            lvDetails.Items.Clear();
            int total = 0;
            foreach (BillDetails bd in lsBillDetails)
            {
                ListViewItem lvi = new ListViewItem(bd.name);
                lvi.SubItems.Add(bd.number+"");
                lvi.SubItems.Add(bd.size + "");
                lvi.SubItems.Add(bd.sum()+ "");
                total += bd.sum();
                lvDetails.Items.Add(lvi);

            }
            txtTotal.Text = total + "";
        }

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            lsBillDetails.Clear();
            ShowDetails(lsBillDetails);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillDetailsBLL bdbll = new BillDetailsBLL();

            foreach (BillDetails bd in lsBillDetails)
            {
                bdbll.AddProduct(bd);

            }
            lsBillDetails.Clear();
            ShowDetails(lsBillDetails);
        }
    }
}
