namespace TopInterview150
{
	public class Solution077
	{
		public int SumNumbers(TreeNode root)
		{
			return SumRootToLeaf(root, 0);
		}

		private int SumRootToLeaf(TreeNode? node, int currentSum)
		{
			if (node == null)
			{
				return 0;
			}

			currentSum = currentSum * 10 + node.val;

			if (node.left == null &&
				node.right == null)
			{
				return currentSum;
			}

			int leftSum = SumRootToLeaf(node.left, currentSum);
			int rightSum = SumRootToLeaf(node.right, currentSum);

			return leftSum + rightSum;
		}
	}
}
