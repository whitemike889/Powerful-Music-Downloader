using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDownloader.Interfaces.Results
{
    public sealed class DownloadLinkResult : IResults
    {
        public string Message { get; set; }

        public string ResultCode { get; set; }

        public string DownloadLink { get; set; }
    }
    public sealed class SearchResults : IResults
    {
        public string Message { get; set; }
        public string ResultCode { get; set; }
        public int Count { get; set; }
        public SongInfo[] ResultList { get; set; }
    }
    public interface IResults
    {
        string Message { get; }
        string ResultCode { get; }
    }

}
