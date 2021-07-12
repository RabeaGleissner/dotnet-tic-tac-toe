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

            Assert.Equal(5, humanPlayer.SelectMove(new Board().GetEmptyFields()));
        }

        [Fact]
        public void AsksForMoveAgainWhenUserInputIsInvalid()
        {
            string invalidMove = "1";
            string validMove = "5";
            PlayerCommunication playerCommunication = new PlayerCommunication(new UserInterfaceMock(new List<string> { invalidMove, validMove }));
            HumanPlayer humanPlayer = new HumanPlayer(playerCommunication, Mark.X);

            Assert.Equal(5, humanPlayer.SelectMove(new List<int> { 2, 3, 5 }));
        }

        [Fact]
        public void ReturnsItsMark()
        {
            PlayerCommunication playerCommunication = new PlayerCommunication(new UserInterfaceMock());
            HumanPlayer humanPlayer = new HumanPlayer(playerCommunication, Mark.X);

            Assert.Equal(Mark.X, humanPlayer.GetMark());
        }
    }
}