using System.Collections.Generic;

namespace TicTacToe
{
    public interface IPlayer
    {
        int SelectMove(List<int> emptyFields);
        Mark GetMark();
    }
}