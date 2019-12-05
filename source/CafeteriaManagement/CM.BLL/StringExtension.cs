using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                if (string.IsNullOrEmpty(line))
                {
                    throw new ArgumentNullException(nameof(source));
                }

                var columns = line.Split(',');
                yield return new Song
                {
                    Title = columns[0],
                    Duration = columns[1],
                    Url = columns[2]
                };
            }
        }

        public static string Standardlize(this string source)
        {
            CatchInvalidNameException(source);
            source = source.ToLower();
            var columns = source.Split(' ').ToList();
            columns.RemoveAll(s => string.IsNullOrWhiteSpace(s));
            var result = "";
            foreach (var column in columns)
            {
                result += column[0].ToString().ToUpper() + column.Substring(1) + " ";
            }
            return result.TrimEnd();
        }

        private static void CatchInvalidNameException(string source)
        {
            if (!source.IsValidName())
            {
                throw new Exception("Name is not valid!");
            }
        }

        public static bool IsValidName(this string source)
        {
            if (source.Any(char.IsDigit))
                return false;
            if (!source.Contains(" "))
                return false;
            return true;
        }

    }
}
