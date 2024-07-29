﻿namespace LeetCode75
{
	public class Solution73
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public int FindMinArrowShots(int[][] points)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
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