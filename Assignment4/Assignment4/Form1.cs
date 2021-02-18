using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Helps us know if a game is currently in progress or not
        /// </summary>
        private bool gameInProgress;
        /// <summary>
        /// Let's us know if it's player ones turn, if not, then it's player twos turn
        /// </summary>
        private bool playerOneTurn;
        /// <summary>
        /// This is our game logic
        /// </summary>
        private TicTacToeDriver gameEngine;

        /// <summary>
        /// Initial set up of the game
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Initial set up
            gameInProgress = false;
            playerOneTurn = true;

            leftTopBox.Text = "";
            midTopBox.Text = "";
            rightTopBox.Text = "";

            leftMidBox.Text = "";
            midBox.Text = "";
            rightMidBox.Text = "";

            leftBottomBox.Text = "";
            midBottomBox.Text = "";
            rightBottomBox.Text = "";
        }

        /// <summary>
        /// Starts the game of Tic Tac Toe or Restarts if the game is already in Progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGame_Click(object sender, EventArgs e)
        {
            if (gameInProgress != true)
            {
                gameInProgress = true;
                playerOneTurn = true;
                gameStatus.Text = "Player ones turn";
                gameEngine = new TicTacToeDriver(this);
                restartGameUIBoard();
            }
            else
            {
                // Do you want to restart the game?
                DialogResult result = MessageBox.Show("Would you like to restart the game?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    gameInProgress = true;
                    playerOneTurn = true;
                    gameStatus.Text = "Player ones turn";
                    gameEngine = new TicTacToeDriver(this);
                    restartGameUIBoard();
                }
            }
        }

        /// <summary>
        /// This is the new click method for Game Tiles
        /// Uses the Tag to determine what was clicked
        /// 
        /// I didn't architect this as well as I should have otherwise I wouldn't have deprecated code below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxClicked(object sender, EventArgs e)
        {
            if (gameInProgress == true)
            {
                Label currentLabel = (Label)sender;
                if (playerOneTurn == true && currentLabel.Text == "")
                {
                    currentLabel.Text = "X";
                    playerOneTurn = false;
                    gameStatus.Text = "Player twos turn";
                }
                else if (playerOneTurn == false && currentLabel.Text == "")
                {
                    currentLabel.Text = "O";
                    playerOneTurn = true;
                    gameStatus.Text = "Player ones turn";
                }

                // Calls our game engine

                if (currentLabel.Tag.ToString() == "LT")
                {
                    gameEngine.makeMove(0, 0, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "MT")
                {
                    gameEngine.makeMove(0, 1, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "RT")
                {
                    gameEngine.makeMove(0, 2, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "LM")
                {
                    gameEngine.makeMove(1, 0, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "M")
                {
                    gameEngine.makeMove(1, 1, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "RM")
                {
                    gameEngine.makeMove(1, 2, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "LB")
                {
                    gameEngine.makeMove(2, 0, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "MB")
                {
                    gameEngine.makeMove(2, 1, !playerOneTurn);
                }
                else if (currentLabel.Tag.ToString() == "RB")
                {
                    gameEngine.makeMove(2, 2, !playerOneTurn);
                }

            }
        }

        #region Game Tiles (Deprecated)

        #region Top Tiles
        /// <summary>
        /// Corresponds to the top left box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftTopBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Corresponds to the top middle box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void midTopBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Corresponds to the top right box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightTopBox_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Mid Row Tiles
        /// <summary>
        /// Corresponds to the middle left box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftMidBox_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Corresponds to the middle box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void midBox_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Corresponds to the middle right box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightMidBox_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bottom Tiles
        /// <summary>
        /// Corresponds to the bottom left box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftBottomBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Corresponds to the bottom middle box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void midBottomBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Corresponds to the bottom right box in the Tic Tac Toe Game
        /// Reacts to the game when player presses it; pending on game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightBottomBox_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        /// <summary>
        /// Resets the UI when needed
        /// </summary>
        private void restartGameUIBoard()
        {
            // Initial set up
            leftTopBox.Text = "";
            midTopBox.Text = "";
            rightTopBox.Text = "";

            leftMidBox.Text = "";
            midBox.Text = "";
            rightMidBox.Text = "";

            leftBottomBox.Text = "";
            midBottomBox.Text = "";
            rightBottomBox.Text = "";

            leftTopBox.BackColor = Color.White;
            midTopBox.BackColor = Color.White;
            rightTopBox.BackColor = Color.White;

            leftMidBox.BackColor = Color.White;
            midBox.BackColor = Color.White;
            rightMidBox.BackColor = Color.White;

            leftBottomBox.BackColor = Color.White;
            midBottomBox.BackColor = Color.White;
            rightBottomBox.BackColor = Color.White;
        }

        /// <summary>
        /// Updates the UI for wins
        /// 0 = Player 1
        /// 1 = Player 2
        /// 2 = Tie
        /// </summary>
        /// <param name="resultIN"></param>
        public void updateGameStats(int resultIN, int winMethod)
        {
            // Updates the game UI board
            if (resultIN == 0)
            {
                player1WinTotal.Text = (Convert.ToInt32(player1WinTotal.Text) + 1).ToString();
                gameStatus.Text = "Player One Wins";
            }
            else if (resultIN == 1)
            {
                player2WinTotal.Text = (Convert.ToInt32(player2WinTotal.Text) + 1).ToString();
                gameStatus.Text = "Player Two Wins";
            }
            else if (resultIN == 2)
            {
                tiesTotal.Text = (Convert.ToInt32(tiesTotal.Text) + 1).ToString();
                gameStatus.Text = "Game Tied";
            }
            else
            {
                // Bad result, do nothing
                gameStatus.Text = "Error calculating winner, please restart game";
            }

            gameInProgress = false;

            // Row Wins
            if (winMethod == 0)
            {
                rightTopBox.BackColor = Color.Blue;
                midTopBox.BackColor = Color.Blue;
                leftTopBox.BackColor = Color.Blue;
            }
            else if (winMethod == 1)
            {
                rightMidBox.BackColor = Color.Blue;
                midBox.BackColor = Color.Blue;
                leftMidBox.BackColor = Color.Blue;
            }
            else if (winMethod == 2)
            {
                rightBottomBox.BackColor = Color.Blue;
                midBottomBox.BackColor = Color.Blue;
                leftBottomBox.BackColor = Color.Blue;
            }
            // Col Wins
            else if (winMethod == 3)
            {
                leftTopBox.BackColor = Color.Blue;
                leftMidBox.BackColor = Color.Blue;
                leftBottomBox.BackColor = Color.Blue;
            }
            else if (winMethod == 4)
            {
                midTopBox.BackColor = Color.Blue;
                midBottomBox.BackColor = Color.Blue;
                midBox.BackColor = Color.Blue;
            }
            else if (winMethod == 5)
            {
                rightTopBox.BackColor = Color.Blue;
                rightMidBox.BackColor = Color.Blue;
                rightBottomBox.BackColor = Color.Blue;
            }
            // Diagonal Wins
            else if (winMethod == 6)
            {
                leftTopBox.BackColor = Color.Blue;
                midBox.BackColor = Color.Blue;
                rightBottomBox.BackColor = Color.Blue;
            }
            else if (winMethod == 7)
            {
                rightTopBox.BackColor = Color.Blue;
                midBox.BackColor = Color.Blue;
                leftBottomBox.BackColor = Color.Blue;
            }

            //restartGameUIBoard();
        }
    }
}
