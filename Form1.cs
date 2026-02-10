using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Player myPlayer;
        Board mainBoard;
        Rewards pokeballs;
        Traps myTraps;

        string character; // Stores "Ash" or "Lily"
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        System.Media.SoundPlayer levelup;
        System.Media.SoundPlayer gameoversound;

        string mode;
        Timer clock;
        int duration;
        int score;
        int level;

        public Form1()
        {
            InitializeComponent();

            this.AutoSize = true;
            boardPanel.AutoSize = true;

            // 2. CRITICAL FIX: Create the Board FIRST. 
            // The Player needs the board to know where walls are.
            mainBoard = new Board(this);

            // 3. Load Character from Settings
            this.character = GameSettings.SelectedChar;
            myPlayer = new Player(mainBoard, this.character);

            // 4. Setup Timer using GameSettings
            clock = new Timer();
            clock.Interval = GameSettings.SpeedInterval; // Read speed from settings
            clock.Tick += new EventHandler(refresh);

            duration = 0;
            score = 0;
            level = 1;
            mode = "REST";
            modeLBL.Text = mode;

            // 5. Start Music & Level 1
            playBackgroundMusic();
            gotoNextLevel(level);
        }

        private void gotoNextLevel(int nextLevel)
        {
            if (nextLevel > 1) // Only play sound if levelling up (not at start)
            {
                levelup = new System.Media.SoundPlayer(Properties.Resources.levelup);
                levelup.Play();
            }

            mode = "REST";

            // Re-create objects for the new level
            myPlayer = new Player(mainBoard, this.character);
            myTraps = new Traps(nextLevel, mainBoard); // Create Traps
            pokeballs = new Rewards(nextLevel, mainBoard, myTraps); // Pass Traps to Rewards

            mainBoard.changeBackground(nextLevel);
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            myPlayer.move(mode);
            modeLBL.Text = mode;

            mainBoard.draw();
            pokeballs.draw();
            myTraps.draw();
            myPlayer.draw();

            duration += clock.Interval;
            timerLBL.Text = Convert.ToString(duration / 1000);

            // --- COLLISION CHECKS ---

            // 1. Snake eats itself
            if (myPlayer.checkEatItself() == true)
            {
                GameOver();
            }
            // 2. Snake hits a Trap
            else if (myTraps.checkTrapCollision(myPlayer.getHeadPosition()) == true)
            {
                GameOver();
            }
            // 3. Snake eats a Pokeball
            else if (pokeballs.checkIFAshHeadCatchPokeball(myPlayer.getHeadPosition()) == true)
            {
                score += pokeballs.catchPokeballAtPostion(myPlayer.getHeadPosition());
                scoreLBL.Text = Convert.ToString(score);

                if (pokeballs.noMorePokeballs() == true)
                {
                    clock.Stop();
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    MessageBox.Show("Press 'Enter' to go to Level " + level, "Congrats");
                }
                else
                {
                    myPlayer.extendBody();
                }
            }
        }

        private void GameOver()
        {
            clock.Stop();
            wplayer.controls.stop();

            gameoversound = new System.Media.SoundPlayer(Properties.Resources.gameoversound);
            gameoversound.Play();

            nameForm inputForm = new nameForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string name = inputForm.PlayerName;
                string record = name + " | Score: " + score;
                File.AppendAllText("scores.txt", record + Environment.NewLine);
                MessageBox.Show("Score Saved!", "Game Over");
            }
            this.Close();
        }

        // --- CONTROLS ---

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    if (mode != "DOWN") mode = "UP";
                    return true;
                case Keys.Down:
                    if (mode != "UP") mode = "DOWN";
                    return true;
                case Keys.Left:
                    if (mode != "RIGHT") mode = "LEFT";
                    return true;
                case Keys.Right:
                    if (mode != "LEFT") mode = "RIGHT";
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startBTN_Click(object sender, EventArgs e) { clock.Start(); }
        private void pauseBTN_Click(object sender, EventArgs e) { clock.Stop(); }

        // Unused buttons (can keep empty or delete)
        private void upBTN_Click(object sender, EventArgs e) { mode = "UP"; }
        private void downBTN_Click(object sender, EventArgs e) { mode = "DOWN"; }
        private void leftBTN_Click(object sender, EventArgs e) { mode = "LEFT"; }
        private void rightBTN_Click(object sender, EventArgs e) { mode = "RIGHT"; }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_KeyDown(object sender, KeyEventArgs e) { }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wplayer.controls.stop();
        }

        private void playBackgroundMusic()
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "snake_music.wav");
            if (!File.Exists(tempFile))
            {
                using (Stream stream = Properties.Resources.JoshuaMcLean_MountainTrial_NOCOPYRIGHT_8bit_Music)
                {
                    byte[] bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, bytes.Length);
                    File.WriteAllBytes(tempFile, bytes);
                }
            }
            wplayer.URL = tempFile;
            wplayer.settings.setMode("loop", true);
            wplayer.settings.volume = 50;
            wplayer.controls.play();
        }
    }
}
