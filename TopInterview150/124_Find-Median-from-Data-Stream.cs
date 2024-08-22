namespace TopInterview150
{
	public class MedianFinder
	{
		private PriorityQueue<int, int> MinHeap { get; set; }
		private PriorityQueue<int, int> MaxHeap { get; set; }

		public MedianFinder()
		{
			MinHeap = new PriorityQueue<int, int>();
			MaxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
		}

		public void AddNum(int num)
		{
			MaxHeap.Enqueue(num, num);

			if (MaxHeap.Count > 0 &&
				MinHeap.Count > 0 &&
				MaxHeap.Peek() > MinHeap.Peek())
			{
				var maxTop = MaxHeap.Dequeue();
				MinHeap.Enqueue(maxTop, maxTop);
			}

			if (MaxHeap.Count > MinHeap.Count + 1)
			{
				var maxTop = MaxHeap.Dequeue();
				MinHeap.Enqueue(maxTop, maxTop);
			}
			else if (MinHeap.Count > MaxHeap.Count)
			{
				var minTop = MinHeap.Dequeue();
				MaxHeap.Enqueue(minTop, minTop);
			}
		}

		public double FindMedian()
		{
			if (MaxHeap.Count == MinHeap.Count)
			{
				return (MaxHeap.Peek() + MinHeap.Peek()) / 2.0;
			}
			else
			{
				return MaxHeap.Peek();
			}
		}
	}
}
