namespace TopInterview150
{
	public class Solution046
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] == nums[j] &&
						j - i <= k)
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}
