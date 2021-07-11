using System;

namespace TicTacToe
{
    internal class UserInterface : IUserInterface
    {
        public string GetInput() => Console.ReadLine();

        public void Print(string input) => Console.WriteLine(input);
    }
}