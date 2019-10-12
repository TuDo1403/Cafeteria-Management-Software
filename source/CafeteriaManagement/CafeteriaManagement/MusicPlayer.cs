using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace CafeteriaManagement
{
    public class MusicPlayer
    {
        bool _isMediaEnded = false;

        bool _isPaused = false;

        public static event EventHandler<Queue<Song>> SongChanged;

        public static Queue<Song> playList = new Queue<Song>();

        private static MusicPlayer musicPlayer;

        private WindowsMediaPlayer windowsMediaPlayer;

        public static MusicPlayer GetInstance()
        {
            if (musicPlayer == null)
            {
                musicPlayer = new MusicPlayer();
            }
            return musicPlayer;
        }

        public void Play()
        {
            if (playList.Count >= 1)
            {
                if (_isPaused == false)
                {
                    OnSongChanging();
                    windowsMediaPlayer.URL = playList.Dequeue().Url;
                }
                    
                else if (_isPaused)
                    _isPaused = false;
                windowsMediaPlayer.controls.play();
            }
            
        }

        private void OnSongChanging()
        {
            (SongChanged as EventHandler<Queue<Song>>)?.Invoke(this, playList);
        }

        public void Pause()
        {
            windowsMediaPlayer.controls.pause();
        }

        private MusicPlayer()
        {
            windowsMediaPlayer = new WindowsMediaPlayer();
            windowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
        }

        


        //idea from https://multisoftextreme.blogspot.com/2009/08/windows-media-player-end-of-stream.html
        private void WindowsMediaPlayer_PlayStateChange(int NewState)
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
                _isPaused = true;
        }
    }
}
