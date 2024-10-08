namespace DynamicProgramming
{
	public class Solution20
	{
		public int FindNumberOfLIS(int[] nums)
		{
			int numsLength = nums.Length;
			int[] length = new int[numsLength];
			int[] count = new int[numsLength];

			Array.Fill(length, 1);
			Array.Fill(count, 1);

			int maxLength = 1;

			for (int i = 0; i < numsLength; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (nums[j] < nums[i])
					{
						if (length[j] + 1 > length[i])
						{
							length[i] = length[j] + 1;
							count[i] = count[j];
						}
						else if (length[j] + 1 == length[i])
						{
							count[i] += count[j];
						}
					}
				}

				maxLength = Math.Max(maxLength, length[i]);
			}

			int numberOfLIS = 0;
			for (int i = 0; i < numsLength; i++)
			{
				if (length[i] == maxLength)
				{
					numberOfLIS += count[i];
				}
			}

			return numberOfLIS;
		}
	}
}
