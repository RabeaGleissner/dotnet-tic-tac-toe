using Xunit;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTest
{
    public class HumanPlayerTest
    {
        [Fact]
        public void SelectsAMove()
        {
            PlayerCommunication playerCommunication = new PlayerCommunication(new UserInterfaceMock(new List<string> { "5" }));
            HumanPlayer humanPlayer = new HumanPlayer(playerCommunication, Mark.X);

            Assert.Equal(5, humanPlayer.SelectMove());
        }
    }
}