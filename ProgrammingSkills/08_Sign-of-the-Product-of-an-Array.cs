namespace ProgrammingSkills
{
	public class Solution08
	{
		public int ArraySign(int[] nums)
		{
			if (nums.Contains(0))
			{
				return 0;
			}

			var negativeCount = nums.Count(n => n < 0);

			if (negativeCount % 2 == 0)
			{
				return 1;
			}

			return -1;
		}
	}
}
