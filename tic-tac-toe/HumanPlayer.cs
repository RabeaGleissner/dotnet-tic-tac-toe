using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class HumanPlayer : IPlayer
    {
        private PlayerCommunication playerCommunication;
        private Mark mark;

        public HumanPlayer(PlayerCommunication playerCommunication, Mark mark)
        {
            this.playerCommunication = playerCommunication;
            this.mark = mark;
        }

        public Mark GetMark() => mark;

        public int SelectMove(List<int> emptyFields)
        {
            string selectedField = playerCommunication.PromptToPickField();
            return Int16.Parse(selectedField);
        }
    }
}