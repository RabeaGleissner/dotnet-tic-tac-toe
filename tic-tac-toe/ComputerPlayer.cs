namespace TicTacToe
{
    public class ComputerPlayer : IPlayer
    {
        private IMoveSelector moveSelector;

        public ComputerPlayer(IMoveSelector moveSelector)
        {
            this.moveSelector = moveSelector;
        }

        public int SelectMove() => moveSelector.GetMove();
    }
}