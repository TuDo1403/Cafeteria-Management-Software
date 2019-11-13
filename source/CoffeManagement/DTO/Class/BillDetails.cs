using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
   public class BillDetails
    {
       public string idBill { get; set; }
       public string idProduct { get; set; }
       public int number { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public int priceThisProduct { get; set; }

        public int sum()
        {
            return number * priceThisProduct;
        }

        


     



        
    }
}
