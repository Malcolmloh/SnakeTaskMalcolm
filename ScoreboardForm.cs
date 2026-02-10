using System;
using System.IO;
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
    public partial class ScoreboardForm : Form
    {
        public ScoreboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ScoreboardForm_Load(object sender, EventArgs e)
        {
            // Check if the file exists first to avoid crashing
            if (File.Exists("scores.txt"))
            {
                // Read all lines from the file into an array
                string[] scores = File.ReadAllLines("scores.txt");

                // Add them to the ListBox
                // Reverse array to show newest first -> Array.Reverse(scores);
                foreach (string s in scores)
                {
                    scoreListBox.Items.Add(s);
                }
            }
            else
            {
                scoreListBox.Items.Add("No scores yet!");
            }
        }
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
