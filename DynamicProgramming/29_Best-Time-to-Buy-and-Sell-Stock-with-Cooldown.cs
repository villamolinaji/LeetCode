namespace DynamicProgramming
{
	public class Solution29
	{
		public int MaxProfit(int[] prices)
		{
			int pricesLength = prices.Length;

			int[] hold = new int[pricesLength];
			int[] sell = new int[pricesLength];
			int[] cooldown = new int[pricesLength];

			hold[0] = -prices[0];
			sell[0] = 0;
			cooldown[0] = 0;

			for (int i = 1; i < pricesLength; i++)
			{
				hold[i] = Math.Max(hold[i - 1], cooldown[i - 1] - prices[i]);
				sell[i] = hold[i - 1] + prices[i];
				cooldown[i] = Math.Max(cooldown[i - 1], sell[i - 1]);
			}

			return Math.Max(sell[pricesLength - 1], cooldown[pricesLength - 1]);
		}
	}
}
