namespace GraphTheory
{
	public class Solution07
	{
		public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
		{
			List<IList<int>> result = new List<IList<int>>();
			List<int> path = new List<int>();

			DFS(graph, 0, path, result);

			return result;
		}

		private void DFS(int[][] graph, int node, List<int> path, List<IList<int>> result)
		{
			path.Add(node);

			if (node == graph.Length - 1)
			{
				result.Add(new List<int>(path));
			}
			else
			{
				foreach (int neighbor in graph[node])
				{
					DFS(graph, neighbor, path, result);
				}
			}

			path.RemoveAt(path.Count - 1);
		}
	}
}
