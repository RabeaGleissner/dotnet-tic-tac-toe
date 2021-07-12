using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class PlayerCommunication
    {
        IUserInterface userInterface;
        private string errorMessage = "Invalid move! Please try again.";
        private const string greeting = "Welcome to Tic Tac Toe!";
        private const string prompt = "Please pick an empty field to place your mark:\n";
        private const string gameOver = "Game Over!";
        private const string selectedFieldMessage = "Selected field by player ";
        private const string line = "\n-----\n";

        public PlayerCommunication(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }

        public void Greet() => userInterface.Print(greeting);

        public void DisplayBoard(List<char> boardState)
        {
            string prettyBoard = line;
            for (int i = 0; i < boardState.Count; i++)
            {
                string field = boardState[i] == '_' ? i.ToString() : boardState[i].ToString();
                bool endOfFirstOrSecondLine = i == 2 || i == 5;
                string spaceOrBreak = endOfFirstOrSecondLine ? "\n" : " ";
                prettyBoard += field += spaceOrBreak;
            }
            prettyBoard += line;
            userInterface.Print(prettyBoard);
        }

        internal void DisplayError() => userInterface.Print(errorMessage);

        public string PromptToPickField()
        {
            userInterface.Print(prompt);
            return userInterface.GetInput();
        }

        public void AnnounceGameOver() => userInterface.Print(gameOver);

        public void AnnounceSelectedField(int selectedField, Mark mark) => userInterface.Print($"{selectedFieldMessage}{mark}: {selectedField}");
    }
}