namespace DailyChallenge
{
	public class Solution018
	{
		public int StrangePrinter(string s)
		{
			int sLength = s.Length;
			var dp = new int[sLength, sLength];

			if (sLength == 0)
			{
				return 0;
			}

			for (int len = 1; len <= sLength; len++)
			{
				for (int i = 0; i <= sLength - len; i++)
				{
					var j = i + len - 1;
					dp[i, j] = len;

					if (len == 1)
					{
						dp[i, j] = 1;
					}
					else
					{
						dp[i, j] = dp[i + 1, j] + 1;

						for (int k = i + 1; k <= j; k++)
						{
							if (s[i] == s[k])
							{
								dp[i, j] = Math.Min(dp[i, j], dp[i + 1, k - 1] + dp[k, j]);
							}
						}
					}
				}
			}

			return dp[0, sLength - 1];
		}
	}
}
