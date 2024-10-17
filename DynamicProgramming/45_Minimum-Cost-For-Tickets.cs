namespace DynamicProgramming
{
	public class Solution45
	{
		public int MincostTickets(int[] days, int[] costs)
		{
			int daysLength = days.Length;
			int lastDay = days[daysLength - 1];
			int[] dp = new int[lastDay + 1];
			HashSet<int> travelDays = new HashSet<int>(days);

			for (int i = 1; i <= lastDay; i++)
			{
				if (!travelDays.Contains(i))
				{
					dp[i] = dp[i - 1];
				}
				else
				{
					var newValue = dp[i - 1] + costs[0];
					newValue = Math.Min(newValue, dp[Math.Max(0, i - 7)] + costs[1]);
					newValue = Math.Min(newValue, dp[Math.Max(0, i - 30)] + costs[2]);
					dp[i] = newValue;
				}
			}

			return dp[lastDay];
		}
	}
}
