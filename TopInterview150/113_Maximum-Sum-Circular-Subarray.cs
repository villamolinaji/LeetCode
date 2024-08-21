namespace TopInterview150
{
	public class Solution113
	{
		public int MaxSubarraySumCircular(int[] nums)
		{
			var totalSum = 0;
			var maxSum = int.MinValue;
			var currentMax = 0;
			var minSum = int.MaxValue;
			var currentMin = 0;

			foreach (var num in nums)
			{
				totalSum += num;

				currentMax = Math.Max(currentMax + num, num);
				maxSum = Math.Max(maxSum, currentMax);

				currentMin = Math.Min(currentMin + num, num);
				minSum = Math.Min(minSum, currentMin);
			}

			var maxSumCircular = totalSum - minSum;

			if (maxSum > 0)
			{
				return Math.Max(maxSum, maxSumCircular);
			}
			else
			{
				return maxSum;
			}
		}
	}
}
