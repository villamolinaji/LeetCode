namespace ProgrammingSkills
{
	public class Solution26
	{
		public bool CheckStraightLine(int[][] coordinates)
		{
			var isStraightLine = true;

			for (int i = 2; i < coordinates.Length; i++)
			{
				if ((coordinates[i][1] - coordinates[i - 1][1]) * (coordinates[i - 1][0] - coordinates[i - 2][0]) !=
					(coordinates[i - 1][1] - coordinates[i - 2][1]) * (coordinates[i][0] - coordinates[i - 1][0]))
				{
					isStraightLine = false;
					break;
				}
			}

			return isStraightLine;
		}
	}
}
