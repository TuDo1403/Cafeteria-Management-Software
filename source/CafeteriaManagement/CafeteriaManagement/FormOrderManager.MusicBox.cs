using MediaToolkit;
using MediaToolkit.Model;
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
using VideoLibrary;
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

        private void dataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DownloadSelectedRowAudio(e.RowIndex);
            //AddDownloadedAudioToQueue();
        }

        private void AddDownloadedAudioToQueue()
        {
            throw new NotImplementedException();
        }

        private void DownloadSelectedRowAudio(int rowIndex)
        {
            var source = @"C:/Users/tudom/Desktop/";
            var video = YouTube.Default.GetVideo(videos[rowIndex+1].Url);
            File.WriteAllBytes(source + video.FullName, video.GetBytes());

            var inputFile = new MediaFile { Filename = source + video.FullName };
            var outputFile = new MediaFile { Filename = $"{source + video.FullName}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }

            Process.Start("cmd", $"/C del {source + video.FullName}/");
            MessageBox.Show("Added To Queue!");
        }
    }
}
