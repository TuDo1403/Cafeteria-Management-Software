using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICoffeeManagement
{
    class Item:Product
    {
        private int kind;

    
        public Item(string ID, string NAME, string PRICE, int NUMBER,int KIND):base(ID,NAME,PRICE,NUMBER)
        {
            kind = KIND;
        }
        public override float countMoney()
        {
            return number * 100000;
        }
    }
}
