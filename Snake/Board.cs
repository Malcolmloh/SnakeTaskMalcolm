using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Board
    {
        int maxRow = 8, maxCol = 16;       //Max 10 rows, and 20 columns in the board
        int squareSize = 40;                //Each square is 40px by 40px

        private Control boardPanel;

        PictureBox[,] squares;

        public Board(Form mainForm)
        {
            // Assign directly to the class field 'this.boardPanel'
            this.boardPanel = mainForm.Controls["boardPanel"];
            this.boardPanel.BackgroundImage = Properties.Resources.lvl1bg;
            this.boardPanel.BackgroundImageLayout = ImageLayout.Stretch;

            squares = new PictureBox[maxRow, maxCol];

            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col] = new PictureBox();
                    squares[row, col].Location = new Point(col * squareSize, row * squareSize);
                    squares[row, col].Height = squareSize;
                    squares[row, col].Width = squareSize;
                    squares[row, col].SizeMode = PictureBoxSizeMode.StretchImage;

                    // Transparency
                    squares[row, col].BackColor = Color.Transparent;
                    squares[row, col].BorderStyle = BorderStyle.FixedSingle;

                    // Add to controls ONLY ONCE using the class field
                    this.boardPanel.Controls.Add(squares[row, col]);
                }
            }
            mainForm.Controls["controlPanel"].Location = new Point(
                this.boardPanel.Location.X,
                this.boardPanel.Location.Y + this.boardPanel.Height + 20
            );
        }

        public void changeBackground(int level)
        {
            // Cycle through 5 background images
            int cycleIndex = (level - 1) % 5;

            switch (cycleIndex)
            {
                case 0:
                    this.boardPanel.BackgroundImage = Properties.Resources.lvl1bg;
                    break;
                case 1:
                    this.boardPanel.BackgroundImage = Properties.Resources.lvl2bg;
                    break;
                case 2:
                    this.boardPanel.BackgroundImage = Properties.Resources.lvl3bg;
                    break;
                case 3:
                    this.boardPanel.BackgroundImage = Properties.Resources.lvl4bg;
                    break;
                case 4:
                    this.boardPanel.BackgroundImage = Properties.Resources.lvl5bg;
                    break;
            }
        }

        public int getMaxColNo()
        {
            return maxCol-1; //Last Column No is 19, not 20
        }

        public int getMaxRowNo()
        {
            return maxRow-1; //Last Row No is 9, not 10
        }

        public int getMinColNo()
        {
            return 0;       // 0 is the smallest Col number of the board
        }

        public int getMinRowNo()
        {
            return 0;       // 0 is the smallest Row number of the board
        }

        public void draw()
        {
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col].Image = null ;
                }
            }
        }

        public void draw(Position p, Image pic)
        {
            squares[p.getRowNo(), p.getColNo()].Image = pic;
        }
    }
}
