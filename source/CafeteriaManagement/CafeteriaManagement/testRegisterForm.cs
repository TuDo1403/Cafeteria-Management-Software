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
    public partial class testRegisterForm : Form
    {
        public testRegisterForm()
        {
            InitializeComponent();
        }

        private void testRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (panelSignIn.Left >= 320)
                timerSignIn.Start();
            else
                timerRegister.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSignIn_Tick(object sender, EventArgs e)
        {
            if (panelRegister.Left > 320)
            {
                panelRegister.Left -= 10;
                panelSignIn.Left -= 10;
            }
            else
                timerSignIn.Stop();
        }

        private void timerRegister_Tick(object sender, EventArgs e)
        {
            if (panelSignIn.Left < 320)
            {
                panelRegister.Left += 10;
                panelSignIn.Left += 10;
            }
            else
                timerRegister.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
