using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class cs1
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';
        

       static void GameBot()
        {
            InitializeBoard();

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            Random random = new Random();
            int startingPlayer = random.Next(2);
            if (startingPlayer == 0)
            {
                Console.WriteLine("You go first!");
            }
            else
            {
                Console.WriteLine("The computer goes first.");
                currentPlayer = 'O';
                ComputerTurn();
            }

            while (true)
            {
                PrintBoard();

                if (CheckForWinner())
                {
                    Console.WriteLine(currentPlayer + " wins!");
                    break;
                }
                else if (CheckForTie())
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }

                if (currentPlayer == 'X')
                {
                    PlayerTurn();
                }
                else
                {
                    ComputerTurn();
                }
            }

            
        }

        static void GamePlayer()
        {
            InitializeBoard();

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            Random random = new Random();
            int startingPlayer = random.Next(2);
            if (startingPlayer == 0)
            {
                Console.WriteLine("You go first!");
                PlayerTurn();
            }
            else
            {
                Console.WriteLine("Second player goes first.");
                currentPlayer = 'O';
                PlayerTurnSecond();
            }

            while (true)
            {
                PrintBoard();

                if (CheckForWinner())
                {
                    Console.WriteLine(currentPlayer + " wins!");
                    break;
                }
                else if (CheckForTie())
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }

                if (currentPlayer == 'X')
                {
                    PlayerTurn();
                }
                else
                {
                    PlayerTurnSecond();
                }
            } 
        }
            

            static void InitializeBoard()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = ' ';
                    }
                }
            }

            static void PrintBoard()
            {
                Console.WriteLine("  1 2 3");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + 1 + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            static void PlayerTurn()
            {
                while (true)
                {
                    Console.Write("Enter row number (1-3): ");
                    int row = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Enter column number (1-3): ");
                    int col = int.Parse(Console.ReadLine()) - 1;

                    if (row < 0 || row > 2 || col < 0 || col > 2)
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                    }
                    else if (board[row, col] != ' ')
                    {
                        Console.WriteLine("That cell is already occupied! Please try again.");
                    }
                    else
                    {
                        board[row, col] = currentPlayer;
                        break;
                    }
                }

                currentPlayer = 'O';
            }
            static void PlayerTurnSecond()
            {
                while (true)
                {
                    Console.Write("Enter row number (1-3): ");
                    int row = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Enter column number (1-3): ");
                    int col = int.Parse(Console.ReadLine()) - 1;

                    if (row < 0 || row > 2 || col < 0 || col > 2)
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                    }
                    else if (board[row, col] != ' ')
                    {
                        Console.WriteLine("That cell is already occupied! Please try again.");
                    }
                    else
                    {
                        board[row, col] = currentPlayer;
                        break;
                    }
                }

                currentPlayer = 'X';
            }



        static void ComputerTurn()
            {
                Console.WriteLine("Computer is thinking...");
                Random random = new Random();
                while (true)
                {
                    int row = random.Next(3);
                    int col = random.Next(3);

                    if (board[row, col] == ' ')
                    {
                        board[row, col] = currentPlayer;
                        break;
                    }
                }

                currentPlayer = 'X';
          }
            

            static bool CheckForWinner()
            {
                // Check rows
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    {
                        return true;
                    }
                }

                // Check columns
                for (int j = 0; j < 3; j++)
                {
                    if (board[0, j] != ' ' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                    {
                        return true;
                    }
                }

                // Check diagonals
                if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    return true;
                }
                if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return true;
                }

                return false;
            }

            static bool CheckForTie()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            public static void TicTacToe()
            {
                Console.WriteLine("Write what gamemode you want to play 1 - Player vs Bot,2 - Player vs Player:");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        GameBot();
                        break;
                    case 2:
                        GamePlayer();
                        break;
                    default:    
                        Console.WriteLine("Wrong GameMode:");
                        break;
                }
            
            
            }
        


    }
}
    

