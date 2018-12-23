using System;

namespace TicTacToe
{
    public class Game
    {
        private static bool isPlayerOneTurn;
        private static bool gameRunning = true;
        private static bool playAgain;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe!");
            Console.WriteLine("The board is layed out as below:");
            PrintBoardGuide();
            Console.WriteLine("\n\n\n");
            do
            {
                Board board = new Board();
                gameRunning = true;
                isPlayerOneTurn = true;
                
                Console.WriteLine("Player 1 (X) goes first.");
                do
                {
                    board.PrintBoard();
                    Console.WriteLine("\n");
                    bool isValidSquare = false;
                    int x = 0, y = 0;
                    do
                    {
                        if (isPlayerOneTurn)
                        {
                            Console.WriteLine("Player X's turn!");
                        }
                        else
                        {
                            Console.WriteLine("Player O's turn!");
                        }
                        int square = GetSquare();
                        if (square > 0 && square <= 3)
                        { // 1, 2, 3
                            x = 0;
                            y = square - 1;
                        }
                        else if (square > 3 && square <= 6) // 4, 5, 6
                        {
                            x = 1;
                            y = square - 3 - 1;
                        }
                        else if (square > 6 && square <= 9)
                        {
                            x = 2;
                            y = square - 6 - 1;
                        }
                        else
                        {
                            Console.WriteLine("Invalid square entered.\n");
                        }

                        Console.WriteLine("\n\n");
                        if (isPlayerOneTurn) // Player 1 = X
                        {
                            isValidSquare = board.PlaceMark(Player.X, x, y);
                            if (!isValidSquare)
                            {
                                Console.WriteLine("Invalid square entered.\n");
                            }
                            else
                            {
                                isPlayerOneTurn = !isPlayerOneTurn; // Change turns
                            }
                        }
                        else // O's turn
                        {
                            isValidSquare = board.PlaceMark(Player.O, x, y);
                            if (!isValidSquare)
                            {
                                Console.WriteLine("Invalid square entered.\n");
                            }
                            else
                            {
                                isPlayerOneTurn = !isPlayerOneTurn; // Change turns
                            }
                        }
                    } while (!isValidSquare);


                    Player victor = board.CheckVictory();
                    if (victor != Player.NULL) // A player has won
                    {
                        board.PrintBoard();
                        Console.WriteLine("Player " + victor + " has won!");
                        gameRunning = false;
                    }

                    if (board.CheckIsAllSquaresFilled())
                    {
                        Console.WriteLine("STALEMATE!");
                        gameRunning = false;
                    }
                } while (gameRunning);

                bool validInput = false;
                do
                {
                    Console.Write("Play again? (y/n) ");
                    char answer = char.Parse(Console.ReadLine());
                    if (answer == 'y')
                    {
                        playAgain = true;
                        validInput = true;
                        Console.WriteLine("\n\n\n");
                    }
                    else if (answer == 'n')
                    {
                        Console.WriteLine("Thanks for playing!\n");
                        Console.WriteLine("Press any key to exit...");
                        playAgain = false;
                        validInput = true;
                    }
                } while (!validInput);
            } while (playAgain);

            Console.ReadKey();
        }

        private static int GetSquare()
        {
            bool validSquare = false;
            int square = 0;
            do
            {
                Console.Write("Enter a square to place mark at: ");
                square = int.Parse(Console.ReadLine());
                if (square < 1 || square > 9)
                {
                    Console.WriteLine("Invalid square entered.\n");
                } else
                {
                    validSquare = true;
                }
            } while (!validSquare);
            return square;
        }

        static void PrintBoardGuide()
        {
            int square = 1;
            for (int i = 0; i < 3; i++) // Loop through rows
            {
                Console.WriteLine("-------------");
                for (int j = 0; j < 3; j++) // Loops through columns
                {

                    Console.Write("| " + square + " ");
                    square++;

                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
        }
    }
}
