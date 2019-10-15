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
using System.Threading;

namespace CafeteriaManagement
{
    public partial class FormMusicBox : Form
    {
        private int _addToQueueClickCount = 0;



        private void buttonQueue_Click(object sender, EventArgs e)
        {
            var formQueue = FormQueue.CreateInstance();
            this.Hide();
            formQueue.ShowDialog();
            this.Show();
        }

        public FormMusicBox()
        {
            InitializeComponent();
        }

        private void dataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _addToQueueClickCount++;
            SongDownloader.DownloadSongBy(e.RowIndex, _addToQueueClickCount);
            MusicPlayer.AddSongToQueue(e.RowIndex, _addToQueueClickCount);
            MessageBox.Show("Song added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    var searchResults = VideoSearcher.GetListOfVideosFrom(textBoxSearchMusic.Text);
                    //prevent cross thread operation not valid error
                    dataGridViewSearchResult.Invoke((Action)delegate
                    {
                        dataGridViewSearchResult.DataSource = searchResults;
                    });
                }).ConfigureAwait(true);
            }
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
            if (textBoxSearchMusic.Text.Length == 0)
            {
                textBoxSearchMusic.Text = "Enter Keyword";
                textBoxSearchMusic.ForeColor = Color.Gray;
            }
        }

    }
}
