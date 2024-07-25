namespace LeetCode75
{
	public class Solution53
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

		private int guess(int num)
		{
			int pick = 1;

			if (num > pick)
			{
				return -1;
			}
			else if (num < pick)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
