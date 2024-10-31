namespace GraphTheory
{
	public class Solution28
	{
		public bool EquationsPossible(string[] equations)
		{
			int[] parent = new int[26];
			for (int i = 0; i < 26; i++)
			{
				parent[i] = i;
			}

			foreach (var eq in equations)
			{
				if (eq[1] == '=')
				{
					Union(eq[0] - 'a', eq[3] - 'a', parent);
				}
			}

			foreach (var eq in equations)
			{
				if (eq[1] == '!' &&
					Find(eq[0] - 'a', parent) == Find(eq[3] - 'a', parent))
				{
					return false;
				}
			}

			return true;
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
			parent[Find(x, parent)] = Find(y, parent);
		}
	}
}
