using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using CM.DTO;

namespace CafeteriaManagement
{

    public partial class UCQueueBox : UserControl
    {
        private readonly Timer timer = new Timer();


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

        private void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e) => UpdateDataGridViewNextUpFromUserAddedPlaylist();

        private void MusicPlayer_SongAddedHandler(object sender, Song e) => UpdateDataGridViewNextUpFromUserAddedPlaylist();

        private void MusicPlayer_SongChangedHandler(object sender, Queue<Song> e)
        {
            InitializeStartAndEndTimeLabels(e);
            InitializeTrackBarSongDuration(e);
            BindPlayingSongToDataGridViewHistory();
            UpdateDataGridVIew(e);
        }

        private void InitializeTrackBarSongDuration(Queue<Song> e)
        {
            var duration = e.Peek().Duration.Trim().Split(':');
            trackBarSongDuration.MaximumValue =
                Convert.ToInt32(duration[0], CultureInfo.InvariantCulture) * 60 + Convert.ToInt32(duration[1], CultureInfo.InvariantCulture);
            trackBarSongDuration.Value = 0;
        }

        private void InitializeStartAndEndTimeLabels(Queue<Song> e)
        {
            labelTime.Text = Properties.Resources.labelTextInitializeTime;
            labelDuration.Text = e.Peek().Duration;
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




        private void Timer_TickHandler(object sender, EventArgs e)
        {
            if (trackBarSongDuration.Value < trackBarSongDuration.MaximumValue)
            {
                trackBarSongDuration.Value++;
                labelTime.Text = $"{trackBarSongDuration.Value / 60}:{trackBarSongDuration.Value % 60}";
            }
            else
            {
                timer.Stop();
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
            dataGridViewHistory.Invoke((Action)delegate
            {
                dataGridViewHistory.DataSource = null;
                dataGridViewHistory.DataSource = MusicPlayer.PlayHistories;
            });
        }



        private void lblOnline_Click(object sender, EventArgs e)
        {
            /*timerHistoryBack.Start();*/
            timerPanelGreenQueue.Start();
            pnlQueue.BringToFront();
            
        }

        private void lblOffline_Click(object sender, EventArgs e)
        {
            //  pnlQueue.Visible = false;
            //   pnlHistory.BringToFront();

            // timerHistory.Start();

            /* timerQueue.Start();*/
             timerPanelGreenHistory.Start();
            pnlHistory.BringToFront();

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

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            MusicPlayer.CreateInstance();

            if (dataGridViewPlaying.DataSource == null)
            {
                var canPlay = MusicPlayer.PlayNext();
                if (canPlay)
                {
                    timer.Start();
                    buttonPlay.SendToBack();
                }
            }
            else
            {
                MusicPlayer.Play();
                timer.Start();
                buttonPlay.SendToBack();
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MusicPlayer.PlayNext();
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            MusicPlayer.Pause();
            timer.Stop();
            buttonPause.SendToBack();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            MusicPlayer.PlayNext();
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            MusicPlayer.CreateInstance();

            if (dataGridViewPlaying.DataSource == null)
            {
                var canPlay = MusicPlayer.PlayNext();
                if (canPlay)
                {
                    timer.Start();
                    buttonPlay.SendToBack();
                }
            }
            else
            {
                MusicPlayer.Play();
                timer.Start();
                buttonPlay.SendToBack();
            }
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {

            MusicPlayer.Pause();
            timer.Stop();
            buttonPause.SendToBack();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            MusicPlayer.PlayPrev();
        }
    }
}
