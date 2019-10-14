using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private static FormQueue formQueue;
        private readonly Timer timer = new Timer();
        private List<Song> _playHistories;

        public static List<int> ConvertedPlayIndex { get; } = new List<int>();

        public static event EventHandler SongNext;

        public static event EventHandler<Song> SongPrev;



        public static FormQueue CreateInstance()
        {
            if (formQueue == null)
            {
                formQueue = new FormQueue();
            }
            return formQueue;
        }

        private FormQueue()
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            InitializeComponent();

            _playHistories = new List<Song>();

            UpdateDataGridViewNextUpFromUserAddedPlaylist();

            MusicPlayer.SongChanged += MusicPlayer_SongChangedHandler;

            FormMusicBox.ConvertCompleted += FormMusicBox_ConvertCompletedHandler;

            FormMusicBox.FormQueueEntered1stTime += FormMusicBox_FormQueueEnteredHandler;

            timer.Interval = 1000;
            timer.Tick += Timer_TickHandler;
        }

        private void FormMusicBox_FormQueueEnteredHandler(object sender, EventArgs e)
        {
            UpdateDataGridViewNextUpFromUserAddedPlaylist();
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
            UpdateDataGridVIew(e);
        }

        private void UpdateDataGridVIew(Queue<Song> e)
        {
            BindPlayingSongToDataGridViewHistory(e);
            BindPlayingSongToDataGridViewPlaying(e);
            BindSongsInTheQueueToDataGridViewNextUp(e);
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

        private void FormMusicBox_ConvertCompletedHandler(object sender, VideoInfo e)
        {
            ConvertedPlayIndex.Add(e.PlayIndex);

            //solve exception: Invoke or BeginInvoke cannot be called on a control until the window handle has been created
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }

            if (IsFirstInTheQueue(e.PlayIndex))
            {
                //prevent cross thread operation not valid
                buttonPlay.Invoke((Action)delegate
                {
                    buttonPlay.Enabled = true;
                });
            }
        }

        

        private static bool IsFirstInTheQueue(int e)
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
                OnSongChangingPrev(_playHistories[GetLastSongIndex()]);
            }
        }

        private int GetLastSongIndex()
        {
            return _playHistories.Count - 2;
        }

        private void OnSongChangingPrev(Song lastPlayedSong)
        {
            (SongPrev as EventHandler<Song>)?.Invoke(this, lastPlayedSong);
        }
    }
}
