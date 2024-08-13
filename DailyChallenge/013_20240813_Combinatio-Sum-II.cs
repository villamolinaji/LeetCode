namespace DailyChallenge
{
	public class Solution013
	{
		public IList<IList<int>> CombinationSum2(int[] candidates, int target)
		{
			var result = new List<IList<int>>();

			Array.Sort(candidates);

			Backtrack(candidates, target, 0, new List<int>(), result);

			return result;
		}

		private void Backtrack(int[] candidates, int remaining, int start, IList<int> current, IList<IList<int>> result)
		{
			if (remaining == 0)
			{
				result.Add(new List<int>(current));

				return;
			}

			for (int i = start; i < candidates.Length; i++)
			{
				if (i > start &&
					candidates[i] == candidates[i - 1])
				{
					continue;
				}

				if (candidates[i] > remaining)
				{
					break;
				}

				current.Add(candidates[i]);

				Backtrack(candidates, remaining - candidates[i], i + 1, current, result);

				current.RemoveAt(current.Count - 1);
			}
		}
	}
}
