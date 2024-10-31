namespace GraphTheory
{
	public class Solution21
	{
		public int MaxAreaOfIsland(int[][] grid)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;
			int maxArea = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (grid[i][j] == 1)
					{
						int area = DFS(grid, i, j);
						maxArea = Math.Max(maxArea, area);
					}
				}
			}

			return maxArea;
		}

		private int DFS(int[][] grid, int x, int y)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;

			if (x < 0 ||
				y < 0 ||
				x >= rows ||
				y >= cols ||
				grid[x][y] == 0)
			{
				return 0;
			}

			grid[x][y] = 0;

			int area = 1;

			area += DFS(grid, x + 1, y);
			area += DFS(grid, x - 1, y);
			area += DFS(grid, x, y + 1);
			area += DFS(grid, x, y - 1);

			return area;
		}
	}
}
