using System;
using Xunit;
using tic_tac_toe;

namespace tic_tac_toe_test
{
    public class TicTacToeTest
    {
        [Fact]
        public void Returns_twelve()
        {
            Assert.Equal(12, new TicTacToe().justForTest());

        }
    }
}
