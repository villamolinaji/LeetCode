namespace TopInterview150
{
	public class Solution128
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
