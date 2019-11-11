using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeManagement
{
    public partial class PaymentTopping : Form
    {
        public static int checkSize { get; set; }
        public static int[] topping { get; set; }
        


        public PaymentTopping()
        {
            InitializeComponent();

           // label4.Text = PaymentUserControl.nhan;

        }
        public PaymentTopping(int checkSize,int []arrTopping)
        {
            InitializeComponent();


            rdoSizeS.Checked =false;
            rdoSizeM.Checked = false;
            rdoSizeL.Checked = false;



            if (checkSize==0)
            {
                rdoSizeS.Checked = true;
            }
            else if(checkSize==1)
            {
                rdoSizeM.Checked = true;

            }
            else if (checkSize==2)
            {
                rdoSizeL.Checked = true;
            }





            if(arrTopping[0]==1)
            {
                ckbWipingCream.Checked = true;
            }
            if (arrTopping[1] == 1)
            {
                CkbJelly.Checked = true;
            }
            if (arrTopping[2] == 1)
            {
                ckbPeanut.Checked = true;
            }
            if (arrTopping[3] == 1)
            {
                ckbBubbleCream.Checked = true;
            }
            if (arrTopping[4] == 1)
            {
                CkbWhitePearl.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topping = new int[5];
            DialogResult = DialogResult.OK;


            if (rdoSizeS.Checked==true)
            {
                checkSize = 0;
            }
            else if (rdoSizeM.Checked==true)
            {
                checkSize = 1;
            }
            else if (rdoSizeL.Checked==true)
            {
                checkSize = 2;
            }


            if(ckbWipingCream.Checked==true)
            {
                topping[0] = 1;
            }
            if (CkbJelly.Checked==true)
            {
                topping[1] = 1;
            }
            if (ckbPeanut.Checked==true)
            {
                topping[2] = 1;
            }
            if (ckbBubbleCream.Checked==true)
            {
                topping[3] = 1;
            }
            if (CkbWhitePearl.Checked==true)
            {
                topping[4] = 1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void PaymentTopping_Load(object sender, EventArgs e)
        {

        }
    }
}
