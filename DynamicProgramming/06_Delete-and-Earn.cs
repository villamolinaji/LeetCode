namespace DynamicProgramming
{
	public class Solution06
	{
		public int DeleteAndEarn(int[] nums)
		{
			int maxVal = nums.Max();

			int[] sumArr = new int[maxVal + 1];
			foreach (int num in nums)
			{
				sumArr[num] += num;
			}

			int[] dp = new int[maxVal + 1];
			dp[1] = sumArr[1];

			for (int i = 2; i <= maxVal; i++)
			{
				dp[i] = Math.Max(dp[i - 1], dp[i - 2] + sumArr[i]);
			}

			return dp[maxVal];
		}
	}
}
