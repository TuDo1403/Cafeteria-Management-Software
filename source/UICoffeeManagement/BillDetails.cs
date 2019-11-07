using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICoffeeManagement
{
   public class BillDetails
    {
       public string idBill { get; set; }
       public Product dr { get; set; }
       public int numberOfProduct { get; set; }
        


        public float countmoney()
        {
            float price = 0;
            numberOfProduct = 1;
            price = dr.countMoney() * numberOfProduct;
            return price;
        }



        public override string ToString()
        {
            return dr.ToString();
        }
    }
}
