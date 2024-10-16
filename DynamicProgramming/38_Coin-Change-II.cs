﻿namespace DynamicProgramming
{
	public class Solution38
	{
		public int Change(int amount, int[] coins)
		{
			int[] dp = new int[amount + 1];
			dp[0] = 1;

			foreach (int coin in coins)
			{
				for (int i = coin; i <= amount; i++)
				{
					dp[i] += dp[i - coin];
				}
			}

			return dp[amount];
		}
	}
}
