namespace GraphTheory
{
	public class Solution34
	{
		public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
		{
			int groupId = m;
			for (int i = 0; i < n; i++)
			{
				if (group[i] == -1)
				{
					group[i] = groupId;
					groupId++;
				}
			}

			Dictionary<int, List<int>> itemGraph = new Dictionary<int, List<int>>();
			int[] itemIndegree = new int[n];
			for (int i = 0; i < n; ++i)
			{
				itemGraph[i] = new List<int>();
			}

			Dictionary<int, List<int>> groupGraph = new Dictionary<int, List<int>>();
			int[] groupIndegree = new int[groupId];
			for (int i = 0; i < groupId; ++i)
			{
				groupGraph[i] = new List<int>();
			}

			for (int curr = 0; curr < n; curr++)
			{
				foreach (int prev in beforeItems[curr])
				{
					itemGraph[prev].Add(curr);
					itemIndegree[curr]++;

					if (group[curr] != group[prev])
					{
						groupGraph[group[prev]].Add(group[curr]);
						groupIndegree[group[curr]]++;
					}
				}
			}

			List<int> itemOrder = TopologicalSort(itemGraph, itemIndegree);
			List<int> groupOrder = TopologicalSort(groupGraph, groupIndegree);

			if (itemOrder.Count == 0 ||
				groupOrder.Count == 0)
			{
				return new int[0];
			}

			Dictionary<int, List<int>> orderedGroups = new Dictionary<int, List<int>>();
			foreach (int item in itemOrder)
			{
				orderedGroups.TryAdd(group[item], new List<int>());
				orderedGroups[group[item]].Add(item);
			}

			List<int> answerList = new List<int>();
			foreach (var groupIndex in from int groupIndex in groupOrder
									   where orderedGroups.ContainsKey(groupIndex)
									   select groupIndex)
			{
				answerList.AddRange(orderedGroups[groupIndex]);
			}

			return answerList.ToArray();
		}

		private static List<int> TopologicalSort(Dictionary<int, List<int>> graph, int[] indegree)
		{
			List<int> visited = new List<int>();
			Stack<int> stack = new Stack<int>();

			for (int key = 0; key < graph.Count; key++)
			{
				if (indegree[key] == 0)
				{
					stack.Push(key);
				}
			}

			while (stack.Count > 0)
			{
				int curr = stack.Pop();
				visited.Add(curr);

				foreach (int prev in graph[curr])
				{
					indegree[prev]--;

					if (indegree[prev] == 0)
					{
						stack.Push(prev);
					}
				}
			}

			return visited.Count == graph.Count ? visited : new List<int>();
		}
	}
}
