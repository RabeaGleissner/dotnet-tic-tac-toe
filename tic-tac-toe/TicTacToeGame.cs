namespace TicTacToe
{
    public class TicTacToeGame
    {
        private PlayerCommunication PlayerCommunication;
        private Board Board;
        private IPlayer Player1;
        private IPlayer Player2;
        private IPlayer CurrentPlayer;

        public TicTacToeGame(PlayerCommunication playerCommunication, Board board, IPlayer player1, IPlayer player2)
        {
            this.PlayerCommunication = playerCommunication;
            this.Board = board;
            this.Player1 = player1;
            this.Player2 = player2;
            this.CurrentPlayer = player1;
        }

        public void play()
        {
            PlayerCommunication.Greet();
            PlayOneMove();
            PlayerCommunication.DisplayBoard(Board.GetCurrentState());
            PlayerCommunication.AnnounceGameOver();
        }

        private void PlayOneMove()
        {
            PlayerCommunication.DisplayBoard(Board.GetCurrentState());
            int selectedField = CurrentPlayer.SelectMove(Board.GetEmptyFields());
            PlayerCommunication.AnnounceSelectedField(selectedField, CurrentPlayer.GetMark());
            Board.AddMark(CurrentPlayer.GetMark(), selectedField);
            if (Rules.GameOver(Board))
            {
                return;
            }
            else
            {
                SwitchPlayers();
                PlayOneMove();
            }
        }

        private void SwitchPlayers()
        {
            if (CurrentPlayer == Player1)
            {
                CurrentPlayer = Player2;
            }
            else
            {
                CurrentPlayer = Player1;
            };
        }

    }
}