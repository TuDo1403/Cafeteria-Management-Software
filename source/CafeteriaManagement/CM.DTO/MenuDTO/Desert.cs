using System;
using System.Collections.Generic;
using System.Text;

namespace CM.DTO
{
    public class Desert : Product
    {
        private string exp { get; set; }
        private string mfg { get; set; }


        public Desert(string ID, string NAME, string PRICE, int NUMBER, string EXP, string MFG) : base(ID, NAME, PRICE, NUMBER)
        {
            exp = EXP;
            mfg = MFG;
        }
        public override float CountMoney() => number * 10000;
    }
}
