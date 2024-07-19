namespace LeetCode75
{
	public class Solution40
	{
		public Dictionary<int, List<TreeNode>> Levels { get; set; }

		public Solution40()
		{
			Levels = new Dictionary<int, List<TreeNode>>();
		}

		public int MaxLevelSum(TreeNode root)
		{
			IterateGraph(root, 1);

			var sumLevels = new Dictionary<int, int>();

			foreach (var level in Levels)
			{
				int sum = 0;

				foreach (var node in level.Value)
				{
					sum += node.val;
				}

				sumLevels.Add(level.Key, sum);
			}

			return sumLevels.OrderByDescending(l => l.Value).First().Key;
		}

		private void IterateGraph(TreeNode? node, int depth)
		{
			if (node == null)
			{
				return;
			}

			if (Levels.TryGetValue(depth, out var nodes))
			{
				nodes.Add(node);
			}
			else
			{
				Levels[depth] = [node];
			}

			IterateGraph(node.left, depth + 1);
			IterateGraph(node.right, depth + 1);
		}
	}
}
