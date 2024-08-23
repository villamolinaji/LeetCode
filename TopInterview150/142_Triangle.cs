namespace TopInterview150
{
	public class Solution142
	{
		public int MinimumTotal(IList<IList<int>> triangle)
		{
			var triangleLength = triangle.Count;
			var dp = new int[triangleLength];

			for (int i = 0; i < triangleLength; i++)
			{
				dp[i] = triangle[triangleLength - 1][i];
			}

			for (int i = triangleLength - 2; i >= 0; i--)
			{
				for (int j = 0; j <= i; j++)
				{
					dp[j] = triangle[i][j] + Math.Min(dp[j], dp[j + 1]);
				}
			}

			return dp[0];
		}
	}
}
