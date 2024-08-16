namespace TopInterview150
{
	public class Solution089
	{
		public int NumIslands(char[][] grid)
		{
			if (grid == null ||
				grid.Length == 0)
			{
				return 0;
			}

			var numIslands = 0;
			var rows = grid.Length;
			var cols = grid[0].Length;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (grid[i][j] == '1')
					{
						numIslands++;
						DFS(grid, i, j, rows, cols);
					}
				}
			}

			return numIslands;
		}

		private void DFS(char[][] grid, int i, int j, int rows, int cols)
		{
			if (i < 0 ||
				i >= rows ||
				j < 0 ||
				j >= cols ||
				grid[i][j] == '0')
			{
				return;
			}

			grid[i][j] = '0';

			DFS(grid, i + 1, j, rows, cols);
			DFS(grid, i - 1, j, rows, cols);
			DFS(grid, i, j + 1, rows, cols);
			DFS(grid, i, j - 1, rows, cols);
		}
	}
}
