namespace GraphTheory
{
	public class Solution05
	{
		public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
		{
			var subordinates = new List<int>[n];
			for (int i = 0; i < n; i++)
			{
				subordinates[i] = new List<int>();
			}

			for (int i = 0; i < n; i++)
			{
				if (manager[i] != -1)
				{
					subordinates[manager[i]].Add(i);
				}
			}

			return DFS(headID, informTime, subordinates);
		}

		private static int DFS(int employeeId, int[] informTime, List<int>[] subordinates)
		{
			if (informTime[employeeId] == 0)
			{
				return 0;
			}

			int maxTime = 0;
			foreach (int subordinate in subordinates[employeeId])
			{
				maxTime = Math.Max(maxTime, DFS(subordinate, informTime, subordinates));
			}

			return informTime[employeeId] + maxTime;
		}
	}
}
