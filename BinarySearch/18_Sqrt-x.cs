namespace BinarySearch
{
	public class Solution18
	{
		public int MySqrt(int x)
		{
			if (x < 2)
			{
				return x;
			}

			int left = 1;
			int right = x / 2;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				long squareMid = (long)mid * mid;

				if (squareMid == x)
				{
					return mid;
				}
				else if (squareMid < x)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return right;
		}
	}
}
