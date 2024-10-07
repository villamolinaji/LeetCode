namespace DynamicProgramming
{
	public class Solution17
	{
		public int MinimumDeleteSum(string s1, string s2)
		{
			int s1Length = s1.Length;
			int s2Length = s2.Length;

			int[,] dp = new int[s1Length + 1, s2Length + 1];

			for (int i = 1; i <= s1Length; i++)
			{
				dp[i, 0] = dp[i - 1, 0] + (int)s1[i - 1];
			}

			for (int j = 1; j <= s2Length; j++)
			{
				dp[0, j] = dp[0, j - 1] + (int)s2[j - 1];
			}

			for (int i = 1; i <= s1Length; i++)
			{
				for (int j = 1; j <= s2Length; j++)
				{
					if (s1[i - 1] == s2[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1];
					}
					else
					{
						dp[i, j] = Math.Min(dp[i - 1, j] + (int)s1[i - 1], dp[i, j - 1] + (int)s2[j - 1]);
					}
				}
			}

			return dp[s1Length, s2Length];
		}
	}
}
