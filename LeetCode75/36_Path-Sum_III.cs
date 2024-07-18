namespace LeetCode75
{
	public class Solution36
	{
		public int PathSum(TreeNode root, int targetSum)
		{
			return CountSum(root, targetSum, new List<int>());
		}

		private int CountSum(TreeNode? root, int targetSum, List<int> parents)
		{
			if (root == null)
			{
				return 0;
			}

			parents.Add(root.val);

			long sum = 0;
			int increment = 0;
			for (int i = parents.Count - 1; i >= 0; i--)
			{
				sum += parents[i];
				if (sum == targetSum)
				{
					increment++;
				}
			}

			return CountSum(root.left, targetSum, new List<int>(parents)) +
				CountSum(root.right, targetSum, new List<int>(parents)) +
				increment;
		}
	}
}
