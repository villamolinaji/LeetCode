namespace BinarySearch
{
	public class Solution19
	{
		public int ArrangeCoins(int n)
		{
			int rows = 0;
			int countCoins = 0;
			int rowCapacity = 1;

			while (rowCapacity <= n)
			{
				rows++;
				countCoins += rowCapacity;
				n -= rowCapacity;
				rowCapacity++;
			}

			return rows;
		}
	}
}
