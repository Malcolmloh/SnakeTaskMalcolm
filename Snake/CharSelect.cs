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
    public partial class CharSelect : Form
    {
        System.Media.SoundPlayer levelup;
        public CharSelect()
        {
            InitializeComponent();
        }

        private void CharSelect_Load(object sender, EventArgs e)
        {

        }

        private void selectAshBTN_Click(object sender, EventArgs e)
        {
            levelup = new System.Media.SoundPlayer(Properties.Resources.levelup);
            levelup.Play();

            // 1. Save the choice globally
            GameSettings.SelectedChar = "Ash";

            // 2. Open the Difficulty Selector (NOT Form1 yet)
            DifficultySelect diff = new DifficultySelect();
            this.Hide();
            diff.ShowDialog();
            this.Show();
        }

        private void selectLilyBTN_Click(object sender, EventArgs e)
        {
            levelup = new System.Media.SoundPlayer(Properties.Resources.levelup);
            levelup.Play();

            // 1. Save the choice globally
            GameSettings.SelectedChar = "Lily";

            // 2. Open the Difficulty Selector (NOT Form1 yet)
            DifficultySelect diff = new DifficultySelect();
            this.Hide();
            diff.ShowDialog();
            this.Show();
        }
        private void startGame(String character)
        {
            // 1. Create the Game Form and pass the character
            Form1 game = new Form1(character);

            // 2. Hide this selection screen
            this.Hide();

            // 3. Show the game
            game.ShowDialog();

            // 4. When game closes, close this form too (returns to Menu)
            this.Close();
        }
    }
}
