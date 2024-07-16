namespace LeetCode75
{
	public class Solution17
	{
		public int LongestSubarray(int[] nums)
		{
			bool hasReplaced = false;
			bool anyReplacement = false;
			int replacedPosition = 0;
			int countOnes = 0;
			int maxOnes = 0;
			int i = 0;
			while (i < nums.Length)
			{
				if (nums[i] == 1)
				{
					countOnes++;
				}
				else if (!hasReplaced)
				{					
					hasReplaced = true;
					replacedPosition = i;
					anyReplacement = true;
				}
				else
				{
					i = replacedPosition;
					hasReplaced = false;
					countOnes = 0;
				}

				maxOnes = Math.Max(maxOnes, countOnes);

				i++;
			}

			return anyReplacement 
				? maxOnes
				: maxOnes - 1;
		}
	}
}
