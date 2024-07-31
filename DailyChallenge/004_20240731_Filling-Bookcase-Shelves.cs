﻿namespace DailyChallenge
{
	public class Solution004
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public int MinHeightShelves(int[][] books, int shelfWidth)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			int booksLength = books.Length;
			int[] dp = new int[booksLength + 1];

			Array.Fill(dp, int.MaxValue);
			dp[0] = 0;

			for (int i = 0; i < booksLength; i++)
			{
				int width = 0;
				int height = 0;

				for (int j = i; j >= 0; j--)
				{
					width += books[j][0];

					if (width > shelfWidth)
					{
						break;
					}

					height = Math.Max(height, books[j][1]);

					dp[i + 1] = Math.Min(dp[i + 1], dp[j] + height);
				}
			}

			return dp[booksLength];
		}
	}
}
