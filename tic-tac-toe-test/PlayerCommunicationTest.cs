using Xunit;
using tic_tac_toe;
using System.Collections.Generic;

namespace tic_tac_toe_test
{
    public class PlayerCommunicationTest
    {
        [Fact]
        public void PrintsGreeting()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            playerCommunication.greet();

            Assert.Single(userInterfaceMock.messagesToPrint);
            Assert.Contains("Welcome to Tic Tac Toe!", userInterfaceMock.messagesToPrint);
        }

        [Fact]
        public void AsksPlayerToSelectAFieldAndReturnsSelectedField()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "1" });
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            string selectedField = playerCommunication.promptToPickField();

            Assert.Single(userInterfaceMock.messagesToPrint);
            Assert.Contains("Please pick a field to make your mark", userInterfaceMock.messagesToPrint);
            Assert.Equal("1", selectedField);
        }

        [Fact]
        public void ConfirmsSelectedField()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock();
            PlayerCommunication playerCommunication = new PlayerCommunication(userInterfaceMock);

            playerCommunication.confirmSelectedField("3");

            Assert.Single(userInterfaceMock.messagesToPrint);
            Assert.Contains("You picked 3", userInterfaceMock.messagesToPrint);
        }
    }
}
