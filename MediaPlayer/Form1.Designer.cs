
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
            this.PrevBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.RptBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFastforward = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxPlayList = new System.Windows.Forms.ListBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnHideShowPlaylist = new System.Windows.Forms.Button();
            this.btnHideShowPlaylistCLICKED = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.picBoxMediaPlayIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Duration = new System.Windows.Forms.Label();
            this.Volumelbl = new System.Windows.Forms.Label();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.LengthSlider = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPlayIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevBtn
            // 
            this.PrevBtn.FlatAppearance.BorderSize = 0;
            this.PrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrevBtn.Image")));
            this.PrevBtn.Location = new System.Drawing.Point(307, 21);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(53, 42);
            this.PrevBtn.TabIndex = 0;
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // PlayBtn
            // 
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayBtn.Image")));
            this.PlayBtn.Location = new System.Drawing.Point(403, 21);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(53, 42);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.Location = new System.Drawing.Point(513, 21);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(45, 42);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // RptBtn
            // 
            this.RptBtn.FlatAppearance.BorderSize = 0;
            this.RptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RptBtn.Image = ((System.Drawing.Image)(resources.GetObject("RptBtn.Image")));
            this.RptBtn.Location = new System.Drawing.Point(248, 21);
            this.RptBtn.Name = "RptBtn";
            this.RptBtn.Size = new System.Drawing.Size(53, 42);
            this.RptBtn.TabIndex = 3;
            this.RptBtn.UseVisualStyleBackColor = true;
            this.RptBtn.Click += new System.EventHandler(this.RptBtn_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(567, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 42);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnFastforward
            // 
            this.btnFastforward.FlatAppearance.BorderSize = 0;
            this.btnFastforward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFastforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastforward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastforward.Image = ((System.Drawing.Image)(resources.GetObject("btnFastforward.Image")));
            this.btnFastforward.Location = new System.Drawing.Point(454, 21);
            this.btnFastforward.Name = "btnFastforward";
            this.btnFastforward.Size = new System.Drawing.Size(53, 42);
            this.btnFastforward.TabIndex = 7;
            this.btnFastforward.UseVisualStyleBackColor = true;
            this.btnFastforward.Click += new System.EventHandler(this.btnFastforward_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.FlatAppearance.BorderSize = 0;
            this.btnRewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewind.Image = ((System.Drawing.Image)(resources.GetObject("btnRewind.Image")));
            this.btnRewind.Location = new System.Drawing.Point(357, 21);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(53, 42);
            this.btnRewind.TabIndex = 8;
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // menuStrip1
            // 
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
            this.playListToolStripMenuItem});
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
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.playListToolStripMenuItem.Text = "PlayList";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.btnHideShowPlaylistCLICKED_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.btnHideShowPlaylist_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnFolder
            // 
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.Image")));
            this.btnFolder.Location = new System.Drawing.Point(637, 21);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(42, 42);
            this.btnFolder.TabIndex = 10;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(870, 26);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(46, 42);
            this.btnFullScreen.TabIndex = 11;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // listBoxPlayList
            // 
            this.listBoxPlayList.AllowDrop = true;
            this.listBoxPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBoxPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxPlayList.FormatString = "D";
            this.listBoxPlayList.FormattingEnabled = true;
            this.listBoxPlayList.HorizontalScrollbar = true;
            this.listBoxPlayList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxPlayList.Location = new System.Drawing.Point(0, 498);
            this.listBoxPlayList.MultiColumn = true;
            this.listBoxPlayList.Name = "listBoxPlayList";
            this.listBoxPlayList.Size = new System.Drawing.Size(931, 67);
            this.listBoxPlayList.TabIndex = 12;
            this.listBoxPlayList.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayList_SelectedIndexChanged_1);
            // 
            // btnPause
            // 
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(403, 21);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 42);
            this.btnPause.TabIndex = 13;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnHideShowPlaylist
            // 
            this.btnHideShowPlaylist.FlatAppearance.BorderSize = 0;
            this.btnHideShowPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHideShowPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShowPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnHideShowPlaylist.Image")));
            this.btnHideShowPlaylist.Location = new System.Drawing.Point(6, 19);
            this.btnHideShowPlaylist.Name = "btnHideShowPlaylist";
            this.btnHideShowPlaylist.Size = new System.Drawing.Size(42, 42);
            this.btnHideShowPlaylist.TabIndex = 14;
            this.btnHideShowPlaylist.UseVisualStyleBackColor = true;
            this.btnHideShowPlaylist.Click += new System.EventHandler(this.btnHideShowPlaylist_Click);
            // 
            // btnHideShowPlaylistCLICKED
            // 
            this.btnHideShowPlaylistCLICKED.BackColor = System.Drawing.Color.Silver;
            this.btnHideShowPlaylistCLICKED.FlatAppearance.BorderSize = 0;
            this.btnHideShowPlaylistCLICKED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHideShowPlaylistCLICKED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowPlaylistCLICKED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShowPlaylistCLICKED.Image = ((System.Drawing.Image)(resources.GetObject("btnHideShowPlaylistCLICKED.Image")));
            this.btnHideShowPlaylistCLICKED.Location = new System.Drawing.Point(6, 28);
            this.btnHideShowPlaylistCLICKED.Name = "btnHideShowPlaylistCLICKED";
            this.btnHideShowPlaylistCLICKED.Size = new System.Drawing.Size(42, 42);
            this.btnHideShowPlaylistCLICKED.TabIndex = 15;
            this.btnHideShowPlaylistCLICKED.UseVisualStyleBackColor = false;
            this.btnHideShowPlaylistCLICKED.Click += new System.EventHandler(this.btnHideShowPlaylistCLICKED_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(685, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 42);
            this.btnStop.TabIndex = 16;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // picBoxMediaPlayIcon
            // 
            this.picBoxMediaPlayIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxMediaPlayIcon.BackgroundImage")));
            this.picBoxMediaPlayIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxMediaPlayIcon.Location = new System.Drawing.Point(0, 24);
            this.picBoxMediaPlayIcon.Name = "picBoxMediaPlayIcon";
            this.picBoxMediaPlayIcon.Size = new System.Drawing.Size(931, 474);
            this.picBoxMediaPlayIcon.TabIndex = 17;
            this.picBoxMediaPlayIcon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.Volumelbl);
            this.groupBox1.Controls.Add(this.VolumeSlider);
            this.groupBox1.Controls.Add(this.btnFastforward);
            this.groupBox1.Controls.Add(this.PrevBtn);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.PlayBtn);
            this.groupBox1.Controls.Add(this.btnHideShowPlaylistCLICKED);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.btnHideShowPlaylist);
            this.groupBox1.Controls.Add(this.RptBtn);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnRewind);
            this.groupBox1.Controls.Add(this.btnFullScreen);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.LengthSlider);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 76);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(19, 3);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(13, 13);
            this.Duration.TabIndex = 20;
            this.Duration.Text = "0";
            // 
            // Volumelbl
            // 
            this.Volumelbl.AutoSize = true;
            this.Volumelbl.Location = new System.Drawing.Point(74, 26);
            this.Volumelbl.Name = "Volumelbl";
            this.Volumelbl.Size = new System.Drawing.Size(13, 13);
            this.Volumelbl.TabIndex = 19;
            this.Volumelbl.Text = "0";
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.Location = new System.Drawing.Point(93, 21);
            this.VolumeSlider.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(112, 45);
            this.VolumeSlider.TabIndex = 17;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            this.VolumeSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VolumeSlider_MouseMove);
            // 
            // LengthSlider
            // 
            this.LengthSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LengthSlider.LargeChange = 2;
            this.LengthSlider.Location = new System.Drawing.Point(38, 0);
            this.LengthSlider.Maximum = 100;
            this.LengthSlider.Name = "LengthSlider";
            this.LengthSlider.Size = new System.Drawing.Size(893, 45);
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
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPlayIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button RptBtn;
        private System.Windows.Forms.Button button5;
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
        private System.Windows.Forms.Button btnHideShowPlaylist;
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
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Timer Time;
    }
}

