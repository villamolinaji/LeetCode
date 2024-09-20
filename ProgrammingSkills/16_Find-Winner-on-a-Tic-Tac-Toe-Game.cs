namespace ProgrammingSkills
{
	public class Solution16
	{
		public string Tictactoe(int[][] moves)
		{
			var board = new char[3, 3];

			for (int i = 0; i < moves.Length; i++)
			{
				board[moves[i][0], moves[i][1]] = i % 2 == 0 ? 'X' : 'O';
			}

			if (IsWin(board, 'X'))
			{
				return "A";
			}
			else if (IsWin(board, 'O'))
			{
				return "B";
			}
			else if (moves.Length == 9)
			{
				return "Draw";
			}
			else
			{
				return "Pending";
			}
		}

		private static bool IsWin(char[,] board, char player)
		{
			for (int i = 0; i < 3; i++)
			{
				if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
				{
					return true;
				}

				if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
				{
					return true;
				}
			}

			if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
			{
				return true;
			}

			if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
			{
				return true;
			}

			return false;
		}
	}
}
