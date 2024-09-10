namespace TopLiked100
{
	public class Solution040
	{
		public int NumSquares(int n)
		{
			var dp = new int[n + 1];

			for (int i = 0; i <= n; i++)
			{
				dp[i] = int.MaxValue;
			}

			dp[0] = 0;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j * j <= i; j++)
				{
					dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
				}
			}

			return dp[n];
		}
	}
}
