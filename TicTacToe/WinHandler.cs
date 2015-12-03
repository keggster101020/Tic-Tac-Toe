using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class WinHandler
    {
        //generate a static empty constructor
        static WinHandler() { }

        private static int checkRowWin(Label[] board)
        {
            int rowCount = 0;
            for(int i = 0; i < board.Length; i+=3)
            {
                if (board[i].Text == "-")
                {
                    rowCount++;
                    continue;
                }
                if (board[i].Text == board[i+1].Text && board[i+1].Text == board[i + 2].Text)
                {
                    return rowCount;
                }
                rowCount++;

            }
            return -1;

        }

        private static int checkColWin(Label [] board)
        {
            int colCount = 3;
            for(int i = 0; i < 3; i++)
            {
                if(board[i].Text == "-")
                {
                    colCount++;
                    continue;
                }
                if(board[i].Text == board[i+3].Text && board[i+3].Text == board[i + 6].Text)
                {
                    return colCount;
                }
                colCount++;
            }
            return -1;
        }

        private static int checkDiagWin(Label [] board)
        {
            
            if (board[0].Text != "-" && board[0].Text == board[4].Text && board[4].Text == board[8].Text)
            {
                return 6; //diagonal win starting at the top left of the board
            }

            if(board[2].Text != "-" &&board[2].Text == board[4].Text && board[4].Text == board[6].Text)
            {
                return 7; //diagonal win starting at the top right of the board
            }

            return -1;

        }

        /**********************************************

            This method will be used to see if that 
            game board has a win.
            Win codes:
            0-first row win
            1-second row win
            2-third row win
            3-first column win
            4-second column win
            5-third column win
            6-first diagonal win
            7-second diagonal win
        **********************************************/
        public static int checkWin(Label [] board)
        {
            if (checkDiagWin(board) >= 0) return checkDiagWin(board);
            else if (checkColWin(board) >= 0) return checkColWin(board);
            else if (checkRowWin(board) >= 0) return checkRowWin(board);
            else return -1;
        }

        public static bool checkDraw(Label [] board)
        {
            bool checkCondition = true;
            foreach (Label sq in board)
            {
                if (sq.Text != "-" && checkWin(board) == -1)
                {
                    checkCondition = checkCondition && true;

                }
                else
                {
                    checkCondition = false;
                }
            }
            return checkCondition;
        }

    }
}
