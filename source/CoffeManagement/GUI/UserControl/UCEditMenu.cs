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
    public partial class UCEditMenu : UserControl
    {
        Button Lasted = null;

        public UCEditMenu()
        {
            InitializeComponent();
        }

        private void UCEditMenu_Load(object sender, EventArgs e)
        {
            LoadButton();
        }

        void LoadButton()
        {
            ProductBLL dspr = new ProductBLL();
            List<Product> lspr = dspr.TakeAllProductBLL();
            flpProduct.Controls.Clear();

            foreach (Product pr in lspr)
            {
                Button lbl = new Button();
                // Random rd = new Random();
                lbl.Text = pr.ToString();
                lbl.Width = 160;
                lbl.Height = 90;
                lbl.BackColor = System.Drawing.Color.LightGray;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                // lbl.ImageIndex = count++;
                lbl.MouseMove += Btn_Click;
                lbl.Tag = pr;


                // this.label1.BackColor = System.Drawing.Color.LightGray;
                flpProduct.Controls.Add(lbl);
                // btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Lasted != null)
            {
                ProductBLL dspr = new ProductBLL();
                Product pr = Lasted.Tag as Product;
                dspr.DeleteProductBLL(pr.id);
                LoadButton();


              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CollectionAdd f = new CollectionAdd();
            ProductBLL prbll = new ProductBLL();


            if(f.ShowDialog() == DialogResult.OK)
            {
                Product pr = new Product();
                pr.id = f.id;
                pr.name = f.name;
                pr.price = f.intprice;
                pr.type = f.type;


               if( prbll.AddProductBLL(pr))
                {
                    LoadButton();
                    MessageBox.Show("THANH CONG");
                }
               else
                {
                    MessageBox.Show("TACH");
                }

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {



            if (Lasted != null)
            {
                Product btnpr = Lasted.Tag as Product;
                CollectionModify f = new CollectionModify(btnpr);
                ProductBLL dspr = new ProductBLL();



                if (f.ShowDialog() == DialogResult.OK)
                {

                    Product temp = new Product();
                    temp.id = f.id;
                    temp.name = f.name;
                    temp.price = f.price;
                    temp.type = f.type;


                    dspr.UpdateProduct(temp, btnpr.id);

                    LoadButton();
                }



            }
        }
    }
}
