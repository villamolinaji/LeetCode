namespace LeetCode75
{
	public class Solution51
	{
		public long MaxScore(int[] nums1, int[] nums2, int k)
		{
			int numsLength = nums1.Length;
			var pairs = new List<(int, int)>();

			for (int i = 0; i < numsLength; i++)
			{
				pairs.Add((nums2[i], nums1[i]));
			}

			pairs.Sort((a, b) => b.Item1.CompareTo(a.Item1));

			var minHeap = new PriorityQueue<int, int>();

			long maxScore = 0;
			long sum = 0;

			foreach (var (num2, num1) in pairs)
			{
				sum += num1;
				minHeap.Enqueue(num1, num1);

				if (minHeap.Count > k)
				{
					sum -= minHeap.Dequeue();
				}

				if (minHeap.Count == k)
				{
					long score = sum * num2;
					maxScore = Math.Max(maxScore, score);
				}
			}

			return maxScore;
		}
	}
}
