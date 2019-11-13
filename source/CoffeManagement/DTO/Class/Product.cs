using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
   public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int number { get; set; }
        public int type { get; set; }

        public void setId(string a)
        {
            id = a;
        }
        public void setName(string a)
        {
            name = a;
        }
        public void setPrice(int a)
        {
            price = a;
        }

        public  Product(string ID,string NAME,int PRICE,int NUMBER)
        {
            id = ID;
            name = NAME;
            price = PRICE;
            number = NUMBER;
           
        }
        public Product()
        {

        }
        public Product(Product a)
        {
            id = a.id;
            name =a.name;
            price = a.price;
            number = a.number;
        }
       
        public virtual float countMoney()
        {
            return 0;

        }

        public override string ToString()
        {
            return name;
        }




    }
}
