using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeSearch;
using YoutubeExplode.Models.MediaStreams;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace CafeteriaManagement
{
    public partial class FormMusicBox : Form
    {
        List<Video> videos;

        public static string musicSavePath = $@"C:\Users\{Environment.UserName}\Music\";

        public static event EventHandler<int> ConvertCompleted;

        public bool IsConverted { get; set; }

        public FormMusicBox()
        {
            InitializeComponent();
            //ConvertCompleted += FormMusicBox_ConvertCompletedHandler;
        }

        private void FormMusicBox_ConvertCompletedHandler(object sender, int e)
        {
            DeleteAudioStream(e);
        }

        private void textBoxSearchMusic_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Enter Keyword")
            {
                textBoxSearchMusic.Text = "";
                textBoxSearchMusic.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchMusic_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "")
            {
                textBoxSearchMusic.Text = "Enter Keyword";
                textBoxSearchMusic.ForeColor = Color.Gray;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Enter Keyword")
            {
                return;
            }
            else
            {
                var items = new VideoSearch();
                videos = SearchedResultsToVideos(items);
                dataGridViewSearchResult.DataSource = videos;
            }
        }

        private List<Video> SearchedResultsToVideos(VideoSearch items)
        {
            var videos = (from item in items.SearchQuery(textBoxSearchMusic.Text, 1)
                          select new Video
                          {
                              //convert string to UTF8 to display Vietnamese string
                              Title = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Title)),
                              Author = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Author)),
                              Duration = item.Duration,
                              Url = item.Url
                          }).ToList();
            return videos;
        }

        private async void dataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!File.Exists(GetSongUrl(e.RowIndex)))
            {
                await Task.Run(() =>
                {
                    DownloadSelectedRowAudio(e.RowIndex);
                });
            }
            else
            {
                OnConvertComplete(e.RowIndex);
            }
            AddMusicToQueue(e.RowIndex);
        }

        private void AddMusicToQueue(int rowIndex)
        {
            var song = videos[rowIndex].ToSong(GetSongUrl(rowIndex));
            MusicPlayer.playList.Enqueue(song);
            MessageBox.Show("Song added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetSongUrl(int rowIndex, bool isConverted = true)
        {
            if (isConverted)
            {
                return musicSavePath + videos[rowIndex].Title.RemoveIllegalChars() + ".mp3";
            }
            return musicSavePath + videos[rowIndex].Title.RemoveIllegalChars() + ".WebM";
        }

        private async void DownloadSelectedRowAudio(int rowIndex)
        {
            await GetAudioStreamSelectedRow(rowIndex);
            await Task.Run(() =>
            {
                ConvertAudioStreamToMp3(rowIndex);
            });
            await Task.Run(() =>
            {
                DeleteAudioStream(rowIndex);
            });
        }


        //solution found from: https://stackoverflow.com/questions/3420737/file-delete-error-the-process-cannot-access-the-file-because-it-is-being-used-b
        private void DeleteAudioStream(int rowIndex)
        {
            if (File.Exists(GetSongUrl(rowIndex, false)))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(GetSongUrl(rowIndex, false));
            }
        }

        private void ConvertAudioStreamToMp3(int rowIndex)
        {
            var input = new MediaFile { Filename = GetSongUrl(rowIndex, false) };
            var output = new MediaFile { Filename = GetSongUrl(rowIndex) };
            using (var engine = new Engine())
            {
                engine.GetMetadata(input);
                engine.Convert(input, output);
                OnConvertComplete(rowIndex);
            }
        }

        private void OnConvertComplete(int rowIndex)
        {
            (ConvertCompleted as EventHandler<int>)?.Invoke(this, rowIndex);
        }

        private async Task GetAudioStreamSelectedRow(int rowIndex)
        {
            var videoIdFromUrl = YoutubeClient.ParseVideoId(videos[rowIndex].Url);
            var streamInfoSet = await new YoutubeClient().GetVideoMediaStreamInfosAsync(videoIdFromUrl);
            var streamInfo = streamInfoSet.Audio.OrderByDescending(audio => audio.Bitrate)
                                                .First(a => a.Container == YoutubeExplode.Models.MediaStreams.Container.WebM);
            await new YoutubeClient().DownloadMediaStreamAsync(streamInfo, GetSongUrl(rowIndex, false));
        }

        private void textBoxSearchMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(this, e);
            }
        }

        private void buttonQueue_Click(object sender, EventArgs e)
        {
            var formQueue = new FormQueue();
            this.Hide();
            formQueue.ShowDialog();
            this.Show();
        }
    }
}
