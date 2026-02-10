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
    public partial class confirmexit : Form
    {
        public confirmexit()
        {
            InitializeComponent();
        }

        private void quitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmexit_Load(object sender, EventArgs e)
        {
            // 1. Show Highest Level
            lblHighLevel.Text = "Highest Level Reached: " + GameSettings.SessionHighestLevel;

            // 2. Format and Show Play Time
            // This converts seconds into a neat "MM:SS" format
            TimeSpan t = TimeSpan.FromSeconds(GameSettings.SessionTotalTimeSeconds);
            string timeString = string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);

            lblPlayTime.Text = "Total Play Time: " + timeString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
