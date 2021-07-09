using System;

namespace tic_tac_toe
{
    public class TicTacToe
    {
        PlayerCommunication playerCommunication;
        Board board;

        public TicTacToe(PlayerCommunication playerCommunication, Board board)
        {
            this.playerCommunication = playerCommunication;
            this.board = board;
        }

        public void play()
        {
            playerCommunication.Greet();
            PlayOneRound();
            playerCommunication.DisplayBoard(this.board.GetCurrentState());
            playerCommunication.AnnounceGameOver();
        }

        private void PlayOneRound()
        {
            playerCommunication.DisplayBoard(this.board.GetCurrentState());
            string selectedField = playerCommunication.PromptToPickField();
            this.board.AddMark(Mark.X, Int16.Parse(selectedField));
            if (Rules.GameOver(this.board))
            {
                return;
            }
            else
            {
                PlayOneRound();
            }
        }
    }
}