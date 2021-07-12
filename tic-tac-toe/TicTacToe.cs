namespace TicTacToe
{
    public class TicTacToe
    {
        private PlayerCommunication playerCommunication;
        private Board board;
        private IPlayer player1;
        private IPlayer player2;
        private IPlayer currentPlayer;

        public TicTacToe(PlayerCommunication playerCommunication, Board board, IPlayer player1, IPlayer player2)
        {
            this.playerCommunication = playerCommunication;
            this.board = board;
            this.player1 = player1;
            this.player2 = player2;
            this.currentPlayer = null;
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
            int selectedField = currentPlayer.SelectMove();
            board.AddMark(Mark.X, selectedField);
            if (Rules.GameOver(board))
            {
                return;
            }
            else
            {
                // SwitchPlayers();
                PlayOneRound();
            }
        }
    }
}