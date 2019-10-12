using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CafeteriaManagement
{
    public partial class FormQueue : Form
    {
        public FormQueue()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlay.Text == "Play")
            {
                buttonPlay.Text = "Pause";
                MusicPlayer.GetInstance().Play();
            }
            else
            {
                buttonPlay.Text = "Play";
                MusicPlayer.GetInstance().Pause();
            }
        }
    }
}
