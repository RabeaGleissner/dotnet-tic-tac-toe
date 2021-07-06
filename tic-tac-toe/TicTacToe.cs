using System;

namespace tic_tac_toe
{
    public class TicTacToe
    {
        public void play()
        {
            Console.WriteLine("Let's play Tic Tac Toe!");

            Console.WriteLine("Please pick a field to make your mark");
            string userInput = Console.ReadLine();

            Console.WriteLine($"You picked {userInput}");

        }

        public int justForTest() => 12;
    }
}