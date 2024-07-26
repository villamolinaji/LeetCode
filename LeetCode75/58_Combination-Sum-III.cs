namespace LeetCode75
{
	public class Solution58
	{
		public IList<IList<int>> CombinationSum3(int k, int n)
		{
			var results = new List<IList<int>>();
			Backtrack(results, new List<int>(), k, n, 1);
			return results;
		}

		private void Backtrack(List<IList<int>> results, List<int> combination, int k, int remaining, int start)
		{
			if (combination.Count == k && remaining == 0)
			{
				results.Add(new List<int>(combination));
				return;
			}

			for (int i = start; i <= 9; i++)
			{
				if (remaining - i < 0)
				{
					break;
				}

				combination.Add(i);

				Backtrack(results, combination, k, remaining - i, i + 1);

				combination.RemoveAt(combination.Count - 1);
			}
		}
	}
}
