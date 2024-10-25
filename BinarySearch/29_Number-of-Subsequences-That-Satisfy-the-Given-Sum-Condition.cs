namespace BinarySearch
{
	public class Solution29
	{
		public int NumSubseq(int[] nums, int target)
		{
			Array.Sort(nums);
			const int Mod = 1_000_000_007;
			int numsLength = nums.Length;

			int[] powers = new int[numsLength];
			powers[0] = 1;
			for (int i = 1; i < numsLength; i++)
			{
				powers[i] = (powers[i - 1] * 2) % Mod;
			}

			int left = 0;
			int right = numsLength - 1;
			int count = 0;

			while (left <= right)
			{
				if (nums[left] + nums[right] <= target)
				{
					count = (count + powers[right - left]) % Mod;
					left++;
				}
				else
				{
					right--;
				}
			}

			return count;
		}
	}
}
