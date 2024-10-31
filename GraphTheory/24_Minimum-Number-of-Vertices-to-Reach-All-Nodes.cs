namespace GraphTheory
{
	public class Solution24
	{
		public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
		{
			int[] indegree = new int[n];

			foreach (var edge in edges)
			{
				int to = edge[1];
				indegree[to]++;
			}

			var result = new List<int>();
			for (int i = 0; i < n; i++)
			{
				if (indegree[i] == 0)
				{
					result.Add(i);
				}
			}

			return result;
		}
	}
}
