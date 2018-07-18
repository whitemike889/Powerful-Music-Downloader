using MusicDownloader.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace MusicDownloader
{
    public static class MusicDownloader
    {
        private static List<(SongInfo, Uri, string)> DownloadList { get; set; } = new List<(SongInfo, Uri, string)>();
        public static bool Add(SongInfo info, Uri URL, string LocalFileName)
        {
            lock (DownloadList)
            {
                DownloadList.Add((info, URL, LocalFileName));
                return true;
            }
        }
        public static bool RemoveAt(int index)
        {
            lock (DownloadList)
            {
                DownloadList.RemoveAt(index);
                return true;
            }
        }

        public static void StartDownload(int index)
        {
            var item = DownloadList[index];
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += Wc_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadFileAsync(item.Item2, item.Item3, item.Item1.DownloadStatus);
        }

        public static void StartDownload()
        {
            foreach (var item in DownloadList)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += Wc_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                webClient.DownloadFileAsync(item.Item2, item.Item3, item.Item1.DownloadStatus);
            }
        }

        private static void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.UserState is DownloadStatus processData)
            {
                processData.DownloadPercent = e.ProgressPercentage.ToString() + "%";
                processData.MaxValue = e.TotalBytesToReceive;
                processData.CurrentValue = e.BytesReceived;
            }
        }
    }
}
