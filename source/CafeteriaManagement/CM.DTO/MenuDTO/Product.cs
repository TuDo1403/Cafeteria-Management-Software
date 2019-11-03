using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class Product
    {
        protected string id { get; set; }
        protected string name { get; set; }
        protected string price { get; set; }
        protected int number { get; set; }

        public Product(string ID, string NAME, string PRICE, int NUMBER)
        {
            id = ID;
            name = NAME;
            price = PRICE;
            number = NUMBER;

        }

        public virtual float CountMoney() => 0;

        public override string ToString() => name;
    }
}
