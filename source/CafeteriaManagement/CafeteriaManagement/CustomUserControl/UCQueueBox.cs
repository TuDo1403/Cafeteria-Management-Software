using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{

    public partial class UCQueueBox : UserControl
    {
        public UCQueueBox()
        {
            InitializeComponent();
        }

        private void lblOnline_Click(object sender, EventArgs e)
        {
            timerHistoryBack.Start();
            timerPanelGreenQueue.Start();
            
        }

        private void lblOffline_Click(object sender, EventArgs e)
        {
            //  pnlQueue.Visible = false;
            //   pnlHistory.BringToFront();

            // timerHistory.Start();

            timerQueue.Start();
            timerPanelGreenHistory.Start();

        }
        
        private void timerQueue_Tick(object sender, EventArgs e)
        {
            if(pnlQueue.Left<=800)
            {
                pnlQueue.Left += 45;
            }
            else
            {
                timerQueue.Stop();

                timerHistory.Start();
            }
            
        }

        private void timerHistory_Tick(object sender, EventArgs e)
        {
            if (pnlHistory.Top >= 70)
            {
                pnlHistory.Top -= 45;
            }
            else
            {
                timerHistory.Stop();
              
            }
        }

        private void timerQueueBack_Tick(object sender, EventArgs e)
        {
            if (pnlQueue.Left >= 30)
            {
                pnlQueue.Left -= 45;
            }
            else
                timerQueueBack.Stop();
        }

        private void timerHistoryBack_Tick(object sender, EventArgs e)
        {
            if (pnlHistory.Top <= 510)
            {
                pnlHistory.Top += 45;
            }
            else
            {
                timerHistoryBack.Stop();
                timerQueueBack.Start();

            }
        }

        private void timerPanelGreen_Tick(object sender, EventArgs e)
        {
            if (pnlGreen.Left <= 122)
            {
                pnlGreen.Left += 9;
            }
            else
                timerPanelGreenHistory.Stop();
        }

        private void timerPanelGreenQueue_Tick(object sender, EventArgs e)
        {
            if (pnlGreen.Left >= 27)
            {
                pnlGreen.Left -= 9;
            }
            else
                timerPanelGreenQueue.Stop();
               
        }

        private void UCQueueBox_Load(object sender, EventArgs e)
        {

        }
    }
}
