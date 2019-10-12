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
            if (PlayList.Count >= 1 && _isPaused == false)
                windowsMediaPlayer.URL = PlayList.Dequeue().Url;
            else if (_isPaused)
                _isPaused = false;
            windowsMediaPlayer.controls.play();
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

        bool _isMediaEnded = false;

        bool _isPaused = false;

        internal static Queue<Song> PlayList { get => playList; set => playList = value; }

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
