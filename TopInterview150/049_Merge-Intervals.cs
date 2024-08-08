namespace TopInterview150
{
	public class Solution049
	{
		public int[][] Merge(int[][] intervals)
		{
			Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

			List<int[]> merged = new List<int[]>();

			int[] currentInterval = intervals[0];
			merged.Add(currentInterval);

			foreach (var interval in intervals)
			{
				int currentEnd = currentInterval[1];
				int nextStart = interval[0];
				int nextEnd = interval[1];

				if (currentEnd >= nextStart)
				{
					currentInterval[1] = Math.Max(currentEnd, nextEnd);
				}
				else
				{
					currentInterval = interval;
					merged.Add(currentInterval);
				}
			}

			return merged.ToArray();
		}
	}
}
