namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe(new PlayerCommunication(new UserInterface()));
            ticTacToe.play();
        }
    }
}
