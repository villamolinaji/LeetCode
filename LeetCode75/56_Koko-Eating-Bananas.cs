namespace LeetCode75
{
	public class Solution56
	{
		public int MinEatingSpeed(int[] piles, int h)
		{
			int left = 1;
			int right = piles.Max();
			int result = right;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;

				if (CanEatAllBananas(piles, mid, h))
				{
					result = mid;
					right = mid - 1;
				}
				else
				{
					left = mid + 1;
				}
			}

			return result;
		}

		private bool CanEatAllBananas(int[] piles, int bananas, int h)
		{
			int hours = 0;

			foreach (int pile in piles)
			{
				hours += (pile + bananas - 1) / bananas;

				if (hours > h)
				{
					return false;
				}
			}

			return true;
		}
	}
}
