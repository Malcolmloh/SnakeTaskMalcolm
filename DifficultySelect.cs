using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class DifficultySelect : Form
    {
        public DifficultySelect()
        {
            InitializeComponent();
        }
        private void startGame(String Character)
        {
            // 1. Create the Game Form and pass the character
            Form1 game = new Form1();

            // 2. Hide this selection screen
            this.Hide();

            // 3. Show the game
            game.ShowDialog();

            // 4. When game closes, close this form too (returns to Menu)
            this.Close();
        }
        private void DifficultySelect_Load(object sender, EventArgs e)
        {

        }

        private void easyBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private void normalBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private void hardBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private void easyBTN_Click(object sender, EventArgs e)
        {
            GameSettings.SpeedInterval = 1000; // Slow
            GameSettings.SpikeCount = 3;
            GameSettings.PointsPerReward = 25;
            Form1 game = new Form1();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void normalBTN_Click(object sender, EventArgs e)
        {
            GameSettings.SpeedInterval = 500; // Normal speed
            GameSettings.SpikeCount = 7;
            GameSettings.PointsPerReward = 50;
            Form1 game = new Form1();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void hardBTN_Click(object sender, EventArgs e)
        {
            GameSettings.SpeedInterval = 300; // Very fast
            GameSettings.SpikeCount = 15;
            GameSettings.PointsPerReward = 100;
            Form1 game = new Form1();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void backtomenuBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
