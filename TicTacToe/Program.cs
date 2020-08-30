using System;
using Lab04_TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Board.DisplayBoard();
            //StartGame();
        }

            static void StartGame()
            {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
            Console.Write("Player 1 enter your name: ");
            string input1 = Console.ReadLine();
            Console.Write("Player 2 enter your name: ");
            string input2 = Console.ReadLine();
            //Player p1 = new Player();
            //Player p2 = new Player();
            }

        
    }
}
