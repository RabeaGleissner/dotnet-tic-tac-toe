using Xunit;
using tic_tac_toe;
using System.Collections.Generic;

namespace tic_tac_toe_test
{
    public class TicTacToeTest
    {
        [Fact]
        public void CommunicatesWithUser()
        {
            UserInterfaceMock userInterfaceMock = new UserInterfaceMock(new List<string> { "1" });
            TicTacToe ticTacToe = new TicTacToe(new PlayerCommunication(userInterfaceMock));

            ticTacToe.play();

            Assert.Equal(3, userInterfaceMock.PrintCount);
        }
    }
}
