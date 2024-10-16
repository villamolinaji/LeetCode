﻿namespace DynamicProgramming
{
	public class Solution39
	{
		public int CombinationSum4(int[] nums, int target)
		{
			int[] dp = new int[target + 1];
			dp[0] = 1;

			for (int i = 1; i <= target; i++)
			{
				foreach (int num in nums)
				{
					if (i >= num)
					{
						dp[i] += dp[i - num];
					}
				}
			}

			return dp[target];
		}
	}
}
