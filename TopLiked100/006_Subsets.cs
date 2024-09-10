namespace TopLiked100
{
	public class Solution006
	{
		public IList<IList<int>> Subsets(int[] nums)
		{
			var result = new List<IList<int>>();

			Backtrack(result, new List<int>(), nums, 0);

			result.Add(new List<int>());

			return result;
		}

		private void Backtrack(IList<IList<int>> result, List<int> tempList, int[] nums, int start)
		{
			if (tempList.Count > 0)
			{
				result.Add(new List<int>(tempList));
			}

			for (int i = start; i < nums.Length; i++)
			{
				tempList.Add(nums[i]);

				Backtrack(result, tempList, nums, i + 1);

				tempList.RemoveAt(tempList.Count - 1);
			}
		}
	}
}
