namespace TopInterview150
{
	public class Solution086
	{
		private int minDiff = int.MaxValue;
		private int? previousValue = null;

		public int GetMinimumDifference(TreeNode root)
		{
			InOrderTraversal(root);

			return minDiff;
		}

		private void InOrderTraversal(TreeNode? node)
		{
			if (node == null)
			{
				return;
			}

			InOrderTraversal(node.left);

			if (previousValue != null)
			{
				minDiff = Math.Min(minDiff, node.val - previousValue.Value);
			}
			previousValue = node.val;

			InOrderTraversal(node.right);
		}
	}
}
