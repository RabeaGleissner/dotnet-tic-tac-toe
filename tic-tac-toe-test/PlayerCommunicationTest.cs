using Xunit;
using TicTacToe;
using System.Collections.Generic;

namespace TicTacToeTest
{
    public class PlayerCommunicationTest
    {
        [Fact]
        public void PrintsGreeting()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            playerCommunication.Greet();

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("Welcome to Tic Tac Toe!", userInterfaceMock.MessagesToPrint);
        }

        [Fact]
        public void PrintsBoardState()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            List<char> boardState = new List<char> {
                'X', 'O', 'X',
                'O', '_', 'O',
                'X', 'O', '_',
                };
            playerCommunication.DisplayBoard(new Board(boardState).GetCurrentState());

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("X O X\nO _ O\nX O _", userInterfaceMock.MessagesToPrint);
        }

        [Fact]
        public void AsksPlayerToSelectAFieldAndReturnsSelectedField()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "1" });
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            string selectedField = playerCommunication.PromptToPickField();

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("Please pick a field to make your mark", userInterfaceMock.MessagesToPrint);
            Assert.Equal("1", selectedField);
        }

        [Fact]
        public void AnnouncesGameOver()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            playerCommunication.AnnounceGameOver();

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("Game Over!", userInterfaceMock.MessagesToPrint);
        }

        [Fact]
        public void AnnouncesSelectedField()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            playerCommunication.AnnounceSelectedField(100, Mark.O);

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("Selected field by player O: 100", userInterfaceMock.MessagesToPrint);
        }
    }
}
