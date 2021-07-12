using System.Collections.Generic;
using TicTacToe;
using Xunit;

namespace TicTacToeTest
{
    public class ComputerPlayerTest
    {
        [Fact]
        public void SelectsAMove()
        {
            ComputerPlayer computerPlayer = new ComputerPlayer(new MoveSelectorMock(new List<int> { 4 }), Mark.O);

            Assert.Equal(4, computerPlayer.SelectMove());
        }

        [Fact]
        public void ReturnsItsMark()
        {

            ComputerPlayer computerPlayer = new ComputerPlayer(new MoveSelectorMock(new List<int> { }), Mark.O);

            Assert.Equal(Mark.O, computerPlayer.GetMark());

        }

    }

}