using CM.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSearch;

namespace CafeteriaManagement
{
    public class VideoSearcher
    {
        public static List<Video> videos = new List<Video>();

        public static List<Video> GetListOfVideosFrom(string userInput)
        {
            videos = (from item in new VideoSearch().SearchQuery(userInput, 1)
                      select new Video
                      {
                          //convert string to UTF8 to display Vietnamese string
                          Title = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Title)),
                          Author = Encoding.UTF8.GetString(Encoding.Default.GetBytes(item.Author)),
                          Duration = item.Duration,
                          Url = item.Url
                      }).ToList();
            return videos;
        }
    }
}
