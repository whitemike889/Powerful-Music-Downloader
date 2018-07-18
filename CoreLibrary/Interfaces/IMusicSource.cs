using MusicDownloader.Interfaces.Results;

using System;

namespace MusicDownloader.Interfaces
{
    public interface IMusicSource
    {
        string MusicSourceName { get; }
        string Author { get; }

        string InterfaceVersion { get; }
        string MusicSourceVersion { get; }

        string[] MusicQualityList { get; }
        WebRequestData GetResearchMethod(string keyword, int skip, int limit);
        WebRequestData GetDownloadMethod(string MusicID, string quality);
        
        DownloadLinkResult GetDownloadLink(string resultJSON);
        SearchResults GetSearchResults(string resultJSON);
    }

    public class WebRequestData
    {
        public bool IsPost { get; set; }
        public Uri Uri { get; set; }
        public string POSTData { get; set; }
    }

    public class SongInfo
    {
        public string Name { get; set; }
        public string SingerName { get; set; }
        public string AlbumName { get; set; }
        public int ContinuedTime { get; set; }
        public string MusicID { get; set; }
        public DownloadStatus DownloadStatus { get; set; }
    }
}
