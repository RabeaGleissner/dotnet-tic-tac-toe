using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tic_tac_toe
{
    public class Board
    {
        private const int Size = 9;
        private const int Dimension = 3;
        private List<char> State;

        public Board()
        {
            this.State = Enumerable.Repeat('_', 9).ToList();
        }

        public Board(List<char> givenState)
        {
            this.State = givenState;
        }

        public List<char> GetCurrentState() => this.State;

        public bool IsEmpty()
        {
            return !this.State.Contains((char)Mark.O) && !this.State.Contains((char)Mark.X);
        }

        public void AddMark(Mark mark, int position) => this.State[position] = (char)mark;

        public bool IsFull() => !this.State.Contains('_');

        public List<List<char>> GetLines()
        {
            List<List<char>> lines = new List<List<char>> { };
            AddRows(lines);
            AddColumns(lines);
            AddDiagonals(lines);
            return lines;
        }

        private void AddRows(List<List<char>> lines)
        {
            for (int i = 0; i < Size; i += Dimension)
            {
                lines.Add((List<char>)this.State.Skip(i).Take(Dimension).ToList());
            }
        }

        private void AddColumns(List<List<char>> lines)
        {
            for (int i = 0; i < Dimension; i++)
            {
                lines.Add(new List<char> { this.State[i], this.State[i + Dimension], this.State[i + (Dimension * 2)] });
            }
        }

        private void AddDiagonals(List<List<char>> lines)
        {
            lines.Add(new List<char> { this.State[0], this.State[4], this.State[8] });
            lines.Add(new List<char> { this.State[2], this.State[4], this.State[6] });
        }
    }
}