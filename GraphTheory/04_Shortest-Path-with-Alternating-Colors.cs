namespace GraphTheory
{
	public class Solution04
	{
		public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
		{
			var redGraph = new List<int>[n];
			var blueGraph = new List<int>[n];

			for (int i = 0; i < n; i++)
			{
				redGraph[i] = new List<int>();
				blueGraph[i] = new List<int>();
			}

			foreach (var edge in redEdges)
			{
				redGraph[edge[0]].Add(edge[1]);
			}

			foreach (var edge in blueEdges)
			{
				blueGraph[edge[0]].Add(edge[1]);
			}

			var result = new int[n];
			Array.Fill(result, -1);

			var visited = new bool[n, 2];
			var queue = new Queue<(int node, int distance, int color)>();

			queue.Enqueue((0, 0, 0));
			queue.Enqueue((0, 0, 1));

			visited[0, 0] = true;
			visited[0, 1] = true;

			result[0] = 0;

			while (queue.Count > 0)
			{
				var (node, distance, color) = queue.Dequeue();
				var nextColor = 1 - color;
				var neighbors = color == 0
					? blueGraph[node]
					: redGraph[node];

				foreach (int neighbor in neighbors)
				{
					if (!visited[neighbor, nextColor])
					{
						visited[neighbor, nextColor] = true;
						queue.Enqueue((neighbor, distance + 1, nextColor));

						if (result[neighbor] == -1)
						{
							result[neighbor] = distance + 1;
						}
					}
				}
			}

			return result;
		}
	}
}
