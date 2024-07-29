namespace TopInterview150
{
	public class Solution003
	{
		public int RemoveDuplicates(int[] nums)
		{
			var distinctNums = nums.Distinct().ToArray();

			for (int i = 0; i < distinctNums.Length; i++)
			{
				nums[i] = distinctNums[i];
			}

			return distinctNums.Length;
		}
	}
}
