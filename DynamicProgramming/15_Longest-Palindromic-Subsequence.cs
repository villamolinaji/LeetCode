namespace DynamicProgramming
{
	public class Solution15
	{
		public int LongestPalindromeSubseq(string s)
		{
			int sLength = s.Length;
			int[,] dp = new int[sLength, sLength];

			for (int i = 0; i < sLength; i++)
			{
				dp[i, i] = 1;
			}

			for (int len = 2; len <= sLength; len++)
			{
				for (int i = 0; i <= sLength - len; i++)
				{
					int j = i + len - 1;
					if (s[i] == s[j])
					{
						dp[i, j] = dp[i + 1, j - 1] + 2;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
					}
				}
			}

			return dp[0, sLength - 1];
		}
	}
}
