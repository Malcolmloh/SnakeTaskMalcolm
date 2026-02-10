using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Player
    {
        Board mainBoard;
        List<Position> body;

        Image headImage;

        public Player(Board mainBoard, String charName)
        {
            this.mainBoard = mainBoard;
            body = new List<Position>();
            body.Add(new Position(0, 0));

            if (charName == "Lily")
            {
                this.headImage = Properties.Resources.Lily;
            }
            else
            {
                this.headImage = Properties.Resources.Ash;
            }
        }
        public void move(string direction)
        {
            Position currentHeadPosition = body[0];
            Position newHeadPosition = null;

            switch (direction)
            {
                case "UP":
                    if (currentHeadPosition.getRowNo() > mainBoard.getMinRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() - 1, currentHeadPosition.getColNo());
                    }
                    break;
                case "DOWN":
                    if (currentHeadPosition.getRowNo() < mainBoard.getMaxRowNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo() + 1, currentHeadPosition.getColNo());
                    }
                    break;
                case "LEFT":
                    if (currentHeadPosition.getColNo() > mainBoard.getMinColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo() - 1);
                    }
                    break;
                case "RIGHT":
                    if (currentHeadPosition.getColNo() < mainBoard.getMaxColNo())
                    {
                        newHeadPosition = new Position(currentHeadPosition.getRowNo(), currentHeadPosition.getColNo() + 1);
                    }
                    break;
            }

            if (newHeadPosition != null)
            {
                body.Insert(0, newHeadPosition); //Add a new head positon 0
                body.RemoveAt(body.Count - 1); //Remove the last position
            }
        }

        Bitmap[] pikas = {
        Properties.Resources.pokemon1,
        Properties.Resources.pokemon2,
        Properties.Resources.pokemon3,
        Properties.Resources.pokemon4,
        Properties.Resources.pokemon5,
        Properties.Resources.pokemon6,
        Properties.Resources.pokemon7,
        Properties.Resources.pokemon8,
        Properties.Resources.pokemon9,
        Properties.Resources.pokemon10
        };

        public void draw()
        {
            for (int i = 1; i < body.Count; i++)
            {
                // This cycles through 0, 1, 2 regardless of how long the body is
                int pikaIndex = (i - 1) % pikas.Length;
                mainBoard.draw(body[i], pikas[pikaIndex]);
            }

            mainBoard.draw(body[0], this.headImage);
        }

        public Boolean checkEatItself()
        {
            Boolean result = false;

            if (body.Count > 1) //If snake is shorter then 1, sure won't eat itself
            {
                //Check if body[0] is at the same position as any one of the remaining body parts
                for (int i = 1; i < body.Count; i++)
                {
                    if (body[0].getRowNo() == body[i].getRowNo() && body[0].getColNo() == body[i].getColNo())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public Position getHeadPosition()
        {
            return body[0];
        }

        public void addToTail(Position p)
        {
            body.Add(p);
        }

        public void extendBody()
        {
            Position p = new Position(body[0].getRowNo(), body[0].getColNo());
            body.Insert(1, p);
        }
    }
}
