namespace TopInterview150
{
	public class Solution083
	{
		public IList<double> AverageOfLevels(TreeNode root)
		{
			var levels = new List<List<double>>();

			IterateGraph(root, 0, levels);

			var averages = new List<double>();
			foreach (var level in levels)
			{
				averages.Add(level.Average());
			}

			return averages;
		}

		private void IterateGraph(TreeNode? node, int depth, List<List<double>> levels)
		{
			if (node == null)
			{
				return;
			}

			if (levels.Count <= depth)
			{
				levels.Add(new List<double>());
			}

			levels[depth].Add(node.val);

			IterateGraph(node.left, depth + 1, levels);
			IterateGraph(node.right, depth + 1, levels);
		}
	}
}
