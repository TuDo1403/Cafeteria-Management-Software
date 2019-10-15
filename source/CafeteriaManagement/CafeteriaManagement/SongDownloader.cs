using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace CafeteriaManagement
{
    public class SongDownloader
    {
        public static readonly string musicSavePath = $@"C:\Users\{Environment.UserName}\Music\";
        private static bool _isProcessing = false;
        private static Queue<VideoInfo> _downloadQueue = new Queue<VideoInfo>();
        public static event EventHandler QueueCountChanged;
        public static event EventHandler<VideoInfo> ConvertCompleted;
        private static SongDownloader songDownloader = new SongDownloader();



        public static void DownloadSongBy(int searchIndex, int playIndex)
        {
            QueueCountChanged += SongDownloader_QueueCountChangedHandler;
            ConvertCompleted += SongDownloader_ConvertCompletedHandler;

            var selectedVideoInfo = new VideoInfo
            {
                Title = VideoSearcher.videos[searchIndex].Title,
                Duration = VideoSearcher.videos[searchIndex].Duration,
                Url = VideoSearcher.videos[searchIndex].Url,
                PlayIndex = playIndex
            };

            _downloadQueue.Enqueue(selectedVideoInfo);
            OnQueueCountChanging();
        }


        private static async void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e)
        {
            if (_isProcessing == false && _downloadQueue.Count > 0)
            {
                _isProcessing = true;
                await WriteConvertedAudioFilesToPathFrom(_downloadQueue.Peek()).ConfigureAwait(true);
            }
        }

        private static async Task WriteConvertedAudioFilesToPathFrom(VideoInfo videoInfo)
        {
            if (AlreadyExistedAudioConvertedFrom(videoInfo) == false)
            {
                await DownloadAudioStreamFrom(videoInfo).ConfigureAwait(true);
                await Task.Run(() =>
                {
                    ConvertAudioStreamToMp3By(videoInfo);
                    DeleteAudioStreamBy(videoInfo.Title);
                    WriteDownloadedSongToTxt(videoInfo);
                    
                }).ConfigureAwait(true);
            }
            else
            {
                OnConvertComplete(videoInfo);
            }
        }

        private static void OnConvertComplete(VideoInfo videoInfo) => (ConvertCompleted as EventHandler<VideoInfo>)?.Invoke(songDownloader, videoInfo);

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

        public static string GetAudioSavePathFrom(string title, bool isConverted = true)
        {
            if (isConverted)
            {
                return musicSavePath + title.RemoveIllegalChars() + ".mp3";
            }
            return musicSavePath + title.RemoveIllegalChars() + ".WebM";
        }

        private static void ConvertAudioStreamToMp3By(VideoInfo videoInfo)
        {
            var input = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title, false) };
            var output = new MediaFile { Filename = GetAudioSavePathFrom(videoInfo.Title) };
            using (var engine = new Engine())
            {
                engine.GetMetadata(input);
                engine.Convert(input, output);

                videoInfo.IsConverted = true;
                OnConvertComplete(videoInfo);

                _isProcessing = false;
                _downloadQueue.Dequeue();
                OnQueueCountChanging();
            }
        }

        private static void OnQueueCountChanging() => (QueueCountChanged as EventHandler)?.Invoke(songDownloader, EventArgs.Empty);

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

        private static async void SongDownloader_QueueCountChangedHandler(object sender, EventArgs e)
        {
            if (_isProcessing == false && _downloadQueue.Count > 0)
            {
                _isProcessing = true;
                await WriteConvertedAudioFilesToPathFrom(_downloadQueue.Peek()).ConfigureAwait(true);
            }
        }
    }
}

