namespace TopInterview150
{
	public class Solution002
	{
		public int RemoveElement(int[] nums, int val)
		{
			int k = nums.Length;
			int nLength = nums.Length;
			int index = 0;

			while (index < nLength)
			{
				if (nums[index] == val)
				{
					for (int j = index; j < nums.Length - 1; j++)
					{
						nums[j] = nums[j + 1];
					}

					k--;

					nLength--;
				}
				else
				{
					index++;
				}
			}

			return k;
		}
	}
}
