using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace TicTacToe
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        private Label[] board;
        private bool isXTurn = false;
        private int xWins = 0;
        private int oWins = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            initGame();
        }

        private void initGame()
        {
            board = new Label[] { topLeft, topCenter,topRight,
                                  middleLeft, middleCenter, middleRight,
                                  bottomLeft, bottomCenter, bottomRight};
            lblWinner.Text = "-";
            lblOWins.Text = oWins.ToString();
            lblXWins.Text = xWins.ToString();
            foreach (Label l in board)
            {
                l.Enabled = true;
                l.Text = "-";
                l.ForeColor = Color.Black;
            }
        }

        private void onLabelClick(object sender, EventArgs e)
        {
            Label square = sender as Label;
            int winStatus = -1;
            if (isXTurn)
            {
                square.Text = "X";
                lblTurn.Text = "O";
                isXTurn = false;
            }
            else
            {
                square.Text = "O";
                lblTurn.Text = "X";
                isXTurn = true;
            }
            square.Enabled = false;
            winStatus = WinHandler.checkWin(board);

            if (winStatus > -1)
            {
                colorWin(winStatus);
                if (isXTurn)
                {
                    lblWinner.Text = "O";
                    oWins++;
                    lblOWins.Text = oWins.ToString();
                }
                else
                {
                    lblWinner.Text = "X";
                    xWins++;
                    lblXWins.Text = xWins.ToString();
                }
            }
            if (WinHandler.checkDraw(board))
            {
                lblWinner.Text = "Draw";
            }
        }

        private void colorWin(int statusCode)
        {
            foreach(Label s in board)
                s.Enabled = false;
            
            switch (statusCode)
            {
                case 0:
                    colorHelper(new[] { board[0], board[1], board[2] },Color.Green);
                    break;
                case 1:
                    colorHelper(new[] { board[3], board[4], board[5] }, Color.Green);
                    break;
                case 2:
                    colorHelper(new[] { board[6], board[7], board[8] }, Color.Green);
                    break;
                case 3:
                    colorHelper(new[] { board[0], board[3], board[6] }, Color.Green);
                    break;
                case 4:
                    colorHelper(new[] { board[1], board[4], board[7] }, Color.Green);
                    break;
                case 5:
                    colorHelper(new[] { board[2], board[5], board[8] }, Color.Green);
                    break;
                case 6:
                    colorHelper(new[] { board[0], board[4], board[8] }, Color.Green);
                    break;
                case 7:
                    colorHelper(new[] { board[2], board[4], board[6] }, Color.Green);
                    break;

            };
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            initGame();
        }

        private void colorHelper(Label[] l, Color c)
        {
            foreach (Label s in l)
            {
                s.Enabled = true;
                s.ForeColor = c;
            }
        }
    }
}
