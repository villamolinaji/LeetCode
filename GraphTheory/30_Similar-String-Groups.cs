namespace GraphTheory
{
	public class Solution30
	{
		public int NumSimilarGroups(string[] strs)
		{
			int strsLegnth = strs.Length;
			bool[] visited = new bool[strsLegnth];
			int groupCount = 0;

			for (int i = 0; i < strsLegnth; i++)
			{
				if (!visited[i])
				{
					groupCount++;

					DFS(i, visited, strsLegnth, strs);
				}
			}

			return groupCount;
		}

		private static bool AreSimilar(string s1, string s2)
		{
			int count = 0;
			for (int i = 0; i < s1.Length; i++)
			{
				if (s1[i] != s2[i])
				{
					count++;

					if (count > 2)
					{
						return false;
					}
				}
			}
			return count == 0 ||
				count == 2;
		}

		private void DFS(int index, bool[] visited, int strsLegnth, string[] strs)
		{
			visited[index] = true;
			for (int i = 0; i < strsLegnth; i++)
			{
				if (!visited[i] && AreSimilar(strs[index], strs[i]))
				{
					DFS(i, visited, strsLegnth, strs);
				}
			}
		}
	}
}
