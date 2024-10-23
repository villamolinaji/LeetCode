namespace BinarySearch
{
	public class Solution21
	{
		public int HIndex(int[] citations)
		{
			int citationsLength = citations.Length;
			int left = 0;
			int right = citationsLength - 1;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;

				if (citations[mid] == citationsLength - mid)
				{
					return citationsLength - mid;
				}
				else if (citations[mid] < citationsLength - mid)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return citationsLength - left;
		}
	}
}
