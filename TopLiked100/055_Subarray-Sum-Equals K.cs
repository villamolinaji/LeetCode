namespace TopLiked100
{
	public class Solution055
	{
		public int SubarraySum(int[] nums, int k)
		{
			int result = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				int sum = 0;
				for (int j = i; j < nums.Length; j++)
				{
					sum += nums[j];
					if (sum == k)
					{
						result++;
					}
				}
			}

			return result;
		}
	}
}
