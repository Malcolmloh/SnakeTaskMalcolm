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

        private class ScoreEntry
        {
            public string OriginalText { get; set; }
            public int ScoreValue { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ScoreboardForm_Load(object sender, EventArgs e)
        {
            scoreListBox.Items.Clear();

            string filePath = "scores.txt";

            if (File.Exists(filePath))
            {
                // 1. Read all lines
                string[] allLines = File.ReadAllLines(filePath);
                List<ScoreEntry> allScores = new List<ScoreEntry>();

                // 2. Parse every line to find the actual number
                foreach (string line in allLines)
                {
                    // Format is: "Name | Score: 150"
                    // We split by " | Score: " to get the number part
                    string[] parts = line.Split(new string[] { " | Score: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        int parsedScore;
                        if (int.TryParse(parts[1], out parsedScore))
                        {
                            allScores.Add(new ScoreEntry { OriginalText = line, ScoreValue = parsedScore });
                        }
                    }
                }

                // --- SECTION 1: TOP 5 HIGHSCORES ---
                scoreListBox.Items.Add("=== 🏆 TOP 5 PLAYERS 🏆 ===");

                // Sort by Score (High to Low), Take top 5
                var top5 = allScores.OrderByDescending(x => x.ScoreValue).Take(5).ToList();

                foreach (var entry in top5)
                {
                    scoreListBox.Items.Add(entry.OriginalText);
                }

                scoreListBox.Items.Add(""); // Empty line for spacing


                // --- SECTION 2: RECENT GAMES ---
                scoreListBox.Items.Add("=== 🕒 RECENT HISTORY ===");

                // Reverse the original lines to show Newest first, then take 10
                var recentScores = allLines.Reverse().Take(10).ToList();

                foreach (string line in recentScores)
                {
                    scoreListBox.Items.Add(line);
                }
            }
            else
            {
                scoreListBox.Items.Add("No games played yet!");
            }
        }
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
