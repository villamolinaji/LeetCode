namespace TopLiked100
{
	public class Solution056
	{
		public int FindKthLargest(int[] nums, int k)
		{
			int left = 0;
			int right = nums.Length - 1;
			Random rand = new Random();

			while (true)
			{
				int pivot_index = left + rand.Next(right - left + 1);
				int new_pivot_index = Partition(nums, left, right, pivot_index);
				if (new_pivot_index == nums.Length - k)
				{
					return nums[new_pivot_index];
				}
				else if (new_pivot_index > nums.Length - k)
				{
					right = new_pivot_index - 1;
				}
				else
				{
					left = new_pivot_index + 1;
				}
			}
		}

		private int Partition(int[] nums, int left, int right, int pivot_index)
		{
			int pivot = nums[pivot_index];

			Swap(nums, pivot_index, right);

			int stored_index = left;

			for (int i = left; i < right; i++)
			{
				if (nums[i] < pivot)
				{
					Swap(nums, i, stored_index);
					stored_index++;
				}
			}

			Swap(nums, right, stored_index);

			return stored_index;
		}

		private void Swap(int[] nums, int i, int j)
		{
			int aux = nums[i];
			nums[i] = nums[j];
			nums[j] = aux;
		}
	}
}
