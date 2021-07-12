namespace TicTacToe
{
    public interface IPlayer
    {
        int SelectMove();
        Mark GetMark();
    }
}