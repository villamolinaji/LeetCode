namespace GraphTheory
{
	public class Solution
	{
		public IList<IList<int>> PacificAtlantic(int[][] heights)
		{
			int rows = heights.Length;
			int cols = heights[0].Length;
			var pacificReachable = new bool[rows, cols];
			var atlanticReachable = new bool[rows, cols];
			var result = new List<IList<int>>();

			for (int i = 0; i < rows; i++)
			{
				DFS(heights, pacificReachable, i, 0);
				DFS(heights, atlanticReachable, i, cols - 1);
			}

			for (int j = 0; j < cols; j++)
			{
				DFS(heights, pacificReachable, 0, j);
				DFS(heights, atlanticReachable, rows - 1, j);
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (pacificReachable[i, j] &&
						atlanticReachable[i, j])
					{
						result.Add(new List<int> { i, j });
					}
				}
			}

			return result;
		}

		private void DFS(int[][] heights, bool[,] reachable, int x, int y)
		{
			int rows = heights.Length;
			int cols = heights[0].Length;

			reachable[x, y] = true;

			int[][] directions = new int[][] {
				new int[] { 0, 1 },
				new int[] { 1, 0 },
				new int[] { 0, -1 },
				new int[] { -1, 0 }
			};

			foreach (var dir in directions)
			{
				int newX = x + dir[0];
				int newY = y + dir[1];

				if (newX >= 0 &&
					newY >= 0 &&
					newX < rows &&
					newY < cols &&
					!reachable[newX, newY] &&
					heights[newX][newY] >= heights[x][y])
				{
					DFS(heights, reachable, newX, newY);
				}
			}
		}
	}
}
