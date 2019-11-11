using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
   public class Product
    {
        protected string id { get; set; }
        protected string name { get; set; }
        protected int price { get; set; }
        protected int number { get; set; }

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
