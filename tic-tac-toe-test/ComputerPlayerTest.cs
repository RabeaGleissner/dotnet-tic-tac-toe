using TicTacToe;
using Xunit;

namespace TicTacToeTest
{
    public class ComputerPlayerTest
    {
        [Fact]
        public void SelectsAMove()
        {
            ComputerPlayer computerPlayer = new ComputerPlayer(new MoveSelectorMock(4));

            Assert.Equal(4, computerPlayer.SelectMove());
        }

    }

}