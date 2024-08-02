namespace DailyChallenge
{
	public class Solution006
	{
		public int MinSwaps(int[] nums)
		{
			int numsLength = nums.Length;

			int totalOnes = nums.Count(n => n == 1);

			if (totalOnes == 0)
			{
				return 0;
			}

			int[] extendedNums = new int[2 * numsLength];
			for (int i = 0; i < numsLength; i++)
			{
				extendedNums[i] = nums[i];
				extendedNums[i + numsLength] = nums[i];
			}

			int maxOnesInWindow = 0;
			int currentOnesInWindow = 0;

			for (int i = 0; i < totalOnes; i++)
			{
				if (extendedNums[i] == 1)
				{
					currentOnesInWindow++;
				}
			}

			maxOnesInWindow = currentOnesInWindow;

			for (int i = totalOnes; i < extendedNums.Length; i++)
			{
				if (extendedNums[i] == 1)
				{
					currentOnesInWindow++;
				}

				if (extendedNums[i - totalOnes] == 1)
				{
					currentOnesInWindow--;
				}

				maxOnesInWindow = Math.Max(maxOnesInWindow, currentOnesInWindow);
			}

			return totalOnes - maxOnesInWindow;
		}
	}
}
