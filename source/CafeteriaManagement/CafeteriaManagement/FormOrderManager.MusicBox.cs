using YoutubeExplode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace CafeteriaManagement
{
    public partial class FormMusicBox : Form
    {
        List<Video> videos;

        public FormMusicBox()
        {
            InitializeComponent();
        }

        private void textBoxSearchMusic_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Search")
            {
                textBoxSearchMusic.Text = "";
                textBoxSearchMusic.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchMusic_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "")
            {
                textBoxSearchMusic.Text = "Search";
                textBoxSearchMusic.ForeColor = Color.Black;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var items = new VideoSearch();
            videos = SearchedResultsToVideos(items);
            dataGridViewSearchResult.DataSource = videos;
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
            await Task.Run(() =>
            {
                DownloadSelectedRowAudio(e.RowIndex);
            });
        }

        private async void DownloadSelectedRowAudio(int rowIndex)
        {
            var selectedUrl = videos[rowIndex].Url;
            var client = new YoutubeClient();
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(YoutubeClient.ParseVideoId(selectedUrl));
            var streamInfo = streamInfoSet.Audio.OrderByDescending(a => a.Bitrate).First();
            var extension = streamInfo.Container;
            await client.DownloadMediaStreamAsync(streamInfo, $"C:\\Users\\tudom\\{System.Environment.UserName}\\downloaded.{extension}");
        }

        private void textBoxSearchMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(this, e);
            }
        }
    }
}
