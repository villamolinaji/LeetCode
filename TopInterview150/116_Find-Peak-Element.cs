namespace TopInterview150
{
	public class Solution116
	{
		public int FindPeakElement(int[] nums)
		{
			var left = 0;
			var right = nums.Length - 1;
			int middle;

			while (left != right)
			{
				middle = left + (right - left) / 2;
				if (nums[middle] > nums[middle + 1])
				{
					right = middle;
				}
				else
				{
					left = middle + 1;
				}
			}

			return right;
		}
	}
}
