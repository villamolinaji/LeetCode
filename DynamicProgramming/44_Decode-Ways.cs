namespace DynamicProgramming
{
	public class Solution44
	{
		public int NumDecodings(string s)
		{
			int sLength = s.Length;

			int[] dp = new int[sLength + 1];

			dp[0] = 1;
			dp[1] = s[0] != '0'
				? 1
				: 0;

			for (int i = 2; i <= sLength; i++)
			{
				int oneDigit = int.Parse(s.Substring(i - 1, 1));
				if (oneDigit >= 1 && oneDigit <= 9)
				{
					dp[i] += dp[i - 1];
				}

				int twoDigits = int.Parse(s.Substring(i - 2, 2));
				if (twoDigits >= 10 && twoDigits <= 26)
				{
					dp[i] += dp[i - 2];
				}
			}

			return dp[sLength];
		}
	}
}
