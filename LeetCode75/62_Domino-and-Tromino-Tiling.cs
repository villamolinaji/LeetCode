namespace LeetCode75
{
	public class Solution62
	{
		public int NumTilings(int n)
		{
			int MOD = 1000000007;

			var dpr = new long[n + 1];
			var dpu = new long[n + 1];
			var dpd = new long[n + 1];
			dpr[0] = 1;
			dpr[1] = 1;

			for (int i = 2; i <= n; i++)
			{
				dpu[i] = (dpd[i - 1] + dpr[i - 2]) % MOD;
				dpd[i] = (dpu[i - 1] + dpr[i - 2]) % MOD;
				dpr[i] = (dpr[i - 1] + dpr[i - 2] + dpu[i - 1] + dpd[i - 1]) % MOD;
			}

			return (int)dpr[n];
		}
	}
}
