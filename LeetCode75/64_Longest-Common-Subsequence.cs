namespace LeetCode75
{
	public class Solution64
	{
		public int LongestCommonSubsequence(string text1, string text2)
		{
			int firstLength = text1.Length;
			int secondLength = text2.Length;

			var dp = new int[firstLength + 1, secondLength + 1];

			for (int i = 1; i <= firstLength; i++)
			{
				for (int j = 1; j <= secondLength; j++)
				{
					if (text1[i - 1] == text2[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1] + 1;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
					}
				}
			}

			return dp[firstLength, secondLength];
		}
	}
}
