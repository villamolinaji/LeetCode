namespace DynamicProgramming
{
	public class Solution41
	{
		public long MostPoints(int[][] questions)
		{
			int questionsLength = questions.Length;
			long[] dp = new long[questionsLength + 1];

			for (int i = questionsLength - 1; i >= 0; i--)
			{
				int points = questions[i][0];
				int brainpower = questions[i][1];

				long solve = points + (i + brainpower + 1 < questionsLength ? dp[i + brainpower + 1] : 0);

				long skip = dp[i + 1];

				dp[i] = Math.Max(solve, skip);
			}

			return dp[0];
		}
	}
}
