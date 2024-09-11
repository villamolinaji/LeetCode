namespace TopLiked100
{
	public class Solution052
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var numsLength = nums.Length;

			for (int i = 0; i < numsLength; i++)
			{
				for (int j = i + 1; j < numsLength; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[] { i, j };
					}
				}
			}

			return new int[] { };
		}
	}
}
