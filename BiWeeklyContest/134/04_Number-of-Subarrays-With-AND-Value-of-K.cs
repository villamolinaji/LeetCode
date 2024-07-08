namespace _134
{
	public class Solution04
	{
		public const int VectorSize = 32;

		public long CountSubarrays(int[] nums, int k)
		{
			return CountSubarraysWithAtLeastK(nums, k) - CountSubarraysWithAtLeastK(nums, k + 1);
		}

		private long CountSubarraysWithAtLeastK(int[] nums, int k)
		{
			long count = 0;
			int[] bitFrequency = new int[VectorSize];
			int left = 0;

			for (int right = 0; right < nums.Length; right++)
			{
				for (int i = 0; i < VectorSize; i++)
				{
					if ((1 << i & nums[right]) != 0)
					{
						bitFrequency[i]++;
					}
				}

				while ((right - left + 1) > 0 && 
					CalculateAnd(bitFrequency, right - left + 1) < k)
				{
					for (int i = 0; i < VectorSize; i++)
					{
						if ((1 << i & nums[left]) != 0)
						{
							bitFrequency[i]--;
						}
					}
					left++;
				}

				count += (right - left + 1);
			}

			return count;
		}

		private int CalculateAnd(int[] bitFrequency, int windowSize)
		{
			int result = 0;
			for (int i = 0; i < VectorSize; i++)
			{
				if (bitFrequency[i] == windowSize)
				{
					result += (1 << i);
				}
			}

			return result;
		}
	}
}
