namespace TopLiked100
{
	public class Solution043
	{
		public bool CanPartition(int[] nums)
		{
			int totalSum = nums.Sum();

			if (totalSum % 2 != 0)
			{
				return false;
			}

			int target = totalSum / 2;
			bool[] dp = new bool[target + 1];

			dp[0] = true;

			foreach (int num in nums)
			{
				for (int i = target; i >= num; i--)
				{
					dp[i] = dp[i] || dp[i - num];
				}
			}

			return dp[target];
		}
	}
}
