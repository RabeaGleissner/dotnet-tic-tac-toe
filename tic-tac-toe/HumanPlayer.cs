using System;

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

        public int SelectMove()
        {
            string selectedField = playerCommunication.PromptToPickField();
            return Int16.Parse(selectedField);
        }
    }
}