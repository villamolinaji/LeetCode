namespace TopLiked100
{
	public class Solution022
	{
		public TreeNode? SortedArrayToBST(int[] nums)
		{
			return DivideSortedArray(nums, 0, nums.Length - 1);
		}

		private TreeNode? DivideSortedArray(int[] nums, int start, int end)
		{
			if (start > end)
			{
				return null;
			}

			int mid = start + (end - start) / 2;
			TreeNode root = new TreeNode(nums[mid]);
			root.left = DivideSortedArray(nums, start, mid - 1);
			root.right = DivideSortedArray(nums, mid + 1, end);

			return root;
		}
	}
}
