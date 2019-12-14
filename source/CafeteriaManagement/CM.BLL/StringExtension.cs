using CM.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CM.BLL
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

        public static string GetMD5HashedString(this string input)
        {
            var bytesFromPassword = Encoding.UTF8.GetBytes(input);
            using var hashAlgorithm = MD5.Create();
            var hash = hashAlgorithm.ComputeHash(bytesFromPassword);

            var stringBuilder = new StringBuilder();
            foreach (var item in hash)
            {
                // convert to hexadecimal
                stringBuilder.Append(item.ToString("x2", CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }
    }
}
