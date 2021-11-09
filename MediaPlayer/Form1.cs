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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SoundPlayer player = new SoundPlayer(ofd.FileName);
                player.Play();
            }

            // WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Title = "Open Video";
            ofd2.Filter = "Video | *.mp4"; // editied to to play video files previously couldnt show video file types
            ofd2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                vPath = ofd2.FileName;
                axWindowsMediaPlayer1.URL = vPath;
            }
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
    }
}
