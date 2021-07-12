namespace TicTacToe
{
    public class TicTacToeGame
    {
        private PlayerCommunication playerCommunication;
        private Board board;
        private IPlayer player1;
        private IPlayer player2;
        private IPlayer currentPlayer;

        public TicTacToeGame(PlayerCommunication playerCommunication, Board board, IPlayer player1, IPlayer player2)
        {
            this.playerCommunication = playerCommunication;
            this.board = board;
            this.player1 = player1;
            this.player2 = player2;
            this.currentPlayer = player1;
        }

        public void play()
        {
            playerCommunication.Greet();
            PlayOneRound();
            playerCommunication.DisplayBoard(board.GetCurrentState());
            playerCommunication.AnnounceGameOver();
        }

        private void PlayOneRound()
        {
            playerCommunication.DisplayBoard(board.GetCurrentState());
            int selectedField = currentPlayer.SelectMove(board.GetEmptyFields());
            playerCommunication.AnnounceSelectedField(selectedField, currentPlayer.GetMark());
            board.AddMark(currentPlayer.GetMark(), selectedField);
            if (Rules.GameOver(board))
            {
                return;
            }
            else
            {
                SwitchPlayers();
                PlayOneRound();
            }
        }

        private void SwitchPlayers()
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            };
        }

    }
}