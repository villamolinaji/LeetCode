namespace TopLiked100
{
	public class Solution042
	{
		public int CoinChange(int[] coins, int amount)
		{
			var max = amount + 1;
			var dp = new int[amount + 1];
			Array.Fill(dp, max);
			dp[0] = 0;

			for (int i = 1; i <= amount; i++)
			{
				foreach (int coin in coins)
				{
					if (i - coin >= 0)
					{
						dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
					}
				}
			}

			return dp[amount] == max
				? -1
				: dp[amount];
		}
	}
}
