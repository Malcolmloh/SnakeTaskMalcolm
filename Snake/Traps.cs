using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Traps
    {
        List<Position> trapList;
        Board mainBoard;
        Random rng = new Random(); // Random number generator

        public Traps(int level, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            trapList = new List<Position>();

            // DIFFICULTY FORMULA:
            // Level 1 = 3 traps
            // Level 2 = 6 traps
            // Level 3 = 9 traps...
            int numberOfTraps = level * 3;

            for (int i = 0; i < numberOfTraps; i++)
            {
                int row, col;
                do
                {
                    // Generate random coordinates
                    row = rng.Next(0, mainBoard.getMaxRowNo() + 1);
                    col = rng.Next(0, mainBoard.getMaxColNo() + 1);

                    // Prevent spawning at (0,0) so the player doesn't die instantly on start!
                } while (isDuplicate(row, col) || (row == 0 && col == 0));

                trapList.Add(new Position(row, col));
            }
        }

        private bool isDuplicate(int r, int c)
        {
            foreach (Position p in trapList)
            {
                if (p.getRowNo() == r && p.getColNo() == c)
                    return true;
            }
            return false;
        }

        public void draw()
        {
            foreach (Position p in trapList)
            {
                // Make sure 'spikeball' is in your Resources!
                mainBoard.draw(p, Properties.Resources.spikeball);
            }
        }

        public bool checkTrapCollision(Position head)
        {
            foreach (Position p in trapList)
            {
                if (head.getRowNo() == p.getRowNo() && head.getColNo() == p.getColNo())
                {
                    return true; // HIT A TRAP!
                }
            }
            return false; // Safe
        }
        public bool isTrapAt(int r, int c)
        {
            foreach (Position p in trapList)
            {
                if (p.getRowNo() == r && p.getColNo() == c)
                {
                    return true; // Yes, there is a trap here
                }
            }
            return false; // No trap here
        }
    }
}
