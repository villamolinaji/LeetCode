namespace TopLiked100
{
	public class Solution092
	{
		public int FirstMissingPositive(int[] nums)
		{
			nums = nums.Where(n => n != 0).OrderBy(num => num).ToArray();

			var firstMissingPositive = 1;

			foreach (var num in nums)
			{
				if (num == firstMissingPositive)
				{
					firstMissingPositive++;
				}
				else if (num > firstMissingPositive)
				{
					break;
				}
			}

			return firstMissingPositive;
		}
	}
}
