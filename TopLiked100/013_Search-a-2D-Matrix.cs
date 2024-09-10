namespace TopLiked100
{
	public class Solution013
	{
		public bool SearchMatrix(int[][] matrix, int target)
		{
			return SearchBinaryMatrix(matrix, target, matrix.Length - 1, 0);
		}

		private bool SearchBinaryMatrix(int[][] matrix, int target, int row, int col)
		{
			if (row < 0 || col >= matrix[0].Length)
			{
				return false;
			}

			if (matrix[row][col] == target)
			{
				return true;
			}
			else if (matrix[row][col] < target)
			{
				return SearchBinaryMatrix(matrix, target, row, col + 1);
			}
			else
			{
				return SearchBinaryMatrix(matrix, target, row - 1, col);
			}
		}
	}
}
