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
            wplayer.controls.play();
            this.Show(); // Show Menu again after they finish playing
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
            Application.Exit(); // Closes the entire application
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void playBackgroundMusic()
        {
            // Define a temporary path on the computer
            string tempFile = Path.Combine(Path.GetTempPath(), "sourrock.wav");

            // Write the music resource to that file (Create it if it doesn't exist)
            if (!File.Exists(tempFile))
            {
                // 1. Get the resource stream
                using (System.IO.Stream stream = Properties.Resources.JeremyKorpas_SourRock)
                {
                    // 2. Create a byte array to hold the data (size based on stream length)
                    byte[] bytes = new byte[stream.Length];

                    // 3. Read the stream data into the byte array
                    stream.Read(bytes, 0, bytes.Length);

                    // 4. Now you can write the bytes to the file
                    File.WriteAllBytes(tempFile, bytes);
                }
            }

            // Configure WMP to play that file
            wplayer.URL = tempFile;
            wplayer.settings.setMode("loop", true); // Enable Looping
            wplayer.settings.volume = 50; // Optional: Lower volume so SFX are louder
            wplayer.controls.play();
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
    }
}
