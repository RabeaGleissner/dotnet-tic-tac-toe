using System.Collections.Generic;
using tic_tac_toe;

namespace tic_tac_toe_test
{
    public class UserInterfaceMock : IUserInterface
    {
        private readonly List<string> givenInput;
        private readonly List<string> userInput;
        public int printCount;
        public List<string> messagesToPrint = new List<string>();

        public UserInterfaceMock()
        {
            this.userInput = new List<string>();
            this.printCount = 0;
        }

        public UserInterfaceMock(List<string> givenInput)
        {
            this.givenInput = givenInput;
            this.userInput = new List<string>();
            this.printCount = 0;
        }

        public string getInput()
        {
            string inputToReturn = this.givenInput[0];
            this.givenInput.RemoveAt(0);
            return inputToReturn;
        }

        public void print(string input)
        {
            this.printCount++;
            this.messagesToPrint.Add(input);
        }
    }
}