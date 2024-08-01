namespace TopInterview150
{
	public class Solution013
	{
		public int[] ProductExceptSelf(int[] nums)
		{
			int numsLength = nums.Length;

			var numsLeft = new int[numsLength];
			numsLeft[0] = 1;
			numsLeft[1] = nums[0];
			for (int i = 2; i < numsLength; i++)
			{
				numsLeft[i] = nums[i - 1] * numsLeft[i - 1];
			}

			var numsRight = new int[numsLength];

			numsRight[numsLength - 2] = nums[numsLength - 1];
			for (int j = numsLength - 3; j >= 0; j--)
			{
				numsRight[j] = numsRight[j + 1] * nums[j + 1];
			}
			numsRight[numsLength - 1] = 1;

			for (int i = 0; i < numsLength; i++)
			{
				numsLeft[i] = numsLeft[i] * numsRight[i];
			}

			return numsLeft;
		}
	}
}
