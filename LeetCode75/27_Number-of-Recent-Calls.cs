namespace LeetCode75
{
	public class RecentCounter
	{		
		public Queue<int> Queue { get; set; }

		public RecentCounter()
		{
			Queue = new Queue<int>();
		}

		public int Ping(int t)
		{
			Queue.Enqueue(t);

			while (Queue.Peek() < t - 3000)
			{
				Queue.Dequeue();
			}

			return Queue.Count;
		}
	}
}
