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
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);
            TicTacToeGame ticTacToeGame = new TicTacToeGame(playerCommunication, new Board(), new HumanPlayer(playerCommunication, Mark.X), new ComputerPlayer(new MoveSelectorMock(new List<int> { 8, 7 }), Mark.O));

            ticTacToeGame.play();

            Assert.Contains("Welcome to Tic Tac Toe!", userInterfaceMock.MessagesToPrint);
            Assert.Contains("Game Over!", userInterfaceMock.MessagesToPrint);
        }
    }
}
