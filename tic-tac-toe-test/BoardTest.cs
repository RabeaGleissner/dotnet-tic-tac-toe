using Xunit;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTest
{
    public class BoardTest
    {
        [Fact]
        public void IsEmptyInitially()
        {
            Assert.True(new Board().IsEmpty());
        }

        [Fact]
        public void IsNotEmptyWhenMarkIsAdded()
        {
            Board board = new Board();
            board.AddMark(Mark.X, 3);

            Assert.False(board.IsEmpty());
        }

        [Fact]
        public void StateChangesAfterAddingMarks()
        {
            Board board = new Board();
            List<char> expectedEmptyBoardState = new List<char> {
                '_', '_', '_',
                '_', '_', '_',
                '_', '_', '_',
                };

            Assert.Equal(expectedEmptyBoardState, board.GetCurrentState());

            board.AddMark(Mark.X, 3);
            board.AddMark(Mark.O, 8);

            List<char> expectedBoardStateWithMark = new List<char> {
                '_', '_', '_',
                'X', '_', '_',
                '_', '_', 'O',
                };

            Assert.Equal(expectedBoardStateWithMark, board.GetCurrentState());
        }

        [Fact]
        public void IsFullWhenAllSlotsAreFilled()
        {
            List<char> fullBoardState = new List<char> {
                'X', 'O', 'X',
                'O', 'X', 'O',
                'X', 'O', 'X',
                };

            Board board = new Board(fullBoardState);

            Assert.True(board.IsFull());
        }

        [Fact]
        public void IsNotFullWhenThereIsAtLeastOneEmptySlot()
        {
            List<char> notFullBoardState = new List<char> {
                'X', 'O', 'X',
                'O', 'X', 'O',
                'X', 'O', '_',
                };

            Board board = new Board(notFullBoardState);

            Assert.False(board.IsFull());
        }

        [Fact]
        public void ReturnsAllRowsColumnsAndDiagonals()
        {
            List<char> gameState = new List<char> {
                'X', 'X', 'X',
                'O', '_', 'O',
                '_', 'O', 'X',
                };

            Board board = new Board(gameState);

            List<List<char>> expectedLines = new List<List<char>>();
            expectedLines.Add(new List<char> { 'X', 'X', 'X' });
            expectedLines.Add(new List<char> { 'O', '_', 'O' });
            expectedLines.Add(new List<char> { '_', 'O', 'X' });
            expectedLines.Add(new List<char> { 'X', 'O', '_' });
            expectedLines.Add(new List<char> { 'X', '_', 'O' });
            expectedLines.Add(new List<char> { 'X', 'O', 'X' });
            expectedLines.Add(new List<char> { 'X', '_', 'X' });
            expectedLines.Add(new List<char> { 'X', '_', '_' });

            Assert.Equal(expectedLines, board.GetLines());
        }

        [Fact]
        public void ReturnsAllEmptyFields()
        {
            List<char> gameState = new List<char> {
                '_', '_', 'X',
                'O', '_', 'O',
                '_', 'O', 'X',
                };

            Board board = new Board(gameState);

            Assert.Equal(new List<int> { 0, 1, 4, 6 }, board.GetEmptyFields());
        }
    }
}