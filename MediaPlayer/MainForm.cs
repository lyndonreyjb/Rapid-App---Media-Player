using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;

namespace MediaPlayer
{
    public partial class MainForm : Form
    {
        SoundPlayer player = new SoundPlayer();
        private Video video;
        private List<string> videoPath = new List<string>();
        private int selectedindex = 0;
        private Size pnlSize;
        private Size formSize;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //picBox1.ImageLocation = "C:/Users/texgh/OneDrive/Pictures/pointing boy.png";
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                picBox1.Image = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("");
                player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btnSSound_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnVPlay_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
            }
        }

        private void btnVPause_Click(object sender, EventArgs e)
        {
            if (video.Playing)
            {
                video.Pause();
            }
        }

        private void btnVStop_Click(object sender, EventArgs e)
        {
            if (video.Playing)
            {
                video.Stop();
            }
        }

        private void btnVPrev_Click(object sender, EventArgs e)
        {
            int index = playList.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = videoPath.Count - 1;

            }
        }

      
        private void btnVNext_Click(object sender, EventArgs e)
        {

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            video.Owner = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);
        }
    }
}
