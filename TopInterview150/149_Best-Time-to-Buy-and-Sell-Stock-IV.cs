namespace TopInterview150
{
	public class Solution149
	{
		public int MaxProfit(int k, int[] prices)
		{
			var pricesLength = prices.Length;

			if (k >= pricesLength / 2)
			{
				var maxProfit = 0;
				for (int i = 1; i < pricesLength; i++)
				{
					if (prices[i] > prices[i - 1])
					{
						maxProfit += prices[i] - prices[i - 1];
					}
				}

				return maxProfit;
			}

			var dp = new int[k + 1, pricesLength];

			for (int i = 1; i <= k; i++)
			{
				var maxDiff = -prices[0];
				for (int j = 1; j < pricesLength; j++)
				{
					dp[i, j] = Math.Max(dp[i, j - 1], prices[j] + maxDiff);
					maxDiff = Math.Max(maxDiff, dp[i - 1, j] - prices[j]);
				}
			}

			return dp[k, pricesLength - 1];
		}
	}
}
