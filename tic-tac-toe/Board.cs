using System;
using System.Collections.Generic;
using System.Linq;

namespace tic_tac_toe
{
    public class Board
    {
        private List<char> BoardState;

        public Board()
        {
            this.BoardState = Enumerable.Repeat('_', 9).ToList();
        }

        public Board(List<char> givenState)
        {
            this.BoardState = givenState;
        }

        public List<char> GetCurrentState() => this.BoardState;

        public bool IsEmpty()
        {
            return !this.BoardState.Contains((char)Mark.O) && !this.BoardState.Contains((char)Mark.X);
        }

        public void AddMark(Mark mark, int position) => this.BoardState[position] = (char)mark;

        public bool IsFull() => !this.BoardState.Contains('_');
    }
}