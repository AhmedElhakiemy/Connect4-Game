using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4
{
    class Game
    {
        //integers for the height of the board and width
        int BoardWidth, BoardHeight;
        //Booleans for the players 
        public bool player1;
        public bool player2;
        //to assign color of each game piece
        private Color pieceColor;
        //state Enum for the state of each place on the game board
        public enum state { empty = 0, player1 = 1, player2 = 2 };
        //2D array of states to represent the board 
        private state[,] board = new state[7, 6];
        //arrayList of integers to force DrawGamePieces fun to draw pieces from the bottom of the board
        List<int> max = new List<int> { 5, 5, 5, 5, 5, 5, 5 };
        //integers to store the score
        int player1score = 0;
        int player2score = 0;

        //properties to access players scores
        public int Player1Score
        {
            set { player1score = value; }
            get { return player1score; }
        }
        public int Player2Score
        {
            set { player2score = value; }
            get { return player2score; }
        }


        // done
        #region default ctor
        //Constructor for the game

        // to make player1 starts the game
        public Game()
        {
            BoardWidth = 700;
            BoardHeight = 600;
            player1 = true;
            player2 = false;
            pieceColor = Color.Blue;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    board[i, j] = state.empty;
                }
            }            
        }
        #endregion

        // done
        #region reset game
        // Method for resting the board

        // make all state of the board empty
        public void Reset()
        {
            max = new List<int>(7) { 5,5,5,5,5,5,5 };
            player1 = true;
            player2 = false;
            pieceColor = Color.Blue;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    board[i, j] = state.empty;
                }
            }
        }
        #endregion

        // done
        #region Draw Board
        //Method to draw blank game board
        public void drawBoard(PaintEventArgs e)
        {
            // create instance of class Pen to draw lines with it
            Pen whiteben = new Pen(Color.White);

            int lineXi = 0, lineXf = 700;
            int lineYi = 0, lineYf = 600;

            // draw horizontal lines
            for (int startY = 0; startY <= BoardWidth; startY += 100)
            {
                e.Graphics.DrawLine(whiteben, startY, lineYi, startY, lineYf);
            }

            // draw verticals lines
            for (int startX = 0; startX <= BoardHeight; startX += 100)
            {
                e.Graphics.DrawLine(whiteben, lineXi, startX, lineXf, startX);
            }

        }
        #endregion

        // done
        #region Change player
        //Method that changes the players turn and game piece color
        private void changePlayer()
        {
            player1 = !player1;
            player2 = !player2;
            if (player1)
            {
                pieceColor = Color.Blue;
            }
            else
            {
                pieceColor = Color.Red;
            }
        }
        #endregion

        // done
        #region drawGamePiece
        //Method to draw the individual game pieces
        // Draws red piece if player 1 and black piece if player 2
        public void drawGamePiece(MouseEventArgs e, Graphics f)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(pieceColor);
            int position = (e.X / 100);

            if (max[position] >= 0)
            {

                if (player1 && board[position, max[position]] == state.empty)
                {
                    board[position, max[position]] = state.player1;
                    f.FillEllipse(myBrush, position * 100, max[position] * 100, 100, 100);
                    max[position]--;
                    changePlayer(); // to change player in next MouseClick
                }
                else if (player2 && board[position, max[position]] == state.empty)
                {
                    board[position, max[position]] = state.player2;
                    f.FillEllipse(myBrush, position * 100, max[position] * 100, 100, 100);
                    max[position]--;
                    changePlayer(); // to change player in next MouseClick
                }
            }

           
        }
        #endregion

        // done
        #region check Who win

        //Method to check who win 
        public int CheckWinner()
        {
            bool BluePlayer = false;
            bool RedPlayer = false;

            int colIndex = 6;
            int rowIndex = 5;

            //For loop to check vertical win ----- check possible cases only to win 
            for (int col = 0; col <= colIndex && !BluePlayer && !RedPlayer; col++)
            {
                // start from rowIndex to start check from the bottom of the board
                // end loop at index >=3 becuase before index 3 you cannot connect four 
                for (int row = rowIndex; row >= 3 && !BluePlayer && !RedPlayer; row--)
                {
                    if (board[col, row] != state.empty)
                    {
                            if ((board[col, row] == state.player1) && (board[col, row - 1] == state.player1) && (board[col, row - 2] == state.player1) && (board[col, row - 3] == state.player1))
                            {
                                BluePlayer = true; // to get out from all loops
                            }
                            else if ((board[col, row] == state.player2) && (board[col, row - 1] == state.player2) && (board[col, row - 2] == state.player2) && (board[col, row - 3] == state.player2))
                            {
                                RedPlayer = true; // to get out from all loops
                            }
                            else
                            {
                                BluePlayer = false;
                                RedPlayer = false;
                            }
                    }

                }
                
            }
            //For loop to check horizontal win ----- check possible cases only to win 
            for (int row = 0; row <= rowIndex && !BluePlayer && !RedPlayer; row++)
            {
                // end loop at index <=3 becuase after index 3 you cannot connect four
                for (int col = 0; col <= 3 && !BluePlayer && !RedPlayer; col++)
                {
                    if (board[col, row] != state.empty)
                    {
                            if ((board[col, row] == state.player1) && (board[col + 1, row] == state.player1) && (board[col + 2, row] == state.player1) && (board[col + 3, row] == state.player1))
                            {
                                BluePlayer = true; // to get out from all loops
                            }
                            else if ((board[col, row] == state.player2) && (board[col + 1, row] == state.player2) && (board[col + 2, row] == state.player2) && (board[col + 3, row] == state.player2))
                            {
                                RedPlayer = true; // to get out from all loops
                            }
                            else
                            {
                                BluePlayer = false;
                                RedPlayer = false;
                            }
                    }


                }
            }

            //For loop to check diagonal up and right ----- check possible cases only to win 

            // start loop at index =3 becuse before index 3 you cannot connect four
            for (int row = 3; row <= rowIndex && !BluePlayer && !RedPlayer; row++)
            {
                // end loop at index <=3 becuse after index 3 you cannot connect four
                for (int col = 0; col <= 3 && !BluePlayer && !RedPlayer; col++)
                {
                    if (board[col, row] != state.empty)
                    {

                        if ((board[col, row] == state.player1) && (board[col + 1, row - 1] == state.player1) && (board[col + 2, row - 2] == state.player1) && (board[col + 3, row - 3] == state.player1))
                        {
                            BluePlayer = true;  // to get out from all loops
                        }
                        else if ((board[col, row] == state.player2) && (board[col + 1, row - 1] == state.player2) && (board[col + 2, row - 2] == state.player2) && (board[col + 3, row - 3] == state.player2))
                        {
                            RedPlayer = true; // to get out from all loops
                        }
                        else
                        {
                            BluePlayer = false;
                            RedPlayer = false;
                        }
                    }
                }
            }

            //For loop to check diagonal win up and to the left ----- check possible cases only to win

            // start loop from rowIndex to start search from the bottom of the board
            // end loop at index >=3 becuase before index 3 you cannot connect four
            for (int row = rowIndex; row >=3 && !BluePlayer && !RedPlayer; row--)
            {
                for (int col = 3; col <= colIndex && !BluePlayer && !RedPlayer; col++)
                {
                    if (board[col, row] != state.empty)
                    { 
                            if ((board[col, row] == state.player1) && (board[col-1, row-1] == state.player1) && (board[col-2, row-2] == state.player1) && (board[col-3, row-3] == state.player1))
                            {
                                    BluePlayer = true; // to get out from all loops
                            }
                            else if ((board[col, row] == state.player2) && (board[col-1, row-1] == state.player2) && (board[col-2, row-2] == state.player2) && (board[col-3, row-3] == state.player2))
                            { 
                                    RedPlayer = true; // to get out from all loops
                            }
                            else
                            {
                                BluePlayer = false;
                                RedPlayer = false;
                            }
                    }
                }
            }
            if (BluePlayer)
                return 1;
            else if (RedPlayer)
                return 2;
            else
                return 0;

        }
        #endregion

        // done
        #region tie

        //method to check if all pieces not empty and no one win the game
        public bool tie()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                        if (board[i, j] == state.empty)
                        {
                        return false;
                        }
                }
            }
            return true;
        }
        #endregion





    }
}
