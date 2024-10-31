namespace GraphTheory
{
	public class TreeNode
	{
		public int val { get; set; }
		public TreeNode? left { get; set; }
		public TreeNode? right { get; set; }
		public TreeNode(int x) { val = x; }
	}

	public class Solution16
	{
		private Dictionary<TreeNode, List<TreeNode>> graph = new Dictionary<TreeNode, List<TreeNode>>();

		public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
		{
			BuildGraph(root, null);

			var queue = new Queue<TreeNode>();
			var visited = new HashSet<TreeNode>();

			queue.Enqueue(target);
			visited.Add(target);

			int currentDistance = 0;

			while (queue.Count > 0)
			{
				if (currentDistance == K)
				{
					break;
				}

				currentDistance++;

				int size = queue.Count;
				for (int i = 0; i < size; i++)
				{
					var node = queue.Dequeue();
					foreach (var neighbor in graph[node])
					{
						if (!visited.Contains(neighbor))
						{
							visited.Add(neighbor);
							queue.Enqueue(neighbor);
						}
					}
				}
			}

			var result = new List<int>();
			while (queue.Count > 0)
			{
				result.Add(queue.Dequeue().val);
			}

			return result;
		}

		private void BuildGraph(TreeNode? node, TreeNode? parent)
		{
			if (node == null)
			{
				return;
			}

			if (!graph.ContainsKey(node))
			{
				graph[node] = new List<TreeNode>();

				if (parent != null)
				{
					graph[node].Add(parent);
					graph[parent].Add(node);
				}

				BuildGraph(node.left, node);
				BuildGraph(node.right, node);
			}
		}
	}
}
