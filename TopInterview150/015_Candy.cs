namespace TopInterview150
{
	public class Solution015
	{
		public int Candy(int[] ratings)
		{
			int ratingsLength = ratings.Length;
			int[] candies = new int[ratingsLength];

			for (int i = 0; i < ratingsLength; i++)
			{
				candies[i] = 1;
			}

			for (int i = 1; i < ratingsLength; i++)
			{
				if (ratings[i] > ratings[i - 1])
				{
					candies[i] = candies[i - 1] + 1;
				}
			}

			for (int i = ratingsLength - 2; i >= 0; i--)
			{
				if (ratings[i] > ratings[i + 1])
				{
					candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
				}
			}

			return candies.Sum();
		}
	}
}
