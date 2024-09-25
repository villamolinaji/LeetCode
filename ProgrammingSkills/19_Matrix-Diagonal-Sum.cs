namespace ProgrammingSkills
{
	public class Solution19
	{
		public int DiagonalSum(int[][] mat)
		{
			int sum = 0;

			for (int i = 0; i < mat.Length; i++)
			{
				sum += mat[i][i];
				if (i != mat.Length - i - 1)
				{
					sum += mat[i][mat.Length - i - 1];
				}
			}


			return sum;
		}
	}
}
