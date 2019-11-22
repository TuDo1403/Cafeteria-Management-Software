using System;
using System.Collections.Generic;
using System.Linq;
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
            var stringBuilder = new StringBuilder();
            var temp = new List<string>();
            foreach (var item in _toppings)
            {
                if (!temp.Any(c => c == item))
                {
                    var count = _toppings.Where(c => c == item).Count();
                    stringBuilder.Append($"{item}: ({count}), ");
                    temp.Add(item);
                }
            }
            Description = stringBuilder.ToString();
        }
    }
}
