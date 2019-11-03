using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode;

namespace CafeteriaManagement
{
    public sealed class SongDownloader : IDisposable
    {
        private static SongDownloader _songDownloader;
        private static Queue<VideoInfo> _downloadQueue = new Queue<VideoInfo>();
        private readonly BackgroundWorker _backgroundWorker = new BackgroundWorker();

        public static readonly string musicSavePath = $@"C:\Users\{Environment.UserName}\Music\";
        public static event EventHandler<VideoInfo> ConvertCompleted;



        public static SongDownloader CreateInstance()
        {
            if (_songDownloader == null)
            {
                _songDownloader = new SongDownloader();
            }
            return _songDownloader;
        }


        private SongDownloader()
        {
            _backgroundWorker.DoWork += _backgroundWorker_DoWorkHandler;
            _backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void _backgroundWorker_DoWorkHandler(object sender, DoWorkEventArgs e)
        {
            while(_downloadQueue.Count >= 1)
            {
                if (AlreadyExistedAudioConvertedFrom(_downloadQueue.Peek()) == false)
                {
                    GetAudioFileFrom(_downloadQueue.Dequeue());
                }
                else
                {
                    var convertedFile = _downloadQueue.Dequeue();
                    OnConvertComplete(convertedFile);
                }
            }
            _backgroundWorker.CancelAsync();
        }

        private static void OnConvertComplete(VideoInfo videoInfo)
        {
            videoInfo.IsConverted = true;
            (ConvertCompleted as EventHandler<VideoInfo>)?.Invoke(_downloadQueue, videoInfo);
        }


        private static async void GetAudioFileFrom(VideoInfo videoInfo)
        {
            await DownloadAudioStreamFrom(videoInfo).ConfigureAwait(true);
            await Task.Run(() =>
            {
                ConvertAudioStreamToMp3By(videoInfo);
                DeleteAudioStreamBy(videoInfo.Title);
                WriteDownloadedSongToTxt(videoInfo);
            }).ConfigureAwait(true);
        }

        private static void WriteDownloadedSongToTxt(VideoInfo videoInfo)
        {
            using (var streamWriter = new StreamWriter(musicSavePath + @"\DownloadedSong.txt", true))
            {
                var savePath = GetAudioSavePathFrom(videoInfo.Title);
                streamWriter.WriteLine($"{videoInfo.Title},{videoInfo.Duration},{savePath}");
            }
        }


        //solution found from: https://stackoverflow.com/questions/3420737/file-delete-error-the-process-cannot-access-the-file-because-it-is-being-used-b
        private static void DeleteAudioStreamBy(string title)
        {
            if (ExistedAudioStreamWith(title))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(GetAudioSavePathFrom(title, false));
            }
        }

        private static bool ExistedAudioStreamWith(string title) => File.Exists(GetAudioSavePathFrom(title, false));



        private static void ConvertAudioStreamToMp3By(VideoInfo videoInfo)
        {
            var input = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title, false) };
            var output = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title) };
            using (var engine = new Engine())
            {
                engine.GetMetadata(input);
                engine.Convert(input, output);

                OnConvertComplete(videoInfo);
            }
        }

        public static string GetAudioSavePathFrom(string title, bool isConverted = true)
        {
            if (isConverted)
            {
                return musicSavePath + title.RemoveIllegalChars() + ".mp3";
            }
            return musicSavePath + title.RemoveIllegalChars() + ".WebM";
        }


        private static async Task DownloadAudioStreamFrom(VideoInfo videoInfo)
        {
            var videoIdFromUrl = YoutubeClient.ParseVideoId(videoInfo.Url);
            var streamInfoSet = await new YoutubeClient().GetVideoMediaStreamInfosAsync(videoIdFromUrl)
                                                         .ConfigureAwait(true);
            var streamInfo = streamInfoSet.Audio.OrderByDescending(audio => audio.Bitrate)
                                                .First(a => a.Container == YoutubeExplode.Models.MediaStreams.Container.WebM);
            await new YoutubeClient().DownloadMediaStreamAsync(streamInfo, GetAudioSavePathFrom(videoInfo.Title, false))
                                     .ConfigureAwait(true);
        }


        private static bool AlreadyExistedAudioConvertedFrom(VideoInfo videoInfo) => File.Exists(GetAudioSavePathFrom(videoInfo.Title));


        public void DownloadSongBy(int searchIndex, int playIndex)
        {
            var selectedVideoInfo = new VideoInfo
            {
                Title = VideoSearcher.videos[searchIndex].Title,
                Duration = VideoSearcher.videos[searchIndex].Duration,
                Url = VideoSearcher.videos[searchIndex].Url,
                PlayIndex = playIndex
            };

            _downloadQueue.Enqueue(selectedVideoInfo);

            if (_backgroundWorker.IsBusy == false)
            {
                _backgroundWorker.RunWorkerAsync();
            }
        }



        public void Dispose()
        {
            _backgroundWorker.Dispose();
        }
    }
}

