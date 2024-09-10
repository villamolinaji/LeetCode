namespace TopLiked100
{
	public class Solution007
	{
		public bool Exist(char[][] board, string word)
		{
			var rows = board.Length;
			var cols = board[0].Length;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (Backtrack(board, word, i, j, 0, rows, cols))
					{
						return true;
					}
				}
			}

			return false;
		}

		private bool Backtrack(char[][] board, string word, int row, int col, int index, int rows, int cols)
		{
			if (index == word.Length)
			{
				return true;
			}

			if (row < 0 ||
				row >= rows ||
				col < 0 ||
				col >= cols ||
				board[row][col] != word[index])
			{
				return false;
			}

			char temp = board[row][col];
			board[row][col] = '#';

			bool found = Backtrack(board, word, row + 1, col, index + 1, rows, cols) ||
							Backtrack(board, word, row - 1, col, index + 1, rows, cols) ||
							Backtrack(board, word, row, col + 1, index + 1, rows, cols) ||
							Backtrack(board, word, row, col - 1, index + 1, rows, cols);

			board[row][col] = temp;

			return found;
		}
	}
}
