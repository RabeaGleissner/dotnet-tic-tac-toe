using System.Collections.Generic;
using TicTacToe;

namespace TicTacToeTest
{
    internal class MoveSelectorMock : IMoveSelector
    {
        private List<int> Moves;

        public MoveSelectorMock(List<int> moves)
        {
            this.Moves = moves;
        }

        public int GetMove(List<int> _)
        {
            int move = Moves[0];
            Moves.RemoveAt(0);
            return move;
        }
    }
}