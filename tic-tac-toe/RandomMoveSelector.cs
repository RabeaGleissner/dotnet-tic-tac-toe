using System;

namespace TicTacToe
{
    internal class RandomMoveSelector : IMoveSelector
    {
        public int GetMove() => new Random().Next(8);
    }
}