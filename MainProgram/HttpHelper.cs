using MusicDownloader.Interfaces;
using MusicDownloader.Interfaces.Results;

using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MusicDownloader
{

    public static class HttpHelper
    {
        public static SongInfo[] SearchSongs<TSongSource>(string keyWord, TSongSource songSource) where TSongSource : IMusicSource
        {
            List<SongInfo> list = new List<SongInfo>();
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            var method = songSource.GetResearchMethod(keyWord, 0, 100);
            string json = method.IsPost ? webClient.UploadString(method.Uri, method.POSTData) : webClient.DownloadString(method.Uri);
            SearchResults results = songSource.GetSearchResults(json);
            return results.ResultList;
        }

        public static string GetDownloadURL<TSongSource>(SongInfo song, string songFormat, TSongSource songSource) where TSongSource : IMusicSource
        {
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");

            var method = songSource.GetDownloadMethod(song.MusicID, songFormat);
            string json = method.IsPost ? webClient.UploadString(method.Uri, method.POSTData) : webClient.DownloadString(method.Uri);
            DownloadLinkResult result = songSource.GetDownloadLink(json);
            return result.DownloadLink;
        }
    }
}
