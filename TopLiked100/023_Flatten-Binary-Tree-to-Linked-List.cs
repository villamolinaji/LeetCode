namespace TopLiked100
{
	public class Solution023
	{
		public void Flatten(TreeNode? root)
		{
			if (root == null)
			{
				return;
			}

			Flatten(root.left);
			Flatten(root.right);

			var leftSubtree = root.left;
			var rightSubtree = root.right;

			root.left = null;
			root.right = leftSubtree;

			var current = root;
			while (current.right != null)
			{
				current = current.right;
			}
			current.right = rightSubtree;
		}
	}
}
