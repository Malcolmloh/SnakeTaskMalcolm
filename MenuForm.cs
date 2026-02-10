using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MenuForm : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            CharSelect selectScreen = new CharSelect();

            wplayer.controls.stop();
            this.Hide();
            selectScreen.ShowDialog();
            if (GameSettings.IsMuted == false)
            {
                wplayer.controls.play();
            }
            this.Show();
        }

        private void optionsBTN_Click(object sender, EventArgs e)
        {
            ScoreboardForm sb = new ScoreboardForm();
            this.Hide();
            sb.ShowDialog();
            this.Show();
        }

        private void quitBTN_Click(object sender, EventArgs e)
        {
            confirmexit exit = new confirmexit();
            exit.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void playBackgroundMusic()
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "sourrock.wav");

            if (!File.Exists(tempFile))
            {
                using (System.IO.Stream stream = Properties.Resources.JeremyKorpas_SourRock)
                {
                    byte[] bytes = new byte[stream.Length];

                    stream.Read(bytes, 0, bytes.Length);

                    File.WriteAllBytes(tempFile, bytes);
                }
            }

            
            wplayer.URL = tempFile;
            wplayer.settings.setMode("loop", true);
            wplayer.settings.volume = 50;

            if (GameSettings.IsMuted == false)
            {
                wplayer.controls.play();
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MenuForm_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            playBackgroundMusic();
        }

        private void infoBTN_Click(object sender, EventArgs e)
        {
            Info sb = new Info();
            this.Hide();
            sb.ShowDialog();
            this.Show();
        }

        private void titleLBL_Click(object sender, EventArgs e)
        {

        }

        private void muteBTN_Click(object sender, EventArgs e)
        {
            // 1. Toggle the global setting
            GameSettings.IsMuted = !GameSettings.IsMuted;

            // 2. Apply it immediately to the Menu music
            if (GameSettings.IsMuted)
            {
                wplayer.controls.stop();
                muteBTN.Text = "Unmute";
            }
            else
            {
                wplayer.controls.play();
                muteBTN.Text = "Mute";
            }
            this.Focus();
        }
    }
}
