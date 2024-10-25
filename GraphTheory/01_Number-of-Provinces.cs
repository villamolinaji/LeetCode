namespace GraphTheory
{
	public class Solution01
	{
		public int FindCircleNum(int[][] isConnected)
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
