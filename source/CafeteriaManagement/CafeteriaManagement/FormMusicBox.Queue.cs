using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormQueue : Form
    {
        private static FormQueue _formQueue;
        private readonly Timer timer = new Timer();

        public static event EventHandler SongNext;
        public static event EventHandler SongPrev;



        public static FormQueue CreateInstance()
        {
            if (_formQueue == null)
            {
                _formQueue = new FormQueue();
            }
            return _formQueue;
        }

        private FormQueue()
        {
            //if (!this.IsHandleCreated)
            //{
            //    this.CreateHandle();
            //}
            InitializeComponent();

            UpdateDataGridViewNextUpFromUserAddedPlaylist();

            MusicPlayer.SongChanged += MusicPlayer_SongChangedHandler;
            MusicPlayer.SongAdded += MusicPlayer_SongAddedHandler;
            SongDownloader.ConvertCompleted += SongDownloader_ConvertCompletedHandler;
            //FormMusicBox.BackGroundWorker.RunWorkerCompleted += BackGroundWorker_RunWorkerCompletedHandler;

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


        private void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e)
        {
            //solve exception: Invoke or BeginInvoke cannot be called on a control until the window handle has been created
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }

            UpdateDataGridViewNextUpFromUserAddedPlaylist();
        }


        private void MusicPlayer_SongAddedHandler(object sender, Song e) => UpdateDataGridViewNextUpFromUserAddedPlaylist();


        private void MusicPlayer_SongChangedHandler(object sender, Queue<Song> e)
        {
            InitializeStartAndEndTimeLabels(e);
            InitializeTrackBarSongDuration(e);
            UpdateDataGridVIew(e);
        }


        private void UpdateDataGridViewNextUpFromUserAddedPlaylist()
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }

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
            BindPlayingSongToDataGridViewHistory(e);
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
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            dataGridViewPlaying.Invoke((Action)delegate
            {
                dataGridViewPlaying.DataSource = e.Where(s => s == e.Peek()).ToList();
            });
        }


        private void BindPlayingSongToDataGridViewHistory(Queue<Song> e)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
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
            labelTime.Text = "0:0";
            labelDuration.Text = e.Peek().Duration;
        }



        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (MusicPlayer.PlayList.Peek().IsConverted)
            {
                if (buttonPlay.Text == "Play")
                {
                    buttonPlay.Text = "Pause";
                    MusicPlayer.CreateInstance().Play();
                    timer.Start();
                }
                else
                {
                    buttonPlay.Text = "Play";
                    MusicPlayer.CreateInstance().Pause();
                    timer.Stop();
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e) => OnSongChangingNext();

        private void OnSongChangingNext() => (SongNext as EventHandler)?.Invoke(this, EventArgs.Empty);

        private void buttonPrevious_Click(object sender, EventArgs e) => OnSongChangingPrev();

        private void OnSongChangingPrev() => (SongPrev as EventHandler)?.Invoke(this, EventArgs.Empty);
    }
}
