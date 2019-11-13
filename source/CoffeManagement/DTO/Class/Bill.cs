using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeManagement
{
   public class Bill
    {
        string idBill { get; set; }
        string date { get; set; }
        string idEmployee { get; set; }
        int price { get; set; }

        List<Product> lsproducts = new List<Product>();

        public float total()
        {
            return 0;
        }

    }
}
