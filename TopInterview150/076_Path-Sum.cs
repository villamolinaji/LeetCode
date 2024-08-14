namespace TopInterview150
{
	public class Solution076
	{
		public bool HasPathSum(TreeNode? root, int targetSum)
		{
			if (root == null)
			{
				return false;
			}

			if (root.left == null &&
				root.right == null)
			{
				return root.val == targetSum;
			}

			var newTargetSum = targetSum - root.val;

			return HasPathSum(root.left, newTargetSum) ||
				HasPathSum(root.right, newTargetSum);
		}
	}
}
