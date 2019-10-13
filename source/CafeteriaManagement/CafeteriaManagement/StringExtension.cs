using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public static class StringExtension
    {
        public static string RemoveIllegalChars(this string source) => string.Join("_", source.Split(Path.GetInvalidFileNameChars()));
    }
}
