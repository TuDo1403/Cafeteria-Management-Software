using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class LogIn2 : Form
    {
        public LogIn2()
        {
            InitializeComponent();
        }

        private void LogIn2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "REGISTER")
            {
                timer1.Start();
            }
            else if (button1.Text == "LOGIN")
            {
                timer2.Start();
             
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 10;
            panel4.Left -= 10;
            if(panel4.Left<=17)
            {
                timer1.Stop();
                button1.Text = "LOGIN";
                button1.BackColor = Color.FromArgb(78, 88, 169);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Left += 10;
            panel4.Left += 10;
            if (panel1.Left >= 17)
            {
                timer2.Stop(); 
                button1.Text = "REGISTER";
                button1.BackColor = Color.FromArgb(254,206,0);
            }
        }
    }
}
