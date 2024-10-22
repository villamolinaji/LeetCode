namespace BinarySearch
{
	public class Solution17
	{
		public bool IsPerfectSquare(int num)
		{
			if (num < 2)
			{
				return true;
			}

			long left = 2;
			long right = num / 2;

			while (left <= right)
			{
				long mid = left + (right - left) / 2;
				long guessSquared = mid * mid;

				if (guessSquared == num)
				{
					return true;
				}
				else if (guessSquared > num)
				{
					right = mid - 1;
				}
				else
				{
					left = mid + 1;
				}
			}

			return false;
		}
	}
}
