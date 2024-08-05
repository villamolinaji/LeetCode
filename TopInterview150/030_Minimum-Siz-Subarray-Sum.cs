namespace TopInterview150
{
	public class Solution030
	{
		public int MinSubArrayLen(int target, int[] nums)
		{
			int left = 0;
			int right = 0;
			int sum = 0;
			int min = Int32.MaxValue;

			while (right < nums.Length)
			{
				sum += nums[right];
				right++;
				while (sum >= target)
				{
					min = Math.Min(min, right - left);
					sum -= nums[left];
					left++;
				}
			}

			return min == Int32.MaxValue ? 0 : min;
		}
	}
}
