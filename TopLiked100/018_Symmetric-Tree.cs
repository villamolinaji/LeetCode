namespace TopLiked100
{
	public class Solution018
	{
		public bool IsSymmetric(TreeNode root)
		{
			if (root == null)
			{
				return true;
			}

			return IsMirror(root.left, root.right);
		}

		private bool IsMirror(TreeNode? left, TreeNode? right)
		{
			if (left == null
				&& right == null)
			{
				return true;
			}
			if (left == null
				|| right == null)
			{
				return false;
			}

#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters
			return (left.val == right.val) &&
					IsMirror(left.left, right.right) &&
					IsMirror(left.right, right.left);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
		}
	}
}
