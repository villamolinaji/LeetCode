namespace TopInterview150
{
	public class Solution038
	{
		public void GameOfLife(int[][] board)
		{
			int rows = board.Length;
			int cols = board[0].Length;

			int[][] copyBoard = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				copyBoard[i] = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					copyBoard[i][j] = board[i][j];
				}
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					var cell = board[i][j];

					if (cell == 0)
					{
						int liveNeighbors = CountLiveNeighbors(copyBoard, i, j);
						if (liveNeighbors == 3)
						{
							board[i][j] = 1;
						}
					}
					else if (cell == 1)
					{
						int liveNeighbors = CountLiveNeighbors(copyBoard, i, j);
						if (liveNeighbors < 2 || liveNeighbors > 3)
						{
							board[i][j] = 0;
						}
					}
				}
			}
		}

		private int CountLiveNeighbors(int[][] board, int row, int col)
		{
			var countLiveNeighbors = 0;
			int rows = board.Length;
			int cols = board[0].Length;

			if (row - 1 >= 0)
			{
				if (col - 1 >= 0 &&
					board[row - 1][col - 1] == 1)
				{
					countLiveNeighbors++;
				}

				if (board[row - 1][col] == 1)
				{
					countLiveNeighbors++;
				}

				if (col + 1 < cols &&
					board[row - 1][col + 1] == 1)
				{
					countLiveNeighbors++;
				}
			}

			if (col - 1 >= 0 &&
				board[row][col - 1] == 1)
			{
				countLiveNeighbors++;
			}

			if (col + 1 < cols &&
				board[row][col + 1] == 1)
			{
				countLiveNeighbors++;
			}

			if (row + 1 < rows)
			{
				if (col - 1 >= 0 &&
					board[row + 1][col - 1] == 1)
				{
					countLiveNeighbors++;
				}

				if (board[row + 1][col] == 1)
				{
					countLiveNeighbors++;
				}

				if (col + 1 < cols &&
					board[row + 1][col + 1] == 1)
				{
					countLiveNeighbors++;
				}
			}

			return countLiveNeighbors;
		}
	}
}
