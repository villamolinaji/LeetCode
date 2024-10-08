namespace DynamicProgramming
{
	public class Solution22
	{
		public int LongestSubsequence(int[] arr, int difference)
		{
			var dp = new Dictionary<int, int>();
			int maxLength = 0;

			foreach (int num in arr)
			{
				dp[num] = dp.ContainsKey(num - difference)
					? dp[num - difference] + 1
					: 1;

				maxLength = Math.Max(maxLength, dp[num]);
			}

			return maxLength;
		}
	}
}
