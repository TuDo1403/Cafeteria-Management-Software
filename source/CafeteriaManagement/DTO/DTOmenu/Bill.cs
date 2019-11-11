using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeteriaManagement
{
   public class Bill
    {
        string idBill { get; set; }
        string date { get; set; }
        int price { get; set; }
        string idCustomer { get; set; }
        string idEmployee { get; set; }

        List<Product> lsproducts = new List<Product>();

        public float total()
        {
            return 0;
        }

    }
}
