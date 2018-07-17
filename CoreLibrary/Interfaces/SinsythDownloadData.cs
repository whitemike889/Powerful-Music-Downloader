namespace MusicDownloader.Interfaces
{
    public class SinsythDownloadData
    {
        public string type { get; set; }
        public Rendata Rendata { get; set; }
        public string Info { get; set; }
        public string State { get; set; }
    }
    public class Rendata
    {
        public string Tname { get; set; }
        public string Type { get; set; }
        public string Song { get; set; }
        public string Audio { get; set; }
        public string Method { get; set; }
        public int Time { get; set; }
    }
}
