namespace TopInterview150_68
{
	public class TreeNode
	{
		public int val { get; set; }
		public TreeNode? left { get; set; }
		public TreeNode? right { get; set; }
		public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public class Solution068
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
