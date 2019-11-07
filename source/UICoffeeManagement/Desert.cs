using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICoffeeManagement
{
    class Desert:Product
    {
        private string exp { get; set; }
        private string mfg { get; set; }


        public Desert(string ID, string NAME, string PRICE, int NUMBER,string EXP,string MFG):base(ID,NAME,PRICE,NUMBER)
        {
            exp = EXP;
            mfg = MFG;
        }
        public override float countMoney()
        {
            return number * 10000;
        }
    }
}
