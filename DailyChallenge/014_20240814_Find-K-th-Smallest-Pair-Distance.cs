namespace DailyChallenge
{
	public class Solution014
	{
		public int SmallestDistancePair(int[] nums, int k)
		{
			Array.Sort(nums);

			var numsLength = nums.Length;
			var left = 0;
			var right = nums[numsLength - 1] - nums[0];

			while (left < right)
			{
				var mid = left + (right - left) / 2;
				var count = 0;
				var j = 0;

				for (int i = 0; i < numsLength; i++)
				{
					while (j < numsLength &&
						nums[j] - nums[i] <= mid)
					{
						j++;
					}
					count += j - i - 1;
				}

				if (count >= k)
				{
					right = mid;
				}
				else
				{
					left = mid + 1;
				}
			}

			return left;
		}
	}
}
