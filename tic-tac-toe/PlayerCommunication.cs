using System.Collections.Generic;

namespace TicTacToe
{
    public class PlayerCommunication
    {
        IUserInterface UserInterface;
        private string errorMessage = "Invalid move! Please try again.";
        private const string greeting = "Welcome to Tic Tac Toe!";
        private const string prompt = "Please pick an empty field to place your mark:\n";
        private const string gameOver = "Game Over!";
        private const string selectedFieldMessage = "Selected field by player ";
        private const string line = "\n-----\n";

        public PlayerCommunication(IUserInterface userInterface)
        {
            this.UserInterface = userInterface;
        }

        public void Greet() => UserInterface.Print(greeting);

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
            UserInterface.Print(prettyBoard);
        }

        internal void DisplayError() => UserInterface.Print(errorMessage);

        public string PromptToPickField()
        {
            UserInterface.Print(prompt);
            return UserInterface.GetInput();
        }

        public void AnnounceGameOver() => UserInterface.Print(gameOver);

        public void AnnounceSelectedField(int selectedField, Mark mark) => UserInterface.Print($"{selectedFieldMessage}{mark}: {selectedField}");
    }
}