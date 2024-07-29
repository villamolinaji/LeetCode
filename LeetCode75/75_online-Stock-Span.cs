namespace LeetCode75
{
	public class StockSpanner
	{
		public List<int> Stocks { get; set; }

		public StockSpanner()
		{
			Stocks = new List<int>();
		}

		public int Next(int price)
		{
			Stocks.Add(price);

			var span = 1;

			var indexBack = Stocks.Count - 2;

			while (indexBack >= 0)
			{
				if (Stocks[indexBack] <= price)
				{
					span++;
					indexBack--;
				}
				else
				{
					break;
				}
			}

			return span;
		}
	}
}
