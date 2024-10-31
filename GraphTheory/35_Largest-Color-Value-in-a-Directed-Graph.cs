namespace GraphTheory
{
	public class Solution35
	{
		public int LargestPathValue(string colors, int[][] edges)
		{
			int colorsLength = colors.Length;
			int k = 26;
			int[] indegrees = new int[colorsLength];
			List<int>[] graph = new List<int>[colorsLength];

			for (int i = 0; i < colorsLength; i++)
			{
				graph[i] = new List<int>();
			}

			foreach (int[] edge in edges)
			{
				int u = edge[0], v = edge[1];

				graph[u].Add(v);

				indegrees[v]++;
			}

			HashSet<int> zero_indegree = new HashSet<int>();

			for (int i = 0; i < colorsLength; i++)
			{
				if (indegrees[i] == 0)
				{
					zero_indegree.Add(i);
				}
			}

			int[,] counts = new int[colorsLength, k];
			for (int i = 0; i < colorsLength; i++)
			{
				counts[i, colors[i] - 'a']++;
			}

			int max_count = 0;
			int visited = 0;

			while (zero_indegree.Count > 0)
			{
				int u = zero_indegree.First();

				zero_indegree.Remove(u);

				visited++;

				foreach (int v in graph[u])
				{
					for (int i = 0; i < k; i++)
					{
						counts[v, i] = Math.Max(counts[v, i], counts[u, i] + (colors[v] - 'a' == i ? 1 : 0));
					}

					indegrees[v]--;

					if (indegrees[v] == 0)
					{
						zero_indegree.Add(v);
					}
				}

				max_count = Math.Max(max_count, Enumerable.Range(0, k).Select(i => counts[u, i]).Max());

			}

			return visited == colorsLength ? max_count : -1;
		}
	}
}
