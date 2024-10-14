namespace DynamicProgramming
{
	public class Solution31
	{
		public int MaxProfit(int[] prices)
		{
			var pricesLength = prices.Length;
			if (pricesLength == 0)
			{
				return 0;
			}

			var leftProfits = new int[pricesLength];
			var rightProfits = new int[pricesLength];

			var minPrice = prices[0];
			for (int i = 1; i < pricesLength; i++)
			{
				minPrice = Math.Min(minPrice, prices[i]);
				leftProfits[i] = Math.Max(leftProfits[i - 1], prices[i] - minPrice);
			}

			var maxPrice = prices[pricesLength - 1];
			for (int i = pricesLength - 2; i >= 0; i--)
			{
				maxPrice = Math.Max(maxPrice, prices[i]);
				rightProfits[i] = Math.Max(rightProfits[i + 1], maxPrice - prices[i]);
			}

			var maxProfit = 0;
			for (int i = 0; i < pricesLength; i++)
			{
				maxProfit = Math.Max(maxProfit, leftProfits[i] + rightProfits[i]);
			}

			return maxProfit;
		}
	}
}
