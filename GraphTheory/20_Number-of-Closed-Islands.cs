namespace GraphTheory
{
	public class Solution20
	{
		public int ClosedIsland(int[][] grid)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;

			for (int i = 0; i < rows; i++)
			{
				if (grid[i][0] == 0)
				{
					DFS(grid, i, 0);
				}

				if (grid[i][cols - 1] == 0)
				{
					DFS(grid, i, cols - 1);
				}
			}
			for (int j = 0; j < cols; j++)
			{
				if (grid[0][j] == 0)
				{
					DFS(grid, 0, j);
				}

				if (grid[rows - 1][j] == 0)
				{
					DFS(grid, rows - 1, j);
				}
			}

			int closedIslands = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (grid[i][j] == 0)
					{
						DFS(grid, i, j);

						closedIslands++;
					}
				}
			}

			return closedIslands;
		}

		private void DFS(int[][] grid, int x, int y)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;

			if (x < 0 ||
				y < 0 ||
				x >= rows ||
				y >= cols ||
				grid[x][y] == 1)
			{
				return;
			}

			grid[x][y] = 1;

			DFS(grid, x + 1, y);
			DFS(grid, x - 1, y);
			DFS(grid, x, y + 1);
			DFS(grid, x, y - 1);
		}
	}
}
