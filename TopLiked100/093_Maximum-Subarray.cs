namespace TopLiked100
{
	public class Solution093
	{
		public int MaxSubArray(int[] nums)
		{
			var currentSum = nums[0];
			var maxSum = nums[0];

			for (int i = 1; i < nums.Length; i++)
			{
				currentSum = Math.Max(nums[i], currentSum + nums[i]);

				maxSum = Math.Max(maxSum, currentSum);
			}

			return maxSum;
		}
	}
}
