namespace LeetCode75
{
	public class Solution44
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public int FindCircleNum(int[][] isConnected)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			int sConnectedLength = isConnected.Length;
			bool[] visited = new bool[sConnectedLength];
			int provinceCount = 0;

			for (int i = 0; i < sConnectedLength; i++)
			{
				if (!visited[i])
				{
					DFS(isConnected, visited, i);
					provinceCount++;
				}
			}

			return provinceCount;
		}

		private void DFS(int[][] isConnected, bool[] visited, int i)
		{
			visited[i] = true;

			for (int j = 0; j < isConnected.Length; j++)
			{
				if (isConnected[i][j] == 1 && !visited[j])
				{
					DFS(isConnected, visited, j);
				}
			}
		}
	}
}
