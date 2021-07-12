using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class RandomMoveSelector : IMoveSelector
    {
        public int GetMove(List<int> emptyFields)
        {
            int randomIndex = new Random().Next(emptyFields.Count);
            return emptyFields[randomIndex];
        }
    }
}