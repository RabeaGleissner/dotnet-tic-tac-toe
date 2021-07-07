using Xunit;
using tic_tac_toe;
using System.Collections.Generic;

namespace tic_tac_toe_test
{
    public class BoardTest
    {
        [Fact]
        public void IsEmptyInitially()
        {
            Board board = new Board();

            Assert.True(board.IsEmpty());
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
            List<char> fullBoardState = new List<char> {
                'X', 'O', 'X',
                'O', 'X', 'O',
                'X', 'O', '_',
                };

            Board board = new Board(fullBoardState);

            Assert.False(board.IsFull());
        }
    }
}