namespace TopInterview150
{
	public class Solution123
	{
		public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
		{
			var result = new List<IList<int>>();
			if (nums1.Length == 0 ||
				nums2.Length == 0 ||
				k == 0)
			{
				return result;
			}

			var minHeap = new PriorityQueue<(int sum, int i, int j), int>();

			for (int i = 0; i < Math.Min(nums1.Length, k); i++)
			{
				minHeap.Enqueue((nums1[i] + nums2[0], i, 0), nums1[i] + nums2[0]);
			}

			while (k > 0 &&
				minHeap.Count > 0)
			{
				var (_, i, j) = minHeap.Dequeue();
				result.Add(new List<int> { nums1[i], nums2[j] });
				k--;

				if (j + 1 < nums2.Length)
				{
					minHeap.Enqueue((nums1[i] + nums2[j + 1], i, j + 1), nums1[i] + nums2[j + 1]);
				}
			}

			return result;
		}
	}
}
