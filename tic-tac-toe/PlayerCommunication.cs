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

        public void greet() => userInterface.print(greeting);

        public string promptToPickField()
        {
            userInterface.print(prompt);
            return userInterface.getInput();
        }

        public void confirmSelectedField(string selectedField) => userInterface.print($"{confirmField}{selectedField}");
    }
}