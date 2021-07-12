using System.Collections.Generic;
using TicTacToe;

namespace TicTacToeTest
{
    internal class MoveSelectorMock : IMoveSelector
    {
        private List<int> moves;

        public MoveSelectorMock(List<int> moves)
        {
            this.moves = moves;
        }

        public int GetMove()
        {
            int move = moves[0];
            moves.RemoveAt(0);
            return move;
        }
    }
}