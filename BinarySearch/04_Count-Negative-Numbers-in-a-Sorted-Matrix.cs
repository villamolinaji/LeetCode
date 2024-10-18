namespace BinarySearch
{
	public class Solution04
	{
		public int CountNegatives(int[][] grid)
		{
			int countNegatives = 0;

			var rows = grid.Length;
			var cols = grid[0].Length;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (grid[i][j] < 0)
					{
						countNegatives += cols - j;
						break;
					}
				}
			}

			return countNegatives;
		}
	}
}
