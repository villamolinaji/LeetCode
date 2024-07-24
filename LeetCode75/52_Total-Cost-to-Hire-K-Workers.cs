namespace LeetCode75
{
	public class Solution52
	{
		public long TotalCost(int[] costs, int k, int candidates)
		{
			int costsLength = costs.Length;
			long totalCost = 0;
			int left = 0;
			int right = costsLength - 1;

			PriorityQueue<int, int> leftHeap = new PriorityQueue<int, int>();
			PriorityQueue<int, int> rightHeap = new PriorityQueue<int, int>();

			for (int i = 0; i < k; i++)
			{
				while (leftHeap.Count < candidates &&
					left <= right)
				{
					leftHeap.Enqueue(costs[left], costs[left]);
					left++;
				}

				while (rightHeap.Count < candidates &&
					right >= left)
				{
					rightHeap.Enqueue(costs[right], costs[right]);
					right--;
				}

				int leftCost = leftHeap.Count > 0 ? leftHeap.Peek() : int.MaxValue;
				int rightCost = rightHeap.Count > 0 ? rightHeap.Peek() : int.MaxValue;

				if (leftCost <= rightCost)
				{
					totalCost += leftHeap.Dequeue();
				}
				else
				{
					totalCost += rightHeap.Dequeue();
				}
			}

			return totalCost;
		}
	}
}
