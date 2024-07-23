namespace LeetCode75
{
	public class Solution46
	{
		public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
		{
			Dictionary<string, List<(string, double)>> graph = new Dictionary<string, List<(string, double)>>();

			for (int i = 0; i < equations.Count; i++)
			{
				string var1 = equations[i][0];
				string var2 = equations[i][1];
				double value = values[i];

				if (!graph.ContainsKey(var1))
				{
					graph[var1] = new List<(string, double)>();
				}
				if (!graph.ContainsKey(var2))
				{
					graph[var2] = new List<(string, double)>();
				}

				graph[var1].Add((var2, value));
				graph[var2].Add((var1, 1 / value));
			}

			double[] results = new double[queries.Count];

			for (int i = 0; i < queries.Count; i++)
			{
				string start = queries[i][0];
				string end = queries[i][1];

				if (!graph.ContainsKey(start) || !graph.ContainsKey(end))
				{
					results[i] = -1.0;
				}
				else
				{
					HashSet<string> visited = new HashSet<string>();
					results[i] = DFS(graph, start, end, visited, 1.0);
				}
			}

			return results;
		}

		private double DFS(
			Dictionary<string, List<(string, double)>> graph,
			string current,
			string target,
			HashSet<string> visited,
			double currentProduct)
		{
			if (current == target)
			{
				return currentProduct;
			}

			visited.Add(current);

			foreach (var (neighbor, value) in graph[current])
			{
				if (!visited.Contains(neighbor))
				{
					double result = DFS(graph, neighbor, target, visited, currentProduct * value);
#pragma warning disable S1244 // Floating point numbers should not be tested for equality
					if (result != -1.0)
					{
						return result;
					}
#pragma warning restore S1244 // Floating point numbers should not be tested for equality
				}
			}

			return -1.0;
		}
	}
}
