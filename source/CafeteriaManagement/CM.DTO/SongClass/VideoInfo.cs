namespace CM.DTO
{
    //provide video info for downloading audio stream and converting it to mp3
    public class VideoInfo
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Url { get; set; }
        public int PlayIndex { get; set; }
        public bool IsConverted { get; set; } = false;



        public Song ToSong(string savePath)
        {
            return new Song
            {
                Index = PlayIndex,
                Title = this.Title,
                Duration = this.Duration,
                Url = savePath
            };
        }
    }
}
