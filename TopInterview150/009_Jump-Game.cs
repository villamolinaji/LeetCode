namespace TopInterview150
{
	public class Solution009
	{
		public bool CanJump(int[] nums)
		{
			bool canJump = false;
			var index = 0;

			if (nums.Length == 1)
			{
				return true;
			}

			while (index < nums.Length)
			{
				var nextIndex = index + nums[index];

				for (int i = index + 1; i <= nextIndex; i++)
				{
					if (i < nums.Length)
					{
						nextIndex = Math.Max(nextIndex, i + nums[i]);
					}
				}

				if (nextIndex == index)
				{
					break;
				}

				index = nextIndex;

				if (index >= nums.Length - 1)
				{
					canJump = true;
					break;
				}
			}

			return canJump;
		}
	}
}
