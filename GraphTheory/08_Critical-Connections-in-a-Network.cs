namespace GraphTheory
{
	public class Solution08
	{
		private int Time { get; set; }
		private List<IList<int>> Bridges { get; set; }
		private int[] Discovery { get; set; }
		private int[] Low { get; set; }
		private List<int>[] Graph { get; set; }

		public Solution08()
		{
			Bridges = new List<IList<int>>();
			Discovery = new int[0];
			Low = new int[0];
			Graph = new List<int>[0];
		}

		public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
		{
			Time = 0;
			Bridges = new List<IList<int>>();
			Discovery = new int[n];
			Low = new int[n];
			Array.Fill(Discovery, -1);
			Graph = new List<int>[n];

			for (int i = 0; i < n; i++)
			{
				Graph[i] = new List<int>();
			}

			foreach (var conn in connections)
			{
				int u = conn[0];
				int v = conn[1];

				Graph[u].Add(v);
				Graph[v].Add(u);
			}

			for (int i = 0; i < n; i++)
			{
				if (Discovery[i] == -1)
				{
					DFS(i, -1);
				}
			}

			return Bridges;
		}

		private void DFS(int u, int parent)
		{
			Discovery[u] = Low[u] = Time++;

			foreach (int v in Graph[u])
			{
				if (v == parent)
				{
					continue;
				}

				if (Discovery[v] == -1)
				{
					DFS(v, u);

					Low[u] = Math.Min(Low[u], Low[v]);

					if (Low[v] > Discovery[u])
					{
						Bridges.Add(new List<int> { u, v });
					}
				}
				else
				{
					Low[u] = Math.Min(Low[u], Discovery[v]);
				}
			}
		}
	}
}
