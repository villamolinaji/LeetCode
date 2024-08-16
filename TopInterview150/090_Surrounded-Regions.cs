namespace TopInterview150
{
	public class Solution090
	{
		public void Solve(char[][] board)
		{
			if (board == null ||
				board.Length == 0)
			{
				return;
			}

			var rows = board.Length;
			var cols = board[0].Length;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if ((i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
						&& board[i][j] == 'O')
					{
						DFS(board, i, j, rows, cols);
					}
				}
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (board[i][j] == 'O')
					{
						board[i][j] = 'X';
					}
					else if (board[i][j] == '#')
					{
						board[i][j] = 'O';
					}
				}
			}
		}

		private void DFS(char[][] board, int i, int j, int rows, int cols)
		{

			if (i < 0 ||
				i >= rows ||
				j < 0 ||
				j >= cols ||
				board[i][j] != 'O')
			{
				return;
			}

			board[i][j] = '#';

			DFS(board, i + 1, j, rows, cols);
			DFS(board, i - 1, j, rows, cols);
			DFS(board, i, j + 1, rows, cols);
			DFS(board, i, j - 1, rows, cols);
		}
	}
}
