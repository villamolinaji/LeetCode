namespace TopInterview150
{
	public class Solution051
	{
		public int FindMinArrowShots(int[][] points)
		{
			int countShots = 0;
			var sortedPointsList = points.OrderBy(p => p[1]).ToList();
			int index = 0;

			while (index < sortedPointsList.Count)
			{
				int currentEnd = sortedPointsList[index][1];

				while (index < sortedPointsList.Count - 1 && sortedPointsList[index + 1][0] <= currentEnd)
				{
					index++;
				}

				countShots++;
				index++;
			}

			return countShots;
		}
	}
}
