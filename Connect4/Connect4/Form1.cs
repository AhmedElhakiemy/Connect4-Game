using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Connect4
{
    public partial class Form1 : Form
    {

        //instance of Game
        Game game1 = new Game();

        //constructor of the Form
        public Form1()
        {
            InitializeComponent();
            lblPlayer_1_score.ForeColor = Color.Blue;
            lblPlayer1.ForeColor = Color.Blue;
            lblPlayer_2_score.ForeColor = Color.Black;
            lblPlayer2.ForeColor = Color.Black;
        }

        //methods to change players labels color
        public void ChangeColorToBlue()
        {
            lblPlayer_1_score.ForeColor = Color.Blue;
            lblPlayer1.ForeColor = Color.Blue;
            lblPlayer_2_score.ForeColor = Color.Black;
            lblPlayer2.ForeColor = Color.Black;
        }
        public void ChangeColorToRed()
        {
            lblPlayer_2_score.ForeColor = Color.Red;
            lblPlayer2.ForeColor = Color.Red;
            lblPlayer_1_score.ForeColor = Color.Black;
            lblPlayer1.ForeColor = Color.Black;
        }

        //Method to handle painting of the form
        #region panel1_Paint redrawGamePiece
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            game1.drawBoard(e);

        }
        #endregion

        //methods to check who win and draw pieces
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics f = this.panel1.CreateGraphics())
            {
                game1.drawGamePiece(e, f);
                if(game1.player1)
                {
                    ChangeColorToBlue();
                }
                else
                {
                    ChangeColorToRed();
                }
                
            }

            if (game1.CheckWinner() == 1)
            {
                MessageBox.Show("Blue Player Wins");
                game1.Player1Score++;
                lblPlayer_1_score.Text = game1.Player1Score.ToString();
                game1.Reset();
                ChangeColorToBlue();
                panel1.Invalidate();
            }
            else if (game1.CheckWinner() == 2)
            {
               
                MessageBox.Show("Red Player Wins");
                game1.Player2Score++;
                lblPlayer_2_score.Text = game1.Player2Score.ToString();
                game1.Reset();
                ChangeColorToBlue();
                panel1.Invalidate();
            }
            else if (game1.tie())
            {
               MessageBox.Show("it is a tie");
                game1.Reset();
                ChangeColorToBlue();
                panel1.Invalidate();
            }

        }



        //Method for reset the current game
        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to reset current game ?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                panel1.Invalidate();
                game1.Reset();
                ChangeColorToBlue();
            }
            

        }

        //method for reset the general game and score
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to reset the score ?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                panel1.Invalidate();
                game1.Reset();
                ChangeColorToBlue();
                game1.Player1Score = 0;
                game1.Player2Score = 0;
                lblPlayer_1_score.Text = 0.ToString();
                lblPlayer_2_score.Text = 0.ToString();
            }

        }
    }
}
