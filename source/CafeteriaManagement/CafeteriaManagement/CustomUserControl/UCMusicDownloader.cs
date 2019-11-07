using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CafeteriaManagement
{
    public partial class UCMusicDownloader : UserControl
    {
        private int _addToQueueClickCount = 0;
        private UserControl _queue;

        private void ButtonQueue_Click(object sender, EventArgs e)
        {
            _queue.BringToFront();
        }

        public UCMusicDownloader()
        {
            var playSongHistory = SongDownloader.musicSavePath + @"\History.txt";
            using (var streamWriter = new StreamWriter(playSongHistory, true)) { };
            InitializeComponent();
            LoadHistoryToAutoCompleteSource();
            FormMain.FormMainLoaded += FormMain_FormMainLoadedHandler;
        }

        private void FormMain_FormMainLoadedHandler(object sender, UserControl e) => _queue = e;

        private void LoadHistoryToAutoCompleteSource()
        {
            var source = File.ReadAllText(SongDownloader.musicSavePath + @"\History.txt");
            if (!string.IsNullOrEmpty(source))
            {
                var keyWords = source.Split(',');
                var autoCompleteStringCollection = new AutoCompleteStringCollection();
                foreach (var word in keyWords)
                {
                    autoCompleteStringCollection.Add(word);
                }
                textBoxSearchMusic.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
        }

        private void DataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _addToQueueClickCount++;
            MusicPlayer.CreateInstance();
            SongDownloader.CreateInstance().DownloadSongBy(e.RowIndex, _addToQueueClickCount);
            MusicPlayer.AddSongToQueue(e.RowIndex, _addToQueueClickCount);
            MessageBox.Show(Properties.Resources.songAddedText, Properties.Resources.songAddedCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxSearchMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(this, e);
            }
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Enter Keyword")
            {
                return;
            }
            else
            {
                SaveToHistory();
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

        private void SaveToHistory()
        {
            var words = File.ReadAllText(SongDownloader.musicSavePath + @"\History.txt");
            if (string.IsNullOrEmpty(words) || !words.Contains(textBoxSearchMusic.Text))
            {
                textBoxSearchMusic.Invoke((Action)delegate
                {
                    textBoxSearchMusic.AutoCompleteCustomSource.Add(textBoxSearchMusic.Text);
                });
                using (var streamWriter = new StreamWriter(SongDownloader.musicSavePath + @"\History.txt", true))
                {
                    streamWriter.Write(textBoxSearchMusic.Text + ",");
                }
            }
        }

        private void TextBoxSearchMusic_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text == "Enter Keyword")
            {
                textBoxSearchMusic.Text = "";
                textBoxSearchMusic.ForeColor = Color.Black;
            }
        }


        private void TextBoxSearchMusic_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchMusic.Text.Length == 0)
            {
                textBoxSearchMusic.Text = Properties.Resources.textBoxSearchMenuText1;
                textBoxSearchMusic.ForeColor = Color.Gray;
            }
        }
    }
}
