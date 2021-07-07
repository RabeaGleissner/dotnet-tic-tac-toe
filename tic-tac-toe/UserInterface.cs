using System;

namespace tic_tac_toe
{
    internal class UserInterface : IUserInterface
    {
        public string GetInput() => Console.ReadLine();

        public void Print(string input) => Console.WriteLine(input);
    }
}