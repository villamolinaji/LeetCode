namespace TopLiked100
{
	public class Solution020
	{
		public int MaxDepth(TreeNode? root)
		{
			if (root == null)
			{
				return 0;
			}
			else
			{
				int leftDepth = MaxDepth(root.left);
				int rightDepth = MaxDepth(root.right);

				return Math.Max(leftDepth, rightDepth) + 1;
			}
		}
	}
}
