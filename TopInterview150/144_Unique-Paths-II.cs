namespace TopInterview150
{
	public class Solution144
	{
		public int UniquePathsWithObstacles(int[][] obstacleGrid)
		{
			var rows = obstacleGrid.Length;
			var cols = obstacleGrid[0].Length;

			if (obstacleGrid[0][0] == 1)
			{
				return 0;
			}

			obstacleGrid[0][0] = 1;

			for (int i = 1; i < rows; i++)
			{
				obstacleGrid[i][0] = (obstacleGrid[i][0] == 0 && obstacleGrid[i - 1][0] == 1) ? 1 : 0;
			}

			for (int j = 1; j < cols; j++)
			{
				obstacleGrid[0][j] = (obstacleGrid[0][j] == 0 && obstacleGrid[0][j - 1] == 1) ? 1 : 0;
			}

			for (int i = 1; i < rows; i++)
			{
				for (int j = 1; j < cols; j++)
				{
					if (obstacleGrid[i][j] == 0)
					{
						obstacleGrid[i][j] = obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1];
					}
					else
					{
						obstacleGrid[i][j] = 0;
					}
				}
			}

			return obstacleGrid[rows - 1][cols - 1];
		}
	}
}
