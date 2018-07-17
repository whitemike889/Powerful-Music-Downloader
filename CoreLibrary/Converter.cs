using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDownloader
{
    public static class Converter
    {
        public static T ConvertJSON<T>(string JSON)
        {
            return JsonConvert.DeserializeObject<T>(JSON);
        }
    }
}
