namespace LeetCode75
{
	public class Solution72
	{
		public int EraseOverlapIntervals(int[][] intervals)
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
