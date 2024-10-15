namespace DynamicProgramming
{
	public class Solution33
	{
		public int NumTrees(int n)
		{
			int[] dp = new int[n + 1];

			dp[0] = 1;
			dp[1] = 1;

			for (int nodes = 2; nodes <= n; nodes++)
			{
				int totalTrees = 0;

				for (int root = 1; root <= nodes; root++)
				{
					int leftSubtrees = dp[root - 1];

					int rightSubtrees = dp[nodes - root];

					totalTrees += leftSubtrees * rightSubtrees;
				}

				dp[nodes] = totalTrees;
			}

			return dp[n];
		}
	}
}
