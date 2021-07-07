using System;

namespace tic_tac_toe
{
    internal class UserInterface : IUserInterface
    {
        public string getInput() => Console.ReadLine();

        public void print(string input) => Console.WriteLine(input);
    }
}