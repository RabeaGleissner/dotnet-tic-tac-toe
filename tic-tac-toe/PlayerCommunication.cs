namespace tic_tac_toe
{
    public class PlayerCommunication
    {
        IUserInterface userInterface;

        const string greeting = "Welcome to Tic Tac Toe!";
        const string prompt = "Please pick a field to make your mark";
        const string confirmField = "You picked ";

        public PlayerCommunication(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }

        public void Greet() => userInterface.Print(greeting);

        public string PromptToPickField()
        {
            userInterface.Print(prompt);
            return userInterface.GetInput();
        }

        public void ConfirmSelectedField(string selectedField) => userInterface.Print($"{confirmField}{selectedField}");
    }
}