namespace DynamicProgramming
{
	public class Solution28
	{
		public int MinInsertions(string s)
		{
			int sLength = s.Length;
			string sReverse = new string(s.Reverse().ToArray());

			int[,] dp = new int[sLength + 1, sLength + 1];

			for (int i = 1; i <= sLength; i++)
			{
				for (int j = 1; j <= sLength; j++)
				{
					if (s[i - 1] == sReverse[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1] + 1;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
					}
				}
			}

			return sLength - dp[sLength, sLength];
		}
	}
}
