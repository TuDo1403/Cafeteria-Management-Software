using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class Video
    {
        public string Title { get; set; }

        public string Duration { get; set; }

        public string Author { get; set; }

        public string Url { get; set; }

        public Song ToSong(string path)
        {
            return new Song
            {
                Title = this.Title,
                Duration = this.Duration,
                Artist = this.Author,
                Url = path
            };
        }
    }
}
