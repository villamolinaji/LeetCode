namespace TopInterview150
{
	public class Solution102
	{
		public IList<IList<int>> Combine(int n, int k)
		{
			var result = new List<IList<int>>();

			Backtrack(result, new List<int>(), n, k, 1);

			return result;
		}

		private void Backtrack(IList<IList<int>> result, List<int> combination, int n, int k, int start)
		{
			if (combination.Count == k)
			{
				result.Add(new List<int>(combination));

				return;
			}

			for (int i = start; i <= n; i++)
			{
				combination.Add(i);

				Backtrack(result, combination, n, k, i + 1);

				combination.RemoveAt(combination.Count - 1);
			}
		}
	}
}
