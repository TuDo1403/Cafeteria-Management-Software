using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaManagement;
using System.IO;

namespace CafeteriaManagement
{
    public partial class UCDisplayMusicNew : UserControl
    {
        private UserControl _queue;
        private int _queueCount = 0;

        public UCDisplayMusicNew()
        {
            var playSongHistory = SongDownloader.musicSavePath + @"\History.txt";
            using (var streamWriter = new StreamWriter(playSongHistory, true)) { };
            FormMainLosed.FormMainLoaded += FormMain_FormMainLoadedHandler;
            InitializeComponent();

            MaterialSkin.MaterialSkinManager.Instance.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            MaterialSkin.MaterialSkinManager.Instance.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE);

            LoadHistoryToAutoCompleteSource();

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


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblOnline_Click(object sender, EventArgs e)
        {

            timerPanelOffline.Start();
            timerGreenOnline.Start();
        }

        private void TimerPanelOnline_Tick(object sender, EventArgs e)
        {
            /* if (pnlOffline.Left >= 40)
             {
                 pnlOffline.Left -= _time;
                 pnlOnline.Left -= _time;
                 _time += 1;
             }
             else
             {
                 timerPanelOnline.Stop();
                 _time = 20;
             }
             */

        }

        private void LblOffline_Click(object sender, EventArgs e)
        {
            timerPanelOnline.Start();
            timerGreenOffline.Start();
        }

        private void TimerPanelOffline_Tick(object sender, EventArgs e)
        {
            /* if (pnlOnline.Left <= 26)
             {
                 pnlOffline.Left += _time;
                 pnlOnline.Left += _time;
                 _time += 1;
             }
             else
             {
                 timerPanelOffline.Stop();
                 _time = 20;
             }*/

        }

        private void TimerGreenOffline_Tick(object sender, EventArgs e)
        {
            if (pnlGreen.Left <= 125)
            {
                pnlGreen.Left += 6;
            }
            else
            {
                timerGreenOffline.Stop();
            }
        }

        private void TimerGreenOnline_Tick(object sender, EventArgs e)
        {
            if (pnlGreen.Left >= 25)
            {
                pnlGreen.Left -= 6;
            }
            else
            {
                timerGreenOnline.Stop();
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


        private void TextBoxSearchMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(this, e);
            }
        }


        private void ButtonQueue_Click(object sender, EventArgs e) => _queue.BringToFront();


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
                        dataGridViewSearchResult.Columns[2].Visible = false;
                        dataGridViewSearchResult.Columns[3].Visible = false;
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
                using var streamWriter = new StreamWriter(SongDownloader.musicSavePath + @"\History.txt", true);
                streamWriter.Write(textBoxSearchMusic.Text + ",");
            }
        }

        private void DataGridViewSearchResult_DoubleClick(object sender, EventArgs e)
        {
            _queueCount++;
            var rowIndex = dataGridViewSearchResult.SelectedRows[0].Index;
            MusicPlayer.CreateInstance();
            SongDownloader.CreateInstance().DownloadSongBy(rowIndex, _queueCount);
            MusicPlayer.AddSongToQueue(rowIndex, _queueCount);
            using var result = new FormAnnouncementNew();
            result.ShowMessage(Properties.Resources.songAddedText, Properties.Resources.songAddedCaption, false);
        }
    }
}
