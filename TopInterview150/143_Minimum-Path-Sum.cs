namespace TopInterview150
{
	public class Solution143
	{
		public int MinPathSum(int[][] grid)
		{
			var rows = grid.Length;
			var cols = grid[0].Length;
			var dp = new int[rows][];

			for (int i = 0; i < rows; i++)
			{
				dp[i] = new int[grid[i].Length];
			}

			dp[0][0] = grid[0][0];

			for (int i = 1; i < rows; i++)
			{
				dp[i][0] = dp[i - 1][0] + grid[i][0];
			}

			for (int i = 1; i < cols; i++)
			{
				dp[0][i] = dp[0][i - 1] + grid[0][i];
			}

			for (int i = 1; i < rows; i++)
			{
				for (int j = 1; j < cols; j++)
				{
					dp[i][j] = grid[i][j] + Math.Min(dp[i - 1][j], dp[i][j - 1]);
				}
			}

			return dp[rows - 1][cols - 1];
		}
	}
}
