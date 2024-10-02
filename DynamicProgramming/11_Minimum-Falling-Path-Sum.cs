namespace DynamicProgramming
{
	public class Solution11
	{
		public int MinFallingPathSum(int[][] matrix)
		{
			int matrixLength = matrix.Length;

			for (int i = matrixLength - 2; i >= 0; i--)
			{
				for (int j = 0; j < matrixLength; j++)
				{
					int down = matrix[i + 1][j];
					int downLeft = j > 0
						? matrix[i + 1][j - 1]
						: int.MaxValue;
					int downRight = j < matrixLength - 1
						? matrix[i + 1][j + 1]
						: int.MaxValue;

					matrix[i][j] += Math.Min(down, Math.Min(downLeft, downRight));
				}
			}

			return matrix[0].Min();
		}
	}
}
