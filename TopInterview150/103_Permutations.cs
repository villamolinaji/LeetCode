namespace TopInterview150
{
	public class Solution103
	{
		public IList<IList<int>> Permute(int[] nums)
		{
			var result = new List<IList<int>>();

			Backtrack(result, new List<int>(), nums, new bool[nums.Length]);

			return result;
		}

		private void Backtrack(IList<IList<int>> result, List<int> tempList, int[] nums, bool[] used)
		{
			if (tempList.Count == nums.Length)
			{
				result.Add(new List<int>(tempList));

				return;
			}

			for (int i = 0; i < nums.Length; i++)
			{
				if (used[i])
				{
					continue;
				}

				used[i] = true;

				tempList.Add(nums[i]);

				Backtrack(result, tempList, nums, used);

				used[i] = false;

				tempList.RemoveAt(tempList.Count - 1);
			}
		}
	}
}
