namespace LeetCode75
{
	public class Solution55
	{
		public int FindPeakElement(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				if (i == 0)
				{
					if (i == nums.Length - 1)
					{
						return i;
					}
					else if (nums[i] > nums[i + 1])
					{
						return i;
					}
				}
				else if (i == nums.Length - 1 &&
					nums[i] > nums[i - 1])
				{
					return i;
				}
				else
				{
					if (nums[i] > nums[i - 1] &&
						nums[i] > nums[i + 1])
					{
						return i;
					}
				}
			}

			return -1;
		}
	}
}
