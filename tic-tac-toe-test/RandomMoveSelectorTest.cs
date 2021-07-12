using System.Collections.Generic;
using TicTacToe;
using Xunit;

namespace TicTacToeTest
{
    public class RandomMoveSelectorTest
    {
        [Fact]
        public void ReturnsTheOnlyPossibleMove()
        {
            RandomMoveSelector randomMoveSelector = new RandomMoveSelector();

            List<char> gameState = new List<char> {
                'X', '_', 'X',
                'O', 'X', 'O',
                'O', 'O', 'X',
                };

            Assert.Equal(1, randomMoveSelector.GetMove(new Board(gameState).GetEmptyFields()));
        }

        [Fact]
        public void ReturnsAMoveBetween0and8WhenBoardIsEmpty()
        {
            RandomMoveSelector randomMoveSelector = new RandomMoveSelector();

            Assert.InRange(randomMoveSelector.GetMove(new Board().GetEmptyFields()), 0, 8);
        }
    }
}