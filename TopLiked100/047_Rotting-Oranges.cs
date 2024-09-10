namespace TopLiked100
{
	public class Solution047
	{
		public int OrangesRotting(int[][] grid)
		{
			int rows = grid.Length;
			int cols = grid[0].Length;

			int minutes = 0;

			int[][] directions = [
				[0, 1],
			[1, 0],
			[0, -1],
			[-1, 0]];

			var queue = new Queue<(int, int)>();
			int freshCount = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (grid[i][j] == 2)
					{
						queue.Enqueue((i, j));
					}
					else if (grid[i][j] == 1)
					{
						freshCount++;
					}
				}
			}

			if (freshCount == 0)
			{
				return 0;
			}

			while (queue.Count > 0)
			{
				int levelSize = queue.Count;
				bool hasRotted = false;

				for (int i = 0; i < levelSize; i++)
				{
					var (x, y) = queue.Dequeue();

					foreach (var dir in directions)
					{
						int newX = x + dir[0];
						int newY = y + dir[1];

						if (newX >= 0 &&
							newX < rows &&
							newY >= 0 &&
							newY < cols &&
							grid[newX][newY] == 1)
						{
							grid[newX][newY] = 2;
							queue.Enqueue((newX, newY));
							freshCount--;
							hasRotted = true;
						}
					}
				}

				if (hasRotted)
				{
					minutes++;
				}
			}

			return freshCount == 0 ? minutes : -1;
		}
	}
}
