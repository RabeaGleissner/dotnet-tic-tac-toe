using System.Collections.Generic;

namespace tic_tac_toe
{
    public class PlayerCommunication
    {
        IUserInterface userInterface;

        const string greeting = "Welcome to Tic Tac Toe!";
        const string prompt = "Please pick a field to make your mark";
        private const string gameOver = "Game Over!";

        public PlayerCommunication(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }

        public void Greet() => userInterface.Print(greeting);

        public void DisplayBoard(List<char> boardState)
        {
            string prettyState = $"{boardState[0]} {boardState[1]} {boardState[2]}\n{boardState[3]} {boardState[4]} {boardState[5]}\n{boardState[6]} {boardState[7]} {boardState[8]}";
            userInterface.Print(prettyState);
        }

        public string PromptToPickField()
        {
            userInterface.Print(prompt);
            return userInterface.GetInput();
        }

        public void AnnounceGameOver() => userInterface.Print(gameOver);
    }
}