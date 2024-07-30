namespace TopInterview150
{
	public class Solution008
	{
		public int MaxProfit(int[] prices)
		{
			int n = prices.Length;

			if (n == 0)
			{
				return 0;
			}

			int hold = -prices[0];
			int cash = 0;

			for (int i = 1; i < n; i++)
			{
				cash = Math.Max(cash, hold + prices[i]);
				hold = Math.Max(hold, cash - prices[i]);
			}

			return cash;
		}
	}
}
