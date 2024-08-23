namespace TopInterview150
{
	public class Solution150
	{
		public int MaximalSquare(char[][] matrix)
		{
			var rows = matrix.Length;
			var cols = matrix[0].Length;
			var dp = new int[rows + 1, cols + 1];
			var maxSideLength = 0;

			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= cols; j++)
				{
					if (matrix[i - 1][j - 1] == '1')
					{
						dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
						maxSideLength = Math.Max(maxSideLength, dp[i, j]);
					}
				}
			}

			return maxSideLength * maxSideLength;
		}
	}
}
