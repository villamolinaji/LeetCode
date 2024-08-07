namespace TopInterview150
{
	public class Solution036
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public void Rotate(int[][] matrix)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
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
