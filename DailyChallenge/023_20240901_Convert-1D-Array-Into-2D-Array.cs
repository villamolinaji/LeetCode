namespace DailyChallenge
{
	public class Solution023
	{
		public int[][] Construct2DArray(int[] original, int m, int n)
		{
			if (original.Length != m * n)
			{
				return new int[0][];
			}

			var result = new int[m][];
			var colIndex = 0;
			var rowIndex = 0;

			for (int i = 0; i < original.Length; i++)
			{
				if (colIndex == 0)
				{
					result[rowIndex] = new int[n];
				}

				result[rowIndex][colIndex] = original[i];

				colIndex++;

				if (colIndex == n)
				{
					colIndex = 0;
					rowIndex++;
				}
			}

			return result;
		}
	}
}
