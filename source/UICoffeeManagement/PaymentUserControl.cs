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
    public partial class PaymentUserControl : UserControl
    {

        static List<CateGory> lsCateGory = new List<CateGory>();
        


        public PaymentUserControl()
        {
            InitializeComponent();


            CateGory temp1 = new CateGory();
            temp1.name = "Drinking";
            Product dr1 = new Drinking("DK001", "Coffee", " 10", 1, 0);
            Product dr2 = new Drinking("DK002", "Espresso", " 10", 1, 0);
            Product dr3 = new Drinking("DK003", "America", " 10", 1, 0);
            Product dr4 = new Drinking("DK004", "Capuchino", " 10", 1, 0);
            Product dr5 = new Drinking("DK005", "Latte", " 10", 1, 0);
            Product dr6 = new Drinking("DK006", "Cold Brew", " 10", 1, 0);
            Product dr7 = new Drinking("DK007", "Milk Coffe", " 10", 1, 0);
            Product dr8 = new Drinking("DK008", "Hot Latee", " 10", 1, 0);
            temp1.addProduct(dr1);
            temp1.addProduct(dr2);
            temp1.addProduct(dr3);
            temp1.addProduct(dr4);
            temp1.addProduct(dr5);
            temp1.addProduct(dr6);
            temp1.addProduct(dr7);
            temp1.addProduct(dr8);





            CateGory temp2 = new CateGory();
            temp2.name = "Desert";
           

            Product ds1 = new Desert("DS001", "Cookies ", "10", 0, "10/10/2019", "15/10/2019");
            Product ds2 = new Desert("DS002", "Cakes ", "10", 0, "10/10/2019", "15/10/2019");
            Product ds3 = new Desert("DS003", "Cupcakes ", "10", 0, "10/10/2019", "15/10/2019");
            Product ds4 = new Desert("DS004", "Fresh Breads ", "10", 0, "10/10/2019", "15/10/2019");
            Product ds5 = new Desert("DS005", "Pies ", "10", 0, "10/10/2019", "15/10/2019");
            Product ds6 = new Desert("DS006", "Brownies & Bars ", "10", 0, "10/10/2019", "15/10/2019");
            temp2.addProduct(ds1);
            temp2.addProduct(ds2);
            temp2.addProduct(ds3);
            temp2.addProduct(ds4);
            temp2.addProduct(ds5);
            temp2.addProduct(ds6);



            CateGory temp3 = new CateGory();
            temp3.name = "Items";

            Product it1 = new Item("IT001", "Glass", "10", 0, 0);
            Product it2 = new Item("IT002", "Gift Card", "10", 0, 0);
            Product it3 = new Item("IT003", "Decorate", "10", 0, 0);
            Product it4 = new Item("IT004", "NoteBook", "10", 0, 0);
            temp3.addProduct(it1);
            temp3.addProduct(it2);
            temp3.addProduct(it3);
            temp3.addProduct(it4);

            lsCateGory.Add(temp1);
            lsCateGory.Add(temp2);
            lsCateGory.Add(temp3);

            foreach(CateGory temp in lsCateGory)
            {
                cmbCateGory.Items.Add(temp);
            }




        }

        private void cmbCateGory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CateGory cg = cmbCateGory.SelectedItem as CateGory;
            lstProduct.Items.Clear();

            foreach(Product pd in cg.pr)
            {
                lstProduct.Items.Add(pd);
            }
               

           /* Product pr1 = new Drinking("DK001", "Coffee"," 10", 1, 0);
            Product pr2 = new Drinking("DK002", "Espresso", " 10", 1, 0);
            Product pr3 = new Drinking("DK003", "America", " 10", 1, 0);
            Product pr4 = new Drinking("DK004", "Capuchino", " 10", 1, 0);
            Product pr5 = new Drinking("DK005", "Latte", " 10", 1, 0);
            Product pr6 = new Drinking("DK006", "Cold Brew", " 10", 1, 0);
            Product pr7 = new Drinking("DK007", "Milk Coffe", " 10", 1, 0);
            Product pr8 = new Drinking("DK008", "Hot Latee", " 10", 1, 0);*/



        }
    }
}
