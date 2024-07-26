namespace LeetCode75
{
	public class Solution68
	{
		public int SingleNumber(int[] nums)
		{
			return nums
				.GroupBy(n => n)
				.Select(n => (n.Key, n.Count()))
				.OrderBy(n => n.Item2)
				.First()
				.Key;
		}
	}
}
