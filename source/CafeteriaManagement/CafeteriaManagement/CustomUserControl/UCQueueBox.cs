using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CafeteriaManagement
{
    public partial class UCQueueBox : UserControl
    {
        private readonly Timer timer = new Timer();

        public static event EventHandler SongNext;
        public static event EventHandler SongPrev;



        public UCQueueBox()
        {
            InitializeComponent();

            UpdateDataGridViewNextUpFromUserAddedPlaylist();

            MusicPlayer.SongChanged += MusicPlayer_SongChangedHandler;
            MusicPlayer.SongAdded += MusicPlayer_SongAddedHandler;
            SongDownloader.ConvertCompleted += SongDownloader_ConvertCompletedHandler;

            timer.Interval = 1000;
            timer.Tick += Timer_TickHandler;
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


        private void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e) => UpdateDataGridViewNextUpFromUserAddedPlaylist();


        private void MusicPlayer_SongAddedHandler(object sender, Song e) => UpdateDataGridViewNextUpFromUserAddedPlaylist();


        private void MusicPlayer_SongChangedHandler(object sender, Queue<Song> e)
        {
            InitializeStartAndEndTimeLabels(e);
            InitializeTrackBarSongDuration(e);
            UpdateDataGridVIew(e);
        }


        private void UpdateDataGridViewNextUpFromUserAddedPlaylist()
        {
            if (MusicPlayer.PlayList.Count >= 1)
            {
                dataGridViewNextUp.Invoke((Action)delegate
                {
                    dataGridViewNextUp.DataSource = MusicPlayer.PlayList.Where(s => true).ToList();
                });
            }
        }



        private void UpdateDataGridVIew(Queue<Song> e)
        {
            BindPlayingSongToDataGridViewHistory();
            BindPlayingSongToDataGridViewPlaying(e);
            BindSongsInTheQueueToDataGridViewNextUp(e);
        }

        private void BindSongsInTheQueueToDataGridViewNextUp(Queue<Song> e)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            if (e.Count >= 1)
            {
                dataGridViewNextUp.Invoke((Action)delegate
                {
                    dataGridViewNextUp.DataSource = e.Where(s => s != e.Peek()).ToList();
                });
            }
        }


        private void BindPlayingSongToDataGridViewPlaying(Queue<Song> e)
        {
            dataGridViewPlaying.Invoke((Action)delegate
            {
                dataGridViewPlaying.DataSource = e.Where(s => s == e.Peek()).ToList();
            });
        }


        private void BindPlayingSongToDataGridViewHistory()
        {
            dataGridViewPlaying.Invoke((Action)delegate
            {
                dataGridViewHistory.DataSource = null;
                dataGridViewHistory.DataSource = MusicPlayer.PlayHistories;
            });
        }


        private void InitializeTrackBarSongDuration(Queue<Song> e)
        {
            var duration = e.Peek().Duration.Trim().Split(':');
            trackBarSongDuration.Maximum =
                Convert.ToInt32(duration[0], CultureInfo.InvariantCulture) * 60 + Convert.ToInt32(duration[1], CultureInfo.InvariantCulture);
            trackBarSongDuration.Value = 0;
        }


        private void InitializeStartAndEndTimeLabels(Queue<Song> e)
        {
            labelTime.Text = Properties.Resources.labelTextInitializeTime;
            labelDuration.Text = e.Peek().Duration;
        }



        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (MusicPlayer.PlayList.Count > 0 && MusicPlayer.PlayList.Peek().IsConverted)
            {
                MusicPlayer.CreateInstance();
                MusicPlayer.Play();
                timer.Start();
                buttonPlay.SendToBack();
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            MusicPlayer.Pause();
            buttonPause.SendToBack();
            timer.Stop();
        }

        private void ButtonNext_Click(object sender, EventArgs e) => OnSongChangingNext();

        private void OnSongChangingNext() => (SongNext as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void ButtonPrevious_Click(object sender, EventArgs e) => OnSongChangingPrev();

        private void OnSongChangingPrev() => (SongPrev as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
