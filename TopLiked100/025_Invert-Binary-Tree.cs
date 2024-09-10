namespace TopLiked100
{
	public class Solution025
	{
		public TreeNode? InvertTree(TreeNode? root)
		{
			if (root == null)
			{
				return null;
			}

			var left = InvertTree(root.left);
			var right = InvertTree(root.right);

			root.left = right;
			root.right = left;

			return root;
		}
	}
}
