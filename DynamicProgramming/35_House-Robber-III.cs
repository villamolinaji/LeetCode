namespace DynamicProgramming
{
	public class Solution35
	{
		public int Rob(TreeNode root)
		{
			// Start recursive helper function
			var result = RobHelper(root);

			return Math.Max(result[0], result[1]);
		}

		private static int[] RobHelper(TreeNode? node)
		{
			if (node == null)
			{
				return new int[2];
			}

			var left = RobHelper(node.left);
			var right = RobHelper(node.right);

			int[] dp = new int[2];

			dp[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);

			dp[1] = node.val + left[0] + right[0];

			return dp;
		}
	}
}
