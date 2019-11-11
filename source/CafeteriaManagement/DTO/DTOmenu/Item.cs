using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    class Item:Product
    {
        private int kind;

        public Item():base()
        {

        }
        public Item(string ID, string NAME, int PRICE, int NUMBER,int KIND):base(ID,NAME,PRICE,NUMBER)
        {
            kind = KIND;
        }
        public override float countMoney()
        {
            return number * 100000;
        }
    }
}
