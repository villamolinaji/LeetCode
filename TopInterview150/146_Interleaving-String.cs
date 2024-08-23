namespace TopInterview150
{
	public class Solution146
	{
		public bool IsInterleave(string s1, string s2, string s3)
		{
			var s1Length = s1.Length;
			var s2Length = s2.Length;

			if (s1Length + s2Length != s3.Length)
			{
				return false;
			}

			bool[,] dp = new bool[s1Length + 1, s2Length + 1];
			dp[0, 0] = true;

			for (int i = 1; i <= s1Length; i++)
			{
				dp[i, 0] = dp[i - 1, 0] && s1[i - 1] == s3[i - 1];
			}

			for (int j = 1; j <= s2Length; j++)
			{
				dp[0, j] = dp[0, j - 1] && s2[j - 1] == s3[j - 1];
			}

			for (int i = 1; i <= s1Length; i++)
			{
				for (int j = 1; j <= s2Length; j++)
				{
					dp[i, j] = (dp[i - 1, j] && s1[i - 1] == s3[i + j - 1]) ||
							   (dp[i, j - 1] && s2[j - 1] == s3[i + j - 1]);
				}
			}

			return dp[s1Length, s2Length];
		}
	}
}
