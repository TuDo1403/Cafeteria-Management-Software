using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace CafeteriaManagement
{
    //MusicPlayer class with Singleton Pattern
    public class MusicPlayer
    {
        private static MusicPlayer _musicPlayer;
        private static bool _isMediaEnded = false;
        private static readonly WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();

        public static bool IsPaused { get; set; } = false;
        public static Queue<Song> PlayList { get; private set; } = new Queue<Song>();
        public static List<Song> PlayHistories { get; private set; } = new List<Song>();

        public static event EventHandler<Queue<Song>> SongChanged;
        public static event EventHandler<Song> SongAdded;

        public static MusicPlayer CreateInstance()
        {
            if (_musicPlayer == null)
            {
                _musicPlayer = new MusicPlayer();
            }
            return _musicPlayer;
        }

        private MusicPlayer()
        {
            windowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChangeHandler;
            UCQueueBox.SongPrev += FormQueue_SongPrevHandler;
            UCQueueBox.SongNext += FormQueue_SongNextHandler;
            SongDownloader.ConvertCompleted += SongDownloader_ConvertCompletedHandler;
        }

        private static void SongDownloader_ConvertCompletedHandler(object sender, VideoInfo e)
        {
            foreach (var song in PlayList)
            {
                if (song.Title == e.Title)
                {
                    song.IsConverted = true;
                    break;
                }
            }
        }

        private void FormQueue_SongPrevHandler(object sender, EventArgs e)
        {
            //add last song to the beginning of the queue
            if (PlayHistories.Count >= 1)
            {
               // PlayList = new Queue<Song>(PlayList.Prepend(PlayHistories.Last()));
                Play();
            }
        }


        private void FormQueue_SongNextHandler(object sender, EventArgs e) => Play();


        //idea from https://multisoftextreme.blogspot.com/2009/08/windows-media-player-end-of-stream.html
        private void WindowsMediaPlayer_PlayStateChangeHandler(int NewState)
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
            if (IsPaused == false && PlayList.Count >= 1 && PlayList.Peek().IsConverted)
            {
                PlayHistories.Add(PlayList.Peek());
                OnSongChanging();
                windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            }
            else if (IsPaused)
                IsPaused = false;

            windowsMediaPlayer.controls.play();
        }

        private static void OnSongChanging() => (SongChanged as EventHandler<Queue<Song>>)?.Invoke(_musicPlayer, PlayList);


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

        private static void OnSongAdding(Song song) => (SongAdded as EventHandler<Song>)?.Invoke(_musicPlayer, song);



        public static void Resume() => windowsMediaPlayer.controls.play();
    }
}
