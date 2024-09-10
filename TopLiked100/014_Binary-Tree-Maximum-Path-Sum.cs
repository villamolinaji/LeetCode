namespace TopLiked100
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

	public class Solution014
	{
		private int maxSum = int.MinValue;

		public int MaxPathSum(TreeNode root)
		{
			MaxPathRecursive(root);

			return maxSum;
		}

		private int MaxPathRecursive(TreeNode? node)
		{
			if (node == null)
			{
				return 0;
			}

			var leftMax = Math.Max(MaxPathRecursive(node.left), 0);
			var rightMax = Math.Max(MaxPathRecursive(node.right), 0);

			var currentMaxPath = node.val + leftMax + rightMax;

			maxSum = Math.Max(maxSum, currentMaxPath);

			return node.val + Math.Max(leftMax, rightMax);
		}
	}
}
