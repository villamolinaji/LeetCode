namespace DynamicProgramming
{
	public class Solution27
	{
		public int MaxUncrossedLines(int[] nums1, int[] nums2)
		{
			int nums1Length = nums1.Length;
			int nums2Length = nums2.Length;

			int[,] dp = new int[nums1Length + 1, nums2Length + 1];

			for (int i = 1; i <= nums1Length; i++)
			{
				for (int j = 1; j <= nums2Length; j++)
				{
					if (nums1[i - 1] == nums2[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1] + 1;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
					}
				}
			}

			return dp[nums1Length, nums2Length];
		}
	}
}
