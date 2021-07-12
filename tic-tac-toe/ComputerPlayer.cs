using System.Collections.Generic;

namespace TicTacToe
{
    public class ComputerPlayer : IPlayer
    {
        private IMoveSelector moveSelector;
        private Mark mark;

        public ComputerPlayer(IMoveSelector moveSelector, Mark mark)
        {
            this.mark = mark;
            this.moveSelector = moveSelector;
        }

        public Mark GetMark() => mark;

        public int SelectMove(List<int> emptyFields) => moveSelector.GetMove(emptyFields);
    }
}