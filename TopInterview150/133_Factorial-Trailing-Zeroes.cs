namespace TopInterview150
{
	public class Solution133
	{
		public int TrailingZeroes(int n)
		{
			var countTrailingZeroes = 0;

			while (n >= 5)
			{
				n /= 5;
				countTrailingZeroes += n;
			}

			return countTrailingZeroes;
		}
	}
}
