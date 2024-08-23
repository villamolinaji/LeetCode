namespace TopLiked100
{
	public class Solution005
	{
		public IList<IList<string>> SolveNQueens(int n)
		{
			var result = new List<IList<string>>();
			var board = new char[n][];

			for (int i = 0; i < n; i++)
			{
				board[i] = new string('.', n).ToCharArray();
			}

			Solve(result, board, 0, n);

			return result;
		}

		private void Solve(List<IList<string>> result, char[][] board, int row, int n)
		{
			if (row == n)
			{
				var solution = new List<string>();
				for (int i = 0; i < n; i++)
				{
					solution.Add(new string(board[i]));
				}
				result.Add(solution);

				return;
			}

			for (int col = 0; col < n; col++)
			{
				if (IsSafe(board, row, col, n))
				{
					board[row][col] = 'Q';

					Solve(result, board, row + 1, n);

					board[row][col] = '.';
				}
			}
		}

		private bool IsSafe(char[][] board, int row, int col, int n)
		{
			for (int i = 0; i < row; i++)
			{
				if (board[i][col] == 'Q')
				{
					return false;
				}
			}

			for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
			{
				if (board[i][j] == 'Q')
				{
					return false;
				}
			}

			for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
			{
				if (board[i][j] == 'Q')
				{
					return false;
				}
			}

			return true;
		}
	}
}
