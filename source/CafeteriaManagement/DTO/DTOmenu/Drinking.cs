using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class Drinking:Product
    {
        public int[] Topping = new int[5];
        int topping { get; set; }
        public int size { get; set; }


        public Drinking(Drinking a) : base(a)
        {
            size = a.size;
            topping = a.topping;
        }
        

         public Drinking():base()
        {

        }
      /*  public Drinking(Product a) : base(a)
        {

        }
        */

        public Drinking(string ID, string NAME, int PRICE, int NUMBER, int TOPPING) : base(ID, NAME, PRICE, NUMBER)
        {
            topping = TOPPING;
        }

        public override float countMoney()
        {
            float sum = 0;
            sum = price;



            if(size==1)
            {
                sum += 5;
            }else if(size==2)
            {
                sum += 10;
            }



            for(int i=0;i<5;i++)
            {
                if(Topping[i]==1)
                {
                    sum += 2;
                }
            }
                

            return sum;
        }

    }
}
