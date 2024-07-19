namespace LeetCode75
{
	public class Solution41
	{
		public TreeNode? SearchBST(TreeNode? root, int val)
		{
			if (root == null)
			{
				return null;
			}

			if (root.val == val)
			{
				return root;
			}
			else
			{
				var searchLeft = SearchBST(root.left, val);
				var searchRight = SearchBST(root.right, val);

				return searchLeft ?? searchRight;
			}
		}
	}
}
