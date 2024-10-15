namespace DynamicProgramming
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

	public class Solution34
	{
		public IList<TreeNode?> GenerateTrees(int n)
		{
			return GenerateTreesHelper(1, n);
		}

		private static IList<TreeNode?> GenerateTreesHelper(int start, int end)
		{
			var result = new List<TreeNode?>();

			if (start > end)
			{
				result.Add(null);

				return result;
			}

			for (int i = start; i <= end; i++)
			{
				var leftSubtrees = GenerateTreesHelper(start, i - 1);

				var rightSubtrees = GenerateTreesHelper(i + 1, end);

				foreach (var left in leftSubtrees)
				{
					foreach (var right in rightSubtrees)
					{
						TreeNode root = new TreeNode(i);
						root.left = left;
						root.right = right;

						result.Add(root);
					}
				}
			}

			return result;
		}
	}
}
