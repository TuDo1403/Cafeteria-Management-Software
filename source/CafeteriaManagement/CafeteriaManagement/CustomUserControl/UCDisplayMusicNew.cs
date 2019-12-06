using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeManagement
{
    public partial class UCDisplayMusicNew : UserControl
    {
        int time = 20;

        public UCDisplayMusicNew()
        {
            InitializeComponent();
          //  InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
          //  skinManager.AddFormToManage(UCDisplayMusicNew);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //form màu xanh lá        //cái khung 3 dấu trên đầu      //hhông biết
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOnline_Click(object sender, EventArgs e)
        {
        
            timerPanelOffline.Start();
            timerGreenOnline.Start();
        }

        private void timerPanelOnline_Tick(object sender, EventArgs e)
        {
            if (pnlOffline.Left >= 40)
            {
                pnlOffline.Left -= time;
                pnlOnline.Left -= time;
                time += 1;
            }
            else
            {
                timerPanelOnline.Stop();
                time = 20;
            }

               
        }

        private void lblOffline_Click(object sender, EventArgs e)
        {
            timerPanelOnline.Start();
            timerGreenOffline.Start();
        }

        private void timerPanelOffline_Tick(object sender, EventArgs e)
        {
            if (pnlOnline.Left <= 26)
            {
                pnlOffline.Left += time ;
                pnlOnline.Left += time ;
                time += 1;
            }
            else
            {
                timerPanelOffline.Stop();
                time = 20;
            }
              
        }

        private void timerGreenOffline_Tick(object sender, EventArgs e)
        {
            if(pnlGreen.Left<=125)
            {
                pnlGreen.Left += 6;
            }
            else
            {
                timerGreenOffline.Stop();
            }
        }

        private void timerGreenOnline_Tick(object sender, EventArgs e)
        {
            if(pnlGreen.Left>=25)
            {
                pnlGreen.Left -= 6;
            }
            else
            {
                timerGreenOnline.Stop();
            }
        }
    }
}
