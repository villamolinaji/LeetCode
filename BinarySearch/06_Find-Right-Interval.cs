namespace BinarySearch
{
	public class Solution06
	{
		public int[] FindRightInterval(int[][] intervals)
		{
			int intervalsLength = intervals.Length;

			var startIndexPairs = new List<(int start, int index)>();
			for (int i = 0; i < intervalsLength; i++)
			{
				startIndexPairs.Add((intervals[i][0], i));
			}
			startIndexPairs.Sort((a, b) => a.start.CompareTo(b.start));

			int[] result = new int[intervalsLength];

			for (int i = 0; i < intervalsLength; i++)
			{
				int end = intervals[i][1];
				int left = 0;
				int right = intervalsLength - 1;
				int foundIndex = -1;

				while (left <= right)
				{
					int mid = left + (right - left) / 2;
					if (startIndexPairs[mid].start >= end)
					{
						foundIndex = startIndexPairs[mid].index;
						right = mid - 1;
					}
					else
					{
						left = mid + 1;
					}
				}

				result[i] = foundIndex;
			}

			return result;
		}
	}
}
