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
        private Timer timer = new Timer();
        private List<Song> _playHistories;

        public static event EventHandler SongNext;

        public static event EventHandler<Song> SongPrev;



        public FormQueue()
        {
            InitializeComponent();

            _playHistories = new List<Song>();

            UpdateDataGridViewNextUpFromUserAddedPlaylist();

            MusicPlayer.SongChanged += MusicPlayer_SongChangedHandler;

            FormMusicBox.ConvertCompleted += FormMusicBox_ConvertCompletedHandler;

            timer.Interval = 1000;
            timer.Tick += Timer_TickHandler;
        }

        private void UpdateDataGridViewNextUpFromUserAddedPlaylist()
        {
            if (MusicPlayer.PlayList.Count >= 1)
            {
                dataGridViewNextUp.DataSource = MusicPlayer.PlayList.Where(s => true).ToList();
            }
        }

        private void MusicPlayer_SongChangedHandler(object sender, Queue<Song> e)
        {
            InitializeStartAndEndTimeLabels(e);
            InitializeTrackBarSongDuration(e);
            BindPlayingSongToDataGridViewHistory(e);
            BindPlayingSongToDataGridViewPlaying(e);
            BindSongsInTheQueueToDataGridViewNextUp(e);
        }

        private void InitializeTrackBarSongDuration(Queue<Song> e)
        {
            var duration = e.Peek().Duration.Trim().Split(':');
            trackBarSongDuration.Maximum = Convert.ToInt32(duration[0]) * 60 + Convert.ToInt32(duration[1]);
            trackBarSongDuration.Value = 0;
        }

        private void InitializeStartAndEndTimeLabels(Queue<Song> e)
        {
            labelTime.Text = "0:0";
            labelDuration.Text = e.Peek().Duration;
        }

        private void Timer_TickHandler(object sender, EventArgs e)
        {
            if (trackBarSongDuration.Value < trackBarSongDuration.Maximum)
            {
                trackBarSongDuration.Value++;
                labelTime.Text = $"{trackBarSongDuration.Value / 60}:{trackBarSongDuration.Value % 60}";
            }
            else
            {
                timer.Stop();
            }
        }

        private void BindSongsInTheQueueToDataGridViewNextUp(Queue<Song> e)
        {
            if (e.Count >= 1)
            {
                dataGridViewNextUp.DataSource = e.Where(s => s != e.Peek()).ToList();
            }
        }

        private void BindPlayingSongToDataGridViewPlaying(Queue<Song> e)
        {
            dataGridViewPlaying.DataSource = e.Where(s => s == e.Peek()).ToList();
        }

        private void BindPlayingSongToDataGridViewHistory(Queue<Song> e)
        {
            _playHistories.Add(e.Peek());
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.DataSource = _playHistories;
        }

        private void FormMusicBox_ConvertCompletedHandler(object sender, int e)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            if (IsFirstInTheQueue(e))
            {
                //prevent cross thread operation not valid
                buttonPlay.Invoke((Action)delegate
                {
                    buttonPlay.Enabled = true;
                });
            }
        }

        private bool IsFirstInTheQueue(int e)
        {
            return e == 1;
        }

        

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlay.Text == "Play")
            {
                buttonPlay.Text = "Pause";
                MusicPlayer.GetInstance().Play();
                timer.Start();
            }
            else
            {
                buttonPlay.Text = "Play";
                MusicPlayer.GetInstance().Pause();
                timer.Stop();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            OnSongChangingNext();
        }

        private void OnSongChangingNext()
        {
            (SongNext as EventHandler)?.Invoke(this, EventArgs.Empty);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (_playHistories.Count > 1)
            {
                OnSongChangingPrev(_playHistories[_playHistories.Count - 2]);
            }
        }

        private void OnSongChangingPrev(Song lastPlayedSong)
        {
            (SongPrev as EventHandler<Song>)?.Invoke(this, lastPlayedSong);
        }
    }
}
