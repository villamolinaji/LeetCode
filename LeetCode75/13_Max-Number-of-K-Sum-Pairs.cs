namespace LeetCode75
{
	public class Solution13
	{
		public int MaxOperations(int[] nums, int k)
		{
			Array.Sort(nums);
			int maxOperations = 0;
			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int sum = nums[left] + nums[right];

				if (sum == k)
				{
					maxOperations++;
					left++;
					right--;
				}
				else if (sum < k)
				{
					left++;
				}
				else
				{
					right--;
				}
			}

			return maxOperations;
		}
	}
}
