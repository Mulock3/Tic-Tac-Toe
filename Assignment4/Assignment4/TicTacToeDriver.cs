using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TicTacToeDriver
    {
        /// <summary>
        /// Two dimensional game board
        /// </summary>
        private int[,] gameBoard = new int[,] { {2,2,2 }, { 2,2,2 }, { 2, 2, 2} };
        private int count;
        /// <summary>
        /// The game UI reference, to call UI updates
        /// </summary>
        private Form1 currentGameUI;

        /// <summary>
        /// Constructor, just sets the board up
        /// </summary>
        public TicTacToeDriver(Form1 currentGameUIIN)
        {
            currentGameUI = currentGameUIIN;
            count = 0;
        }

        /// <summary>
        /// Handles each move in tic tac toe
        /// Row 0 starts at the top
        /// Col 0 starts at the left
        /// PlayerOne true is player one
        /// PlayerOne false is player two
        /// </summary>
        /// <param name="rowIN"></param>
        /// <param name="colIN"></param>
        /// <param name="playerOneIN"></param>
        public void makeMove(int rowIN, int colIN, bool playerOneIN)
        {
            if (playerOneIN == true)
            {
                gameBoard[rowIN, colIN] = 0;
            }
            else
            {
                gameBoard[rowIN, colIN] = 1;
            }

            count++;

            // The bool portion of this is not important to this set up, but could be useful to others in future applications
            bool restartGame = win();

            if (restartGame == true)
            {
                gameBoard = new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
            }
        }

        /// <summary>
        /// This checks for wins, we only have 8 possible wins scenarios
        /// Also calls the currentGameUI win function if a win is detectd
        /// </summary>
        /// <returns></returns>
        public bool win()
        {
            // Win checks
            #region Player One
            // Row Win
            if (gameBoard[0,0] == 0 && gameBoard[0,1] == 0 && gameBoard[0,2] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 0);
                return true;
            }
            else if (gameBoard[1, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[1, 2] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 1);
                return true;
            }
            else if (gameBoard[2, 0] == 0 && gameBoard[2, 1] == 0 && gameBoard[2, 2] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 2);
                return true;
            }
            // Col Win
            else if (gameBoard[0, 0] == 0 && gameBoard[1, 0] == 0 && gameBoard[2, 0] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 3);
                return true;
            }
            else if (gameBoard[0, 1] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 1] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 4);
                return true;
            }
            else if (gameBoard[0, 2] == 0 && gameBoard[1, 2] == 0 && gameBoard[2, 2] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 5);
                return true;
            }
            // Diagonal Win
            else if (gameBoard[0, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 2] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 6);
                return true;
            }
            else if (gameBoard[0, 2] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 0] == 0)
            {
                // Win for player 1
                currentGameUI.updateGameStats(0, 7);
                return true;
            }
            #endregion

            #region Player two
            // Row Win
            if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 0);
                return true;
            }
            else if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 1);
                return true;
            }
            else if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 2);
                return true;
            }
            // Col Win
            else if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 3);
                return true;
            }
            else if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 4);
                return true;
            }
            else if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 5);
                return true;
            }
            // Diagonal Win
            else if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 6);
                return true;
            }
            else if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
            {
                // Win for player 1
                currentGameUI.updateGameStats(1, 7);
                return true;
            }
            #endregion

            // Check for tie
            if (count == 9)
            {
                currentGameUI.updateGameStats(2, 9);
                return true;
            }

            return false;
        }

    }
}
