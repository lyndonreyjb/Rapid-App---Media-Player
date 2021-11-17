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
//using Microsoft.DirectX.AudioVideoPlayback;
//using WMPLib;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        string vPath;
        string filename;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.Pink;
            btnHideShowPlaylistCLICKED.Hide();
            listBoxPlayList.Hide();
            axWindowsMediaPlayer1.Hide();
            btnPause.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // this is the start button 
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
        }

        private void button2_Click(object sender, EventArgs e) // this is the play button
        {


            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.Ctlcontrols.play();

            button2.Hide();
            btnPause.Show();
            picBoxMediaPlayIcon.Hide();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFastforward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
        }

        private void btnFullScreen_Click(object sender, EventArgs e) // Based on lyndons fullscreen method
        { 
            if(WindowState ==  FormWindowState.Normal )  // doesnt resize video player and buttons properly 
            {
                this.WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
            else if (WindowState == FormWindowState.Maximized )
            {
                this.WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
            } 

           // axWindowsMediaPlayer1.fullScreen = true; thiis makes the video player fullscreen but no controls or exit fullscreen
        }

        private void btnFolder_Click(object sender, EventArgs e)
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
            ofd2.Filter = "Video | *.mp4"; // editied to to play video files previously couldnt show video file types
           // ofd2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd2.Multiselect = true;
            
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                filename = ofd2.SafeFileName;
                vPath = ofd2.FileName;
                listBoxPlayList.Items.Clear();

                for (int i = 0; i < filename.Length; i++)
                {



                    listBoxPlayList.Items.Add(filename[i]) ;
                   
                }
                listBoxPlayList.SelectedIndex = 0;
               
                axWindowsMediaPlayer1.URL = vPath;
                axWindowsMediaPlayer1.Show();
                picBoxMediaPlayIcon.Hide();
                button2.Hide();
                btnPause.Show();

            }


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            button2.Show();
            btnPause.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // this is the next button
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void btnHideShowPlaylist_Click(object sender, EventArgs e)
        {
            listBoxPlayList.Show();
            btnHideShowPlaylistCLICKED.Show();
            btnHideShowPlaylist.Hide();
        }

        private void btnHideShowPlaylistCLICKED_Click(object sender, EventArgs e)
        {
            listBoxPlayList.Hide();
            btnHideShowPlaylistCLICKED.Hide();
            btnHideShowPlaylist.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Hide();
            picBoxMediaPlayIcon.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
