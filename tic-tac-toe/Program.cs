namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args) => new TicTacToe(new PlayerCommunication(new UserInterface()), new Board()).play();
    }
}
