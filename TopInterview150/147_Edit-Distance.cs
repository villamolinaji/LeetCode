namespace TopInterview150
{
	public class Solution147
	{
		public int MinDistance(string word1, string word2)
		{
			int length1 = word1.Length;
			int length2 = word2.Length;
			var dp = new int[length1 + 1, length2 + 1];

			for (int i = 0; i <= length1; i++)
			{
				dp[i, 0] = i;
			}
			for (int j = 0; j <= length2; j++)
			{
				dp[0, j] = j;
			}

			for (int i = 1; i <= length1; i++)
			{
				for (int j = 1; j <= length2; j++)
				{
					if (word1[i - 1] == word2[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1];
					}
					else
					{
						dp[i, j] = Math.Min(dp[i - 1, j] + 1, Math.Min(dp[i, j - 1] + 1, dp[i - 1, j - 1] + 1));
					}
				}
			}

			return dp[length1, length2];
		}
	}
}
