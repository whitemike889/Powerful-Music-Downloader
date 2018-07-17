using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;

namespace MusicDownloader
{
    public static class CommonHelper
    {
        public static TimeSpan IntToTimeString(int interval) => new TimeSpan(0, 0, interval);

        public static bool LengthToBool(object value)
        {
            bool result = !long.TryParse(value.ToString(), out long num) ? false : num == 0L ? true : false;
            return result;
        }
    }
}
