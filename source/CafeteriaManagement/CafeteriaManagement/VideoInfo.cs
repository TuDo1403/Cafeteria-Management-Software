using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    //provide video info for downloading audio stream and converting it to mp3
    public class VideoInfo
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int PlayIndex { get; set; }
    }
}
