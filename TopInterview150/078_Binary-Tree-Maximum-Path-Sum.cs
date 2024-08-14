namespace TopInterview150
{
	public class Solution078
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
