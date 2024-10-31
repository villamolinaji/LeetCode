namespace GraphTheory
{
	public class Solution27
	{
		public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
		{
			var n = accounts.Count;

			var union = new DisjointSet(n);
			var map = new Dictionary<string, int>();

			for (int i = 0; i < n; i++)
			{
				for (int j = 1; j < accounts[i].Count; j++)
				{
					var account = accounts[i][j];

					if (map.ContainsKey(account) && accounts[map[account]][0] == accounts[i][0])
					{
						union.Union(i, map[account]);
					}
					else
					{
						map.Add(account, i);
					}
				}
			}

			var result = new Dictionary<int, HashSet<string>>();

			for (int i = 0; i < n; i++)
			{
				var parent = union.Find(i);

				result.TryAdd(parent, new());

				for (int j = 1; j < accounts[parent].Count; j++)
				{
					result[parent].Add(accounts[parent][j]);
				}

				for (int j = 1; j < accounts[i].Count; j++)
				{
					result[parent].Add(accounts[i][j]);
				}
			}

			return result
				.Select(x =>
				{
					var list = new List<string>();

					list.AddRange(x.Value);
					list.Sort(StringComparer.Ordinal);

					list.Insert(0, accounts[x.Key][0]);

					return (IList<string>)list;
				})
				.ToList();
		}
	}

	public class DisjointSet
	{
		private readonly int[] _nodes;
		private readonly int[] _weights;

		public DisjointSet(int n)
		{
			_nodes = new int[n];
			_weights = new int[n];

			for (int i = 0; i < n; i++)
			{
				_nodes[i] = i;
				_weights[i] = 1;
			}
		}

		public int Find(int a)
		{
			a = _nodes[a];

			while (a != _nodes[a])
			{
				a = _nodes[a] = _nodes[_nodes[a]];
			}

			return a;
		}

		public void Union(int a, int b)
		{
			a = Find(a);
			b = Find(b);

			if (a == b)
			{
				return;
			}

			if (_weights[a] < _weights[b])
			{
				_nodes[a] = b;
				_weights[b] += _weights[a];
			}
			else
			{
				_nodes[b] = a;
				_weights[a] += _weights[b];
			}
		}
	}
}
