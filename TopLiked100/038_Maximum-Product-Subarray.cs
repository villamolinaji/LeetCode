namespace TopLiked100
{
	public class Solution038
	{
		public int MaxProduct(int[] nums)
		{
			int currentMax = nums[0];
			int currentMin = nums[0];
			int result = nums[0];

			for (int i = 1; i < nums.Length; i++)
			{
				int auxMax = currentMax;

				currentMax = Math.Max(nums[i], Math.Max(auxMax * nums[i], currentMin * nums[i]));
				currentMin = Math.Min(nums[i], Math.Min(auxMax * nums[i], currentMin * nums[i]));

				result = Math.Max(result, currentMax);
			}

			return result;
		}
	}
}
