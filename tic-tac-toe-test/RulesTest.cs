using Xunit;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTest
{
    public class RulesTest
    {
        [Fact]
        public void GameIsNotOverWhenThereIsNoWinner()
        {
            List<char> notFullBoardState = new List<char> {
                '_', 'O', 'X',
                'O', '_', 'O',
                'X', 'O', '_',
                };

            Board board = new Board(notFullBoardState);

            Assert.False(Rules.GameOver(board));
        }

        [Fact]
        public void GameIsOverWhenBoardIsFull()
        {
            List<char> fullBoardState = new List<char> {
                'X', 'O', 'X',
                'O', 'X', 'O',
                'X', 'O', 'X',
                };

            Board board = new Board(fullBoardState);

            Assert.True(Rules.GameOver(board));
        }

        [Fact]
        public void GameIsOverWhenThereIsAHorizontalMatchingLine()
        {
            List<char> fullBoardState = new List<char> {
                'X', 'X', 'X',
                'O', '_', '_',
                '_', '_', 'O',
                };

            Board board = new Board(fullBoardState);

            Assert.True(Rules.GameOver(board));
        }

        [Fact]
        public void GameIsOverWhenThereIsAVerticalMatchingLine()
        {
            List<char> fullBoardState = new List<char> {
                'O', 'X', 'X',
                'O', '_', '_',
                'O', '_', 'O',
                };

            Board board = new Board(fullBoardState);

            Assert.True(Rules.GameOver(board));
        }

        [Fact]
        public void GameIsOverWhenThereIsADiagonalMatchingLine()
        {
            List<char> fullBoardState = new List<char> {
                'O', 'X', 'X',
                'O', 'O', '_',
                'X', '_', 'O',
                };

            Board board = new Board(fullBoardState);

            Assert.True(Rules.GameOver(board));
        }
    }
}