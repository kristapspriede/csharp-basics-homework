using System;

namespace TicTacToe
{
    class Program
    {

        // define 3x3 board
        static char[,] board = new char[3, 3];
        static char player = 'X';
        static int turn = 0;
        static int win = 0;

        static void Main(string[] args)
        {
            DisplayBoard();

            while (win == 0)
            {
                Console.Clear();
                if (turn == 9)
                {
                    win = 2;
                    break;
                }
                DisplayBoard();
                takeTurn();
            }

            DisplayBoard();
            if (win == 1) Console.WriteLine("Winner! Congrats to Player " + player);
            else Console.WriteLine("Game is tie.");

            Console.ReadLine();
        }


        static void takeTurn()
        {

            Console.Write(player + " , choose your location (row, column): ");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            playTurn(row, column);
        }

        static void playTurn(int row, int column)
        {



            if (board[row, column] == 0)
            {

                board[row, column] = player;
                checkWin();
                if (win == 0)
                {
                    player = (player == 'X') ? 'O' : 'X';
                    turn++;
                }
            }
            else
            {
                Console.WriteLine("Space already filled, try again.");
                takeTurn();
            }
        }

        static void checkWin()
        {
            // check row
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] > 0 && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    win = 1;
                    return;
                }
            }
            // check column
            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] > 0 && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    win = 1;
                    return;
                }
            }
            // check diagonal
            if (board[0, 0] > 0 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                win = 1;
                return;
            }
            if (board[2, 0] > 0 && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                win = 1;
                return;
            }
        }
        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

    }
}
