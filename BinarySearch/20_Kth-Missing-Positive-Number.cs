namespace BinarySearch
{
	public class Solution20
	{
		public int FindKthPositive(int[] arr, int k)
		{
			int left = 0;
			int right = arr.Length - 1;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				int missingNumbersUntilMid = arr[mid] - (mid + 1);

				if (missingNumbersUntilMid < k)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return left + k;
		}
	}
}
