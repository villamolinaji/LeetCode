namespace GraphTheory
{
	public class Solution23
	{
		public int FindJudge(int n, int[][] trust)
		{
			if (n == 1 &&
				trust.Length == 0)
			{
				return 1;
			}

			int[] trusts = new int[n + 1];
			int[] trustedBy = new int[n + 1];

			foreach (var relation in trust)
			{
				int a = relation[0];
				int b = relation[1];

				trusts[a]++;
				trustedBy[b]++;
			}

			for (int i = 1; i <= n; i++)
			{
				if (trusts[i] == 0 &&
					trustedBy[i] == n - 1)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
