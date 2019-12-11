using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class ItemChosenEventArgs : EventArgs
    {
        public IEnumerable<string> Toppings { get; set; }

        public string Name { get; set; }

        public ItemChosenEventArgs(IEnumerable<string> toppings, string name)
        {
            Toppings = toppings;
            Name = name;
        }
    }
}
