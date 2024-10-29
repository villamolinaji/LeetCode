namespace GraphTheory
{
	public class Solution09
	{
		public int NearestExit(char[][] maze, int[] entrance)
		{
			int rows = maze.Length;
			int cols = maze[0].Length;
			int startX = entrance[0];
			int startY = entrance[1];

			int[][] directions = [
				[0, 1],
			[1, 0],
			[0, -1],
			[-1, 0]];

			var queue = new Queue<(int, int, int)>();
			queue.Enqueue((startX, startY, 0));

			var visited = new HashSet<(int, int)>();
			visited.Add((startX, startY));

			while (queue.Count > 0)
			{
				var (x, y, steps) = queue.Dequeue();

				foreach (var dir in directions)
				{
					int newX = x + dir[0];
					int newY = y + dir[1];

					if (newX >= 0 &&
						newX < rows &&
						newY >= 0
						&& newY < cols
						&& maze[newX][newY] == '.')
					{
						if ((newX == 0 || newX == rows - 1 || newY == 0 || newY == cols - 1) &&
							(newX != startX || newY != startY))
						{
							return steps + 1;
						}

						if (!visited.Contains((newX, newY)))
						{
							visited.Add((newX, newY));
							queue.Enqueue((newX, newY, steps + 1));
						}
					}
				}
			}

			return -1;
		}
	}
}
