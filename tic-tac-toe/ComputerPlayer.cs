using System.Collections.Generic;

namespace TicTacToe
{
    public class ComputerPlayer : IPlayer
    {
        private IMoveSelector MoveSelector;
        private Mark Mark;

        public ComputerPlayer(IMoveSelector moveSelector, Mark mark)
        {
            this.Mark = mark;
            this.MoveSelector = moveSelector;
        }

        public Mark GetMark() => Mark;

        public int SelectMove(List<int> emptyFields) => MoveSelector.GetMove(emptyFields);
    }
}