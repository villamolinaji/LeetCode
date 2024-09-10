namespace TopLiked100
{
	public class Solution011
	{
		public int[] SearchRange(int[] nums, int target)
		{
			var index = Array.IndexOf(nums, target);

			if (index == -1)
			{
				return new int[] { -1, -1 };
			}
			else
			{
				var start = index;

				while (index < nums.Length &&
					nums[index] == target)
				{
					index++;
				}

				return new int[] { start, index - 1 };
			}
		}
	}
}
