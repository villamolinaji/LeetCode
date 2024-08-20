namespace DailyChallenge
{
	public class Solution016
	{
		public int MinSteps(int n)
		{
			var result = 0;
			var divisor = 2;

			while (n > 1)
			{
				while (n % divisor == 0)
				{
					result += divisor;
					n /= divisor;
				}

				divisor++;
			}

			return result;
		}
	}
}
