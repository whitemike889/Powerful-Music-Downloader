using MusicDownloader.Interfaces;
using MusicDownloader.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInPlugins
{
    public class Netease : IMusicSource
    {
        public string MusicSourceName => "网易云音乐";

        public string Author => "Leroy.H.Y";

        public string InterfaceVersion => "V1.0.0";

        public string MusicSourceVersion => "V1.0.0";

        public string[] MusicQualityList => new string[] { };

        public DownloadLinkResult GetDownloadLink(string resultJSON) => throw new NotImplementedException();
        public WebRequestData GetDownloadMethod(string MusicID, string quality) => throw new NotImplementedException();
        public WebRequestData GetResearchMethod(string keyword, int skip, int limit) => throw new NotImplementedException();
        public SearchResults GetSearchResults(string resultJSON) => throw new NotImplementedException();
    }
}
