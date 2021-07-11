using Xunit;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTest
{
    public class TicTacToeTest
    {
        [Fact]
        public void PlaysUntilThereIsAWinner()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "0", "1", "2" });
            TicTacToe.TicTacToe ticTacToe = new TicTacToe.TicTacToe(new PlayerCommunication(userInterfaceMock), new Board());

            ticTacToe.play();

            Assert.Contains("Welcome to Tic Tac Toe!", userInterfaceMock.MessagesToPrint);
            Assert.Contains("Game Over!", userInterfaceMock.MessagesToPrint);
        }
    }
}
