using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class Item : Product
    {
        private readonly int _kind;


        public Item(string ID, string NAME, string PRICE, int NUMBER, int KIND) : base(ID, NAME, PRICE, NUMBER)
        {
            _kind = KIND;
        }
        public override float CountMoney()
        {
            return number * 100000;
        }
    }
}
