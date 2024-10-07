namespace DynamicProgramming
{
	public class Solution18
	{
		public int NumDistinct(string s, string t)
		{
			int sLength = s.Length;
			int tLength = t.Length;

			int[,] dp = new int[sLength + 1, tLength + 1];

			for (int i = 0; i <= sLength; i++)
			{
				dp[i, 0] = 1;
			}

			for (int j = 1; j <= tLength; j++)
			{
				dp[0, j] = 0;
			}

			for (int i = 1; i <= sLength; i++)
			{
				for (int j = 1; j <= tLength; j++)
				{
					if (s[i - 1] == t[j - 1])
					{
						dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1];
					}
					else
					{
						dp[i, j] = dp[i - 1, j];
					}
				}
			}

			return dp[sLength, tLength];
		}
	}
}
