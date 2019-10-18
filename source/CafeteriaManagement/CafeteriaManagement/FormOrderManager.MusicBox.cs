using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormMusicBox : Form
    {
        private int _addToQueueClickCount = 0;

        private void buttonQueue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQueue.CreateInstance().ShowDialog();
            this.Show();
        }

        public FormMusicBox()
        {
            InitializeComponent();
            LoadHistoryToAutoCompleteSource();
        }

        private void LoadHistoryToAutoCompleteSource()
        {
            var source = File.ReadAllText(SongDownloader.musicSavePath + @"\History.txt");
            var keyWords = source.Split(',');
            var autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var word in keyWords)
            {
                autoCompleteStringCollection.Add(word);
            }
            textBoxSearchMusic.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void dataGridViewSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _addToQueueClickCount++;
            MusicPlayer.CreateInstance();
            SongDownloader.CreateInstance().DownloadSongBy(e.RowIndex, _addToQueueClickCount);
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
                    SaveToHistory();
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
            if (!words.Contains(textBoxSearchMusic.Text))
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
