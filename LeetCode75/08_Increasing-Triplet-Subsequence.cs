namespace LeetCode75
{
	public class Solution08
	{
		public bool IncreasingTriplet(int[] nums)
		{			
			var first = int.MaxValue;
			var second = int.MaxValue;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] <= first)
				{
					first = nums[i];
				}
				else if (nums[i] <= second)
				{
					second = nums[i];
				}
				else
				{
					return true;
				}
			}

			return false;
		}
	}
}
