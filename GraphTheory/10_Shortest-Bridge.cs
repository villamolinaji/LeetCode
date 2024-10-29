namespace GraphTheory
{
	public class Solution10
	{
		public int ShortestBridge(int[][] grid)
		{
			int gridLength = grid.Length;
			Queue<(int, int)> queue = new Queue<(int, int)>();
			bool found = false;

			for (int i = 0; i < gridLength; i++)
			{
				if (found)
				{
					break;
				}

				for (int j = 0; j < gridLength; j++)
				{
					if (grid[i][j] == 1)
					{
						DFS(grid, i, j, queue);

						found = true;

						break;
					}
				}
			}

			int steps = 0;
			int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };

			while (queue.Count > 0)
			{
				int size = queue.Count;

				for (int i = 0; i < size; i++)
				{
					var (x, y) = queue.Dequeue();

					foreach (var dir in directions)
					{
						int nx = x + dir[0];
						int ny = y + dir[1];

						if (nx >= 0 &&
							nx < gridLength &&
							ny >= 0 &&
							ny < gridLength)
						{
							if (grid[nx][ny] == 1)
							{
								return steps;
							}

							if (grid[nx][ny] == 0)
							{
								grid[nx][ny] = 2;
								queue.Enqueue((nx, ny));
							}
						}
					}
				}
				steps++;
			}

			return -1;
		}

		private void DFS(int[][] grid, int x, int y, Queue<(int, int)> queue)
		{
			int gridLength = grid.Length;

			if (x < 0 ||
				x >= gridLength ||
				y < 0 ||
				y >= gridLength ||
				grid[x][y] != 1)
			{
				return;
			}

			grid[x][y] = 2;
			queue.Enqueue((x, y));

			DFS(grid, x + 1, y, queue);
			DFS(grid, x - 1, y, queue);
			DFS(grid, x, y + 1, queue);
			DFS(grid, x, y - 1, queue);
		}
	}
}
