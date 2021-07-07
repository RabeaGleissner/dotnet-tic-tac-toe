namespace tic_tac_toe
{
    public class TicTacToe
    {
        PlayerCommunication playerCommunication;

        public TicTacToe(PlayerCommunication playerCommunication)
        {
            this.playerCommunication = playerCommunication;
        }

        public void play()
        {
            playerCommunication.greet();
            string selectedField = playerCommunication.promptToPickField();
            playerCommunication.confirmSelectedField(selectedField);
        }
    }
}