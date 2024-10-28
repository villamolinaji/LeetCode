namespace GraphTheory
{
	public class Solution02
	{
		public IList<int> EventualSafeNodes(int[][] graph)
		{
			int graphLenght = graph.Length;

			List<int>[] reversedGraph = new List<int>[graphLenght];
			int[] indegree = new int[graphLenght];

			for (int i = 0; i < graphLenght; i++)
			{
				reversedGraph[i] = new List<int>();
			}

			for (int i = 0; i < graphLenght; i++)
			{
				foreach (int j in graph[i])
				{
					reversedGraph[j].Add(i);
					indegree[i]++;
				}
			}

			Queue<int> queue = new Queue<int>();

			for (int i = 0; i < graphLenght; i++)
			{
				if (indegree[i] == 0)
				{
					queue.Enqueue(i);
				}
			}

			bool[] safe = new bool[graphLenght];

			while (queue.Count > 0)
			{
				int node = queue.Dequeue();
				safe[node] = true;

				foreach (int neighbor in reversedGraph[node])
				{
					indegree[neighbor]--;
					if (indegree[neighbor] == 0)
					{
						queue.Enqueue(neighbor);
					}
				}
			}

			List<int> result = new List<int>();

			for (int i = 0; i < graphLenght; i++)
			{
				if (safe[i])
				{
					result.Add(i);
				}
			}

			result.Sort();
			return result;
		}
	}
}
