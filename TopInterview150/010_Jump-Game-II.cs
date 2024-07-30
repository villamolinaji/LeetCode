namespace TopInterview150
{
	public class Solution010
	{
		public int Jump(int[] nums)
		{
			int numsLength = nums.Length;
			if (numsLength <= 1)
			{
				return 0;
			}

			int jumps = 0;
			int currentEnd = 0;
			int farthest = 0;

			for (int i = 0; i < numsLength - 1; i++)
			{
				farthest = Math.Max(farthest, i + nums[i]);

				if (i == currentEnd)
				{
					jumps++;
					currentEnd = farthest;

					if (currentEnd >= numsLength - 1)
					{
						break;
					}
				}
			}

			return jumps;
		}
	}
}
