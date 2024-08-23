namespace TopInterview150
{
	public class Solution141
	{
		public int LengthOfLIS(int[] nums)
		{
			var numsLength = nums.Length;
			var dp = new int[numsLength];
			Array.Fill(dp, 1);

			for (int i = 1; i < numsLength; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (nums[i] > nums[j])
					{
						dp[i] = Math.Max(dp[i], dp[j] + 1);
					}
				}
			}

			var maxLength = 0;
			for (int i = 0; i < numsLength; i++)
			{
				maxLength = Math.Max(maxLength, dp[i]);
			}

			return maxLength;
		}
	}
}
