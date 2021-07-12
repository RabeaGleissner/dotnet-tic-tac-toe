using System.Collections.Generic;

namespace TicTacToe
{
    public interface IMoveSelector
    {
        int GetMove(List<int> emptyFields);
    }
}