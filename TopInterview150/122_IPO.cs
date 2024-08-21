namespace TopInterview150
{
	public class Solution122
	{
		public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
		{
			var profitsLength = profits.Length;

			var projects = new List<Tuple<int, int>>();
			for (int i = 0; i < profitsLength; i++)
			{
				projects.Add(new Tuple<int, int>(capital[i], profits[i]));
			}

			projects.Sort((a, b) => a.Item1.CompareTo(b.Item1));

			var maxHeap = new PriorityQueue<int, int>();

			var currentCapital = w;
			var projectIndex = 0;

			for (int i = 0; i < k; i++)
			{
				while (projectIndex < profitsLength
					&& projects[projectIndex].Item1 <= currentCapital)
				{
					maxHeap.Enqueue(projects[projectIndex].Item2, -projects[projectIndex].Item2);
					projectIndex++;
				}

				if (maxHeap.Count == 0)
				{
					break;
				}

				var maxProfit = maxHeap.Dequeue();
				currentCapital += maxProfit;
			}

			return currentCapital;
		}
	}
}
