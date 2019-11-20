using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        private readonly List<string> _toppings = new List<string>();

        public void AddTopping(string topping)
        {
            _toppings.Add(topping);
        }
    }
}
