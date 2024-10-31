namespace GraphTheory
{
	public class Solution25
	{
		public int MaximalNetworkRank(int n, int[][] roads)
		{
			int[] degree = new int[n];
			var directConnections = new HashSet<(int, int)>();

			foreach (var road in roads)
			{
				int u = road[0];
				int v = road[1];

				degree[u]++;
				degree[v]++;

				directConnections.Add((Math.Min(u, v), Math.Max(u, v)));
			}

			int maxRank = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					int currentRank = degree[i] + degree[j];

					if (directConnections.Contains((i, j)))
					{
						currentRank--;
					}

					maxRank = Math.Max(maxRank, currentRank);
				}
			}

			return maxRank;
		}
	}
}
