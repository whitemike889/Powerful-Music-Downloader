using MusicDownloader;
using MusicDownloader.Interfaces;
using MusicDownloader.Interfaces.Results;
using System;
using System.Linq;

namespace QQMusic
{
    public class QQMusic : IMusicSource
    {
        public readonly static string qqSearchURL = "https://c.y.qq.com/soso/fcgi-bin/client_search_cp?ct=24&qqmusic_ver=1298&new_json=1&remoteplace=txt.yqq.center&searchid=47105719578687519&t=0&aggr=1&cr=1&catZhida=1&lossless=0&flag_qc=0&p=1&n=100&w=";
        public readonly static string SinsythInterface_QQ = "https://www.sinsyth.com/lxapi/ssk/yqq.x";
        public readonly static string qqMusicDetailPage = "https://y.qq.com/n/yqq/song/";
        public string MusicSourceName => "QQ 音乐";

        public DownloadLinkResult GetDownloadLink(string resultJSON)
        {
            var resultsObject = Converter.ConvertJSON<SinsythDownloadData>(resultJSON);
            return new DownloadLinkResult()
            {
                Message = resultsObject.State,
                ResultCode = resultsObject.Info,
                DownloadLink = resultsObject.Rendata.Song
            };
        }

        public WebRequestData GetDownloadMethod(string ID, string quality)
        {
            return new WebRequestData()
            {
                IsPost = true,
                POSTData = "surl=" + qqMusicDetailPage + ID + "&type=" + quality + "&strkey=yqq_18analyze",
                Uri = new Uri(SinsythInterface_QQ)
            };
        }

        public WebRequestData GetResearchMethod(string keyword, int skip, int limit)
        {
            return new WebRequestData()
            {
                IsPost = false,
                POSTData = null,
                Uri = new Uri(qqSearchURL + keyword)
            };
        }

        public SearchResults GetSearchResults(string resultJSON)
        {
            var resultsObject = Converter.ConvertJSON<_QQMusicSearchResultInternal>(resultJSON);
            return new SearchResults()
            {
                Count = resultsObject.data.song.list.Length,
                ResultCode = resultsObject.code + ":" + resultsObject.subcode,
                Message = string.IsNullOrWhiteSpace(resultsObject.message) ? resultsObject.message : "OK",
                ResultList = (from song in resultsObject.data.song.list
                              select new SongInfo()
                              {
                                  AlbumName = song.album.name,
                                  ContinuedTime = song.interval,
                                  DownloadStatus = new DownloadStatus(),
                                  Name = song.name,
                                  MusicID = song.mid,
                                  SingerName = string.Join("/", from _singer in song.singer select _singer.name)
                              }).ToArray(),

            };
        }
    }
}