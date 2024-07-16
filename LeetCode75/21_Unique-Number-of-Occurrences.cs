namespace LeetCode75
{
	public class Solution21
	{
		public bool UniqueOccurrences(int[] arr)
		{
			var groupList = arr.GroupBy(x => x).Select(x => x.Count()).ToList();

			return groupList.Count == groupList.Distinct().Count();
		}
	}
}
