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
        List<Song> playHistories;
        public FormQueue()
        {
            InitializeComponent();
            MusicPlayer.SongChanged += MusicPlayer_SongChangedHandler;
            playHistories = new List<Song>();
            if (MusicPlayer.playList.Count >= 1)
            {
                dataGridViewNextUp.DataSource = MusicPlayer.playList.Where(s => true).ToList();
            }
            FormMusicBox.ConvertCompleted += FormMusicBox_ConvertCompletedHandler;
        }

        private void FormMusicBox_ConvertCompletedHandler(object sender, int e)
        {
            //prevent cross thread operation not valid
            buttonPlay.Invoke((Action)delegate
            {
                buttonPlay.Enabled = true;
            });
        }

        private void MusicPlayer_SongChangedHandler(object sender, Queue<Song> e)
        {
            playHistories.Add(e.Peek());
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.DataSource = playHistories;
            dataGridViewPlaying.DataSource = e.Where(s => s == e.Peek()).ToList();
            if (e.Count >= 1)
            {
                dataGridViewNextUp.DataSource = e.Where(s => s != e.Peek()).ToList();
            }
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
