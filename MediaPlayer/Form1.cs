using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        private int selectedIndex = 0;
        string[] vPath;
        string filename;
        double SkipReverseSpeed = 30; //default value for skip/reverse button 
        List<string> paths = new List<string>();
        

        public Form1()  
        {
            InitializeComponent();
            //hide buttons that should not be showing on start up 
            btnHideShowPlaylistCLICKED.Hide();
            listBoxPlayList.Hide();
            listBoxPlayList.Size = new Size(100,100);
            axWindowsMediaPlayer1.Hide();
            btnPause.Hide();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Time.Start();
           
        }

        private void PrevBtn_Click(object sender, EventArgs e) // Previous button uses the listbox index to to select  the file back in line from currently playing  
        {
            int index = listBoxPlayList.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = vPath[listBoxPlayList.SelectedIndex].Count() - 1;
            }
            selectedIndex = index;
            listBoxPlayList.SelectedIndex = index;
           
        }

        private void NextBtn_Click(object sender, EventArgs e) // Next button uses the listbox index to to select the file next in line from currently playing 
        {

            int index = listBoxPlayList.SelectedIndex;
            index++;
            if (index > vPath[listBoxPlayList.SelectedIndex].Count() - 1)
            {
                index = 0;
            }
            selectedIndex = index;
            listBoxPlayList.SelectedIndex = index;
          
        }

        private void PlayBtn_Click(object sender, EventArgs e) //  Shows the mediaplayer and starts the media file as well as hiding the play icon 
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.Ctlcontrols.play();

            PlayBtn.Hide();
            btnPause.Show();
            picBoxMediaPlayIcon.Hide();
        }


        private void RptBtn_Click(object sender, EventArgs e) // repeats the currently playing file
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
        }

        private void btnFastforward_Click(object sender, EventArgs e) // fast forward uses the SkipReverseSpeed to which sets the amount of time to skip
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += SkipReverseSpeed;
        }

        private void btnRewind_Click(object sender, EventArgs e) // Rewind  uses the SkipReverseSpeed to which sets the amount of time to skip
        {
              axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= SkipReverseSpeed;
        }

        private void btnFullScreen_Click(object sender, EventArgs e) // resizes window to full screen layout 
        { 
            if(WindowState ==  FormWindowState.Normal )  
            {
                this.WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                menuStrip1.Hide();
            }
            else if (WindowState == FormWindowState.Maximized )
            {
                this.WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
                menuStrip1.Show();
            } 

          
        }

        private void btnFolder_Click(object sender, EventArgs e) // opens folder to select media files
        {
            // FolderBrowserDialog folder = new FolderBrowserDialog();

            // folder.ShowNewFolderButton = true;

            // DialogResult result = folder.ShowDialog();
            //// d.Filter = "Video | *.mp4";
            // if (result == DialogResult.OK)
            // {
            //    //textBox1.Text = folderDlg.SelectedPath;
            //     Environment.SpecialFolder root = folder.RootFolder;
            //     vPath = folder.SelectedPath;
            //     axWindowsMediaPlayer1.URL = vPath;
            // }


            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Title = "Open Media File";
            ofd2.Filter = "WMV |*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv"; // editied to to play video files previously couldnt show video file types                                                                                // ofd2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd2.Multiselect = true;
            
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                filename = ofd2.SafeFileName;
                vPath = ofd2.FileNames;
                listBoxPlayList.Items.Clear();

                /* for (int i = 0; i < filename.Length; i++)
                 {
                     listBoxPlayList.Items.Add(filename[i]) ;                  
                 }*/
                foreach(string filename  in ofd2.SafeFileNames) // foreach file (file path) selected gets added to the listboxplaylist 
                {
                    listBoxPlayList.Items.Add(filename);
                }

                foreach(string filename in listBoxPlayList.Items)
                {
                    paths.Add(filename);
                }

                listBoxPlayList.SelectedIndex = 0; // start the index at 0 so we select the first file added to play first 
             
                axWindowsMediaPlayer1.URL = axWindowsMediaPlayer1.URL = vPath[listBoxPlayList.SelectedIndex]; // take the path from the playlist and give it to the media player to play the file 
                axWindowsMediaPlayer1.Show();
                picBoxMediaPlayIcon.Hide();
                PlayBtn.Hide();
                btnPause.Show();

            }
        }

        private void btnPause_Click(object sender, EventArgs e) // Pauses video and then hides the pause button and shows the play button 
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            PlayBtn.Show();
            btnPause.Hide();
        }

        private void btnHideShowPlaylist_Click(object sender, EventArgs e) // toggle for showing and hiding the playlist
        {
            listBoxPlayList.Show();
            btnHideShowPlaylistCLICKED.Show();
            btnHideShowPlaylist.Hide();
        }

        private void btnHideShowPlaylistCLICKED_Click(object sender, EventArgs e) // toggle for showing and hiding the playlist
        {
            listBoxPlayList.Hide();
            btnHideShowPlaylistCLICKED.Hide();
            btnHideShowPlaylist.Show();
        }

        private void btnStop_Click(object sender, EventArgs e) // stops the media file 
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Hide();
            picBoxMediaPlayIcon.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            Volumelbl.Text = VolumeSlider.Value.ToString() + '%';
        }

        private void VolumeSlider_MouseMove(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = VolumeSlider.Value;
            Volumelbl.Text = VolumeSlider.Value.ToString() + '%';
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            LengthSlider.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    LengthSlider.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
            //    LengthSlider.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            //}
            //lblDurationStart.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            //lblDurationEnd.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            //if (LengthSlider.Maximum == LengthSlider.Value)
            //{
            //    Time.Stop();
            //    LengthSlider.Value = 0;
            //    lblDurationStart.Text = "00:00";
            //}
        }
        private void LengthSlider_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = LengthSlider.Value;
            lblDurationStart.Text = axWindowsMediaPlayer1.currentMedia.duration.ToString();
        }

        private void listBoxPlayList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = vPath[listBoxPlayList.SelectedIndex];
        }

        private void x05ToolStripMenuItem_Click(object sender, EventArgs e) // toolstrip - controls -media speed - 0.5
        {
            
            axWindowsMediaPlayer1.settings.rate = 0.5;
           
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e) // toolstrip - controls -media speed - 1
        {
            axWindowsMediaPlayer1.settings.rate = 1;
            
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e) // toolstrip - controls -media speed - 2
        {
            axWindowsMediaPlayer1.settings.rate = 2;
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)// toolstrip - controls -media speed - 3
        {
            axWindowsMediaPlayer1.settings.rate = 3;
        }

        private void secondsToolStripMenuItem_Click(object sender, EventArgs e) // toolstrip Skip/Reverse - toggle - 10secs
        {
            SkipReverseSpeed = 10;
        }

        private void secondsToolStripMenuItem1_Click(object sender, EventArgs e) // toolstrip Skip/Reverse - toggle - 30secs
        {
            SkipReverseSpeed = 30;
        }

        private void minuteToolStripMenuItem_Click(object sender, EventArgs e) // toolstrip Skip/Reverse - toggle - 1min
        {
            
            SkipReverseSpeed = 60;
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e) // show hide credits 
        {
           
           
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e) // Shuffles the media file 
        {
            
            Random random = new Random();
          


            int maxinlistbox = listBoxPlayList.Items.Count;
           

            int maxrandom = random.Next(0, maxinlistbox);

            
            selectedIndex = maxrandom;
            listBoxPlayList.SelectedIndex = maxrandom;



        }
    }
}
