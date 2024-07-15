namespace LeetCode75
{
	public class Solution14
	{
		public double FindMaxAverage(int[] nums, int k)
		{			
			double sum = 0;
			for (int i = 0; i < k; i++)
			{
				sum += nums[i];
			}
			
			double maxSum = sum;
			
			for (int i = k; i < nums.Length; i++)
			{
				sum += nums[i] - nums[i - k];
				if (sum > maxSum)
				{
					maxSum = sum;
				}
			}
			
			return maxSum / k;
		}
	}
}