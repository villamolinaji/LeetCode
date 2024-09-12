namespace AmazonSpring
{
	public class Solution01
	{
		public int KthFactor(int n, int k)
		{
			var factors = new List<int>();

			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					factors.Add(i);
				}
			}

			if (k > factors.Count)
			{
				return -1;
			}

			return factors[k - 1];
		}
	}
}
