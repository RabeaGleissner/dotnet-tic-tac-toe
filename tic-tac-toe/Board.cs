using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
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

        public List<char> GetCurrentState() => State;

        public bool IsEmpty()
        {
            return !State.Contains((char)Mark.O) && !State.Contains((char)Mark.X);
        }

        public void AddMark(Mark mark, int position) => State[position] = (char)mark;

        public bool IsFull() => !State.Contains('_');

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
                lines.Add((List<char>)State.Skip(i).Take(Dimension).ToList());
            }
        }

        private void AddColumns(List<List<char>> lines)
        {
            for (int i = 0; i < Dimension; i++)
            {
                lines.Add(new List<char> { State[i], State[i + Dimension], State[i + (Dimension * 2)] });
            }
        }

        private void AddDiagonals(List<List<char>> lines)
        {
            lines.Add(new List<char> { State[0], State[4], State[8] });
            lines.Add(new List<char> { State[2], State[4], State[6] });
        }

        public List<int> GetEmptyFields()
        {
            List<int> emptyFields = new List<int> { };
            for (int i = 0; i < State.Count; i++)
            {
                if (State[i] == '_')
                {
                    emptyFields.Add(i);
                }
            }
            return emptyFields;
        }
    }
}