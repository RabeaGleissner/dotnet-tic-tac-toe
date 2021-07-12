namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCommunication playerCommunication = new PlayerCommunication(new UserInterface());
            new TicTacToeGame(
                playerCommunication,
                new Board(),
                new HumanPlayer(playerCommunication, Mark.X),
                new ComputerPlayer(new RandomMoveSelector(), Mark.O)
             ).play();
        }
    }
}
