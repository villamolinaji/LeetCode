namespace ProgrammingSkills
{
	public class Solution21
	{
		public void SetZeroes(int[][] matrix)
		{
			int rows = matrix.Length;
			int cols = matrix[0].Length;
			var changed = new HashSet<(int, int)>();

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (matrix[i][j] == 0 &&
						!changed.Contains((i, j)))
					{
						for (int r = 0; r < rows; r++)
						{
							if (matrix[r][j] != 0)
							{
								matrix[r][j] = 0;
								changed.Add((r, j));
							}
						}

						for (int c = 0; c < cols; c++)
						{
							if (matrix[i][c] != 0)
							{
								matrix[i][c] = 0;
								changed.Add((i, c));
							}
						}
					}
				}
			}
		}
	}
}
