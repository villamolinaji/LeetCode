namespace LeetCode75
{
	public class Solution19
	{
		public int PivotIndex(int[] nums)
		{
			var leftNums = new int[nums.Length];
			var rightNums = new int[nums.Length];

			int leftSum = 0;
			int rightSum = 0;

			for (int i = 0; i < nums.Length; i++)
			{				
				leftNums[i] = leftSum;
				rightNums[nums.Length - 1 - i] = rightSum;

				leftSum += nums[i];
				rightSum += nums[nums.Length - 1 - i];
			}

			for (int i = 0; i < nums.Length; i++)
			{
				if (leftNums[i] == rightNums[i])
				{
					return i;
				}
			}

			return -1;
		}
	}
}
