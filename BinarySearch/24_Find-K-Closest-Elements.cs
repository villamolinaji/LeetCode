namespace BinarySearch
{
	public class Solution24
	{
		public IList<int> FindClosestElements(int[] arr, int k, int x)
		{
			int left = 0;
			int right = arr.Length - k;

			while (left < right)
			{
				int mid = left + (right - left) / 2;

				if (x - arr[mid] > arr[mid + k] - x)
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}

			return arr
				.Skip(left)
				.Take(k)
				.ToList();
		}
	}
}
