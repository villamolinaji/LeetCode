namespace DynamicProgramming
{
	public class Solution23
	{
		public int LongestArithSeqLength(int[] nums)
		{
			int numsLength = nums.Length;

			Dictionary<int, int>[] dp = new Dictionary<int, int>[numsLength];

			for (int i = 0; i < numsLength; i++)
			{
				dp[i] = new Dictionary<int, int>();
			}

			int maxLength = 2;

			for (int i = 1; i < numsLength; i++)
			{
				for (int j = 0; j < i; j++)
				{
					int diff = nums[i] - nums[j];

					int length = 2;

					if (dp[j].ContainsKey(diff))
					{
						length = dp[j][diff] + 1;
					}

					if (dp[i].ContainsKey(diff))
					{
						dp[i][diff] = Math.Max(dp[i][diff], length);
					}
					else
					{
						dp[i][diff] = length;
					}

					maxLength = Math.Max(maxLength, dp[i][diff]);
				}
			}

			return maxLength;
		}
	}
}
