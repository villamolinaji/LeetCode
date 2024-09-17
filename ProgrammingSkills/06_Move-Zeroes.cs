namespace ProgrammingSkills
{
	public class Solution06
	{
		public void MoveZeroes(int[] nums)
		{
			int left = 0;
			int right = 1;
			while (left < nums.Length &&
				right < nums.Length &&
				left < right)
			{
				if (nums[left] != 0)
				{
					left++;
					right++;
				}
				else if (nums[left] == 0 &&
					nums[right] == 0)
				{
					right++;
				}
				else if (nums[left] == 0 &&
					nums[right] != 0)
				{
					nums[left] = nums[right];
					nums[right] = 0;
					left++;
					right++;
				}

				if (left >= right)
				{
					right = left + 1;
				}
			}
		}
	}
}
