namespace GraphTheory
{
	public class Solution26
	{
		public bool IsBipartite(int[][] graph)
		{
			int n = graph.Length;
			int[] colors = new int[n];

			for (int i = 0; i < n; i++)
			{
				if (colors[i] == 0)
				{
					var queue = new Queue<int>();
					queue.Enqueue(i);

					colors[i] = 1;

					while (queue.Count > 0)
					{
						int node = queue.Dequeue();

						foreach (int neighbor in graph[node])
						{
							if (colors[neighbor] == 0)
							{
								colors[neighbor] = -colors[node];

								queue.Enqueue(neighbor);
							}
							else if (colors[neighbor] == colors[node])
							{
								return false;
							}
						}
					}
				}
			}

			return true;
		}
	}
}
