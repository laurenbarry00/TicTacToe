using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private Player[,] board;

        public Board()
        {
            board = new Player[3,3]; // Board is 3x3

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i,j] = Player.NULL;
                }
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++) // Loop through rows
            {
                Console.WriteLine("-------------");
                for (int j = 0; j < 3; j++) // Loops through columns
                {
                    if (board[i,j] == Player.NULL)
                    {
                        Console.Write("| " + "  ");
                    }
                    else
                    {
                        Console.Write("| " + board[i,j] + " ");
                    }
                    
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
        }
        
        public bool PlaceMark(Player player, int x, int y)
        {
            if (board[x, y] == Player.NULL) // Square is empty
            {
                board[x, y] = player;
                return true;
            }
            return false;
        }

        public Player GetSquare(int x, int y)
        {
            return board[x, y];
        }

        public Player CheckVictory()
        {
            // Check horizontal and vertical victory
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    return board[i, 0];
                }
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
                {
                    return board[0, i];
                }
            }
            
            if (board[0,0] == board[1,1] && board[0,0] == board[2,2])
            {
                return board[0, 0];
            } else if (board[2,0] == board[1,1] && board[2,0] == board[0,2])
            {
                return board[2, 0];
            }
            /* Check for horizontal victory
             * Check for vertical victory
             * Check for diagonal victory
            */
            return Player.NULL;
        }

        public bool CheckIsAllSquaresFilled()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i,j] == Player.NULL)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
