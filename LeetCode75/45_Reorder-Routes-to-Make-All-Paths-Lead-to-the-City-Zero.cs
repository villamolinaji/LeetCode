namespace LeetCode75
{
	public class Solution45
	{
		public int MinReorder(int n, int[][] connections)
		{
			List<List<(int, int)>> graph = new List<List<(int, int)>>();
			for (int i = 0; i < n; i++)
			{
				graph.Add(new List<(int, int)>());
			}

			foreach (var connection in connections)
			{
				int from = connection[0];
				int to = connection[1];
				graph[from].Add((to, 1));
				graph[to].Add((from, 0));
			}

			bool[] visited = new bool[n];

			return DFS(0, graph, visited);
		}

		private int DFS(int node, List<List<(int, int)>> graph, bool[] visited)
		{
			visited[node] = true;
			int reorderCount = 0;

			foreach (var (adjNode, direction) in graph[node])
			{
				if (!visited[adjNode])
				{
					reorderCount += direction;

					reorderCount += DFS(adjNode, graph, visited);
				}
			}

			return reorderCount;
		}
	}
}
