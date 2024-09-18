namespace ProgrammingSkills
{
	public class Solution10
	{
		public bool IsMonotonic(int[] nums)
		{
			int index = 0;

			while (index < nums.Length - 1 && nums[index] == nums[index + 1])
			{
				index++;
			}

			if (index == nums.Length - 1)
			{
				return true;
			}

			bool isIncreasing = nums[index] < nums[index + 1];

			for (int i = index + 1; i < nums.Length - 1; i++)
			{
				if (isIncreasing && nums[i] > nums[i + 1])
				{
					return false;
				}

				if (!isIncreasing && nums[i] < nums[i + 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}
