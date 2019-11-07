using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICoffeeManagement
{
    class Drinking:Product
    {
        private int topping { get; set; }

        public Drinking(string ID, string NAME, string PRICE, int NUMBER, int TOPPING) : base(ID, NAME, PRICE, NUMBER)
        {
            topping = TOPPING;
        }

        public override float countMoney()
        {
            return number * 20000;
        }

    }
}
