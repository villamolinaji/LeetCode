﻿namespace TopInterview150
{
	public class Solution104
	{
		public IList<IList<int>> CombinationSum(int[] candidates, int target)
		{
			var result = new List<IList<int>>();

			Array.Sort(candidates);

			Backtrack(result, new List<int>(), candidates, target, 0);

			return result;
		}

		private void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int remain, int start)
		{
			if (remain < 0)
			{
				return;
			}

			if (remain == 0)
			{
				result.Add(new List<int>(tempList));

				return;
			}

			for (int i = start; i < candidates.Length; i++)
			{
				tempList.Add(candidates[i]);

				Backtrack(result, tempList, candidates, remain - candidates[i], i);

				tempList.RemoveAt(tempList.Count - 1);
			}
		}
	}
}
