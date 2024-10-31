namespace GraphTheory
{
	public class Solution29
	{
		public string SmallestEquivalentString(string s1, string s2, string baseStr)
		{
			int[] parent = new int[26];

			for (int i = 0; i < 26; i++)
			{
				parent[i] = i;
			}

			for (int i = 0; i < s1.Length; i++)
			{
				Union(s1[i] - 'a', s2[i] - 'a', parent);
			}

			char[] smallestChars = new char[26];
			for (int i = 0; i < 26; i++)
			{
				smallestChars[i] = (char)(Find(i, parent) + 'a');
			}

			char[] result = new char[baseStr.Length];
			for (int i = 0; i < baseStr.Length; i++)
			{
				result[i] = smallestChars[baseStr[i] - 'a'];
			}

			return new string(result);
		}

		private static int Find(int x, int[] parent)
		{
			if (parent[x] != x)
			{
				parent[x] = Find(parent[x], parent);
			}
			return parent[x];
		}

		private static void Union(int x, int y, int[] parent)
		{
			int rootX = Find(x, parent);
			int rootY = Find(y, parent);

			if (rootX != rootY)
			{
				parent[Math.Max(rootX, rootY)] = Math.Min(rootX, rootY);
			}
		}
	}
}
