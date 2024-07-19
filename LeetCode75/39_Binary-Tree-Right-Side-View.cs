namespace LeetCode75
{
	public class Solution39
	{
		public Dictionary<int, List<TreeNode>> Levels { get; set; }

		public Solution39()
		{
			Levels = new Dictionary<int, List<TreeNode>>();
		}

		public IList<int> RightSideView(TreeNode root)
		{
			var rightNodes = new List<int>();

			int depth = IterateGraph(root, 0);

			for (int i = 0; i < depth; i++)
			{
				rightNodes.Add(Levels[i][Levels[i].Count - 1].val);
			}

			return rightNodes;
		}

		private int IterateGraph(TreeNode? node, int depth)
		{
			if (node == null)
			{
				return depth;
			}

			if (Levels.TryGetValue(depth, out var nodes))
			{
				nodes.Add(node);
			}
			else
			{
				Levels[depth] = [node];
			}

			int leftDepth = IterateGraph(node.left, depth + 1);
			int rightDepth = IterateGraph(node.right, depth + 1);

			return Math.Max(leftDepth, rightDepth);
		}
	}
}
