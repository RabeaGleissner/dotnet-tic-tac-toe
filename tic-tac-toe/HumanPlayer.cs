using System;
using System.Collections.Generic;
using System.Linq;

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

            if (EmptyFieldsAsStrings(emptyFields).Contains(selectedField))
            {
                return Int16.Parse(selectedField);
            }
            else
            {
                return ShowErrorAndSelectAgain(emptyFields);
            }
        }

        private static List<string> EmptyFieldsAsStrings(List<int> emptyFields) => emptyFields.Select(field => field.ToString()).ToList();

        private int ShowErrorAndSelectAgain(List<int> emptyFields)
        {
            playerCommunication.DisplayError();
            return SelectMove(emptyFields);
        }
    }
}