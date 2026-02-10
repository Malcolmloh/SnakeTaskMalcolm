using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class GameSettings
    {
        // Lower number = Faster speed (Interval in milliseconds)
        public static int SpeedInterval;

        // Number of spikeballs to spawn
        public static int SpikeCount;

        public static string SelectedChar;

        public static int SessionHighestLevel = 1; // Tracks max level reached

        public static int SessionTotalTimeSeconds = 0; // Tracks total play time

        public static int PointsPerReward;

        public static bool IsMuted = false;
    }
}
