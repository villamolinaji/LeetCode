namespace LeetCode75
{
	public class Solution72
	{
#pragma warning disable S2368 // Public methods should not have multidimensional array parameters
		public int EraseOverlapIntervals(int[][] intervals)
#pragma warning restore S2368 // Public methods should not have multidimensional array parameters
		{
			Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

			int countNonOverlapping = 0;
			int lastEndTime = intervals[0][1];

			for (int i = 1; i < intervals.Length; i++)
			{
				if (intervals[i][0] < lastEndTime)
				{
					countNonOverlapping++;
				}
				else
				{
					lastEndTime = intervals[i][1];
				}
			}

			return countNonOverlapping;
		}
	}
}
