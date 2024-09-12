namespace TopLiked100
{
	public class Solution079
	{
		public int[] MaxSlidingWindow(int[] nums, int k)
		{
			var deque = new LinkedList<int>();
			var result = new List<int>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (deque.Count > 0 &&
					deque.First?.Value < i - k + 1)
				{
					deque.RemoveFirst();
				}

				while (deque.Count > 0 &&
					deque.Last?.Value >= 0 &&
					nums[deque.Last.Value] <= nums[i])
				{
					deque.RemoveLast();
				}

				deque.AddLast(i);

				if (i >= k - 1 &&
					deque.First?.Value >= 0)
				{
					result.Add(nums[deque.First.Value]);
				}
			}

			return result.ToArray();
		}
	}
}
