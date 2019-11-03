using System;
using System.Collections.Generic;

namespace CM.DTO
{
    public class Category : Product
    {
        public List<Product> pr = new List<Product>();

        public Category(string ID, string NAME, string PRICE, int NUMBER) : base(ID, NAME, PRICE, NUMBER)
        {
        }

        public string Name { get; set; }


        public void AddProduct(Product temp)
        {
            pr.Add(temp);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
