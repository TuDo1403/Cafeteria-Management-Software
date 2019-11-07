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

        public static List<Bill> lsBill = new List<Bill>();
        public static List<Product> lsproducts = new List<Product>();
        public static string nhan;


        public PaymentUserControl(string a)
        {

        }

        public PaymentUserControl()
        {

            InitializeComponent();

           
            foreach(CateGory temp in CollectionUserControl.lsCateGory)
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

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstProduct.SelectedIndex!=-1)
            {
                Product pr = lstProduct.SelectedItem as Product;
                nhan = pr.ToString();
                PaymentTopping pmt = new PaymentTopping();
                

                if(pmt.ShowDialog()==DialogResult.OK)
                {
                    //  BillDetails temp = new BillDetails();
                   
                    CateGory cg = cmbCateGory.SelectedItem as CateGory;
                   

                    if (pr is Drinking)
                    {
                        Drinking tempDrinking = new Drinking(pr as Drinking); // copyconstructor
  


                        tempDrinking.size = PaymentTopping.checkSize; // lấy dữ liệu size từ form topping
                        

                         //loop: lấy dữ liệut topping từ form topping
                       for(int i=0;i<5;i++)
                        {
                            tempDrinking.Topping[i] = PaymentTopping.topping[i];
                        }


                        lsproducts.Add(tempDrinking);
                        showSelectedProduct();



                        float sum = 0;
                        foreach(Product a in lsproducts)
                        {
                            sum += a.countMoney();
                        }

                        txtTotal.Text = sum + " ";



                    }
                    else if(pr is Desert)
                    {
                       
                        Desert tempDesert = new Desert();
                         tempDesert=  pr as Desert;


                        lstbSelectedItems.Items.Add(tempDesert);
                    }
                    else if (pr is Item)
                    {

                        Item tempItem = new Item();
                        tempItem=   pr as Item;


                        lstbSelectedItems.Items.Add(tempItem);
                    }



                    //hiển thị total
                    
                }
            }
        }

        public int countAllBilldetails()
        {
            return 0;
        }
        public void showSelectedProduct()
        {
            lstbSelectedItems.Items.Clear();// không bị lặp lại dữ liệu

            foreach(Product pr in lsproducts)
            {
                lstbSelectedItems.Items.Add(pr);
            }

        }

        

        private void lstbSelectedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i= lstbSelectedItems.SelectedIndex;
            Product pr = lstbSelectedItems.SelectedItem as Product;

            if(pr is Drinking)
            {

                Drinking temp = pr as Drinking;   
                PaymentTopping pmt = new PaymentTopping(temp.size, temp.Topping);


                if (pmt.ShowDialog() == DialogResult.OK)
                {

                    temp.size = PaymentTopping.checkSize; // lấy dữ liệu size từ form topping


                    //loop: lấy dữ liệut topping từ form topping
                    for (int j = 0; j < 5; j++)
                    {
                        temp.Topping[j] = PaymentTopping.topping[j];
                    }


                    float sum = 0;
                    foreach (Product a in lsproducts)
                    {
                        sum += a.countMoney();
                    }

                    txtTotal.Text = sum + " ";
                }



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
