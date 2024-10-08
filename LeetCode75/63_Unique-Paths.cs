﻿namespace LeetCode75
{
	public class Solution63
	{
		public int UniquePaths(int m, int n)
		{
			var dp = new int[m, n];
			dp[0, 0] = 1;

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i > 0)
					{
						dp[i, j] += dp[i - 1, j];
					}

					if (j > 0)
					{
						dp[i, j] += dp[i, j - 1];
					}
				}
			}

			return dp[m - 1, n - 1];
		}
	}
}
