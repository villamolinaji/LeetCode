namespace LeetCode75
{
	public class Solution37
	{
		public int LongestZigZag(TreeNode root)
		{
			return CountZigZag(root, 0, 0, 0);
		}

		private int CountZigZag(TreeNode? root, int currentMax, int maxZigZag, int prevDirection)
		{
			if (root == null)
			{
				return Math.Max(currentMax, maxZigZag);
			}

			int currentMaxLeft = currentMax;
			int currentMaxRight = currentMax;

			if (prevDirection == -1)
			{				
				currentMaxLeft = 0;				
			}
			else if (prevDirection == 1)
			{
				currentMaxRight = 0;				
			}

			if (root.left is not null)
			{
				currentMaxLeft++;
			}
			if (root.right is not null)
			{
				currentMaxRight++;
			}

			maxZigZag = Math.Max(maxZigZag, Math.Max(currentMaxLeft, currentMaxRight));

			return Math.Max(
				CountZigZag(root.left, currentMaxLeft, maxZigZag, -1),
				CountZigZag(root.right, currentMaxRight, maxZigZag, 1));			
		}
	}
}
