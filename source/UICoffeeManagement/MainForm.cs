using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICoffeeManagement
{
   
    public partial class MainForm : Form
    {

        public static int c = 3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      

        private void buttonCollection_Click(object sender, EventArgs e)
        {
            collectionUserControl1.BringToFront();
        }

        private void buttonPayMent_Click(object sender, EventArgs e)
        {
            paymentUserControl1.BringToFront();
           //collectionUserControl 
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
           //musicUserControl1.BringToFront();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
           // employeeUserControl1.BringToFront();
        }

        private void buttonStatic_Click(object sender, EventArgs e)
        {
           // statiticUserControl1.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //homeUserControl1.BringToFront();
          //  PaymentUserControl pm = new PaymentUserControl();
          //  pm.Show();
           // PaymentUserControl.a = 3;
            

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //homeUserControl1.BringToFront();
            //homeUserControl1
          //  PaymentUserControl pm = new PaymentUserControl();
          //  pm.Show();
        }

        private void collectionUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
