using MusicDownloader.Interfaces;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using MusicDownloader.Interfaces.Results;

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
            // REMOVE "callback(" and ")"
            json = json.Substring(9, json.Length - 9);
            json = json.Substring(0, json.Length - 1);

            SearchResults results = songSource.GetSearchResults(json);
            return results.ResultList;
        }

        public static string GetDownloadURL<TSongSource>(string MusicID, string songFormat, TSongSource songSource) where TSongSource : IMusicSource
        {
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");

            var method = songSource.GetDownloadMethod(MusicID, songFormat);
            string json = method.IsPost ? webClient.UploadString(method.Uri, method.POSTData) : webClient.DownloadString(method.Uri);
            DownloadLinkResult result = songSource.GetDownloadLink(json);
            return result.DownloadLink;
        }


        public static void DownFile(string fileUrl, string savePath, DownloadStatus pd)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += Wc_DownloadProgressChanged;
            webClient.DownloadFileAsync(new Uri(fileUrl), savePath, pd);
        }


        private static void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.UserState is DownloadStatus processData)
            {
                processData.MaxValue = e.TotalBytesToReceive;
                processData.CurrentValue = e.BytesReceived;
                processData.DownloadPercent = e.ProgressPercentage.ToString() + "%";
            }
        }
    }
}
