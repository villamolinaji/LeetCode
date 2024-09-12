namespace TopLiked100
{
	public class Solution091
	{
		public void NextPermutation(int[] nums)
		{
			var numsLength = nums.Length;

			var i = numsLength - 2;
			while (i >= 0 &&
				nums[i] >= nums[i + 1])
			{
				i--;
			}

			if (i >= 0)
			{
				var j = numsLength - 1;
				while (j >= 0 &&
					nums[j] <= nums[i])
				{
					j--;
				}

				Swap(nums, i, j);
			}

			Reverse(nums, i + 1, numsLength - 1);
		}

		private void Swap(int[] nums, int i, int j)
		{
			var auxNum = nums[i];
			nums[i] = nums[j];
			nums[j] = auxNum;
		}

		private void Reverse(int[] nums, int start, int end)
		{
			while (start < end)
			{
				Swap(nums, start, end);

				start++;
				end--;
			}
		}
	}
}
