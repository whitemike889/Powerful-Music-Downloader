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

namespace MusicDownloader.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        IMusicSource currentSource;
        List<IMusicSource> _loadedPlugins = new List<IMusicSource>();
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void LoadPlugins_ButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pluginFilePAth.Text = openFileDialog1.FileName;
                Assembly s = Assembly.LoadFrom(pluginFilePAth.Text);
                var m = (from t in s.ExportedTypes where t.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IMusicSource)) select t).ToList();

                foreach (var types in m)
                {
                    var o = (IMusicSource)m[0].GetConstructor(Type.EmptyTypes).Invoke(null);
                    comboBox1.Items.Add(o.MusicSourceName);
                    _loadedPlugins.Add(o);
                }
            }
        }

        private void DoSearch_ButtonClick(object sender, EventArgs e)
        {
            MusicList.Items.Clear();
            var m = HttpHelper.SearchSongs(keyWord.Text, currentSource);
            foreach (var item in m)
            {
                MusicList.Items.Add(new ListViewItem(new string[] { item.MusicID, item.Name, item.SingerName, CommonHelper.IntToTimeString(item.ContinuedTime).ToString() }));
            }
        }

        private void GetDownloadLink_ButtonClick(object sender, EventArgs e)
        {
            string URL = HttpHelper.GetDownloadURL(MusicList.SelectedItems[0].Text, "mp3", currentSource);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSource = _loadedPlugins[comboBox1.SelectedIndex];
        }
    }
}
