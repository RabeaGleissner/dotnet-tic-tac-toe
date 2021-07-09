using Xunit;
using tic_tac_toe;
using System.Collections.Generic;

namespace tic_tac_toe_test
{
    public class TicTacToeTest
    {
        [Fact]
        public void PlaysUntilThereIsAWinner()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "0", "1", "2" });
            TicTacToe ticTacToe = new TicTacToe(new PlayerCommunication(userInterfaceMock), new Board());

            ticTacToe.play();

            Assert.Contains("Welcome to Tic Tac Toe!", userInterfaceMock.MessagesToPrint);
            Assert.Contains("Game Over!", userInterfaceMock.MessagesToPrint);
        }
    }
}
