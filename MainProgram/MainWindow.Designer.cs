namespace MusicDownloader.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pluginFilePAth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadDllDialog = new System.Windows.Forms.OpenFileDialog();
            this.plListSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MusicList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Play_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.QualityDropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.savePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.musicController = new System.Windows.Forms.Panel();
            this.DownLoadGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.downloadQuality = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.downloadFileName = new System.Windows.Forms.TextBox();
            this.downloadPath = new System.Windows.Forms.TextBox();
            this.AddDownloadList = new System.Windows.Forms.Button();
            this.MusicAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.musicURL = new System.Windows.Forms.TextBox();
            this.getAddressBtn = new System.Windows.Forms.Button();
            this.PlayBackGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.Pause_Btn = new System.Windows.Forms.Button();
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.progressPlaybackTrakbar = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.logList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.downloadListView = new System.Windows.Forms.ListView();
            this.downlist_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downlist_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downlist_percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.plAuthor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.formats = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.plVer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.interfaceVer = new System.Windows.Forms.Label();
            this.playStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.musicController.SuspendLayout();
            this.DownLoadGroupBox.SuspendLayout();
            this.MusicAddressGroupBox.SuspendLayout();
            this.PlayBackGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPlaybackTrakbar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginFilePAth
            // 
            this.pluginFilePAth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginFilePAth.Location = new System.Drawing.Point(83, 12);
            this.pluginFilePAth.Name = "pluginFilePAth";
            this.pluginFilePAth.ReadOnly = true;
            this.pluginFilePAth.Size = new System.Drawing.Size(849, 21);
            this.pluginFilePAth.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(938, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "从文件加载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadPlugins_ButtonClick);
            // 
            // loadDllDialog
            // 
            this.loadDllDialog.FileName = "extension";
            this.loadDllDialog.Filter = "音乐下载器插件|*.dll";
            this.loadDllDialog.Title = "加载插件";
            // 
            // plListSelection
            // 
            this.plListSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plListSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plListSelection.FormattingEnabled = true;
            this.plListSelection.IntegralHeight = false;
            this.plListSelection.Location = new System.Drawing.Point(827, 49);
            this.plListSelection.Name = "plListSelection";
            this.plListSelection.Size = new System.Drawing.Size(225, 20);
            this.plListSelection.TabIndex = 2;
            this.plListSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "使用的插件：";
            // 
            // keyWord
            // 
            this.keyWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyWord.Location = new System.Drawing.Point(93, 20);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(507, 21);
            this.keyWord.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "搜索关键字：";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(606, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DoSearch_ButtonClick);
            // 
            // MusicList
            // 
            this.MusicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MusicList.FullRowSelect = true;
            this.MusicList.GridLines = true;
            this.MusicList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MusicList.HideSelection = false;
            this.MusicList.Location = new System.Drawing.Point(6, 47);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(470, 558);
            this.MusicList.TabIndex = 6;
            this.MusicList.UseCompatibleStateImageBehavior = false;
            this.MusicList.View = System.Windows.Forms.View.Details;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "歌曲ID";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲名";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "持续时间";
            this.columnHeader3.Width = 130;
            // 
            // Play_Btn
            // 
            this.Play_Btn.Location = new System.Drawing.Point(6, 20);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(59, 26);
            this.Play_Btn.TabIndex = 7;
            this.Play_Btn.Text = "播放▶";
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "音质：";
            // 
            // QualityDropDown
            // 
            this.QualityDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityDropDown.FormattingEnabled = true;
            this.QualityDropDown.Location = new System.Drawing.Point(51, 5);
            this.QualityDropDown.Name = "QualityDropDown";
            this.QualityDropDown.Size = new System.Drawing.Size(164, 20);
            this.QualityDropDown.TabIndex = 8;
            this.QualityDropDown.SelectedIndexChanged += new System.EventHandler(this.QualityDropDown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "插件路径：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.musicController);
            this.groupBox2.Controls.Add(this.keyWord);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.MusicList);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 611);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索和下载";
            // 
            // musicController
            // 
            this.musicController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicController.Controls.Add(this.DownLoadGroupBox);
            this.musicController.Controls.Add(this.label4);
            this.musicController.Controls.Add(this.QualityDropDown);
            this.musicController.Controls.Add(this.MusicAddressGroupBox);
            this.musicController.Controls.Add(this.PlayBackGroupBox);
            this.musicController.Enabled = false;
            this.musicController.Location = new System.Drawing.Point(482, 47);
            this.musicController.Name = "musicController";
            this.musicController.Size = new System.Drawing.Size(228, 558);
            this.musicController.TabIndex = 14;
            // 
            // DownLoadGroupBox
            // 
            this.DownLoadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownLoadGroupBox.Controls.Add(this.label16);
            this.DownLoadGroupBox.Controls.Add(this.label15);
            this.DownLoadGroupBox.Controls.Add(this.downloadQuality);
            this.DownLoadGroupBox.Controls.Add(this.label13);
            this.DownLoadGroupBox.Controls.Add(this.button8);
            this.DownLoadGroupBox.Controls.Add(this.label7);
            this.DownLoadGroupBox.Controls.Add(this.label11);
            this.DownLoadGroupBox.Controls.Add(this.downloadFileName);
            this.DownLoadGroupBox.Controls.Add(this.downloadPath);
            this.DownLoadGroupBox.Controls.Add(this.AddDownloadList);
            this.DownLoadGroupBox.Location = new System.Drawing.Point(3, 385);
            this.DownLoadGroupBox.Name = "DownLoadGroupBox";
            this.DownLoadGroupBox.Size = new System.Drawing.Size(222, 170);
            this.DownLoadGroupBox.TabIndex = 13;
            this.DownLoadGroupBox.TabStop = false;
            this.DownLoadGroupBox.Text = "下载";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(171, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "0KB";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "预计的文件大小";
            // 
            // downloadQuality
            // 
            this.downloadQuality.AutoSize = true;
            this.downloadQuality.Location = new System.Drawing.Point(45, 95);
            this.downloadQuality.Name = "downloadQuality";
            this.downloadQuality.Size = new System.Drawing.Size(47, 12);
            this.downloadQuality.TabIndex = 5;
            this.downloadQuality.Text = "Quality";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "音质：";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(194, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 21);
            this.button8.TabIndex = 3;
            this.button8.Text = "…";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "文件名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "下载位置：";
            // 
            // downloadFileName
            // 
            this.downloadFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFileName.Location = new System.Drawing.Point(6, 71);
            this.downloadFileName.Name = "downloadFileName";
            this.downloadFileName.Size = new System.Drawing.Size(210, 21);
            this.downloadFileName.TabIndex = 1;
            // 
            // downloadPath
            // 
            this.downloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadPath.Location = new System.Drawing.Point(6, 32);
            this.downloadPath.Name = "downloadPath";
            this.downloadPath.Size = new System.Drawing.Size(182, 21);
            this.downloadPath.TabIndex = 1;
            // 
            // AddDownloadList
            // 
            this.AddDownloadList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDownloadList.Location = new System.Drawing.Point(6, 127);
            this.AddDownloadList.Name = "AddDownloadList";
            this.AddDownloadList.Size = new System.Drawing.Size(210, 37);
            this.AddDownloadList.TabIndex = 0;
            this.AddDownloadList.Text = "添加到下载列表";
            this.AddDownloadList.UseVisualStyleBackColor = true;
            this.AddDownloadList.Click += new System.EventHandler(this.AddDownloadList_Click);
            // 
            // MusicAddressGroupBox
            // 
            this.MusicAddressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicAddressGroupBox.Controls.Add(this.musicURL);
            this.MusicAddressGroupBox.Controls.Add(this.getAddressBtn);
            this.MusicAddressGroupBox.Location = new System.Drawing.Point(3, 31);
            this.MusicAddressGroupBox.Name = "MusicAddressGroupBox";
            this.MusicAddressGroupBox.Size = new System.Drawing.Size(222, 153);
            this.MusicAddressGroupBox.TabIndex = 11;
            this.MusicAddressGroupBox.TabStop = false;
            this.MusicAddressGroupBox.Text = "音乐地址：";
            // 
            // musicURL
            // 
            this.musicURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicURL.Location = new System.Drawing.Point(3, 48);
            this.musicURL.Multiline = true;
            this.musicURL.Name = "musicURL";
            this.musicURL.ReadOnly = true;
            this.musicURL.Size = new System.Drawing.Size(216, 102);
            this.musicURL.TabIndex = 9;
            // 
            // getAddressBtn
            // 
            this.getAddressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getAddressBtn.Location = new System.Drawing.Point(6, 20);
            this.getAddressBtn.Name = "getAddressBtn";
            this.getAddressBtn.Size = new System.Drawing.Size(210, 22);
            this.getAddressBtn.TabIndex = 12;
            this.getAddressBtn.Text = "获取音乐地址";
            this.getAddressBtn.UseVisualStyleBackColor = true;
            this.getAddressBtn.Click += new System.EventHandler(this.GetDownloadLink_ButtonClick);
            // 
            // PlayBackGroupBox
            // 
            this.PlayBackGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayBackGroupBox.Controls.Add(this.label9);
            this.PlayBackGroupBox.Controls.Add(this.label1);
            this.PlayBackGroupBox.Controls.Add(this.Play_Btn);
            this.PlayBackGroupBox.Controls.Add(this.Stop_Btn);
            this.PlayBackGroupBox.Controls.Add(this.volumeTrackbar);
            this.PlayBackGroupBox.Controls.Add(this.Pause_Btn);
            this.PlayBackGroupBox.Controls.Add(this.currentProgressLabel);
            this.PlayBackGroupBox.Controls.Add(this.progressPlaybackTrakbar);
            this.PlayBackGroupBox.Location = new System.Drawing.Point(3, 190);
            this.PlayBackGroupBox.Name = "PlayBackGroupBox";
            this.PlayBackGroupBox.Size = new System.Drawing.Size(219, 189);
            this.PlayBackGroupBox.TabIndex = 10;
            this.PlayBackGroupBox.TabStop = false;
            this.PlayBackGroupBox.Text = "试听";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "进度";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "音量";
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.Location = new System.Drawing.Point(6, 52);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(125, 26);
            this.Stop_Btn.TabIndex = 10;
            this.Stop_Btn.Text = "停止🛑";
            this.Stop_Btn.UseVisualStyleBackColor = true;
            this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.volumeTrackbar.Location = new System.Drawing.Point(171, 17);
            this.volumeTrackbar.Maximum = 100;
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeTrackbar.Size = new System.Drawing.Size(45, 124);
            this.volumeTrackbar.TabIndex = 11;
            this.volumeTrackbar.Value = 100;
            this.volumeTrackbar.Scroll += new System.EventHandler(this.volumeTrackbar_Scroll);
            // 
            // Pause_Btn
            // 
            this.Pause_Btn.Location = new System.Drawing.Point(72, 20);
            this.Pause_Btn.Name = "Pause_Btn";
            this.Pause_Btn.Size = new System.Drawing.Size(59, 26);
            this.Pause_Btn.TabIndex = 10;
            this.Pause_Btn.Text = "暂停⏸";
            this.Pause_Btn.UseVisualStyleBackColor = true;
            this.Pause_Btn.Click += new System.EventHandler(this.Pause_Btn_Click);
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.currentProgressLabel.Location = new System.Drawing.Point(22, 102);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(96, 16);
            this.currentProgressLabel.TabIndex = 9;
            this.currentProgressLabel.Text = "00:00/00:00";
            // 
            // progressPlaybackTrakbar
            // 
            this.progressPlaybackTrakbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPlaybackTrakbar.Location = new System.Drawing.Point(3, 141);
            this.progressPlaybackTrakbar.Name = "progressPlaybackTrakbar";
            this.progressPlaybackTrakbar.Size = new System.Drawing.Size(213, 45);
            this.progressPlaybackTrakbar.TabIndex = 8;
            this.progressPlaybackTrakbar.Scroll += new System.EventHandler(this.progressPlaybackTrakbar_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前状态：";
            // 
            // currentStatus
            // 
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(32, 17);
            this.currentStatus.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "项目主页";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(334, 17);
            this.toolStripStatusLabel3.Text = "https://github.com/lhy0403/Powerful-Music-Downloader";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "下载状态：";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            // 
            // logList
            // 
            this.logList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logList.FormattingEnabled = true;
            this.logList.IntegralHeight = false;
            this.logList.ItemHeight = 12;
            this.logList.Location = new System.Drawing.Point(3, 17);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(312, 199);
            this.logList.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.logList);
            this.groupBox3.Location = new System.Drawing.Point(734, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 219);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作日志";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.downloadListView);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(734, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 294);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "下载列表";
            // 
            // downloadListView
            // 
            this.downloadListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.downlist_name,
            this.downlist_status,
            this.downlist_percent});
            this.downloadListView.GridLines = true;
            this.downloadListView.HideSelection = false;
            this.downloadListView.Location = new System.Drawing.Point(6, 53);
            this.downloadListView.Name = "downloadListView";
            this.downloadListView.Size = new System.Drawing.Size(306, 235);
            this.downloadListView.TabIndex = 15;
            this.downloadListView.UseCompatibleStateImageBehavior = false;
            this.downloadListView.View = System.Windows.Forms.View.Details;
            // 
            // downlist_name
            // 
            this.downlist_name.Text = "歌曲名";
            this.downlist_name.Width = 122;
            // 
            // downlist_status
            // 
            this.downlist_status.Text = "状态";
            this.downlist_status.Width = 67;
            // 
            // downlist_percent
            // 
            this.downlist_percent.Text = "进度";
            this.downlist_percent.Width = 111;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(263, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 27);
            this.button11.TabIndex = 14;
            this.button11.Text = "清空";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 27);
            this.button9.TabIndex = 14;
            this.button9.Text = "全部开始";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "作者:";
            // 
            // plAuthor
            // 
            this.plAuthor.AutoSize = true;
            this.plAuthor.Location = new System.Drawing.Point(814, 86);
            this.plAuthor.Name = "plAuthor";
            this.plAuthor.Size = new System.Drawing.Size(41, 12);
            this.plAuthor.TabIndex = 13;
            this.plAuthor.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(877, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "支持的格式:";
            // 
            // formats
            // 
            this.formats.AutoSize = true;
            this.formats.Location = new System.Drawing.Point(954, 109);
            this.formats.Name = "formats";
            this.formats.Size = new System.Drawing.Size(47, 12);
            this.formats.TabIndex = 13;
            this.formats.Text = "Formats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(756, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "插件版本:";
            // 
            // plVer
            // 
            this.plVer.AutoSize = true;
            this.plVer.Location = new System.Drawing.Point(814, 109);
            this.plVer.Name = "plVer";
            this.plVer.Size = new System.Drawing.Size(35, 12);
            this.plVer.TabIndex = 13;
            this.plVer.Text = "PlVer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "接口版本:";
            // 
            // interfaceVer
            // 
            this.interfaceVer.AutoSize = true;
            this.interfaceVer.Location = new System.Drawing.Point(954, 86);
            this.interfaceVer.Name = "interfaceVer";
            this.interfaceVer.Size = new System.Drawing.Size(41, 12);
            this.interfaceVer.TabIndex = 13;
            this.interfaceVer.Text = "IntVer";
            // 
            // playStatusTimer
            // 
            this.playStatusTimer.Tick += new System.EventHandler(this.playStatusTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.formats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.plVer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.interfaceVer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.plAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plListSelection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pluginFilePAth);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.musicController.ResumeLayout(false);
            this.musicController.PerformLayout();
            this.DownLoadGroupBox.ResumeLayout(false);
            this.DownLoadGroupBox.PerformLayout();
            this.MusicAddressGroupBox.ResumeLayout(false);
            this.MusicAddressGroupBox.PerformLayout();
            this.PlayBackGroupBox.ResumeLayout(false);
            this.PlayBackGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPlaybackTrakbar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pluginFilePAth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog loadDllDialog;
        private System.Windows.Forms.ComboBox plListSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView MusicList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button Play_Btn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox QualityDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog savePathDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentStatus;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox musicURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label plAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label formats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label plVer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label interfaceVer;
        private System.Windows.Forms.GroupBox PlayBackGroupBox;
        private System.Windows.Forms.Label currentProgressLabel;
        private System.Windows.Forms.TrackBar progressPlaybackTrakbar;
        private System.Windows.Forms.Button Pause_Btn;
        private System.Windows.Forms.Button Stop_Btn;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.Button getAddressBtn;
        private System.Windows.Forms.GroupBox MusicAddressGroupBox;
        private System.Windows.Forms.GroupBox DownLoadGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddDownloadList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox downloadPath;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label downloadQuality;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox downloadFileName;
        private System.Windows.Forms.ListView downloadListView;
        private System.Windows.Forms.ColumnHeader downlist_name;
        private System.Windows.Forms.ColumnHeader downlist_status;
        private System.Windows.Forms.ColumnHeader downlist_percent;
        private System.Windows.Forms.Panel musicController;
        private System.Windows.Forms.Timer playStatusTimer;
    }
}