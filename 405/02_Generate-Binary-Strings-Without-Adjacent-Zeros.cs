namespace _405
{
	public static class Solution02
	{
		public static IList<string> ValidStrings(int n)		
		{
			var result = new List<string>();

			var queue = new Queue<string>();

			queue.Enqueue("0");
			queue.Enqueue("1");

			while(queue.Count > 0)
			{
				var q = queue.Dequeue();

				if (q.Length == n)
				{
					if (!q.Contains("00"))
					{
						result.Add(q);
					}
				}
				else
				{
					queue.Enqueue(q + "0");
					queue.Enqueue(q + "1");
				}
			}

			return result;
		}
	}
}