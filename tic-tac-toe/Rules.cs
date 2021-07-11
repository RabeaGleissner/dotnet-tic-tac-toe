using System.Collections.Generic;

namespace TicTacToe
{
    public static class Rules
    {
        public static bool GameOver(Board board) => HasWinner(board) || board.IsFull();

        private static bool HasWinner(Board board)
        {
            bool winner = false;
            foreach (List<char> line in board.GetLines())
            {
                if (!line.Contains('_') && line[0] == line[1] && line[1] == line[2])
                {
                    winner = true;
                }
            }
            return winner;
        }
    }
}