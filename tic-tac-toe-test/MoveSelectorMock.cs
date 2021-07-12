using TicTacToe;

namespace TicTacToeTest
{
    internal class MoveSelectorMock : IMoveSelector
    {
        private int move;

        public MoveSelectorMock(int move)
        {
            this.move = move;
        }

        public int GetMove() => move;
    }
}