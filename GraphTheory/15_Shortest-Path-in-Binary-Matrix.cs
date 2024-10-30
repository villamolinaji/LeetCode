namespace GraphTheory
{
	public class Solution15
	{
		public int ShortestPathBinaryMatrix(int[][] grid)
		{
			int gridLength = grid.Length;

			if (grid[0][0] == 1 ||
				grid[gridLength - 1][gridLength - 1] == 1)
			{
				return -1;
			}

			int[][] directions = new int[][]
			{
				new int[] {1, 0},
				new int[] {0, 1},
				new int[] {-1, 0},
				new int[] {0, -1},
				new int[] {1, 1},
				new int[] {1, -1},
				new int[] {-1, 1},
				new int[] {-1, -1}
			};

			var queue = new Queue<(int, int, int)>();
			queue.Enqueue((0, 0, 1));

			grid[0][0] = 1;

			while (queue.Count > 0)
			{
				var (row, col, dist) = queue.Dequeue();

				if (row == gridLength - 1 &&
					col == gridLength - 1)
				{
					return dist;
				}

				foreach (var dir in directions)
				{
					int newRow = row + dir[0];
					int newCol = col + dir[1];

					if (newRow >= 0 &&
						newRow < gridLength &&
						newCol >= 0 &&
						newCol < gridLength &&
						grid[newRow][newCol] == 0)
					{
						queue.Enqueue((newRow, newCol, dist + 1));

						grid[newRow][newCol] = 1;
					}
				}
			}

			return -1;
		}
	}
}
