using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class HumanPlayer : IPlayer
    {
        private PlayerCommunication PlayerCommunication;
        private Mark Mark;

        public HumanPlayer(PlayerCommunication playerCommunication, Mark mark)
        {
            this.PlayerCommunication = playerCommunication;
            this.Mark = mark;
        }

        public Mark GetMark() => Mark;

        public int SelectMove(List<int> emptyFields)
        {
            string selectedField = PlayerCommunication.PromptToPickField();

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
            PlayerCommunication.DisplayError();
            return SelectMove(emptyFields);
        }
    }
}