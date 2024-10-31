namespace GraphTheory
{
	public class Solution17
	{
		public int ShortestPathAllKeys(string[] grid)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;
			int allKeys = 0;
			int startX = 0;
			int startY = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					char cell = grid[i][j];
					if (cell == '@')
					{
						startX = i;
						startY = j;
					}
					else if (cell >= 'a' && cell <= 'f')
					{
						allKeys |= (1 << (cell - 'a'));
					}
				}
			}

			var queue = new Queue<(int, int, int, int)>();
			var visited = new HashSet<(int, int, int)>();

			queue.Enqueue((startX, startY, 0, 0));
			visited.Add((startX, startY, 0));

			int[][] directions = new int[][] {
				new int[] { 0, 1 },
				new int[] { 1, 0 },
				new int[] { 0, -1 },
				new int[] { -1, 0 }
			};

			while (queue.Count > 0)
			{
				var (x, y, keys, steps) = queue.Dequeue();

				if (keys == allKeys)
				{
					return steps;
				}

				foreach (var dir in directions)
				{
					int newX = x + dir[0];
					int newY = y + dir[1];

					if (newX < 0 ||
						newY < 0 ||
						newX >= rows ||
						newY >= cols)
					{
						continue;
					}

					char cell = grid[newX][newY];
					int newKeys = keys;

					if (cell == '#')
					{
						continue;
					}

					if (cell >= 'a' &&
						cell <= 'f')
					{
						newKeys |= (1 << (cell - 'a'));
					}

					if (cell >= 'A' &&
						cell <= 'F' &&
						(newKeys & (1 << (cell - 'A'))) == 0)
					{
						continue;
					}

					if (!visited.Contains((newX, newY, newKeys)))
					{
						visited.Add((newX, newY, newKeys));
						queue.Enqueue((newX, newY, newKeys, steps + 1));
					}
				}
			}

			return -1;
		}
	}
}
