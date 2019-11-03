using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class Drinking : Product
    {
        public int Topping { get; set; }

        public Drinking(string ID, string NAME, string PRICE, int NUMBER, int TOPPING) : base(ID, NAME, PRICE, NUMBER)
        {
            Topping = TOPPING;
        }

        public override float CountMoney()
        {
            return number * 20000;
        }
    }
}
