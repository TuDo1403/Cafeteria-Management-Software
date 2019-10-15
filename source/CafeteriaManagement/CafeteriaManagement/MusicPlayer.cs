using System;
using System.Collections.Generic;
using System.Linq;
using WMPLib;

namespace CafeteriaManagement
{
    //MusicPlayer class with Singleton Pattern
    public class MusicPlayer
    {
        public static List<int> ConvertedSongIndexes { get; private set; } = new List<int>();
        private static MusicPlayer musicPlayer;
        private static bool _isMediaEnded = false;
        private static readonly WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();

        public static event EventHandler<Queue<Song>> SongChanged;
        public static event EventHandler<Song> SongAdded;

        public static Queue<Song> PlayList { get; private set; } = new Queue<Song>();
        public static bool IsPaused { get; set; } = false;
        public static List<Song> PlayHistories { get; private set; } = new List<Song>();

        public static MusicPlayer GetInstance()
        {
            if (musicPlayer == null)
            {
                musicPlayer = new MusicPlayer();
            }
            return musicPlayer;
        }

        private MusicPlayer()
        {
            windowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChangeHandler;
            FormQueue.SongPrev += FormQueue_SongPrevHandler;
            FormQueue.SongNext += FormQueue_SongNextHandler;

            SongDownloader.ConvertCompleted += SongDownloader_ConvertCompletedHandler;
        }

        private void FormQueue_SongPrevHandler(object sender, EventArgs e)
        {
            //add last song to the beginning of the queue
            if (PlayHistories.Count >= 1)
            {
                PlayList = new Queue<Song>(PlayList.Prepend(PlayHistories.Last()));
                Play();
            }

            //OnSongChanging();
            //windowsMediaPlayer.controls.stop();
            //windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            //windowsMediaPlayer.controls.play();

        }

        private static void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e)
        {
            ConvertedSongIndexes.Add(e.PlayIndex);
        }

        private static void FormQueue_SongNextHandler(object sender, EventArgs e)
        {
            if (NextSongIsConverted(PlayList.Peek()) && PlayList.Count >= 2)
            {
                Play();
            }
        }

        private static bool NextSongIsConverted(Song e)
        {
            foreach (var index in ConvertedSongIndexes)
            {
                if (index == e.Index)
                    return true;
            }
            return false;
        }

        //idea from https://multisoftextreme.blogspot.com/2009/08/windows-media-player-end-of-stream.html
        private static void WindowsMediaPlayer_PlayStateChangeHandler(int NewState)
        {
            if (windowsMediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
                _isMediaEnded = true;
            else if (windowsMediaPlayer.playState == WMPPlayState.wmppsTransitioning)
            {
                if (_isMediaEnded)
                {
                    _isMediaEnded = false;
                    Play();
                }
            }
            else if (windowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
                IsPaused = true;
        }



        public static void Play()
        {
            if (IsPaused == false && PlayList.Count >= 1)
            {
                PlayHistories.Add(PlayList.Peek());
                OnSongChanging();
                windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            }
            else if (IsPaused)
                IsPaused = false;
            windowsMediaPlayer.controls.play();

        }

        private static void OnSongChanging() => (SongChanged as EventHandler<Queue<Song>>)?.Invoke(musicPlayer, PlayList);


        public static void Pause() => windowsMediaPlayer.controls.pause();

        public static void AddSongToQueue(int searchIndex, int playIndex)
        {
            var videoInfo = new VideoInfo
            {
                Title = VideoSearcher.videos[searchIndex].Title,
                Duration = VideoSearcher.videos[searchIndex].Duration,
                Url = VideoSearcher.videos[searchIndex].Url,
                PlayIndex = playIndex
            };

            var song = videoInfo.ToSong(SongDownloader.GetAudioSavePathFrom(videoInfo.Title));
            PlayList.Enqueue(song);
            OnSongAdding(song);
        }

        private static void OnSongAdding(Song song) => (SongAdded as EventHandler<Song>)?.Invoke(musicPlayer, song);
    }
}
