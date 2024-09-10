namespace TopLiked100
{
	public class Solution029
	{
		private int maxDiameter = 0;

		public int DiameterOfBinaryTree(TreeNode root)
		{
			GetDepth(root);

			return maxDiameter;
		}

		private int GetDepth(TreeNode? root)
		{
			if (root == null)
			{
				return 0;
			}

			int leftDepth = GetDepth(root.left);
			int rightDepth = GetDepth(root.right);

			maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);

			return Math.Max(leftDepth, rightDepth) + 1;
		}
	}
}
