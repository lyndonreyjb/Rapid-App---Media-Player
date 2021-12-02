namespace MediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOpen = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSSound = new System.Windows.Forms.Button();
            this.btnVPause = new System.Windows.Forms.Button();
            this.btnVPlay = new System.Windows.Forms.Button();
            this.btnVStop = new System.Windows.Forms.Button();
            this.btnVPrev = new System.Windows.Forms.Button();
            this.btnVNext = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.pnlVideo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkGray;
            this.btnOpen.Location = new System.Drawing.Point(126, 408);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(263, 53);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open a picture";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.ImageLocation = "Stretch";
            this.picBox1.Location = new System.Drawing.Point(18, 20);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(486, 382);
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkGray;
            this.btnPlay.Location = new System.Drawing.Point(155, 504);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(109, 49);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play ";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkGray;
            this.btnStop.Location = new System.Drawing.Point(270, 504);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 49);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSSound
            // 
            this.btnSSound.BackColor = System.Drawing.Color.DarkGray;
            this.btnSSound.Location = new System.Drawing.Point(155, 559);
            this.btnSSound.Name = "btnSSound";
            this.btnSSound.Size = new System.Drawing.Size(214, 43);
            this.btnSSound.TabIndex = 4;
            this.btnSSound.Text = "System Sound";
            this.btnSSound.UseVisualStyleBackColor = false;
            this.btnSSound.Click += new System.EventHandler(this.btnSSound_Click);
            // 
            // btnVPause
            // 
            this.btnVPause.BackColor = System.Drawing.Color.MistyRose;
            this.btnVPause.Location = new System.Drawing.Point(687, 471);
            this.btnVPause.Name = "btnVPause";
            this.btnVPause.Size = new System.Drawing.Size(114, 47);
            this.btnVPause.TabIndex = 5;
            this.btnVPause.Text = "Pause";
            this.btnVPause.UseVisualStyleBackColor = false;
            this.btnVPause.Click += new System.EventHandler(this.btnVPause_Click);
            // 
            // btnVPlay
            // 
            this.btnVPlay.BackColor = System.Drawing.Color.MistyRose;
            this.btnVPlay.Location = new System.Drawing.Point(567, 471);
            this.btnVPlay.Name = "btnVPlay";
            this.btnVPlay.Size = new System.Drawing.Size(114, 47);
            this.btnVPlay.TabIndex = 6;
            this.btnVPlay.Text = "Play";
            this.btnVPlay.UseVisualStyleBackColor = false;
            this.btnVPlay.Click += new System.EventHandler(this.btnVPlay_Click);
            // 
            // btnVStop
            // 
            this.btnVStop.BackColor = System.Drawing.Color.MistyRose;
            this.btnVStop.Location = new System.Drawing.Point(807, 471);
            this.btnVStop.Name = "btnVStop";
            this.btnVStop.Size = new System.Drawing.Size(114, 47);
            this.btnVStop.TabIndex = 7;
            this.btnVStop.Text = "Stop";
            this.btnVStop.UseVisualStyleBackColor = false;
            this.btnVStop.Click += new System.EventHandler(this.btnVStop_Click);
            // 
            // btnVPrev
            // 
            this.btnVPrev.BackColor = System.Drawing.Color.MistyRose;
            this.btnVPrev.Location = new System.Drawing.Point(634, 524);
            this.btnVPrev.Name = "btnVPrev";
            this.btnVPrev.Size = new System.Drawing.Size(114, 47);
            this.btnVPrev.TabIndex = 8;
            this.btnVPrev.Text = "Prev";
            this.btnVPrev.UseVisualStyleBackColor = false;
            this.btnVPrev.Click += new System.EventHandler(this.btnVPrev_Click);
            // 
            // btnVNext
            // 
            this.btnVNext.BackColor = System.Drawing.Color.MistyRose;
            this.btnVNext.Location = new System.Drawing.Point(754, 524);
            this.btnVNext.Name = "btnVNext";
            this.btnVNext.Size = new System.Drawing.Size(114, 47);
            this.btnVNext.TabIndex = 9;
            this.btnVNext.Text = "Next";
            this.btnVNext.UseVisualStyleBackColor = false;
            this.btnVNext.Click += new System.EventHandler(this.btnVNext_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.MistyRose;
            this.btnFullScreen.Location = new System.Drawing.Point(662, 577);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(181, 44);
            this.btnFullScreen.TabIndex = 10;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 35;
            this.playList.Location = new System.Drawing.Point(1040, 28);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(222, 389);
            this.playList.TabIndex = 11;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Location = new System.Drawing.Point(566, 35);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(416, 381);
            this.pnlVideo.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1285, 729);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnVNext);
            this.Controls.Add(this.btnVPrev);
            this.Controls.Add(this.btnVStop);
            this.Controls.Add(this.btnVPlay);
            this.Controls.Add(this.btnVPause);
            this.Controls.Add(this.btnSSound);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "forex free foe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSSound;
        private System.Windows.Forms.Button btnVPause;
        private System.Windows.Forms.Button btnVPlay;
        private System.Windows.Forms.Button btnVStop;
        private System.Windows.Forms.Button btnVPrev;
        private System.Windows.Forms.Button btnVNext;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Panel pnlVideo;
    }
}

