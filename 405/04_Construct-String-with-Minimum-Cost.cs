namespace _405
{
	public class Solution04
	{
		class Node
		{
			public bool isLast = false;
			public int cost = int.MaxValue;
			readonly Node[] sub = new Node[26];

#pragma warning disable S1144 // Unused private types or members should be removed
			public Node this[char c]
#pragma warning restore S1144 // Unused private types or members should be removed
			{
				get { return sub[c - 'a']; }
				set { sub[c - 'a'] = value; }
			}
		}
		class Trie
		{
			public Node node = new();

			public void Add(string s, int cost)
			{
				Node n = node;
				foreach (var c in s)
				{
					if (n[c] == null)
					{
						n[c] = new();
					}

					n = n[c];
				}
				n.isLast = true;
				if (cost < n.cost)
				{
					n.cost = cost;
				}
			}

			public IEnumerable<(int, int)> MatchFrom(string s, int startIndex = 0)
			{
				Node n = node;
				for (int i = startIndex; i < s.Length; i++)
				{
					n = n[s[i]];
					if (n == null)
					{
						break;
					}

					if (n.isLast)
					{ 
						yield return (i - startIndex + 1, n.cost);
					}
				}
			}
		}

		public int MinimumCost(string target, string[] words, int[] costs)
		{
			int n = target.Length;
			int unknown = -2;
			

			Trie trie = new();
			for (int i = 0; i < words.Length; i++)
			{
				trie.Add(words[i], costs[i]);
			}

			int[] memo = new int[n];
			Array.Fill(memo, unknown);

			return MinCostFrom(0, memo, trie, target, costs);			
		}

		private int MinCostFrom(int idx, int[] memo, Trie trie, string target, int[] costs)
		{
			int unreachable = -1;
			int unknown = -2;
			int n = target.Length;

			if (idx > n)
			{
				return unreachable;
			}

			if (idx == n)
			{
				return 0;
			}

			if (memo[idx] != unknown)
			{
				return memo[idx];
			}

			int min = int.MaxValue;
			foreach (var (len, cost) in trie.MatchFrom(target, idx))
			{
				var after = MinCostFrom(idx + len, memo, trie, target, costs);
				if (after != unreachable)
				{
					min = Math.Min(min, cost + after);
				}
			}

			int minCost = min == int.MaxValue ? unreachable : min;
			memo[idx] = minCost;

			return minCost;
		}
	}
}