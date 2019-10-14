using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace CafeteriaManagement
{
    //MusicPlayer class with Singleton Pattern
    public class MusicPlayer
    {
        private static MusicPlayer musicPlayer;
        private bool _isMediaEnded = false;
        private WindowsMediaPlayer windowsMediaPlayer;

        public static event EventHandler<Queue<Song>> SongChanged;

        public static Queue<Song> PlayList { get; private set; } = new Queue<Song>();
        public static bool IsPaused { get; set; } = false;

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
            windowsMediaPlayer = new WindowsMediaPlayer();
            windowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChangeHandler;
            FormQueue.SongPrev += FormQueue_SongPrevHandler;
            FormQueue.SongNext += FormQueue_SongNextHandler;
        }


        private void FormQueue_SongNextHandler(object sender, EventArgs e)
        {
            if (PlayList.Count >= 1 && NextSongIsConverted(PlayList.Peek()))
            {
                OnSongChanging();
                windowsMediaPlayer.controls.stop();
                windowsMediaPlayer.URL = PlayList.Dequeue().Url;
                windowsMediaPlayer.controls.play();
            }
        }

        private bool NextSongIsConverted(Song e)
        {
            foreach (var index in FormQueue.ConvertedPlayIndex)
            {
                if (index == e.Index)
                    return true;
            }
            return false;
        }

        private void FormQueue_SongPrevHandler(object sender, Song e)
        {
            //add last song to the beginning of the queue
            PlayList = new Queue<Song>(PlayList.Prepend(e));
            OnSongChanging();
            windowsMediaPlayer.controls.stop();
            windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            windowsMediaPlayer.controls.play();
        }

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



        public void Play()
        {
            if (IsPaused == false && PlayList.Count >= 1)
            {
                OnSongChanging();
                windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            }
            else if (IsPaused)
                IsPaused = false;
            windowsMediaPlayer.controls.play();

        }

        private void OnSongChanging()
        {
            (SongChanged as EventHandler<Queue<Song>>)?.Invoke(this, PlayList);
        }



        public void Pause()
        {
            windowsMediaPlayer.controls.pause();
        }
    }
}
