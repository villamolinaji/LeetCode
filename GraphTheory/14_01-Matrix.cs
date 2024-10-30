namespace GraphTheory
{
	public class Solution14
	{
		public int[][] UpdateMatrix(int[][] mat)
		{
			int rows = mat.Length;
			int cols = mat[0].Length;

			int[][] dist = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				dist[i] = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					dist[i][j] = mat[i][j] == 0
						? 0
						: int.MaxValue;
				}
			}

			var queue = new Queue<(int, int)>();

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (mat[i][j] == 0)
					{
						queue.Enqueue((i, j));
					}
				}
			}

			int[][] directions = new int[][] {
				new int[] { 1, 0 },
				new int[] { -1, 0 },
				new int[] { 0, 1 },
				new int[] { 0, -1 }
			};

			while (queue.Count > 0)
			{
				var (row, col) = queue.Dequeue();

				foreach (var dir in directions)
				{
					int newRow = row + dir[0];
					int newCol = col + dir[1];

					if (newRow >= 0 &&
						newRow < rows &&
						newCol >= 0 &&
						newCol < cols &&
						dist[newRow][newCol] > dist[row][col] + 1)
					{

						dist[newRow][newCol] = dist[row][col] + 1;

						queue.Enqueue((newRow, newCol));
					}
				}
			}

			return dist;
		}
	}
}
