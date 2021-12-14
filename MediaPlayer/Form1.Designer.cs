
namespace MediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipReverseSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxPlayList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.lblDurationEnd = new System.Windows.Forms.Label();
            this.lblDurationStart = new System.Windows.Forms.Label();
            this.Volumelbl = new System.Windows.Forms.Label();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.btnFastforward = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.btnHideShowPlaylistCLICKED = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.btnHideShowPlaylist = new System.Windows.Forms.Button();
            this.RptBtn = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.LengthSlider = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.picBoxMediaPlayIcon = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPlayIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(181)))), ((int)(((byte)(168)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.controlsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.closeMediaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "Media";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // closeMediaToolStripMenuItem
            // 
            this.closeMediaToolStripMenuItem.Name = "closeMediaToolStripMenuItem";
            this.closeMediaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeMediaToolStripMenuItem.Text = "Close Media";
            this.closeMediaToolStripMenuItem.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playListToolStripMenuItem,
            this.mediaSpeedToolStripMenuItem,
            this.skipReverseSpeedToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playListToolStripMenuItem.Text = "PlayList";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.btnHideShowPlaylist_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.btnHideShowPlaylistCLICKED_Click);
            // 
            // mediaSpeedToolStripMenuItem
            // 
            this.mediaSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x05ToolStripMenuItem,
            this.x10ToolStripMenuItem,
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem});
            this.mediaSpeedToolStripMenuItem.Name = "mediaSpeedToolStripMenuItem";
            this.mediaSpeedToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mediaSpeedToolStripMenuItem.Text = "Media Speed";
            // 
            // x05ToolStripMenuItem
            // 
            this.x05ToolStripMenuItem.Name = "x05ToolStripMenuItem";
            this.x05ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.x05ToolStripMenuItem.Text = "x0.5";
            this.x05ToolStripMenuItem.Click += new System.EventHandler(this.x05ToolStripMenuItem_Click);
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.x10ToolStripMenuItem.Text = "x1.0";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.x2ToolStripMenuItem.Text = "x2.0";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.x3ToolStripMenuItem.Text = "x3.0";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // skipReverseSpeedToolStripMenuItem
            // 
            this.skipReverseSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondsToolStripMenuItem,
            this.secondsToolStripMenuItem1,
            this.minuteToolStripMenuItem});
            this.skipReverseSpeedToolStripMenuItem.Name = "skipReverseSpeedToolStripMenuItem";
            this.skipReverseSpeedToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.skipReverseSpeedToolStripMenuItem.Text = "Skip/Reverse Speed";
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.secondsToolStripMenuItem.Text = "10 Seconds ";
            this.secondsToolStripMenuItem.Click += new System.EventHandler(this.secondsToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem1
            // 
            this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
            this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.secondsToolStripMenuItem1.Text = "30 Seconds ";
            this.secondsToolStripMenuItem1.Click += new System.EventHandler(this.secondsToolStripMenuItem1_Click);
            // 
            // minuteToolStripMenuItem
            // 
            this.minuteToolStripMenuItem.Name = "minuteToolStripMenuItem";
            this.minuteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.minuteToolStripMenuItem.Text = "1 Minute";
            this.minuteToolStripMenuItem.Click += new System.EventHandler(this.minuteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBoxPlayList
            // 
            this.listBoxPlayList.AllowDrop = true;
            this.listBoxPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(181)))), ((int)(((byte)(168)))));
            this.listBoxPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayList.FormatString = "D";
            this.listBoxPlayList.FormattingEnabled = true;
            this.listBoxPlayList.HorizontalScrollbar = true;
            this.listBoxPlayList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxPlayList.ItemHeight = 18;
            this.listBoxPlayList.Location = new System.Drawing.Point(0, 509);
            this.listBoxPlayList.Name = "listBoxPlayList";
            this.listBoxPlayList.Size = new System.Drawing.Size(931, 56);
            this.listBoxPlayList.TabIndex = 12;
            this.listBoxPlayList.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayList_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(181)))), ((int)(((byte)(168)))));
            this.groupBox1.Controls.Add(this.btnHideShowPlaylist);
            this.groupBox1.Controls.Add(this.VolumeSlider);
            this.groupBox1.Controls.Add(this.btnFullScreen);
            this.groupBox1.Controls.Add(this.lblDurationEnd);
            this.groupBox1.Controls.Add(this.lblDurationStart);
            this.groupBox1.Controls.Add(this.Volumelbl);
            this.groupBox1.Controls.Add(this.btnFastforward);
            this.groupBox1.Controls.Add(this.PrevBtn);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.PlayBtn);
            this.groupBox1.Controls.Add(this.btnHideShowPlaylistCLICKED);
            this.groupBox1.Controls.Add(this.nextBtn);
            this.groupBox1.Controls.Add(this.RptBtn);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnShuffle);
            this.groupBox1.Controls.Add(this.btnRewind);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.LengthSlider);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreen.BackgroundImage = global::MediaPlayer.Properties.Resources.Fullscreen;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Location = new System.Drawing.Point(888, 16);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(40, 38);
            this.btnFullScreen.TabIndex = 11;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // lblDurationEnd
            // 
            this.lblDurationEnd.AutoSize = true;
            this.lblDurationEnd.Location = new System.Drawing.Point(912, 77);
            this.lblDurationEnd.Name = "lblDurationEnd";
            this.lblDurationEnd.Size = new System.Drawing.Size(13, 13);
            this.lblDurationEnd.TabIndex = 21;
            this.lblDurationEnd.Text = "0";
            // 
            // lblDurationStart
            // 
            this.lblDurationStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDurationStart.AutoSize = true;
            this.lblDurationStart.Location = new System.Drawing.Point(12, 77);
            this.lblDurationStart.Name = "lblDurationStart";
            this.lblDurationStart.Size = new System.Drawing.Size(13, 13);
            this.lblDurationStart.TabIndex = 20;
            this.lblDurationStart.Text = "0";
            // 
            // Volumelbl
            // 
            this.Volumelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Volumelbl.AutoSize = true;
            this.Volumelbl.Location = new System.Drawing.Point(128, 20);
            this.Volumelbl.Name = "Volumelbl";
            this.Volumelbl.Size = new System.Drawing.Size(13, 13);
            this.Volumelbl.TabIndex = 19;
            this.Volumelbl.Text = "0";
            this.Volumelbl.Click += new System.EventHandler(this.Volumelbl_Click_1);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VolumeSlider.Location = new System.Drawing.Point(147, 16);
            this.VolumeSlider.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(112, 45);
            this.VolumeSlider.TabIndex = 17;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            this.VolumeSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VolumeSlider_MouseMove);
            // 
            // btnFastforward
            // 
            this.btnFastforward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFastforward.BackgroundImage = global::MediaPlayer.Properties.Resources.P;
            this.btnFastforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFastforward.FlatAppearance.BorderSize = 0;
            this.btnFastforward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFastforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastforward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastforward.Location = new System.Drawing.Point(511, 10);
            this.btnFastforward.Name = "btnFastforward";
            this.btnFastforward.Size = new System.Drawing.Size(38, 35);
            this.btnFastforward.TabIndex = 7;
            this.btnFastforward.UseVisualStyleBackColor = true;
            this.btnFastforward.Click += new System.EventHandler(this.btnFastforward_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevBtn.BackgroundImage = global::MediaPlayer.Properties.Resources.Prev;
            this.PrevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrevBtn.FlatAppearance.BorderSize = 0;
            this.PrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.Location = new System.Drawing.Point(345, 10);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(42, 38);
            this.PrevBtn.TabIndex = 0;
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.BackgroundImage = global::MediaPlayer.Properties.Resources.Stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(311, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(28, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayBtn.BackgroundImage = global::MediaPlayer.Properties.Resources.Pause1;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(452, 6);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(53, 42);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // btnHideShowPlaylistCLICKED
            // 
            this.btnHideShowPlaylistCLICKED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHideShowPlaylistCLICKED.BackColor = System.Drawing.Color.Transparent;
            this.btnHideShowPlaylistCLICKED.BackgroundImage = global::MediaPlayer.Properties.Resources.Playlist;
            this.btnHideShowPlaylistCLICKED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideShowPlaylistCLICKED.FlatAppearance.BorderSize = 0;
            this.btnHideShowPlaylistCLICKED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHideShowPlaylistCLICKED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowPlaylistCLICKED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShowPlaylistCLICKED.Location = new System.Drawing.Point(12, 17);
            this.btnHideShowPlaylistCLICKED.Name = "btnHideShowPlaylistCLICKED";
            this.btnHideShowPlaylistCLICKED.Size = new System.Drawing.Size(30, 30);
            this.btnHideShowPlaylistCLICKED.TabIndex = 15;
            this.btnHideShowPlaylistCLICKED.UseVisualStyleBackColor = false;
            this.btnHideShowPlaylistCLICKED.Click += new System.EventHandler(this.btnHideShowPlaylistCLICKED_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextBtn.BackgroundImage = global::MediaPlayer.Properties.Resources.Next;
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(555, 9);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(42, 38);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // btnHideShowPlaylist
            // 
            this.btnHideShowPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHideShowPlaylist.BackgroundImage = global::MediaPlayer.Properties.Resources.Playlist;
            this.btnHideShowPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideShowPlaylist.FlatAppearance.BorderSize = 0;
            this.btnHideShowPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHideShowPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShowPlaylist.Location = new System.Drawing.Point(12, 16);
            this.btnHideShowPlaylist.Name = "btnHideShowPlaylist";
            this.btnHideShowPlaylist.Size = new System.Drawing.Size(30, 30);
            this.btnHideShowPlaylist.TabIndex = 14;
            this.btnHideShowPlaylist.UseVisualStyleBackColor = true;
            this.btnHideShowPlaylist.Click += new System.EventHandler(this.btnHideShowPlaylist_Click);
            // 
            // RptBtn
            // 
            this.RptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RptBtn.BackgroundImage = global::MediaPlayer.Properties.Resources.rpt;
            this.RptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RptBtn.FlatAppearance.BorderSize = 0;
            this.RptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RptBtn.Location = new System.Drawing.Point(264, 14);
            this.RptBtn.Name = "RptBtn";
            this.RptBtn.Size = new System.Drawing.Size(41, 28);
            this.RptBtn.TabIndex = 3;
            this.RptBtn.UseVisualStyleBackColor = true;
            this.RptBtn.Click += new System.EventHandler(this.RptBtn_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.BackgroundImage = global::MediaPlayer.Properties.Resources.Play;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(452, 7);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 42);
            this.btnPause.TabIndex = 13;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShuffle.BackgroundImage = global::MediaPlayer.Properties.Resources.shuffle;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(603, 15);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(34, 26);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRewind.BackgroundImage = global::MediaPlayer.Properties.Resources.B;
            this.btnRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRewind.FlatAppearance.BorderSize = 0;
            this.btnRewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewind.Location = new System.Drawing.Point(393, 10);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(53, 37);
            this.btnRewind.TabIndex = 8;
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFolder.BackgroundImage = global::MediaPlayer.Properties.Resources.Folder;
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(643, 9);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(36, 36);
            this.btnFolder.TabIndex = 10;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // LengthSlider
            // 
            this.LengthSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LengthSlider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LengthSlider.LargeChange = 2;
            this.LengthSlider.Location = new System.Drawing.Point(3, 54);
            this.LengthSlider.Maximum = 100;
            this.LengthSlider.Name = "LengthSlider";
            this.LengthSlider.Size = new System.Drawing.Size(925, 45);
            this.LengthSlider.TabIndex = 18;
            this.LengthSlider.Scroll += new System.EventHandler(this.LengthSlider_Scroll);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(931, 541);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // Time
            // 
            this.Time.Interval = 1;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // picBoxMediaPlayIcon
            // 
            this.picBoxMediaPlayIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.picBoxMediaPlayIcon.BackgroundImage = global::MediaPlayer.Properties.Resources.Pause1;
            this.picBoxMediaPlayIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxMediaPlayIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxMediaPlayIcon.Location = new System.Drawing.Point(0, 24);
            this.picBoxMediaPlayIcon.Name = "picBoxMediaPlayIcon";
            this.picBoxMediaPlayIcon.Size = new System.Drawing.Size(931, 485);
            this.picBoxMediaPlayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxMediaPlayIcon.TabIndex = 17;
            this.picBoxMediaPlayIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(931, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxMediaPlayIcon);
            this.Controls.Add(this.listBoxPlayList);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPlayIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button RptBtn;
        private System.Windows.Forms.Button btnShuffle;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnFastforward;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxPlayList;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHideShowPlaylistCLICKED;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMediaToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox picBoxMediaPlayIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.TrackBar LengthSlider;
        private System.Windows.Forms.Label Volumelbl;
        private System.Windows.Forms.Label lblDurationStart;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ToolStripMenuItem mediaSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x05ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipReverseSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minuteToolStripMenuItem;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button btnHideShowPlaylist;
        private System.Windows.Forms.Label lblDurationEnd;
    }
}

