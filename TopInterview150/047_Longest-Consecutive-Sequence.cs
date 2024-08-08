namespace TopInterview150
{
	public class Solution047
	{
		public int LongestConsecutive(int[] nums)
		{
			if (nums.Length == 0)
			{
				return 0;
			}

			Array.Sort(nums);

			int longest = 1;
			int currentLongest = 1;
			int previous = nums[0];

			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] == previous + 1)
				{
					currentLongest++;
				}
				else if (nums[i] != previous)
				{
					longest = Math.Max(longest, currentLongest);
					currentLongest = 1;
				}

				previous = nums[i];
			}

			longest = Math.Max(longest, currentLongest);


			return longest;
		}
	}
}
