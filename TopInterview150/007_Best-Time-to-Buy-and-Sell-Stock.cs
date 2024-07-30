namespace TopInterview150
{
	public class Solution007
	{
		public int MaxProfit(int[] prices)
		{
			var result = prices.Aggregate(new { MinPrice = int.MaxValue, MaxProfit = 0 },
			(acc, price) => new
			{
				MinPrice = Math.Min(acc.MinPrice, price),
				MaxProfit = Math.Max(acc.MaxProfit, price - acc.MinPrice)
			});

			return result.MaxProfit;
		}
	}
}
