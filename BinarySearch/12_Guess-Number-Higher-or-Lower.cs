﻿namespace BinarySearch
{
	public class GuessGame
	{
		public int guess(int num)
		{
			return 0;
		}
	}

	public class Solution12 : GuessGame
	{
		public int GuessNumber(int n)
		{
			int left = 1;
			int right = n;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				int result = guess(mid);

				if (result == 0)
				{
					return mid;
				}
				else if (result < 0)
				{
					right = mid - 1;
				}
				else
				{
					left = mid + 1;
				}
			}

			return -1;
		}
	}
}
