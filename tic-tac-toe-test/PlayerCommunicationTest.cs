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
        public void PrintsEmptyBoardWithSlotsAsNumbers()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            List<char> boardState = new List<char> {
                '_', '_', '_',
                '_', '_', '_',
                '_', '_', '_',
                };
            playerCommunication.DisplayBoard(new Board(boardState).GetCurrentState());

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("\n-----\n0 1 2\n3 4 5\n6 7 8 \n-----\n", userInterfaceMock.MessagesToPrint);
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
            Assert.Contains("\n-----\nX O X\nO 4 O\nX O 8 \n-----\n", userInterfaceMock.MessagesToPrint);
        }

        [Fact]
        public void AsksPlayerToSelectAFieldAndReturnsSelectedField()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "1" });
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            string selectedField = playerCommunication.PromptToPickField();

            Assert.Single(userInterfaceMock.MessagesToPrint);
            Assert.Contains("Please pick an empty field to place your mark:\n", userInterfaceMock.MessagesToPrint);
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
