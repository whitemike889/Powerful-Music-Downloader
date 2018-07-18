using MusicDownloader.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.IO;
using System.Diagnostics;

namespace MusicDownloader.Windows
{
    public partial class MainWindow : Form
    {
        List<IMusicSource> _loadedPlugins = new List<IMusicSource>();
        SongInfo[] songs;
        public MainWindow()
        {
            InitializeComponent();
        }
        private IMusicSource CurrentSource;
        private string CurrentQuality;
        private SongInfo CurrentSelectedSong;

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            downloadPath.Text = Directory.CreateDirectory(Application.StartupPath + "\\Downloaded\\").FullName;
            currentStatus.Text = "";
        }

        private void LoadPlugins_ButtonClick(object sender, EventArgs e)
        {
            if (loadDllDialog.ShowDialog() == DialogResult.OK)
            {
                pluginFilePAth.Text = loadDllDialog.FileName;
                string filePath = pluginFilePAth.Text;
                LoadAssemblyFromFile(filePath);
            }
        }

        private void LoadAssemblyFromFile(string filePath)
        {
            var s = Assembly.LoadFrom(filePath);
            var plugins = (from t in s.ExportedTypes where t.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IMusicSource)) select t).ToList();
            foreach (var types in plugins)
            {
                var o = (IMusicSource)types.GetConstructor(Type.EmptyTypes).Invoke(null);
                _loadedPlugins.Add(o);
                plListSelection.Items.Add(o.MusicSourceName);
            }
        }

        private void DoSearch_ButtonClick(object sender, EventArgs e)
        {
            if (CurrentSource == null)
            {
                MessageBox.Show("请先加载音乐插件");
                return;
            }
            MusicList.Items.Clear();
            var m = HttpHelper.SearchSongs(keyWord.Text, CurrentSource);
            songs = m;
            foreach (var item in m)
            {
                MusicList.Items.Add(new ListViewItem(new string[] { item.MusicID, item.Name, item.SingerName, CommonHelper.IntToTimeString(item.ContinuedTime).ToString() }));
            }
        }

        private void GetDownloadLink_ButtonClick(object sender, EventArgs e)
        {
            string URL = HttpHelper.GetDownloadURL(CurrentSelectedSong, CurrentQuality, CurrentSource);
            var uri = new Uri(URL);
            string Fullpath = URL.Substring(0, URL.IndexOf(uri.Query));
            string extension = Fullpath.Substring(Fullpath.LastIndexOf("."));
            if (Fullpath.IndexOf(CurrentQuality) < 0)
            {
                MessageBox.Show("暂时找不到请求的音质，现在提供的是" + extension);
                QualityDropDown.SelectedText = extension;
            }
            downloadQuality.Text = extension;
            musicURL.Text = URL;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSource = _loadedPlugins[plListSelection.SelectedIndex];
            QualityDropDown.Items.Clear();
            QualityDropDown.Items.AddRange(CurrentSource.MusicQualityList);
            QualityDropDown.SelectedIndex = 0;
            CurrentQuality = QualityDropDown.SelectedItem.ToString();
            plAuthor.Text = CurrentSource.Author;
            plVer.Text = CurrentSource.MusicSourceVersion; ;
            interfaceVer.Text = CurrentSource.InterfaceVersion;
            formats.Text = string.Join("/", CurrentSource.MusicQualityList);
        }

        private void QualityDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentQuality = QualityDropDown.SelectedItem.ToString();
            if (CurrentSelectedSong != null)
            {
                GetDownloadLink_ButtonClick(sender, e);
            }
        }

        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputDevice?.PlaybackState != PlaybackState.Playing)
            {
                if (MusicList.SelectedItems.Count > 0)
                {
                    Stop_Btn_Click(sender, e);
                    CurrentSelectedSong = songs[MusicList.SelectedIndices[0]];
                    musicController.Enabled = true;
                    musicURL.Clear();
                    downloadFileName.Text = CurrentSelectedSong.Name + " - " + CurrentSelectedSong.SingerName;
                }
                else
                {
                    musicController.Enabled = false;
                }
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lhy0403/Powerful-Music-Downloader");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (savePathDialog.ShowDialog() == DialogResult.OK)
            {
                downloadPath.Text = savePathDialog.SelectedPath;
            }
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            if (outputDevice?.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
            }
            else
            {
                try
                {
                    audioFile = new AudioFileReader(musicURL.Text);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请求的文件播放失败，换个音质试试？\r\n" + ex.Message);
                    return;
                }
            }
            outputDevice.Volume = volumeTrackbar.Value / 100f;
            playStatusTimer.Enabled = true;
            progressPlaybackTrakbar.Maximum = (int)audioFile.TotalTime.TotalMilliseconds + 1;
        }

        private void Pause_Btn_Click(object sender, EventArgs e)
        {
            outputDevice.Pause();
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            playStatusTimer.Enabled = false;
            currentProgressLabel.Text = "00:00/00:00";
            progressPlaybackTrakbar.Value = 0;
            outputDevice?.Stop();
            outputDevice?.Dispose();
        }

        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {
            outputDevice.Volume = volumeTrackbar.Value / 100f;
        }

        private void playStatusTimer_Tick(object sender, EventArgs e)
        {
            progressPlaybackTrakbar.Value = (int)audioFile.CurrentTime.TotalMilliseconds;
            currentProgressLabel.Text = audioFile.CurrentTime.ToString(@"mm\:ss") + "/" + audioFile.TotalTime.ToString(@"mm\:ss");
        }

        private void progressPlaybackTrakbar_Scroll(object sender, EventArgs e)
        {
            audioFile.CurrentTime = new TimeSpan(0, 0, 0, 0, progressPlaybackTrakbar.Value);
        }

        private void AddDownloadList_Click(object sender, EventArgs e)
        {
            string URL = HttpHelper.GetDownloadURL(CurrentSelectedSong, CurrentQuality, CurrentSource);
            var uri = new Uri(URL);
            string Fullpath = URL.Substring(0, URL.IndexOf(uri.Query));
            string extension = Fullpath.Substring(Fullpath.LastIndexOf("."));
            lock (downloadListView.Items)
            {
                downloadListView.Items.Add(new ListViewItem(new string[]
                {
                CurrentSelectedSong.Name + " - " + CurrentSelectedSong.SingerName,
                "等待下载", "0%"
                }));
                CurrentSelectedSong.DownloadStatus.IndexOfList = downloadListView.Items.Count - 1;
            }
            CurrentSelectedSong.DownloadStatus.PropertyChanged += DownloadStatus_PropertyChanged;
            MusicDownloader.Add(CurrentSelectedSong, uri, downloadPath.Text + downloadFileName.Text + "." + extension);
        }

        private void DownloadStatus_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<DownloadStatus, PropertyChangedEventArgs>(delegating), sender as DownloadStatus, e);
            }
            else
            {
                delegating(sender as DownloadStatus, e);
            }
        }

        private void delegating(DownloadStatus status, PropertyChangedEventArgs e)
        {
            downloadListView.Items[status.IndexOfList].SubItems[1].Text = status.DownloadPercent == "100%" ? "已完成" : "正在下载";
            downloadListView.Items[status.IndexOfList].SubItems[2].Text = status.DownloadPercent;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MusicDownloader.StartDownload();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            downloadListView.Items.Clear();
        }
    }
}
