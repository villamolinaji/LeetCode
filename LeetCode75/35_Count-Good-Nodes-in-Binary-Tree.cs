namespace LeetCode75
{
	public class Solution35
	{
		public int GoodNodes(TreeNode root)
		{
			return CountGoodNodes(root, root.val);
		}

		private int CountGoodNodes(TreeNode? root, int currentMax)
		{
			if (root == null)
			{
				return 0;
			}

			int increment = 0;
			if (root.val >= currentMax)
			{
				currentMax = root.val;
				increment = 1;
			}

			return CountGoodNodes(root.left, currentMax) + 
				CountGoodNodes(root.right, currentMax) + 
				increment;
		}
	}
}
