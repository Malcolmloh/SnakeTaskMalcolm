using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Rewards
    {
        List<Position> pokeballList;
        Board mainBoard;
        System.Media.SoundPlayer captureMusic;

        // Create the Random object HERE, once.
        Random rng = new Random();

        public Rewards(int size, Board mainBoard, Traps existingTraps)
        {
            this.mainBoard = mainBoard;
            pokeballList = new List<Position>();

            for (int i = 0; i < size; i++)
            {
                int rowNo, colNo;
                do
                {
                    // Use the class-level 'rng' object
                    rowNo = rng.Next(0, mainBoard.getMaxRowNo() + 1); // Note: verify min/max rows
                    colNo = rng.Next(0, mainBoard.getMaxColNo() + 1);

                } while (isDuplicate(rowNo, colNo) == true || existingTraps.isTrapAt(rowNo, colNo) == true);

                pokeballList.Add(new Position(rowNo, colNo));
            }
        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< pokeballList.Count;i++)
            {
                if (pokeballList[i].getRowNo() == row && pokeballList[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < pokeballList.Count; i++)
            {
                mainBoard.draw(pokeballList[i], Properties.Resources.pokeball);
            }     
        }

        public Boolean checkIFAshHeadCatchPokeball(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < pokeballList.Count; i++)
            {
                if (snakeHead.getRowNo() == pokeballList[i].getRowNo() && snakeHead.getColNo() == pokeballList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public Boolean checkIFAshCatchPokeball(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < pokeballList.Count; i++)
            {
                if (snakeHead.getRowNo() == pokeballList[i].getRowNo() && snakeHead.getColNo() == pokeballList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int catchPokeballAtPostion(Position p)
        {
            // Loop through the list to find and remove the matching position
            for (int i = 0; i < pokeballList.Count; i++)
            {
                if (pokeballList[i].getRowNo() == p.getRowNo() &&
                    pokeballList[i].getColNo() == p.getColNo())
                {
                    pokeballList.RemoveAt(i); // Remove the eaten pokeball
                    captureMusic = new System.Media.SoundPlayer(Properties.Resources.Pokemon_Capture_Sound);
                    captureMusic.Play();
                    return 50; // Return points
                }
            }
            return 0;
        }

        public Boolean noMorePokeballs()
        {
            if (pokeballList.Count > 0)
                return false;
            else
                return true;
        }
    }
}
