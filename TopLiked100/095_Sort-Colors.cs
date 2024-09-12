namespace TopLiked100
{
	public class Solution095
	{
		public void SortColors(int[] nums)
		{
			var redIndex = 0;
			var whiteIndex = 0;
			var blueIndex = nums.Length - 1;

			while (whiteIndex <= blueIndex)
			{
				if (nums[whiteIndex] == 0)
				{
					Swap(nums, redIndex, whiteIndex);
					redIndex++;
					whiteIndex++;
				}
				else if (nums[whiteIndex] == 1)
				{
					whiteIndex++;
				}
				else if (nums[whiteIndex] == 2)
				{
					Swap(nums, whiteIndex, blueIndex);
					blueIndex--;
				}
			}
		}

		private void Swap(int[] nums, int i, int j)
		{
			var numsLength = nums.Length;

			if (i < numsLength &&
				j < numsLength)
			{
				var auxNum = nums[i];
				nums[i] = nums[j];
				nums[j] = auxNum;
			}
		}
	}
}
