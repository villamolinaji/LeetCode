namespace GraphTheory
{
	public class Solution13
	{
		public bool CanReach(int[] arr, int start)
		{
			var queue = new Queue<int>();
			var visited = new HashSet<int>();

			queue.Enqueue(start);
			visited.Add(start);

			while (queue.Count > 0)
			{
				int current = queue.Dequeue();

				if (arr[current] == 0)
				{
					return true;
				}

				int forward = current + arr[current];
				int backward = current - arr[current];

				if (forward < arr.Length &&
					!visited.Contains(forward))
				{
					queue.Enqueue(forward);
					visited.Add(forward);
				}

				if (backward >= 0 &&
					!visited.Contains(backward))
				{
					queue.Enqueue(backward);
					visited.Add(backward);
				}
			}

			return false;
		}
	}
}