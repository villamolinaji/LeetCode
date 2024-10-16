namespace DynamicProgramming
{
	public class Solution40
	{
		public int FindMaxForm(string[] strs, int m, int n)
		{
			int[,] dp = new int[m + 1, n + 1];

			foreach (string str in strs)
			{
				int zeroCount = str.Count(c => c == '0');
				int oneCount = str.Length - zeroCount;

				for (int i = m; i >= zeroCount; i--)
				{
					for (int j = n; j >= oneCount; j--)
					{
						dp[i, j] = Math.Max(dp[i, j], dp[i - zeroCount, j - oneCount] + 1);
					}
				}
			}

			return dp[m, n];
		}
	}
}
