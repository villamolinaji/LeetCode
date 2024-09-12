namespace TopLiked100
{
	public class Solution076
	{
		public bool SearchMatrix(int[][] matrix, int target)
		{

#pragma warning disable S125 // Sections of code should not be commented out
			//for (int i = 0; i < matrix.Length; i++)
			//{
			//	if (matrix[i].ToList().Exists(m => m == target))
			//	{
			//		return true;
			//	}
			//}

			//return false;
#pragma warning restore S125 // Sections of code should not be commented out

			var rows = matrix.Length;
			var cols = matrix[0].Length;

			int rowIndex = 0;
			int colIndex = cols - 1;

			while (rowIndex < rows &&
				colIndex >= 0)
			{
				if (matrix[rowIndex][colIndex] == target)
				{
					return true;
				}
				else if (matrix[rowIndex][colIndex] > target)
				{
					colIndex--;
				}
				else
				{
					rowIndex++;
				}
			}

			return false;
		}
	}
}
