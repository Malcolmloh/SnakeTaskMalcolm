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
        string character;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        System.Media.SoundPlayer levelup;
        System.Media.SoundPlayer gameoversound;
        Traps myTraps;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500;
        int score;
        int level;

        public Form1(string selectedChar)
        {
            InitializeComponent();

            string myCharacter = GameSettings.SelectedChar;
            myPlayer = new Player(mainBoard, myCharacter);

            playBackgroundMusic();

            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed;
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            // Set the timer interval to what we chose in the selector
            clock.Interval = GameSettings.SpeedInterval;

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;

            gotoNextLevel(level);
            mode = "REST";

        }

        private void gotoNextLevel(int nextLevel)
        {
            levelup = new System.Media.SoundPlayer(Properties.Resources.levelup);
            levelup.Play();
            mode = "REST";
            myPlayer = new Player(mainBoard, this.character);
            myTraps = new Traps(nextLevel, mainBoard);
            pokeballs = new Rewards(nextLevel, mainBoard, myTraps);
            mainBoard.changeBackground(nextLevel);
        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            myPlayer.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            pokeballs.draw();
            myTraps.draw();
            myPlayer.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //If Player collides into pokemon, game over
            if (myPlayer.checkEatItself() == true)
            {
                GameOver();
            }
            else if (myTraps.checkTrapCollision(myPlayer.getHeadPosition()) == true)
            {
                // Optional: Play explosion sound here
                GameOver();
            }
            else if (pokeballs.checkIFAshHeadCatchPokeball( myPlayer.getHeadPosition()) == true)
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
                    //Length the snake and continue with the Game
                    myPlayer.extendBody();
                }
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }

        private void GameOver()
        {
            gameoversound = new System.Media.SoundPlayer(Properties.Resources.gameoversound);
            gameoversound.Play();
            clock.Stop();

            // 1. Open the Name Form
            nameForm inputForm = new nameForm();

            // 2. Wait for the user to click "Save Score" (OK)
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string name = inputForm.PlayerName; // Get the name from the other form

                // 3. Format the string: "Name | Score"
                string record = name + " | Score: " + score;

                // 4. Save to file
                System.IO.File.AppendAllText("scores.txt", record + Environment.NewLine);

                MessageBox.Show("Score Saved!", "Game Over");
            }
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myCharacter = GameSettings.SelectedChar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check which key is pressed and update 'mode'
            switch (keyData)
            {
                case Keys.Up:
                    if (mode != "DOWN") mode = "UP"; // Prevent suicide (reverse gear)
                    return true; // Return true to say "We handled it, don't let buttons use it!"

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

            // If it wasn't an arrow key, let the form handle it normally
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wplayer != null)
            {
                wplayer.controls.stop();
            }
        }
        private void playBackgroundMusic()
        {
            // Define a temporary path on the computer
            string tempFile = Path.Combine(Path.GetTempPath(), "snake_music.wav");

            // Write the music resource to that file (Create it if it doesn't exist)
            if (!File.Exists(tempFile))
            {
                // 1. Get the resource stream
                using (System.IO.Stream stream = Properties.Resources.JoshuaMcLean_MountainTrial_NOCOPYRIGHT_8bit_Music)
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
    }
}
