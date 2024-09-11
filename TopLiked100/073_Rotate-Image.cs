namespace TopLiked100
{
	public class Solution073
	{
		public void Rotate(int[][] matrix)
		{
			int matrixLength = matrix.Length;

			for (int i = 0; i < matrixLength; i++)
			{
				for (int j = i; j < matrixLength; j++)
				{
					int temp = matrix[i][j];
					matrix[i][j] = matrix[j][i];
					matrix[j][i] = temp;
				}
			}

			for (int i = 0; i < matrixLength; i++)
			{
				Array.Reverse(matrix[i]);
			}
		}
	}
}
