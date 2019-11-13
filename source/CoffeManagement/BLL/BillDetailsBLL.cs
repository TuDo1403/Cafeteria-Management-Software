using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
   public class BillDetailsBLL
    {
        BillDetailsAcccess psa = new BillDetailsAcccess();


        public bool AddProduct(BillDetails pr)
        {
            return psa.AddProduct(pr);
        }
    }
}
