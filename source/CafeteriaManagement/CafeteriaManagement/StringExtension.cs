using System;
using System.Collections.Generic;
using System.IO;

namespace CafeteriaManagement
{
    public static class StringExtension
    {
        public static string RemoveIllegalChars(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException(nameof(source));
            }

            return string.Join("_", source.Split(Path.GetInvalidFileNameChars()));
        }

        public static IEnumerable<Song> ToSong(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');
                yield return new Song
                {
                    Title = columns[0],
                    Duration = columns[1],
                    Url = columns[2]
                };
            }
        }
    }
}
