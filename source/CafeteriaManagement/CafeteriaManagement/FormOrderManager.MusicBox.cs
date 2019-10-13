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
using System.IO;

namespace CafeteriaManagement
{
    public partial class FormMusicBox : Form
    {
        private int _addToQueueClickCount = 0;
        private List<VideoInfo> _downnloadList = new List<VideoInfo>();
        private List<Video> _videos;

        public static string musicSavePath = $@"C:\Users\{Environment.UserName}\Music\";

        public static event EventHandler<List<VideoInfo>> FormLeft;
        public static event EventHandler<int> ConvertCompleted;



        private void buttonQueue_Click(object sender, EventArgs e)
        {
            var formQueue = new FormQueue();
            this.Hide();
            OnFormLeaving();
            formQueue.ShowDialog();
            this.Show();
        }

        private void OnFormLeaving()
        {
            (FormLeft as EventHandler<List<VideoInfo>>)?.Invoke(this, _downnloadList);
        }

        public FormMusicBox()
        {
            InitializeComponent();
            FormLeft += FormMusicBox_FormLeftHandlerAsync;
        }

        private async void FormMusicBox_FormLeftHandlerAsync(object sender, List<VideoInfo> e)
        {
            foreach (var videoInfo in e)
            {
                await WriteConvertedAudioFilesToPathFrom(videoInfo);
            }
        }

        private async Task WriteConvertedAudioFilesToPathFrom(VideoInfo videoInfo)
        {
            if (AlreadyExistedAudioConvertedFrom(videoInfo) == false)
            {
                await DownloadAudioStreamFrom(videoInfo);
                await Task.Run(() =>
                {
                    ConvertAudioStreamToMp3By(videoInfo);
                    DeleteAudioStreamBy(videoInfo.Title);
                });
            }
            else
            {
                OnConvertComplete(videoInfo.PlayIndex);
            }
        }

        private bool AlreadyExistedAudioConvertedFrom(VideoInfo videoInfo)
        {
            return File.Exists(GetAudioSavePathFrom(videoInfo.Title));
        }

        private async Task DownloadAudioStreamFrom(VideoInfo videoInfo)
        {
            var videoIdFromUrl = YoutubeClient.ParseVideoId(videoInfo.Url);
            var streamInfoSet = await new YoutubeClient().GetVideoMediaStreamInfosAsync(videoIdFromUrl);
            var streamInfo = streamInfoSet.Audio.OrderByDescending(audio => audio.Bitrate)
                                                .First(a => a.Container == YoutubeExplode.Models.MediaStreams.Container.WebM);
            await new YoutubeClient().DownloadMediaStreamAsync(streamInfo, GetAudioSavePathFrom(videoInfo.Title, false));
        }


        private void ConvertAudioStreamToMp3By(VideoInfo videoInfo)
        {
            var input = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title, false) };
            var output = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title) };
            using (var engine = new Engine())
            {
                engine.GetMetadata(input);
                engine.Convert(input, output);
                OnConvertComplete(videoInfo.PlayIndex);
            }
        }

        private void OnConvertComplete(int index)
        {
            (ConvertCompleted as EventHandler<int>)?.Invoke(this, index);
        }


        //solution found from: https://stackoverflow.com/questions/3420737/file-delete-error-the-process-cannot-access-the-file-because-it-is-being-used-b
        private void DeleteAudioStreamBy(string title)
        {
            if (ExistedAudioStreamWith(title))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(GetAudioSavePathFrom(title, false));
            }
        }

        private bool ExistedAudioStreamWith(string title)
        {
            return File.Exists(GetAudioSavePathFrom(title, false));
        }

        private void dataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _addToQueueClickCount++;
            var selectedVideoInfo = new VideoInfo
            {
                Title = _videos[e.RowIndex].Title,
                Url = _videos[e.RowIndex].Url,
                PlayIndex = _addToQueueClickCount
            };
            _downnloadList.Add(selectedVideoInfo);
            AddMusicToQueue(_videos[e.RowIndex]);
        }

        private void AddMusicToQueue(Video video)
        {
            var song = video.ToSong(GetAudioSavePathFrom(video.Title));
            MusicPlayer.PlayList.Enqueue(song);
            MessageBox.Show("Song added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetAudioSavePathFrom(string title, bool isConverted = true)
        {
            if (isConverted)
            {
                return musicSavePath + title.RemoveIllegalChars() + ".mp3";
            }
            return musicSavePath + title.RemoveIllegalChars() + ".WebM";
        }



        private void textBoxSearchMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(this, e);
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Enter Keyword")
            {
                return;
            }
            else
            {
                await Task.Run(() =>
                {
                    _videos = GetListOfVideosFrom(new VideoSearch());
                    //prevent cross thread operation not valid error
                    dataGridViewSearchResult.Invoke((Action)delegate
                    {
                        dataGridViewSearchResult.DataSource = _videos;
                    });
                });
            }
        }

        private List<Video> GetListOfVideosFrom(VideoSearch items)
        {
            return (from item in items.SearchQuery(textBoxSearchMusic.Text, 1)
                          select new Video
                          {
                              //convert string to UTF8 to display Vietnamese string
                              Title = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Title)),
                              Author = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Author)),
                              Duration = item.Duration,
                              Url = item.Url
                          }).ToList();
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
    }
}
