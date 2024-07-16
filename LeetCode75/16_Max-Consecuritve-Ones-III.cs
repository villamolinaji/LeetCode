namespace LeetCode75
{
	public class Solution16
	{
		public int LongestOnes(int[] nums, int k)
		{
			int countK = 0;
			int counterOnes = 0;
			int maxOnes = 0;
			int i = 0;
			while (i < nums.Length)
			{
				if (nums[i] == 1)
				{
					counterOnes++;
				}
				else if (countK < k)
				{
					counterOnes++;
					countK++;
				}
				else
				{
					i = i - counterOnes;
					countK = 0;
					counterOnes = 0;
				}

				maxOnes = Math.Max(maxOnes, counterOnes);

				i++;
			}

			return maxOnes;
		}
	}
}
